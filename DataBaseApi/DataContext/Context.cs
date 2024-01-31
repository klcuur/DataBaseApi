using DataBaseApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DataBaseApi.DataContext
{
	public class Context : IdentityDbContext<AppUser, AppRole, string>
	{
		public Context(DbContextOptions<Context> options) : base(options)
		{

		}
		public Context() { }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<AppRole>().HasData(new AppRole
			{
				Id = "1",
				Name = "Admin",
				NormalizedName = "ADMIN"
			},
			new AppRole
			{
				Id = "2",
				Name = "Doctor",
				NormalizedName = "DOCTOR"
			},
			new AppRole
			{
				Id = "3",
				Name = "Patient",
				NormalizedName = "PATIENT"
			});

			var hasher = new PasswordHasher<AppUser>();

			modelBuilder.Entity<AppUser>().HasData(

				new AppUser
				{
					Id = "1",
					UserName = "admin",
					NormalizedUserName = "ADMIN",
					Email = "info@admin.com",
					NormalizedEmail = "INFO@ADMIN.COM",
					PasswordHash = hasher.HashPassword(null, "123456"),
					SecurityStamp = string.Empty,
					EmailConfirmed = true
					
				},
				new AppUser
				{
					Id = "2",
					UserName = "hidircelikel",
					NormalizedUserName = "HIDIRCELIKEL",
					Email = "info@hidir.com",
					NormalizedEmail = "INFO@HIDIR.COM",
					PasswordHash = hasher.HashPassword(null, "123456"),
					SecurityStamp = string.Empty,
					EmailConfirmed = true
				},
				new AppUser
				{
					Id = "3",
					UserName = "sevvalyildirim",
					NormalizedUserName = "SEVVALYILDIRIM",
					Email = "info@sevval.com",
					NormalizedEmail = "INFO@SEVVAL.COM",
					PasswordHash = hasher.HashPassword(null, "123456"),
					SecurityStamp = string.Empty,
					EmailConfirmed = true
				},
				new AppUser
				{
					Id = "4",
					UserName = "ogunozkaya",
					NormalizedUserName = "OGUNOZKAYA",
					Email = "info@ogun.com",
					NormalizedEmail = "INFO@OGUN.COM",
					PasswordHash = hasher.HashPassword(null, "123456"),
					SecurityStamp = string.Empty,
					EmailConfirmed = true
				});
			modelBuilder.Entity<IdentityUserRole<string>>().HasData(

				new IdentityUserRole<string> { UserId = "1", RoleId = "1" },
				new IdentityUserRole<string> { UserId = "2", RoleId = "3" },
				new IdentityUserRole<string> { UserId = "3", RoleId = "3" },
				new IdentityUserRole<string> { UserId = "4", RoleId = "2" }
			);



		}
	}

}
