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
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "",
                IssueNumber = 700,
                Description = "",
                Artists = new Artist[]
                {
                    new Artist() {Name= "", Role = ""},
                    new Artist() {Name= "", Role = ""},
                    new Artist() {Name= "", Role = ""},
                    new Artist() {Name= "", Role = ""}
                }
            };
            return View();
        }
    }
}