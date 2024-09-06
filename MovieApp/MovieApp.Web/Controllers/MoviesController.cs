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
        public ActionResult Details(int id)
        {
            return View(_context.Movies.Find(id));
        }
        public IActionResult Create()
        {
			//ViewBag.Genres = GenreRepository.Genres;
            ViewBag.Genres=new SelectList(_context.Genres.ToList(),"GenreId","Name");

			return View();
        }

		[HttpPost]
		public IActionResult Create(Movie m)
		{
			//ViewBag.Genres = GenreRepository.Genres;
          
			if (ModelState.IsValid)
			{
                _context.Movies.Add(m);
                _context.SaveChanges();
                //MovieRepository.ADD(m);
                TempData["Message"] = $"{m.Title} isimli Film eklendi";

                return RedirectToAction("List");
			}
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");

            return View();

		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
            //ViewBag.Genres = GenreRepository.Genres;
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");

            return View(_context.Movies.Find(id));
            return View(MovieRepository.GetById(id));

        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
			if (ModelState.IsValid)
			{
                //MovieRepository.Edit(m);
                _context.Movies.Update(m);
                TempData["Message"] = $"{m.Title} isimli Film Güncellendi";

                return RedirectToAction("Details", "Movies", new { @id = m.MovieId });
			}
            //ViewBag.Genres = GenreRepository.Genres;
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");


            return View(m);
		
        }
        [HttpPost]
        public IActionResult Delete(int MovieId,string Title)
        {
        //MovieRepository.Delete(MovieId);
        var entity=_context.Movies.Find(MovieId);
            _context.Movies.Remove(entity);
            TempData["Message"] = $"{Title} isimli Film Silindi";
        return RedirectToAction("List");

        }
    }
}
