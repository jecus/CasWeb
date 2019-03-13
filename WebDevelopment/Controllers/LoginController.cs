using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
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
				HttpContext.Response.Cookies.Append("AuthToken", _jwtProvider.GenerateToken(user));;
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