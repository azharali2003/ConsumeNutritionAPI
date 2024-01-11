using consumeAPI_SUN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace consumeAPI_SUN.Controllers
{
    
    public class AccountController : Controller
    {
        Entities db = new Entities();

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(SignUpTB signUpTB)
        {
            if(ModelState.IsValid==true)
            {
                /*this is for  sql data checking */
                /*var data = db.SignUpTBs.Where(model => model.username == signUpTB.username && model.password == signUpTB.password).FirstOrDefault();*/

                /*this is hard code cuz everyone can access*/

                bool data = "admin" == signUpTB.username && "admin" == signUpTB.password;
                

                if (data != true)
                {
                    ViewBag.ErrorMessage = "Login Failed....";
                    return View();
                }
                else
                {
                    Session["username"] = signUpTB;
                    return RedirectToAction("GetFoodInfo","Food");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Account");
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(SignUpTB signUpTB)
        {    
            /* for signup new user you have to add model class i'll publish my code into gitUp and signUp table or it's data available in my local system,
                 * so first you have to create dat base then connect*/

            using (var context=new Entities())
            {
                context.SignUpTBs.Add(signUpTB);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }
    }
}