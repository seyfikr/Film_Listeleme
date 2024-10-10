using MovieApp.Web.Entity;
using MovieApp.Web.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Models
{
	public class AdminMoviesViewModel
	{
        public List<AdminMovieViewModel> Movies { get; set; }
    }
	public class AdminMovieViewModel
	{
		public int MovieId { get; set; }
		public string Title { get; set; }
		public string ImageUrl{ get; set; }
		public List<Genre> Genres { get; set; }
	}
	public class AdminCreateMovieModel
	{
		public string ImageUrl { get; set; }

		[Display(Name ="Movie Name")]
		[Required(ErrorMessage = "Enter the movie name")]
		[StringLength(50,MinimumLength =3,ErrorMessage ="Movie Name 3-50 Beetween")]
		public string Title { get; set; }

		[Display(Name = "Movie Description")]
		[Required(ErrorMessage = "Enter the movie Description")]
		[StringLength(500, MinimumLength = 10, ErrorMessage = "Movie Description 10-500 Beetween")]
		public string Description { get; set; }
		[Required(ErrorMessage = "en az 1 tür seçiniz")]

		public int[] GenreIds { get; set; }
		public bool IsClassic { get; set; }
		[ClassicMovie(1950)]
		[DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }=DateTime.Now;
    }

	public class AdminEditMovieViewModel
	{
		public int MovieId { get; set; }
		[Display(Name = "Movie Name")]
		[Required(ErrorMessage = "Enter the movie name")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Movie Name 3-50 Beetween")]
		public string Title { get; set; }

		[Display(Name = "Movie Description")]
		[Required(ErrorMessage = "Enter the movie Description")]
		[StringLength(500, MinimumLength = 10, ErrorMessage = "Movie Description 10-500 Beetween")]
		public string Description { get; set; }
		[Required(ErrorMessage = "en az 1 tür seçiniz")]

		public string ImageUrl { get; set; }
		public int[] GenreIds { get; set; }

	}
}
