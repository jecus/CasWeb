using System;
using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[AllowAnonymous]
    public class LoginController : Controller
    {
	    private readonly IUserRepository _userRepository;
	    private readonly IJwtProvider _jwtProvider;

	    public LoginController(IUserRepository userRepository, IJwtProvider jwtProvider)
	    {
		    _userRepository = userRepository;
		    _jwtProvider = jwtProvider;
	    }

        public IActionResult Index()
        {
            return View();
        }

		
	    [HttpPost]
		public async Task<IActionResult> Login(UserView userView)
	    {
		    var user =  await _userRepository.GetUserByLoginPassword(userView.Login, userView.Password);

		    if (user != null)
			{
				var options = new CookieOptions
				{
					Expires = DateTime.Now.AddHours(8),
					IsEssential = true
				};
				HttpContext.Response.Cookies.Append("AuthToken", _jwtProvider.GenerateToken(user), options);;
				return RedirectToAction("Index", "Home");
		    }

		    return View("Index");
	    }

		public async Task<IActionResult> Logout()
		{
			HttpContext.Response.Cookies.Delete("AuthToken");
			return View("Index");
		}
	}
}