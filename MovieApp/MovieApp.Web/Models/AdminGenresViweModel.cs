using MovieApp.Web.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Models
{
	public class AdminGenresViweModel
	{
		[Required(ErrorMessage ="Bir tür bilgisi girmelisiniz")]
		public string Name { get; set; }
		public List<AdminGenreViewModel> Genres { get; set; }
	}

	public class AdminGenreViewModel
	{
        public int GenreId { get; set; }
		public int Count { get; set; }
        public string Name { get; set; }

    }
	public class AdminGenreEditViewModel
	{
		public int GenreId { get; set; }

		[Required(ErrorMessage = "Bir tür bilgisi girmelisiniz")]
		public string Name { get; set; }
		public List<AdminMovieViewModel> Movies { get; set; }
	}
}
