using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Data.Models;
using System.Threading.Tasks;

namespace MVC_Data.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(_roleManager.Roles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string name )
        {
           IdentityResult result = await _roleManager.CreateAsync(new IdentityRole { Name = name });
            if (result.Succeeded)
            {
                return RedirectToAction("Index");

            }
            return View();

        }

        public IActionResult AddUserToRole()
        {
            ViewBag.Roles = new SelectList(_roleManager.Roles, "Name", "Name");
            ViewBag.Users = new SelectList(_userManager.Users, "Id", "UserName"); //chooses id but writes user on webpage

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUserToRole(string role, string user)
        {
            var _user = await _userManager.FindByIdAsync(user);

            IdentityResult result = await _userManager.AddToRoleAsync(_user, role);
              if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
