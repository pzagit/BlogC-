using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogRough.Models
{
    public class Post
    {
        [Required] public string Title { get; set; }

        [Required] public string Body { get; set; }

        public DateTime Date { get; set; }

        public List<Post> ListOfPosts { get; set; }
    }
}