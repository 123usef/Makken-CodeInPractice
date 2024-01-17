using CodeAcademyCompany.DAL.Model;
using CodeAcademyCompany.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyCompany.PL.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<ApplicationUser>  _userManager;
		private readonly SignInManager<ApplicationUser> _signinManager;

		public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signinManager)
        {
			_userManager = userManager;
			_signinManager = signinManager;
		}
        #region Register
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVm user)
		{   //BBRW4FHLQ99aFjx
            //P@ssWord11
			if (ModelState.IsValid)
            {
                ApplicationUser _User = new ApplicationUser()
                {
                    Fname = user.Fname ,
                    Lname = user.Lname ,
                    UserName = user.Fname + user.Lname ,
                    Email = user.Email ,

                };
                var result = await _userManager.CreateAsync(_User, user.Password);
                if(result.Succeeded)
                {
                      return  RedirectToAction("Index", "Home");  
                }

                
            }

            return View(user);
        }

        #endregion
        #region Login
        public IActionResult Login()
        {
            return View();
        }
        #endregion

    }
}
