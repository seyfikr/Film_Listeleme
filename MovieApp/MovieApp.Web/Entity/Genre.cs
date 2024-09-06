using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Entity
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Required] 
        public string Name { get; set; }
        public List<Movie> Movies { get; set;}
    }
}
