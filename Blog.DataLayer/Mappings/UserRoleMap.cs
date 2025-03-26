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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> b)
        {
            // Primary key
            b.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            b.ToTable("AspNetUserRoles");


            b.HasData( new AppUserRole
                {
                    RoleId = Guid.Parse("59470E7D-6B21-4FF7-919F-2C1ABF16D2C6"),
                    UserId = Guid.Parse("C996D162-2278-4FFD-B8CD-ABC1974EFDCA"),
                },
                new AppUserRole
                {
                    RoleId = Guid.Parse("31D9C209-5859-4024-8BA2-AC03DAD58D3B"),
                    UserId = Guid.Parse("F9F4FC85-C51B-4EDF-8A88-8D9A51B05CD8"),
                }
            );
        }
    }
}
