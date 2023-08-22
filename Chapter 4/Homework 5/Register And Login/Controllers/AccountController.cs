using CryptoHelper;
using Microsoft.AspNetCore.Mvc;
using Register_And_Login.Data;
using Register_And_Login.Models;
using Register_And_Login.ViewModel;

namespace Register_And_Login.Controllers
{
    public class AccountController : Controller
    {
        private User? _user => RouteData.Values["LoggedUser"] as User; //Must be same as in Authenticator class.
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //} 
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if(_context.Users!.Any(u => u.Email == model.Email))
            {
                ModelState.AddModelError("Email","This email has already been registered.");
            }
            if (ModelState.IsValid)
            {
                User user = new()
                {
                    Username = model.Username,
                    Email = model.Email,
                    Password = Crypto.HashPassword(model.Password),
                    Token = Guid.NewGuid().ToString(),
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                Response.Cookies.Append("token",user.Token,new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(24),
                    HttpOnly = true
                });
            }
            return View();
        }
    }
}
