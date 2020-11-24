using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        //path pattern = controller/action(method)
        //ex : ComicBooks/Detail is how to get to this page and action "URL routing"

        private ComicBookRepository _comicBookRepo = null;

        public ComicBooksController()
        {
            _comicBookRepo = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepo.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id)//action result is the base class of both redirect and content
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepo.GetComicBook(id.Value);
            return View(comicBook);
        }
    }
}