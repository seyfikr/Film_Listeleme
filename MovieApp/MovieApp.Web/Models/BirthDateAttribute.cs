using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
namespace MovieApp.Web.Models
{
	internal class BirthDateAttribute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			DateTime dateTime = Convert.ToDateTime(value);
			return dateTime <= DateTime.Now;
		}
	}
}