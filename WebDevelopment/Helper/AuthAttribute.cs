using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Helper
{
	public class AuthAttribute : ActionFilterAttribute
	{
		private readonly Roles _roles;

		public AuthAttribute(Roles roles)
		{
			_roles = roles;
		}

		public override void OnActionExecuting(ActionExecutingContext context)
		{
			var svc = context.HttpContext.RequestServices;
			var jwt = svc.GetService<IJwtProvider>();

			if (context.HttpContext.Request.Cookies.ContainsKey("AuthToken"))
			{
				var user = jwt.GetUserFromToken(context.HttpContext.Request.Cookies["AuthToken"]);
				if (user == null)
					context.Result = new RedirectResult(("/Login/Index"));
			}
			else context.Result = new RedirectResult(("/Login/Index"));	
		}
	}
}