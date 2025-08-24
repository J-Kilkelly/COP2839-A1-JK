using System.ComponentModel.DataAnnotations;

namespace COP2839_A1_JK.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Author { get; set; }
	}
}
