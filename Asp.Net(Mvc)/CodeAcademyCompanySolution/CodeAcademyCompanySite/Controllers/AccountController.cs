using CodeAcademyCompany.DAL.Model;
using CodeAcademyCompany.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyCompany.PL.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signinMaganer;
		#region Register
		//private readonly UserManager<ApplicationUser>  _userManager;
		//private readonly SignInManager<ApplicationUser> _signinManager;

		//public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signinManager)
		//      {
		//	_userManager = userManager;
		//	_signinManager = signinManager;
		//}
		//      #region Register
		//      public IActionResult Register()
		//      {
		//          return View();
		//      }
		//      [HttpPost]
		//      public async Task<IActionResult> Register(RegisterVm user)
		//{   //BBRW4FHLQ99aFjx
		//          //P@ssWord11
		//	if (ModelState.IsValid)
		//          {
		//              ApplicationUser _User = new ApplicationUser()
		//              {
		//                  Fname = user.Fname ,
		//                  Lname = user.Lname ,
		//                  UserName = user.Fname + user.Lname ,
		//                  Email = user.Email ,

		//              };
		//              var result = await _userManager.CreateAsync(_User, user.Password);
		//              if(result.Succeeded)
		//              {
		//                    return  RedirectToAction("Index", "Home");  
		//              }


		//          }

		//          return View(user);
		//      }

		//      #endregion
		//      #region Login
		//      public IActionResult Login()
		//      {
		//          return View();
		//      }
		//      #endregion 
		#endregion
		//what should i do ? // Create User || Login
		// UserManager , SigninManager
		public AccountController(UserManager<ApplicationUser> userManager , SignInManager<ApplicationUser> signinMaganer)
        {
			_userManager = userManager;
			_signinMaganer = signinMaganer;
		}
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Register(RegisterVm model)
        {
            if(ModelState.IsValid)
            {
                var User = new ApplicationUser()
                {
                    //UserName = model.Fname +model.Lname,
                    UserName = model.Email.Split('@')[0],
                    Fname = model.Fname ,
                    Lname = model.Lname ,
                    Email = model.Email ,

                };
                var result = await  _userManager.CreateAsync(User , model.Password);
				if (result.Succeeded)
				{
					return RedirectToAction("Login");
				}
				else
				{
                    foreach (var err in result.Errors)
                    {
						ModelState.AddModelError(string.Empty, err.Description);
                    }
                }	

			}
           
            return View(model);
        }

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginVm model)
		{
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(model.Email );

				if(user is not null)
				{
					var flag = await _userManager.CheckPasswordAsync(user, model.Password );
					if (flag)
					{
						 var result = await _signinMaganer.PasswordSignInAsync(user , model.Password , model.RememberMe , false );
						if(result.Succeeded)
						{
							return RedirectToAction("Index", "Employee");

						}
					}
					else
					{
						// t3ala hack 
						ModelState.AddModelError(string.Empty, "Passwrod not Valid");

					}
				}
				ModelState.AddModelError(string.Empty, "Email not Valid");
			}

			return View(model);
		}
    }
}
