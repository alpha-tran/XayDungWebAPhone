using Microsoft.EntityFrameworkCore;
using XayDungWebAphone.Models;

namespace XayDungWebAphone
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			var connectionString = builder.Configuration.GetConnectionString("WebAphoneConnection");
			builder.Services.AddDbContext<XayDungWebAphoneContext>(options =>
			 options.UseSqlServer(connectionString));


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
			}
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
