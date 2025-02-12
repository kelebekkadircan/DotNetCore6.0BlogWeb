using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataLayer.Migrations
{
    public partial class seedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Name", "UpdatedBy", "UpdatedDate", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("2a2a8ef5-0d02-4091-b462-6bea352720e1"), "Kadircan 1", new DateTime(2025, 2, 12, 22, 21, 18, 240, DateTimeKind.Local).AddTicks(7343), null, null, "ASP.NET CORE CATEGORY 1", null, null, false },
                    { new Guid("3d832871-248c-4da9-ba3d-64732cd26bcc"), "Kadircan 3", new DateTime(2025, 2, 12, 22, 21, 18, 240, DateTimeKind.Local).AddTicks(7351), null, null, "ASP.NET CORE CATEGORY 3", null, null, false },
                    { new Guid("af45c78d-8dd3-4b5f-909b-1af12d09c7cb"), "Kadircan 2", new DateTime(2025, 2, 12, 22, 21, 18, 240, DateTimeKind.Local).AddTicks(7347), null, null, "ASP.NET CORE CATEGORY 2", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "UpdatedBy", "UpdatedDate", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("69726f77-c099-4048-81f0-f33e437175cf"), "Kadircan 1", new DateTime(2025, 2, 12, 22, 21, 18, 240, DateTimeKind.Local).AddTicks(7451), null, null, "Image Name 1 ", "jpg", null, null, false },
                    { new Guid("91ce1900-9c49-4e5e-a44e-070c082f95e2"), "Kadircan 2", new DateTime(2025, 2, 12, 22, 21, 18, 240, DateTimeKind.Local).AddTicks(7456), null, null, "Image Name 2 ", "jpg", null, null, false },
                    { new Guid("ca14c683-3529-45b4-8268-dd08be4e9344"), "Kadircan 3", new DateTime(2025, 2, 12, 22, 21, 18, 240, DateTimeKind.Local).AddTicks(7459), null, null, "Image Name 3 ", "jpg", null, null, false }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "Title", "UpdatedBy", "UpdatedDate", "ViewCount", "isDeleted" },
                values: new object[] { new Guid("47376917-e0a9-4329-84c6-c924681dc246"), new Guid("af45c78d-8dd3-4b5f-909b-1af12d09c7cb"), "ASP.NET CORE DENEME 2 İÇERİK ", "Kadircan 2", new DateTime(2025, 2, 12, 22, 21, 18, 240, DateTimeKind.Local).AddTicks(7091), null, null, new Guid("91ce1900-9c49-4e5e-a44e-070c082f95e2"), "ASP.NET CORE DENEME 2", null, null, 100, false });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "Title", "UpdatedBy", "UpdatedDate", "ViewCount", "isDeleted" },
                values: new object[] { new Guid("48483b7e-aafa-4bc1-8bf6-9523d577a756"), new Guid("2a2a8ef5-0d02-4091-b462-6bea352720e1"), "ASP.NET CORE DENEME 1 İÇERİK ", "Kadircan 1", new DateTime(2025, 2, 12, 22, 21, 18, 240, DateTimeKind.Local).AddTicks(7085), null, null, new Guid("69726f77-c099-4048-81f0-f33e437175cf"), "ASP.NET CORE DENEME 1", null, null, 100, false });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "Title", "UpdatedBy", "UpdatedDate", "ViewCount", "isDeleted" },
                values: new object[] { new Guid("5a02788c-d74b-4ff6-a762-8967fe4237d5"), new Guid("3d832871-248c-4da9-ba3d-64732cd26bcc"), "ASP.NET CORE DENEME 3 İÇERİK ", "Kadircan 3", new DateTime(2025, 2, 12, 22, 21, 18, 240, DateTimeKind.Local).AddTicks(7105), null, null, new Guid("ca14c683-3529-45b4-8268-dd08be4e9344"), "ASP.NET CORE DENEME 3", null, null, 100, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("47376917-e0a9-4329-84c6-c924681dc246"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("48483b7e-aafa-4bc1-8bf6-9523d577a756"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5a02788c-d74b-4ff6-a762-8967fe4237d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a2a8ef5-0d02-4091-b462-6bea352720e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d832871-248c-4da9-ba3d-64732cd26bcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af45c78d-8dd3-4b5f-909b-1af12d09c7cb"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("69726f77-c099-4048-81f0-f33e437175cf"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("91ce1900-9c49-4e5e-a44e-070c082f95e2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ca14c683-3529-45b4-8268-dd08be4e9344"));
        }
    }
}
