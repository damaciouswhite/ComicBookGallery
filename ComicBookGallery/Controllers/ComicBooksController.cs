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

        public ActionResult Detail()//action result is the base class of both redirect and content
        {
            return View();
            
        }
    }
}