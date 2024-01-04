using Microsoft.AspNetCore.Mvc;
using Project.Models;


namespace Project.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
        {
         new User(){name="ali",email="asdfghjm", phone ="sdfghj"},
         new User(){name="ali",email="asdfghjm", phone ="sdfghj"},
         new User(){name="ali", email="asdfghjm", phone ="sdfghj"},
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
