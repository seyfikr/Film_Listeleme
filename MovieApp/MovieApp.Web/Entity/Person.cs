namespace MovieApp.Web.Entity
{
	public class Person
	{
		public int PersonId { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public string Bio { get; set; }
		public string IMDB { get; set; }
		public string HomePage { get; set; }
		public string PlaceOfBird { get; set; }
		public User User { get; set; }
		public int UserId { get; set; }
	}
}
