﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project3.Entities {
    internal class Post {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { 
        

        }

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comments) {

            Comments.Add(comments);
        }

        public void RemoveComment(Comment comments) {

            Comments.Remove(comments);
        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments) {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
