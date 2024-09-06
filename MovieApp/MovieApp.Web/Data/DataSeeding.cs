using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Web.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieContext>();
            context.Database.Migrate();//dotnet ef migrations update
            var genres = new List<Genre>()
                {
                new Genre{Name="MACERA",Movies=new List<Movie>()
				{
					 new Movie
				{
					Title="yenifilmmacera",
					Description="aciklama1",
					IMBD=8,
					ImageUrl="1.jpg",
				},
				   new Movie
				{

					Title="yenifilmmacera2",
					Description="aciklama2",
					IMBD=5,
					ImageUrl="2.jpg",


				},
				}},
                new Genre{Name="KOMADİ"},
                new Genre{Name="ROMANTİK"},
                new Genre{Name="SAVAS"},
				new Genre{Name="BılımKurgu"}

				};
			var movies = new List<Movie>()
			{
				 new Movie
				{
					Title="Uyumsuz",
					Description="aciklama1",
					IMBD=8,
					ImageUrl="1.jpg",
					Genres=new List<Genre>(){genres[0],new Genre() { Name = "YeniTur" }, genres[2] }

				},
				   new Movie
				{

					Title="Dune",
					Description="aciklama2",
					IMBD=5,
					ImageUrl="2.jpg",
					Genres=new List<Genre>(){genres[0], genres[1] }


				},
					  new Movie
				{

					Title="piyanist",
					Description="aciklama3",
					IMBD=4,
					ImageUrl="3.jpg",
					Genres=new List<Genre>(){genres[3], genres[2] }



				},
					   new Movie
				{
					Title="film1",
					Description="aciklama1",
					IMBD=8,
					ImageUrl="1.jpg",
					Genres=new List<Genre>(){genres[2], genres[0] }


				},
				   new Movie
				{

					Title="film2",
					Description="aciklama2",
					IMBD=5,
					ImageUrl="2.jpg",


					Genres=new List<Genre>(){genres[3], genres[0] },




				},
					  new Movie
				{

					Title="film3",
					Description="aciklama3",
					IMBD=4,
					ImageUrl="3.jpg",

					Genres=new List<Genre>(){genres[3] }




				}
			};
			var users = new List<User>()
			{
				new User(){UserName="Ahmet",Email="bomcuAhmet55@gmail.com",Password="1234"},
				new User(){UserName="Ayşe",Email="MakyajcıAyşe@gmail.com",Password="4566"},
				new User(){UserName="Erdem",Email="ErdemSöför@gmail.com",Password="7897",},
			};
			var people = new List<Person>()
			{
				new Person()
				{
					Name = "Personel 1",
					Bio = "Güvenlik",
					User=users[0]
				},
				 new Person()
				{
					Name = "Personel 2",
					Bio = "Güvenlik3",
					User=users[1]

				}
			};
			var crew = new List<Crew>() 
			{
				new Crew(){Movie=movies[0],Person=people[0],Job="Eğrelti Otu" },
				new Crew(){Movie=movies[0],Person=people[1],Job="Yönetmenin HerBOkalog oglu " },

			};
			var cast = new List<Cast>()
			{
				new Cast() {Movie=movies[0],Person=people[0],Name="oyuncu adi",Character="karakter2"},
				new Cast() {Movie=movies[0],Person=people[1],Name="oyuncu adi2",Character="karakter"}

			};

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);

                }
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(movies);


                }
				if (context.Users.Count() == 0)
				{
					context.Users.AddRange(users);
				}
				if (context.Persons.Count() == 0)
				{
					context.Persons.AddRange(people);
				}
				if (context.Crews.Count() == 0)
				{
					context.Crews.AddRange(crew);
				}
				if (context.Casts.Count() == 0)
				{
					context.Casts.AddRange(cast);
				}
				context.SaveChanges();

			}
		}
    } }
