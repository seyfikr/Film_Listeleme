using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Entity;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult  Index()
        {
            var model = new HomePageViewModel
            {
                populerMovies = MovieRepository.Movies
            };
         

        return View(model);
        }
        public ActionResult About()
        {
        
            return View();
        }
    }
}
