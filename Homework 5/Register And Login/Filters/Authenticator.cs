using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Register_And_Login.Data;
using Register_And_Login.Models;

namespace Register_And_Login.Filters
{
    public class Authenticator : ActionFilterAttribute
    {
        private readonly ApplicationDbContext _context;

        public Authenticator(ApplicationDbContext context)
        {
            _context = context;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //If the token is not present, send the user to Login Page.
            if (!context.HttpContext.Request.Cookies.TryGetValue("token", out string? token))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "login",controller = "account" }));
            }
            User? user = _context.Users?.FirstOrDefault(u => u.Token!.Equals(token));
            if(user == null)
            {
                _ = new RedirectToRouteResult(new RouteValueDictionary(new { action = "login", controller = "account" }));
            }
            Controller? controller = context.Controller as Controller;
            if(controller!= null)
            {
                controller.ViewBag.User = user;
            }
            context.RouteData.Values["LoggedUser"] = user;
        }
    }
}
