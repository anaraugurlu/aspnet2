using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet2.Controllers
{
    using aspnet2.Entities;
    using aspnet2.Models;
    using Microsoft.AspNetCore.Mvc;
    //using aspnet2.Entities;
    //using RazorProject.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace RazorProject.Controllers
    {
        public class RegistrationController : Controller
        {

            public IActionResult Info(RegistrationViewModel vm)
            {
                return View(vm);
            }
            [HttpGet]
            public IActionResult Add()
            {
                var model = new RegistrationViewModel
                {
                    Player = new RegistrationDate()
                };

                return View(model);
            }
            [HttpPost]
            public IActionResult Add(RegistrationDate player)
            {
                return RedirectToAction("Info", "Player", new RegistrationViewModel { Player = player });
            }

        }
    }

}
