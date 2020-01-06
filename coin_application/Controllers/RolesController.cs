using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coin_application.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace coin_application.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesController : Controller
    {
        private MyDbContext _dbContext = new MyDbContext();

        private RoleManager<Role> _roleManager;

        public RolesController()
        {
            RoleStore<Role> roleStore =  new RoleStore<Role>(_dbContext);
            _roleManager = new RoleManager<Role>(roleStore);
        }
        // GET: Roles
        public ActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessRole(string roleName)
        {
            var role = new Role()
            {
                Name = roleName,
                CreatedAt = DateTime.Now    
                
            };
            var result = _roleManager.Create(role);
            return Redirect("/Home");
        }
    }
}