﻿using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntityLayer.Entities
{
    public class Category : EntityBase , IEntityBase
    {
      
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }

    }
}
