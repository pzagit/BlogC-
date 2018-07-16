using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using BlogRough.Models;

namespace BlogRough.Controllers
{
    public class PostsController : Controller
    {

        public ActionResult View(int id)
        {
            return View();
        }
        // GET: Post
        public ActionResult Index(int? index)
        {
            if (!index.HasValue)
            {
                index = 1;
            }

            List<Post> listOfPosts = new List<Post>();
            Post post = new Post
            {
                Title = "First post",
                Body = "Hello, World!",
                Date = DateTime.Now
            };
            Post post2 = new Post
            {
                Title = "Second post",
                Body = "Hola!",
                Date = DateTime.Now
            };
            listOfPosts.Add(post);
            listOfPosts.Add(post2);
            //var post = new Post() {Title = "First Post", Body = "Hello, World!"};

            return View(listOfPosts);
        }
    }
}