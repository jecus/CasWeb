using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace WebDevelopment
{
	public static class RouteConfig
	{
		public static void RegisterRoutes(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Login}/{action=Index}/{id?}");
			});
		}
	}
}