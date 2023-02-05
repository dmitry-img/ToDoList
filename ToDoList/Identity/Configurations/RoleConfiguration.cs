using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "1bb99b5c-2c45-4989-8db8-ebc5597a08ec",
                    Name = "SimpleUser",
                    NormalizedName = "SimpleUser"
                },
                new IdentityRole
                {
                    Id = "da118bce-20f4-430d-8844-a0b7e5e045ab",
                    Name = "ProUser",
                    NormalizedName = "PROUSER"
                },
                new IdentityRole
                {
                    Id = "705b1c3e-71c9-4e67-b25f-79063000caa1",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );
        }
    }
}
