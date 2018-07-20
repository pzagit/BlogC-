using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogRough.Models
{
    public class Post
    {   
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime Date { get; set; }

        public string ImageFile { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}