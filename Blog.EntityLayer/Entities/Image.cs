﻿using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace Blog.EntityLayer.Entities
{
    public class Image  : EntityBase, IEntityBase
    {
     
        public string FileName { get; set; }
        public string FileType { get; set; }
        
        public ICollection<Article> Articles { get; set; }

        public ICollection<AppUser> AppUsers { get; set; }
    }
}
