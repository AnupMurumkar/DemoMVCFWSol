using DemoMVCFW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Diagnostics;

namespace ModelBindingDemoCore.Controllers
{
    public class FormController : Controller
    {
        private readonly ILogger<FormController> _logger;

        public FormController(ILogger<FormController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(User user)
        {
            if (user != null)
            {
                if (ModelState.IsValid)
                {
                    ViewBag.Message = $"User created as UserName:{user.UserName} for Email:{user.UserEmail}";
                    return View("Index");
                }
            }
            return View("Index", user);

            /*var keys=form.Keys;
            if(form.ContainsKey("UserName") && form.ContainsKey("UserEmail"))
            {
                if(form.TryGetValue("UserName",out StringValues userName)&& 
                    form.TryGetValue("UserEmail", out StringValues userEmail))
                {
                    ViewBag.Message = $"User created as UserName:{userName} for Email:{userEmail}";

                }
                else
                {
                    ViewBag.Message = "UserName or UserEmail not Found";
                }
            }
            else
            {
                ViewBag.Message = "Form does not contain Keys";
            }*/

        }

        
    }
}