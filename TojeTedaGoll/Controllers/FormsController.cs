using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TojeTedaGoll.Models;

namespace TojeTedaGoll.Controllers
{
    public class FormsController : Controller
    {
        private GuestsDBEntities _db = new GuestsDBEntities();
        
        // GET: Forms
        public ActionResult GuestList()
        {
            return View(_db.RsvpForm.ToList());
        }

        // GET: Forms/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Forms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Forms/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Guest GuestToCreate)
        {
            if(!ModelState.IsValid)
            
                return View();
                _db.RsvpForm.Add(GuestToCreate);
                _db.SaveChanges();

            return RedirectToAction("../Pages/Index");
        }

        // GET: Forms/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Forms/Edit/5
        [HttpPost]
        public ActionResult Edit()
        {
            return View();


        }

        // GET: /Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            return View();
            
        }

        // POST: /Movies/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
    
}
