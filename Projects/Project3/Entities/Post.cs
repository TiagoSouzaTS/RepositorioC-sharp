using System;
using System.Collections.Generic;
using System.Text;

namespace Project3.Entities {
    internal class Post {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();


    }
}
