using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using BlogRough.Context;
using BlogRough.Models;
using Newtonsoft.Json.Linq;

namespace BlogRough.Controllers
{
    public class PostsController : Controller
    {
        private BlogContext _db = new BlogContext();

        // GET: Post
        public ActionResult Index()
        {

            return View(_db.DbPost.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                _db.DbPost.Add(post);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = _db.DbPost.Find(Id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = _db.DbPost.Find(Id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? Id, string body, string title, DateTime date)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Post post = _db.DbPost.Find(Id);

            if (post == null)
            {
                return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
                post.Title = title;
                post.Body = body;
                post.Date = date;

                _db.DbPost.AddOrUpdate(post);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(post);
        }

        public ActionResult Delete(int? Id)
        {
             if (Id == null)
             {
                 return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
             }

            Post post = _db.DbPost.Find(Id);

            if (post == null)
            {
                return new HttpNotFoundResult();
            }

            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = _db.DbPost.Find(id);
            if (ModelState.IsValid)
            {
                _db.DbPost.Remove(post);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}