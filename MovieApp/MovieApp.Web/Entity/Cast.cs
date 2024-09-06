namespace MovieApp.Web.Entity
{
	public class Cast
	{
		public int CastId { get; set; }
		public Movie Movie { get; set; }
		public int MovieId { get; set; }
		public Person Person { get; set; }
		public int PersonID { get; set; }
		public string Name { get; set; }
		public string Character { get; set; }

	}
}
