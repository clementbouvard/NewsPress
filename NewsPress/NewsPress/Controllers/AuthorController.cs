using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewsPress.Areas.Identity.Data;
using NewsPress.Data;
using NewsPress.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPress.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly AuthDbContext _dbAuth;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<Author> _userManager;
        private readonly SignInManager<Author> _signInManager;
        public AuthorController(AuthDbContext dbAuth, ApplicationDbContext db, IWebHostEnvironment hostEnvironment, UserManager<Author> userManager, SignInManager<Author> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this._hostEnvironment = hostEnvironment;
            _db = db;
            _dbAuth = dbAuth;
        }
        public IActionResult Profile([FromRoute] string id)
        {  
            IEnumerable<Article> objList = _db.Articles;
            IEnumerable<Author> authorList = _dbAuth.Authors;

            foreach (var author in authorList)
            {
                if (author.Id == id)
                {
                    ViewBag.author = author;
                    ViewBag.FullName = author.FirstName + " " + author.LastName;
                }
            }

            return View(objList);
        }
        public IActionResult AdminToggle([FromRoute]string id)
        {
            if (_signInManager.IsSignedIn(User) && _userManager.GetUserAsync(User).Result.admin == true)
            {
                IEnumerable<Author> authorList = _dbAuth.Authors;
                Author authorToEdit = null;
                foreach (var author in authorList)
                {
                    if (author.Id == id && author.approved)
                    {
                        if (author.admin)
                        {
                            author.admin = false;
                            authorToEdit = author;
                        }
                        else
                        {
                            
                            author.admin = true;
                            authorToEdit = author;

                        }
                        
                    }
                }
                _dbAuth.Authors.Update(authorToEdit);
                _dbAuth.SaveChanges();
            }
            return Redirect("/Home");
        }

        public IActionResult Index()
        {
            IEnumerable<Author> authorList = _dbAuth.Authors;
            ViewBag.authorList = authorList;
            return View();
        }
        public IActionResult Approve([FromRoute] string id)
        {
            if (_signInManager.IsSignedIn(User) && _userManager.GetUserAsync(User).Result.admin == true)
            {
                IEnumerable<Author> authorList = _dbAuth.Authors;
                Author authorToEdit = null;
                foreach (var author in authorList)
                {
                    if (author.Id == id)
                    {
                        if (author.approved)
                        {
                            author.approved = false;
                            authorToEdit = author;
                        }
                        else
                        {

                            author.approved = true;
                            authorToEdit = author;

                        }

                    }
                }
                _dbAuth.Authors.Update(authorToEdit);
                _dbAuth.SaveChanges();
            }
            return Redirect("/Home");
        }
        public IActionResult Edit([FromRoute] string id)
        {
          
          if (_signInManager.IsSignedIn(User))
            {  if (id == _userManager.GetUserAsync(User).Result.Id )
                { 
            IEnumerable<Author> authorList = _dbAuth.Authors;
            foreach (var author in authorList)
            {
                if (author.Id == id)
                {
                    ViewBag.author = author;
                            return View(author);
                }
            }
                    return Redirect("/Home");
                }
            }
            return Redirect("/Home");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Author obj)
        {
            if (_signInManager.IsSignedIn(User))

            {
              

                    if (obj.ImageFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string filename = Path.GetFileNameWithoutExtension(obj.ImageFile.FileName);
                        string extension = Path.GetExtension(obj.ImageFile.FileName);
                        obj.ProfilePicture= filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(wwwRootPath + "/Images/", filename);

                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await obj.ImageFile.CopyToAsync(fileStream);
                        }
                    }
                    _dbAuth.Authors.Update(obj);
                    _dbAuth.SaveChanges();
                
            }


            return RedirectToAction("Index");
        }



    }
}
