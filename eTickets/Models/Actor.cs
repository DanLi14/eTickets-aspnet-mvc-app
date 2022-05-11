using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace eTickets.Models	
{
	public class Actor
	{
		[Key]

		public int Id { get; set; }

		public string ProfilePictureURL { get; set; }

		public string FullName { get; set;}

		public string Bio { get; set;}
	}
}
