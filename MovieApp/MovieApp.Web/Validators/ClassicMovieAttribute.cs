using MovieApp.Web.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Validators
{
	public class ClassicMovieAttribute: ValidationAttribute
	{
        public ClassicMovieAttribute(int year)
        {
            Year = year;
        }
        public int Year {  get; set; }
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var movie =(AdminCreateMovieModel)validationContext.ObjectInstance;
			var releaseYear=((DateTime)value).Year;
			if (movie.IsClassic && releaseYear > Year)
			{
				return new ValidationResult($"klasik filmler için 1950 ve öncesi yıl giriniz ");
			}
			return ValidationResult.Success;
		}


	}
}
