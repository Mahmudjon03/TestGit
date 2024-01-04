using Microsoft.AspNetCore.Mvc;
using Project.Models;


namespace Project.Controllers
{
    public class Korgar : Controller
    {
        List<User> users = new List<User>()
        {
         new User(){name="Mahmud",role="Oshpaz", phone =923848293},
         new User(){name="Bilol",role="Waiter", phone =929384954},
         new User(){name="Behzod", role="Manager", phone =87654323},
        };
        public int MyProperty { get; set; }


        public IActionResult Index()
        {

            return View(users);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Create(User model)
        {
            // validate and insert
            if (ModelState.IsValid)
            {
                users.Add(model);
                Console.WriteLine(users.Count);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }
    }
}
