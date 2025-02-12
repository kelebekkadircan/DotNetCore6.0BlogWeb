using Blog.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataLayer.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(150)
                .IsRequired();

            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "ASP.NET CORE DENEME 1",
                Content = "ASP.NET CORE DENEME 1 İÇERİK ",
                ViewCount = 100,
                CategoryId = Guid.Parse("2A2A8EF5-0D02-4091-B462-6BEA352720E1"),
                ImageId = Guid.Parse("69726F77-C099-4048-81F0-F33E437175CF"),
                CreatedBy = "Kadircan 1",
                UpdatedBy = null,
                DeletedBy = null,
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                DeletedDate = null,
                isDeleted = false,
            },new Article
            {
                Id = Guid.NewGuid(),
                Title = "ASP.NET CORE DENEME 2",
                Content = "ASP.NET CORE DENEME 2 İÇERİK ",
                ViewCount = 100,
                CategoryId = Guid.Parse("AF45C78D-8DD3-4B5F-909B-1AF12D09C7CB"),
                ImageId = Guid.Parse("91CE1900-9C49-4E5E-A44E-070C082F95E2"),
                CreatedBy = "Kadircan 2",
                UpdatedBy = null,
                DeletedBy = null,
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                DeletedDate = null,
                isDeleted = false,

            }, new Article
            {
                Id = Guid.NewGuid(),
                Title = "ASP.NET CORE DENEME 3",
                Content = "ASP.NET CORE DENEME 3 İÇERİK ",
                ViewCount = 100,
                CategoryId = Guid.Parse("3D832871-248C-4DA9-BA3D-64732CD26BCC"),
                ImageId = Guid.Parse("CA14C683-3529-45B4-8268-DD08BE4E9344"),
                CreatedBy = "Kadircan 3",
                UpdatedBy = null,
                DeletedBy = null,
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                DeletedDate = null,
                isDeleted = false,

            });

         






        }
    }
}
