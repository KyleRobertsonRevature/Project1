using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Models;
using Project1.Models.Repositories;

namespace Project1.UI.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserRepo _userRepo;
        //private readonly AccountRepo _accountRepo;

        public UsersController(BankingContext context)
        {
            _userRepo = new UserRepo(context);
            // todo add account repo here
        }

        // GET: Users
        public IActionResult Index()
        {
            return View(_userRepo.GetAllUsers());
        }

        // GET: Users/Details/username?
        [Route("/Users/Details/{username}")]
        public IActionResult Details(string username)
        {
            if (username == null)
            {
                return NotFound();
            }

            var user = _userRepo.GetUser(username);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public IActionResult Create([Bind("FirstName,LastName,Username,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                if (_userRepo.GetUser(user.Username) != null)
                {
                    ModelState.AddModelError("Username", "Username already in use.");
                    return View(user);
                }
                user.Accounts = new List<Account>();
                _userRepo.Add(user);
                HttpContext.Session.SetString("User", user.Username);
                return RedirectToAction("Overview");
            }
            return View(user);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([Bind("Username,Password")]LoginVM login)
        {
            if (ModelState.IsValid)
            {
                var dbUser = _userRepo.GetUser(login.Username);
                if (dbUser != null)
                {
                    if (login.Password == dbUser.Password)
                    {
                        HttpContext.Session.SetString("User", login.Username);
                        return RedirectToAction("Overview");
                    }
                    ModelState.AddModelError("Password", "Invalid Password.");
                    return View(login);
                }
                ModelState.AddModelError("Username", "Username not found.");
                return View(login);
            }
            return View(login);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("User", "");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Overview()
        {
            var user = _userRepo.GetUser(HttpContext.Session.GetString("User"));
            if (user == null) return NotFound();
            var overview = new OverviewVM
            {
                User = user,
                Accounts = user.Accounts
            };
            return View(overview);
        }
    }
}
