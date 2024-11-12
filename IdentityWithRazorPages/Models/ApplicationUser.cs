using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityWithRazorPages.Models
{
	public class ApplicationUser:IdentityUser
	{
		[Required,MaxLength(50)]
		public string FirstName { get; set; }
		[Required, MaxLength(50)]
		public string LirstName { get; set; }
		public byte[] ProfilePicture { get; set; }
	}
}
