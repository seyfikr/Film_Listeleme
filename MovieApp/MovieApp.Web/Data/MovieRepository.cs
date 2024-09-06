using MovieApp.Web.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
	public class MovieRepository
	{
		private static readonly List<Movie> _movies = null;
		static MovieRepository()
		{
			_movies = new List<Movie>()
			{
				 new Movie
				{
					 MovieId =1,
					Title="Uyumsuz",
					Description="aciklama1",
					IMBD=8,
					ImageUrl="1.jpg",
				},
				   new Movie
				{
					 MovieId =2,

					Title="Dune",
					Description="aciklama2",
					IMBD=5,
					ImageUrl="2.jpg",


				},
					  new Movie
				{
					 MovieId =3,

					Title="piyanist",
					Description="aciklama3",
					IMBD=4,
					ImageUrl="3.jpg",


				},
					   new Movie
				{
					 MovieId =4,
					Title="film1",
					Description="aciklama1",
					IMBD=8,
					ImageUrl="1.jpg",


                },
				   new Movie
				{
					 MovieId =5,

					Title="film2",
					Description="aciklama2",
					IMBD=5,
					ImageUrl="2.jpg",




                },
					  new Movie
				{
					 MovieId =6,

					Title="film3",
					Description="aciklama3",
					IMBD=4,
					ImageUrl="3.jpg",




                }


        };
		}
		public static List<Movie> Movies
		{
			get
			{
				 return _movies;
			}
		}
		public static void ADD(Movie movie)
		{
			movie.MovieId = _movies.Count() + 1;
			_movies.Add(movie);
		}
		public static Movie GetById(int id)
		{
			return _movies.FirstOrDefault(m => m.MovieId==id);
		}
		public static void Edit(Movie m)
		{
			foreach (var  movie in _movies)
			{
				if (movie.MovieId == m.MovieId)
				{
					
					movie.Title=m.Title;
                    movie.Description=m.Description;
                    movie.MovieId = movie.MovieId;
                    movie.ImageUrl=movie.ImageUrl;
                    //movie.GenreId=movie.GenreId; 
					break;
				}	
			}

		}
		public static void Delete(int MovieID)
		{
			var movie=GetById(MovieID);

			if(movie!=null) 
			{
				_movies.Remove(movie);
			}
		}
	}
}
