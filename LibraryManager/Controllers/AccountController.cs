//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using LibraryManager.Models;
//using LibraryManager.ViewModels;
//using System.Web.Security;

//namespace LibraryManager.Controllers
//{
//    public class AccountController : Controller
//    {
//        // GET: Account
//        public ActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Login(User model)
//        {
//            using (var context = new LibraryEntities1())
//            {
//                bool isValid = context.Users.Any(x => x.username == model.username && x.password == model.password);
//                if (isValid)
//                {
//                    FormsAuthentication.SetAuthCookie(model.username, false);
//                    return RedirectToAction("Index", "Employees");
//                }
//                ModelState.AddModelError("", "Invalid");

//                return View();
//            }
//        }

//        public ActionResult Signup()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Signup(NewUserViewModel model)
//        {
//            using(var context = new LibraryEntities1())
//            {
//                context.Users.Add(model.User); //odnovremenno user&employee?
//                context.SaveChanges();
//            }
//            return RedirectToAction("login");
//        }
//    }
//}