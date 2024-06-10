namespace PosterInventory.Models
{
	public class Poster
	{
		public int PosterId { get; set; }
		public string Media { get; set; }
		public string Depicts { get; set; }
		public int SizeX { get; set; }
		public int SizeY { get; set; }
		public bool OnWall { get; set; }
	}
}