using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using MovieApp.Web.Entity;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Threading.Tasks;
namespace MovieApp.Web.Controllers
{
	public class AdminController : Controller
	{
		private readonly MovieContext _movieContext;
		public AdminController(MovieContext context)
		{
			_movieContext = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult MovieUpdate(int? id)
		{


			if (id == null)
			{
				return NotFound();

			}
			var entity = _movieContext.Movies.Select(m => new AdminEditMovieViewModel
			{
				MovieId = m.MovieId,
				Description = m.Description,
				Title = m.Title,
				ImageUrl = m.ImageUrl,
				GenreIds = m.Genres.Select(i => i.GenreId).ToArray()
			}).FirstOrDefault(m => m.MovieId == id);

			ViewBag.Genres = _movieContext.Genres.ToList();

			if (entity == null)
			{
				return NotFound();
			}
			return View(entity);
		}
		[HttpPost]
		public async Task<IActionResult> MovieUpdate(AdminEditMovieViewModel model, int[] genreIds, IFormFile file)
		{
			if (ModelState.IsValid)
			{

				var entity = _movieContext.Movies.Include("Genres").FirstOrDefault(m => m.MovieId == model.MovieId);

				if (entity == null)
				{
					return NotFound();
				}

				entity.Description = model.Description;
				entity.Title = model.Title;
				//resim ekleme
				if (file != null)
				{
					var extension = Path.GetExtension(file.FileName);
					var fileName = string.Format($"{Guid.NewGuid()}{extension}");
					var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", fileName);
					entity.ImageUrl = fileName;
					using (var stream = new FileStream(path, FileMode.Create))
					{
						await file.CopyToAsync(stream);
					}
				}
				entity.Genres = genreIds.Select(id => _movieContext.Genres.FirstOrDefault(m => m.GenreId == id)).ToList();

				_movieContext.SaveChanges();
				return RedirectToAction("MovieList");
			}

			ViewBag.Genres = _movieContext.Genres.ToList();
			return View(model);
		}

		public IActionResult MovieList()
		{
			return View(new AdminMoviesViewModel
			{
				Movies = _movieContext.Movies
				.Include(m => m.Genres)
				.Select(m => new AdminMovieViewModel
				{
					MovieId = m.MovieId,
					ImageUrl = m.ImageUrl,
					Title = m.Title,
					Genres = m.Genres.ToList(),
				})
				.ToList(),
			});
		}
		public IActionResult GenreList()
		{

			return View(GetGenres());
		}
		private AdminGenresViweModel GetGenres()
		{
			return new AdminGenresViweModel
			{
				Genres = _movieContext.Genres.Select(g => new AdminGenreViewModel
				{
					GenreId = g.GenreId,
					Name = g.Name,
					Count = g.Movies.Count
				}).ToList()
			};
		}
		public IActionResult GenreCreate(AdminGenresViweModel model)
		{
			if (model.Name != null && model.Name.Length < 4)
			{
				ModelState.AddModelError("Name", "Tür adı minumum 3 karakter olmalıdır");
			}
			if (ModelState.IsValid)
			{
				_movieContext.Genres.Add(new Genre { Name = model.Name });
				_movieContext.SaveChanges();
				return RedirectToAction("GenreList");
			}
			return View("GenreList", GetGenres());
		}
		public IActionResult GenreUpdate(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var entity = _movieContext
				.Genres
				.Select(g => new AdminGenreEditViewModel
				{
					GenreId = g.GenreId,
					Name = g.Name,
					Movies = g.Movies.Select(i => new AdminMovieViewModel
					{
						MovieId = i.MovieId,
						Title = i.Title,
						ImageUrl = i.ImageUrl,
					}).ToList(),
				})
				.FirstOrDefault(g => g.GenreId == id);

			if (entity == null)
			{
				return NotFound();
			}
			return View(entity);
		}
		public ActionResult Details()
		{
			return View("Movies");
		}
		public IActionResult SeyfiPage()
		{
			return View();
		}
		[HttpPost]
		public IActionResult GenreUpdate(AdminGenreEditViewModel model, int[] movieIds)
		{
			var entity = _movieContext.Genres.FirstOrDefault(i => i.GenreId == model.GenreId);

			if (ModelState.IsValid)
			{
				if (entity == null)
				{
					return BadRequest();
				}
				entity.Name = model.Name;
				foreach (var id in movieIds)
				{
					entity.Movies.Remove(entity.Movies.FirstOrDefault(m => m.MovieId == id));
				}
				_movieContext.SaveChanges();
				return RedirectToAction("GenreList");
			}
			return View(model);
		}
		[HttpPost]
		public IActionResult GenreDelete(int genreID)
		{
			var entity = _movieContext.Genres.Find(genreID);
			if (entity != null)
			{
				_movieContext.Genres.Remove(entity);
				_movieContext.SaveChanges();
			}
			return RedirectToAction("GenreList");
		}

		[HttpPost]
		public IActionResult MovieDelete(int movieId)
		{
			var entity = _movieContext.Movies.Find(movieId);
			if (entity != null)
			{

				_movieContext.Movies.Remove(entity);
				_movieContext.SaveChanges();
			}
			return RedirectToAction("MovieList");
		}
		[HttpGet]

		public IActionResult MovieCreate()
		{
			ViewBag.Genres = _movieContext.Genres.ToList();

			// AdminCreateMovieModel türünde yeni bir model oluşturuyoruz
			var createMovieModel = new AdminCreateMovieModel();

			return View(createMovieModel); // Doğru modeli Razor sayfasına gönderiyoruz
		}
		[HttpPost]
		public IActionResult MovieCreate(AdminCreateMovieModel m)
		{
			if (m.Title != null && m.Title.Contains("@"))
			{
				ModelState.AddModelError("", "Film Basliği @ İçeremez");
			}
			if (m.GenreIds == null)
			{
				ModelState.AddModelError("GenreIds", "en az bir tür seçiniz");
			}
			if (ModelState.IsValid)
			{
				var entity = new Movie
				{
					Title = m.Title,
					Description = m.Description,
					ImageUrl = "no-image.png"
				};
				entity.Genres = new List<Genre>();
				foreach (int id in m.GenreIds)
				{
					entity.Genres.Add(_movieContext.Genres.FirstOrDefault(i => i.GenreId == id));
				}
				_movieContext.Movies.Add(entity);
				_movieContext.SaveChanges();
				return RedirectToAction("MovieList", "Admin");
			}
			ViewBag.Genres = _movieContext.Genres.ToList();
			return View(m);
		}
	}
}
