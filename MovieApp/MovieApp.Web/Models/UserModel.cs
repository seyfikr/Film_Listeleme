using Microsoft.AspNetCore.Diagnostics;
using System;
using System.ComponentModel.DataAnnotations;
using MovieApp.Web.Validators;
using Xunit.Abstractions;

namespace MovieApp.Web.Models
{
	public class UserModel
	{
        public int UserId{ get; set; }
		[Required]
		[StringLength(10,ErrorMessage ="UserName için 10 karakterden fazla olamaz")]
		public string UserName{ get; set; }
		[Required]
		[StringLength(15, ErrorMessage = "{0} karakter uzunluğu {2}-{1} arasında olmalıdır.",MinimumLength =3)]
		public string Name { get; set; }
		[Required]
		[EmailAddress]
		[EmailPovider]
		public string Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[Compare(nameof(Password))]
		public string RePassword { get; set; }
		[Url]
		public string Url { get; set; }
		//[Required]
		//[Range(1900,2007)]
		//public int BirthDay { get; set; }
		[BirthDate(ErrorMessage = "Geçersiz doğum tarihi!")]
		[DataType(DataType.Date)]
		[Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }




    }
}
