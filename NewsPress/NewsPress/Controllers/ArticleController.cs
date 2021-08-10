using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NewsPress.Data;
using NewsPress.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace NewsPress.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hostEnvironment;
      
           

        
        public ArticleController(ApplicationDbContext db, IWebHostEnvironment hostEnvironment)
        {
            this._hostEnvironment = hostEnvironment;
            _db = db;
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

            foreach (var articles in objList)
            {
                if (articles.Id == id)
                {
                    ViewBag.article = articles;


                }
            }
            return View(themeList);
        }
        public IActionResult Create()
        {
            IEnumerable<Theme> themeList = _db.Themes;
            ViewBag.Themes = themeList;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Article obj)
        {
            obj.Themes = "";
            foreach(var themeNumber in obj.Arechecked)
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
            obj.WrittenDate = now;
            obj.EditDate = now;
            _db.Articles.Add(obj);
            _db.SaveChanges();
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
            if(articleExist)
            {
            return View(articleToEdit);
            }
            else
                return RedirectToAction("Index");

        }
        [HttpPost]
        public async Task<IActionResult> Edit(Article obj)
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
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(Article obj)
        {
            _db.Articles.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
