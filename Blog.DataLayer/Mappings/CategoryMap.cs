using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataLayer.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("2A2A8EF5-0D02-4091-B462-6BEA352720E1"),
                Name = "ASP.NET CORE CATEGORY 1",
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                DeletedDate = null,
                CreatedBy = "Kadircan 1",
                UpdatedBy = null,
                DeletedBy = null,
                isDeleted = false,

            }, new Category
            {
                Id = Guid.Parse("AF45C78D-8DD3-4B5F-909B-1AF12D09C7CB"),
                Name = "ASP.NET CORE CATEGORY 2",
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                DeletedDate = null,
                CreatedBy = "Kadircan 2",
                UpdatedBy = null,
                DeletedBy = null,
                isDeleted = false,
            }, new Category
            {
                Id = Guid.Parse("3D832871-248C-4DA9-BA3D-64732CD26BCC"),
                Name = "ASP.NET CORE CATEGORY 3",
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                DeletedDate = null,
                CreatedBy = "Kadircan 3",
                UpdatedBy = null,
                DeletedBy = null,
                isDeleted = false,
            }

            );



        }
    }
}
