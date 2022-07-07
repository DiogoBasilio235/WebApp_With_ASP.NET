using System;
namespace DutchTreat
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
			app.UseDefaultFiles();
			app.UseStaticFiles();
        }
	}
}

