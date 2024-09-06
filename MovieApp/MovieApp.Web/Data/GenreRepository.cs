using MovieApp.Web.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
	public class GenreRepository
	{
		public static readonly List<Genre> _genres = null;

		static GenreRepository()
		{
			_genres = new List<Genre>()
			{
				new Genre{GenreId=1,Name="MACERA"},
				new Genre{GenreId=2,Name="KOMADİ"},
				new Genre{GenreId=3,Name="ROMANTİK"},
				new Genre{GenreId=4,Name="SAVAS"}
			};
		}
		public static List<Genre> Genres {
			get 
			{
				return _genres;
			} 
		}
		public static void Add(Genre genre)
		{
			_genres.Add(genre);
		}
		public static Genre GetById(int id)
		{
			return _genres.FirstOrDefault(g => g.GenreId == id);
		}
	}
}
