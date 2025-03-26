using Blog.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataLayer.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> b)
        {
            // Primary key
            b.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            b.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            b.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            b.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            b.Property(u => u.Name).HasMaxLength(256);
            b.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            b.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            b.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            b.HasData(new AppRole
            {
                Id = Guid.Parse("31D9C209-5859-4024-8BA2-AC03DAD58D3B"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = new Guid().ToString() // iki kişi aynı anda değişiklik yapmaya çalışırsa en son değişikliği almamızı sağlar milisaniye cinsinden
            }, new AppRole
            {

                Id = Guid.Parse("59470E7D-6B21-4FF7-919F-2C1ABF16D2C6"),
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN",
                ConcurrencyStamp = new Guid().ToString() // iki kişi aynı anda değişiklik yapmaya çalışırsa en son değişikliği almamızı sağlar milisaniye cinsinden

            }, new AppRole
            {
                Id = Guid.Parse("7F4F7D8B-078B-4A18-8B86-A459E2FD90CF"),
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = new Guid().ToString() // iki kişi aynı anda değişiklik yapmaya çalışırsa en son değişikliği almamızı sağlar milisaniye cinsinden
            }

            );
        
        }
    }
}
