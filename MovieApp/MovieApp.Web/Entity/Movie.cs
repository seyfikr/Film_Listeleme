using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace MovieApp.Web.Entity
{
    public class Movie
    {
        public Movie()
        {
            Genres = new List<Genre>();
        }
        public int MovieId { get; set; }
        //[DisplayName("baslik")]
        //[Required(ErrorMessage = "Film Basligi ekleyiniz")]
        //[StringLength(25, MinimumLength = 4, ErrorMessage = "film basligi 5 ile 25 arası olmalıdır")]
        [Required]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
      //  public string[] Players { get; set; }
        public int IMBD { get; set; }
        public string ImageUrl { get; set; }
		[Required]

	
        public List<Genre> Genres { get; set; }
    }
}
