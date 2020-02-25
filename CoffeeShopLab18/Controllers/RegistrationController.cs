using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopLab18.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopLab18.Controllers
{
    public class RegistrationController : Controller
    {
       
        public IActionResult RegistrationForm()
        {
            return View(new User());
        }

        public IActionResult Summary(User user)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View("RegistrationForm", user);
            }
           
        }
    }
}