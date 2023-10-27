using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Post
    {
        public Post()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Image> ImagePosts { get; set; }
        public virtual ICollection<Video> VideoPosts { get; set; }
    }
}
