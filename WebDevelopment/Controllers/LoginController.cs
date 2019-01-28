using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebDevelopment.Controllers
{
    public class LoginController : Controller
    {
	    private readonly IUserRepository _userRepository;

	    public LoginController(IUserRepository userRepository)
	    {
		    _userRepository = userRepository;
	    }

        public IActionResult Index()
        {
            return View();
        }

	    [HttpPost]
		public async Task<IActionResult> Index(UserView userView)
	    {
		    var user =  await _userRepository.IsAuthorized(userView.Login, userView.Password);
			
			if(user)
				return RedirectToAction("Index", "Home");

		    return View();
	    }
	}
}