using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NewsPress.Areas.Identity.Data;
using NewsPress.Data;
using NewsPress.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace NewsPress.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly AuthDbContext _dbAuth;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<Author> _userManager;
        private readonly SignInManager<Author> _signInManager;


        public ArticleController(AuthDbContext dbAuth,ApplicationDbContext db, IWebHostEnvironment hostEnvironment, UserManager<Author> userManager,SignInManager<Author> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this._hostEnvironment = hostEnvironment;
            _db = db;
            _dbAuth = dbAuth;
        }
        public IActionResult Index()
        {
            IEnumerable<Article> objList = _db.Articles;
            
            return View(objList);
        }
        [HttpGet]
        public IActionResult Theme([FromRoute] string id)
        {
            
            IEnumerable<Article> objList = _db.Articles;
            IEnumerable<Theme> themeList = _db.Themes;
            foreach(var theme in themeList)
            {
                if (theme.Name == id)
                {
                    ViewBag.id = theme.Id;
                    ViewBag.Name = theme.Name;
                }
            }
                return View(objList);
        }
        [HttpGet]
        public IActionResult Details([FromRoute] int id)
        {
            IEnumerable<Theme> themeList = _db.Themes;
            IEnumerable<Article> objList = _db.Articles;
            IEnumerable<Author> authorList = _dbAuth.Authors;
           
            foreach (var articles in objList)
            {
                if (articles.Id == id)
                {
                    ViewBag.article = articles;
                    foreach (var author in authorList)
                     {
                        if (author.Id == articles.AuthorId)
                         {
                         ViewBag.authorName = author.FirstName+" "+author.LastName;
                        }
                    }

                }
            }
            return View(themeList);
        }
        public IActionResult Create()
        {
            if (_signInManager.IsSignedIn(User))

            {
                if ( _userManager.GetUserAsync(User).Result.approved)
                {
                    IEnumerable<Theme> themeList = _db.Themes;
                    ViewBag.Themes = themeList;
                    return View();
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Create(Article obj)
        {
            if (_signInManager.IsSignedIn(User))

            {
                if (_userManager.GetUserAsync(User).Result.approved == true || _userManager.GetUserAsync(User).Result.admin == true)
                {
                    obj.Themes = "";
                    if (obj.Arechecked!=null)
                    {
 foreach (var themeNumber in obj.Arechecked)
                    {
                        obj.Themes += themeNumber.ToString() + ",";
                    }
                    }
                   
                    if (obj.ImageFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string filename = Path.GetFileNameWithoutExtension(obj.ImageFile.FileName);
                        string extension = Path.GetExtension(obj.ImageFile.FileName);
                        obj.PictureName = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(wwwRootPath + "/Images/", filename);

                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await obj.ImageFile.CopyToAsync(fileStream);
                        }
                    }
                    obj.AuthorId = _userManager.GetUserId(User);
                    DateTime now = DateTime.Now;
                    obj.WrittenDate = now;
                    obj.EditDate = now;
                    _db.Articles.Add(obj);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit([FromRoute]int id)
        {
            IEnumerable<Theme> themeList = _db.Themes;
            ViewBag.Themes = themeList;
            Article articleToEdit=null;
            bool articleExist = false;
            IEnumerable<Article> articleList = _db.Articles;
            foreach(var article in articleList)
            {
                if (article.Id==id)
                {
                    articleToEdit = article;
                    ViewBag.article = article;
                    articleExist = true;
                }
            }
            if(_signInManager.IsSignedIn(User))
{

                if (articleExist&&(articleToEdit.AuthorId== _userManager.GetUserAsync(User).Result.Id || _userManager.GetUserAsync(User).Result.admin == true))
            {
            return View(articleToEdit);
            } }
            
                return RedirectToAction("Index");

        }
        [HttpPost]
        public async Task<IActionResult> Edit(Article obj)
        {
            if(_signInManager.IsSignedIn(User))

                { if (obj.AuthorId == _userManager.GetUserAsync(User).Result.Id || _userManager.GetUserAsync(User).Result.admin == true)
            {
                  obj.Themes = "";
                 foreach (var themeNumber in obj.Arechecked)
                {
                obj.Themes += themeNumber.ToString() + ",";
                 }
                 if (obj.ImageFile != null)
                 {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(obj.ImageFile.FileName);
                string extension = Path.GetExtension(obj.ImageFile.FileName);
                obj.PictureName = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Images/", filename);

                 using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                    await obj.ImageFile.CopyToAsync(fileStream);
                    }
                }
            DateTime now = DateTime.Now;
            obj.EditDate = now;
            _db.Articles.Update(obj);
            _db.SaveChanges();
            }
                }
                
                
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(Article obj)
        {
            if (_signInManager.IsSignedIn(User))

            {
                if (obj.AuthorId == _userManager.GetUserAsync(User).Result.Id || _userManager.GetUserAsync(User).Result.admin == true)
                {
                    _db.Articles.Remove(obj);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        
        public IActionResult Searching([FromRoute] string id)
        {
            if (id!=null)
            {
 ViewBag.searchbar = id;
            IEnumerable<Article> articleList = _db.Articles;
            List<Article> SearchedTitleArticleList = new List<Article>();
            List<Article> SearchedTextArticleList = new List<Article>();
            foreach (var article in articleList)
            {
                if (article.Title.Contains(id, StringComparison.OrdinalIgnoreCase) )
                {
                    SearchedTitleArticleList.Add(article);
                }else if(article.Text.Contains(id, StringComparison.OrdinalIgnoreCase) )
                        {
                    SearchedTextArticleList.Add(article);
                }
            }
            SearchedTextArticleList.OrderByDescending(Article => Article.WrittenDate);
            ViewBag.SearchedTextArticleList = SearchedTextArticleList;
            SearchedTitleArticleList.OrderByDescending(Article => Article.WrittenDate);
            ViewBag.SearchedTitleArticleList = SearchedTitleArticleList;
            return View();
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Search(string searchbar)
        {
          
            return Redirect("Searching/"+searchbar);
        }

        public IActionResult ThemeFilter(List<string> Arechecked)
        {
            IEnumerable<Theme> themeList = _db.Themes;
            ViewBag.themeList = themeList;

            IEnumerable<Author> authorList = _dbAuth.Authors;
            ViewBag.authorList = authorList;
            IEnumerable<Article> articleList = _db.Articles;
            List<Article> FilterArticle = new List<Article>();
            foreach (var article in articleList)
            {
                bool alreadyIn = false;
                string[] subthemes = article.Themes.Split(',');
                foreach (var subtheme in subthemes)
                {
                    foreach (var themeNumber in Arechecked)
                    {

                        if (subtheme == themeNumber)
                        {
                            foreach(var filteredArticle in FilterArticle)
                            {
                                if(article.Id==filteredArticle.Id)
                                {
                                    alreadyIn = true;
                                }
                            }
                            if(alreadyIn==false)
                            {
                                FilterArticle.Add(article);
                            }
                            
                        }

                    }
                }
                
            }
            ViewBag.FilterArticle = FilterArticle;
            return View();
        }
        public IActionResult AuthorFilter(List<string> Arechecked)
        {
            IEnumerable<Theme> themeList = _db.Themes;
            ViewBag.themeList = themeList;

            IEnumerable<Author> authorList = _dbAuth.Authors;
            ViewBag.authorList = authorList;
            IEnumerable<Article> articleList = _db.Articles;
            List<Article> FilterArticle = new List<Article>();
            foreach (var article in articleList)
            {
              
                    foreach (var authorId in Arechecked)
                    {

                        if (article.AuthorId == authorId.ToString())
                        {
                            FilterArticle.Add(article);
                        }

                    }
                
            }
            ViewBag.FilterArticle = FilterArticle;
            return View();
        }
    }
}
