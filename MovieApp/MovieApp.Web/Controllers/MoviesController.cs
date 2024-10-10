using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Data;
using MovieApp.Web.Entity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        public readonly MovieContext _context;

        public MoviesController(MovieContext movieContext) 
        {
            _context = movieContext;
        }
        //action
        // localhost:44375//movies

        public ActionResult Index()
        {
            return View();
        }
		// localhost:44375//movies/list
		// localhost:44375//movies/list/1
		

		public ActionResult List(int? id ,string q)
        {
           /* var kelime = HttpContext.Request.Query["q"].ToString();*///http den q yü alıyoruz
          
            //var movies =  MovieRepository.Movies;
            var movies=_context.Movies.AsQueryable();
            if(id!=null) 
            {
                movies=movies.Include(m=>m.Genres).Where (m=>m.Genres.Any(g=>g.GenreId==id));
            }

            if (!string.IsNullOrEmpty(q))
            {
                movies=movies.Where(i=>i.Title.ToLower().Contains(q.ToLower())||
                i.Description.ToLower().Contains(q.ToLower()));
            }
           

            var model = new MoviesViewModel()
            {
                Movies = movies.ToList()
            };
            return View("Movies", model);
        }
        // localhost:44375//movies/details/1
        [HttpGet]
		public ActionResult Details(int id)
		{
			return View(_context.Movies.Find(id));
		}
	}
}
