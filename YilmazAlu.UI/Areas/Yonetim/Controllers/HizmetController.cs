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

namespace YilmazAlu.UI.Areas.Yonetim.Controllers
{
    public class HizmetController : Controller
    {
        Repository<Hizmet> repoHizmet = new Repository<Hizmet>();
        [Authorize(Roles ="admin,member")]
        public ActionResult Index()
        {
            return View(repoHizmet.GetAll().ToList());
        }
        [Authorize(Roles = "admin,member")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hizmet hizmet = repoHizmet.GetBy(i=> i.ID==id);
            if (hizmet == null)
            {
                return HttpNotFound();
            }
            return View(hizmet);
        }
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Create(Hizmet hizmet)
        {
            if (ModelState.IsValid)
            {
                repoHizmet.Add(hizmet);
                return RedirectToAction("Index");
            }

            return View(hizmet);
        }
        [Authorize(Roles = "admin,member")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hizmet hizmet = repoHizmet.GetBy(i => i.ID == id);
            if (hizmet == null)
            {
                return HttpNotFound();
            }
            return View(hizmet);
        }

        [Authorize(Roles = "admin,member")]
        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Edit(Hizmet hizmet)
        {
            if (ModelState.IsValid)
            {
                repoHizmet.Update(hizmet);
                return RedirectToAction("Index");
            }
            return View(hizmet);
        }
        [Authorize(Roles = "admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hizmet hizmet = repoHizmet.GetBy(i => i.ID == id);
            if (hizmet == null)
            {
                return HttpNotFound();
            }
            return View(hizmet);
        }
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete"),ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hizmet hizmet = repoHizmet.GetBy(i => i.ID == id);
            repoHizmet.Remove(hizmet);
            return RedirectToAction("Index");
        }        
    }
}
