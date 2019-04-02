using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YilmazAlu.BOL.Entities;
using YilmazAlu.Repositories;

namespace YilmazAluUI.Areas.Yonetim.Controllers
{
    
    public class AdminController : Controller
    {
        Repository<Admin> repoAdmin = new Repository<Admin>();

        [Authorize]
        public ActionResult Index()
        {
            return View(repoAdmin.GetAll().ToList());
        }

        [Authorize(Roles = "admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = repoAdmin.GetBy(i=> i.ID==id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }
        
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost,ValidateAntiForgeryToken,Authorize(Roles ="admin")]
        public ActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                repoAdmin.Add(admin);
                return RedirectToAction("Index");
            }
            return View(admin);
        }
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = repoAdmin.GetBy(i => i.ID == id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }
        
        [HttpPost,ValidateAntiForgeryToken, Authorize]
        public ActionResult Edit(Admin admin)
        {
            if (ModelState.IsValid)
            {
                repoAdmin.Update(admin);
                return RedirectToAction("Index");
            }
            return View(admin);
        }

        [Authorize(Roles = "admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = repoAdmin.GetBy(i => i.ID == id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Yonetim/Hizmet/Delete/5
        [HttpPost, ActionName("Delete"),ValidateAntiForgeryToken,Authorize(Roles ="admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Admin admin = repoAdmin.GetBy(i => i.ID == id);
            repoAdmin.Remove(admin);
            return RedirectToAction("Index");
        }
    }
}
