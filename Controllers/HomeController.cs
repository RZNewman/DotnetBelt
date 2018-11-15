using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ent.Models;
using Microsoft.AspNetCore.Http;
using DbConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ent.Controllers
{
    public class HomeController : Controller
    {
        private EntContext db;
        public HomeController(EntContext context)
        {
            db = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            if (logged())
            {
                return RedirectToAction("success");
            }
            return RedirectToAction("reg");
        }
        public IActionResult success()
        {
            return RedirectToAction("events");
        }
        #region Login
        [HttpGet("register")]
        public IActionResult reg()
        {
            return View("Register");
        }
        [HttpGet("login")]
        public IActionResult log()
        {
            return View("login");
        }


        [HttpGet("logout")]
        public IActionResult Logout()
        {
            reset();
            return RedirectToAction("");
        }
        public void reset()
        {
            HttpContext.Session.Clear();

        }

        public bool logged()
        {
            int? Id = HttpContext.Session.GetInt32("User");
            if (Id == null)
            {
                return false;
            }
            User u = db.Users.FirstOrDefault(use => use.UserId == Id);
            if (u == null)
            {
                reset();
                return false;

            }
            if (u.Password != HttpContext.Session.GetString("PassH"))
            {

                reset();
                return false;

            }
            return true;
        }


        public IActionResult register(User user)
        {
            if (ModelState.IsValid)
            {
                // If a User exists with provided email
                if (db.Users.Any(u => u.Email == user.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");

                    // You may consider returning to the View at this point
                    return View();
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                db.Users.Add(user);
                db.SaveChanges();
                User Userdb = db.Users.FirstOrDefault(u => u.Email == user.Email);
                HttpContext.Session.SetInt32("User", Userdb.UserId);
                HttpContext.Session.SetString("PassH", Userdb.Password);
                return RedirectToAction("success");
            }
            return View();
        }
        public IActionResult login(loginObj log)
        {
            if (ModelState.IsValid)
            {



                var user = db.Users.FirstOrDefault(u => u.Email == log.Email);
                // If no user exists with provided email
                if (user == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("login");
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<loginObj>();

                // varify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(log, user.Password, log.Password);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("login");
                }
                HttpContext.Session.SetInt32("User", user.UserId);
                HttpContext.Session.SetString("PassH", user.Password);
                return RedirectToAction("success");

            }
            return View();
        }
        #endregion





        #region CRUD
        [HttpGet("events")]
        public IActionResult Events()
        {
            if (!logged())
            {
                return RedirectToAction("");
            }
            var evs = db.Events.OrderBy(e => e.Start).Include(e => e.Creator).Include(e => e.Guests).ThenInclude(a => a.User).ToList();
            ViewBag.Events = evs;
            //Console.WriteLine("HERE----------------------"+ViewBag.Events);
            int uid = HttpContext.Session.GetInt32("User") ?? 0;
            User us = db.Users.Where(u => u.UserId == uid).Include(e => e.Attending).ThenInclude(a => a.Event).First();
            ViewBag.User = us;
            ViewBag.Attending = us.Attending.Select(a => a.Event).ToList();
            return View();
        }


        [HttpGet("newEvent")]
        public IActionResult NewEvent()
        {
            if (!logged())
            {
                return RedirectToAction("");
            }
            return View();
        }

        [HttpGet("events/{id}")]
        public IActionResult ShowEvent(int id)
        {
            if (!logged())
            {
                return RedirectToAction("");
            }
            int uid = HttpContext.Session.GetInt32("User") ?? 0;
            Event ev = db.Events.Where(p => p.EventId == id).Include(p => p.Creator).Include(e => e.Guests).ThenInclude(a => a.User).First();
            ViewBag.Event = ev;
            User us = db.Users.Where(u => u.UserId == uid).Include(e => e.Attending).ThenInclude(a => a.Event).First();
            ViewBag.User = us;
            ViewBag.Attending = us.Attending.Select(a => a.Event).ToList();
            return View();
        }

        public IActionResult CreateEvent(Event e)
        {
            if (ModelState.IsValid)
            {
                e.UserId = HttpContext.Session.GetInt32("User") ?? 0;
                db.Add(e);
                
                db.SaveChanges();

                //This Code make a user join events theyve created, which enforces conflicts

                // Atendee a = new Atendee
                // {
                //     UserId = e.UserId,
                //     EventId = e.EventId
                // };
                // db.Add(a);
                // db.SaveChanges();


                return RedirectToAction("ShowEvent", new { id = e.EventId });

            }
            else
            {
                return View("newEvent");
            }
        }
        [HttpGet("events/{id}/delete")]
        public IActionResult Delete(int id)
        {
            if (!logged())
            {
                return RedirectToAction("");
            }
            Event ev = db.Events.Where(d => d.EventId == id).First();
            if (ev.UserId == (HttpContext.Session.GetInt32("User") ?? 0))
            {
                db.Events.Remove(ev);
                db.SaveChanges();
            }
            return RedirectToAction("");
        }
        [HttpGet("events/{id}/join")]
        public IActionResult Join(int id)
        {
            if (!logged())
            {
                return RedirectToAction("");
            }
            Event ev = db.Events.Where(d => d.EventId == id).First();
            int UsrId = (HttpContext.Session.GetInt32("User") ?? 0);
            Atendee a = new Atendee
            {
                UserId = UsrId,
                EventId = ev.EventId
            };
            db.Add(a);
            db.SaveChanges();

            return RedirectToAction("");
        }
        [HttpGet("events/{id}/leave")]
        public IActionResult Leave(int id)
        {
            if (!logged())
            {
                return RedirectToAction("");
            }
            Event ev = db.Events.Where(d => d.EventId == id).First();
            int UsrId = (HttpContext.Session.GetInt32("User") ?? 0);
            Atendee at = db.Atendees.FirstOrDefault(a => a.UserId == UsrId && a.EventId == ev.EventId);
            if (at != null)
            {
                db.Atendees.Remove(at);
                db.SaveChanges();
            }


            return RedirectToAction("");
        }


       
        // public IActionResult Update(Dish d)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         // do somethng!  maybe insert into db?  then we will redirectcopy
        //         Dish dish = db.Dishes.Where(di => di.DishId == d.DishId).First();
        //         db.Entry(dish).CurrentValues.SetValues(d);
        //         db.SaveChanges();
        //         return RedirectToAction("");

        //     }
        //     else
        //     {
        //         return View("new");
        //     }
        // }
        #endregion

    }
}
