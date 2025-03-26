using Blog.EntityLayer.DTO.Users;
using Blog.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _appUser;
        private readonly SignInManager<AppUser> _signInManager;
        public AuthController(UserManager<AppUser> appUser, SignInManager<AppUser> signInManager)
        {
            _appUser = appUser;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
           
            // Kullanıcı zaten oturum açmışsa ana sayfaya yönlendir
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home", new { Area = "Admin" });
            }
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            // Kullanıcı zaten oturum açmışsa ana sayfaya yönlendir
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home", new { Area = "Admin" });
            }
          

            if (ModelState.IsValid)
            {
                var user = await _appUser.FindByEmailAsync(userLoginDto.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false);
                    if (result.Succeeded) {
                        return RedirectToAction("Index", "Home", new {Area = "Admin"} );
                    }
                    else
                    {
                        ModelState.AddModelError("", "Email or password is incorrect");
                        return View(userLoginDto);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email or password is incorrect");
                    return View(userLoginDto);
                }
            }
            else
            {
                 return View(userLoginDto);

            }

            
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login","Auth", new {Area = "Admin" });
        }





    }
}
