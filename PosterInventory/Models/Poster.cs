namespace PosterInventory.Models
{
	public class Poster
	{
		public int PosterId { get; set; }
		public string Media { get; set; }
		
		public Poster(string media)
		{
			Media = media;
		}
	}
}