﻿using Blog.Core.Entities;

namespace Blog.EntityLayer.Entities
{
    public class Article : EntityBase , IEntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid? ImageId { get; set; }
        public Image Image { get; set; }

        public Guid UserId { get; set; }

        public AppUser User { get; set; }
       
    }
}
