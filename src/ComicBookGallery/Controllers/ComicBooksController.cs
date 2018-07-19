using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;   //using deractive for Controller

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller  //controller classes need to be public
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
            }
            return Content("Hello from the Comic Books Controller!");
        }
    }
}