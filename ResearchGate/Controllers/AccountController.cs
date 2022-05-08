using ResearchGate.Data;
using ResearchGate.Data.Static;
using ResearchGate.Data.ViewModels;
using ResearchGate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace ResearchGate.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Auther> _userManager;
        private readonly SignInManager<Auther> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<Auther> userManager, SignInManager<Auther> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login() => View(new LoginVM());

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            var user = await _userManager.FindByEmailAsync(loginVM.Email);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                TempData["Error"] = "Wrong credentials. Please, try again!";
                return View(loginVM);
            }

            TempData["Error"] = "Wrong credentials. Please, try again!";
            return View(loginVM);
        }

        public IActionResult Register() => View(new RegisterVM());

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            var user = await _userManager.FindByEmailAsync(registerVM.Email);
            if (user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(registerVM);
            }

            var newUser = new Auther()
            {
                FirstName = registerVM.FirstName,
                LastName = registerVM.LastName,
                PhoneNumber = registerVM.Mobile,
                Uni = registerVM.Uni,
                Dept = registerVM.Dept,
                Email = registerVM.Email, 
                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                UserName = registerVM.Email
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);

            //if (newUserResponse.Succeeded)
                //await _userManager.AddToRoleAsync(newUser, UserRoles.Admin);

            return View("RegisterCompleted");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
