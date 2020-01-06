using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using coin_application.App_Start;
using coin_application.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace coin_application.Controllers
{
    public class UsersController : Controller
    {
        private MyDbContext _myDbContext;

        private ApplicationUserManager _userManager;

        public UsersController(MyDbContext dbContext, ApplicationUserManager userManager)
        {
            _myDbContext = dbContext;
            _userManager = userManager;
        }
        // GET: Users
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> ProcessRegister(string userName, string password, string email, string fullName, string phoneNumber)
        {
            var user = new User()
            {
                UserName = userName,
                Email = email,
                FullName = fullName,
                PhoneNumber = phoneNumber,
                CreatedAt = DateTime.Now
            };

            IdentityResult result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                _userManager.AddToRole(user.Id, "User");
                return Redirect("/Home");
            }
            return Redirect("/Home");
        }

        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessLogin(string userName, string password)
        {
            var users = _userManager.Find(userName, password);
            if (users == null)
            {
                return HttpNotFound("Tên đăng nhập hoặc mật khẩu không đúng, vui lòng thử lại!");
            }

            var ident = _userManager.CreateIdentity(users, DefaultAuthenticationTypes.ApplicationCookie);
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignIn(new AuthenticationProperties{ IsPersistent = false}, ident);
            return Redirect("/Home");
        }

        [HttpGet]
        [Authorize]
        public ActionResult Logout()
        {
            HttpContext.GetOwinContext().Authentication.SignOut();
            return Redirect("/Home");
        }

        
    }
}