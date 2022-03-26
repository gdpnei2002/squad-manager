using Microsoft.AspNetCore. Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System. Threading. Tasks;

namespace SquadManager.Controllers
{
    public class LoginController : Controller{
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Test(UserViewModel user)
        {
            User.Email = "email enviado";
                return ("Index", User)
        }

    }
}