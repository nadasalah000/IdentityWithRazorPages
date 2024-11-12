using IdentityWithRazorPages.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityWithRazorPages.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<ApplicationUser>().ToTable("users","Security");
			builder.Entity<IdentityRole>().ToTable("Roles", "Security");
			builder.Entity<IdentityUserRole<string>>().ToTable("userRoles", "Security");
			builder.Entity<IdentityUserClaim<string>>().ToTable("userClaims", "Security");
			builder.Entity<IdentityUserLogin<string>>().ToTable("usersLogin", "Security");
			builder.Entity<IdentityUserClaim<string>>().ToTable("RoleClaims", "Security");
			builder.Entity<IdentityUserToken<string>>().ToTable("userTokens", "Security");

		}
	}
}
