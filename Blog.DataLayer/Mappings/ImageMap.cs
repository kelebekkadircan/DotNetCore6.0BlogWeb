using Blog.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataLayer.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("69726F77-C099-4048-81F0-F33E437175CF"),
                FileName = "Image Name 1 ",
                FileType = "jpg",
                CreatedBy = "Kadircan 1",
                UpdatedBy = null,
                DeletedBy = null,
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                DeletedDate = null,
                isDeleted = false,
            } , new Image
            {
                Id = Guid.Parse("91CE1900-9C49-4E5E-A44E-070C082F95E2"),
                FileName = "Image Name 2 ",
                FileType = "jpg",
                CreatedBy = "Kadircan 2",
                UpdatedBy = null,
                DeletedBy = null,
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                DeletedDate = null,
                isDeleted = false,
            } , new Image
            {
                Id = Guid.Parse("CA14C683-3529-45B4-8268-DD08BE4E9344"),
                FileName = "Image Name 3 ",
                FileType = "jpg",
                CreatedBy = "Kadircan 3",
                UpdatedBy = null,
                DeletedBy = null,
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                DeletedDate = null,
                isDeleted = false,
            }
            );
        }
    }
}
