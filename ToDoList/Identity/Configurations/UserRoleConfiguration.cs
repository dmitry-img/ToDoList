using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "705b1c3e-71c9-4e67-b25f-79063000caa1",
                    UserId = "ad859e1b-b23b-43d1-b7a1-c5ce852fc98d"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "1bb99b5c-2c45-4989-8db8-ebc5597a08ec",
                    UserId = "e44d31c7-e726-45ec-99a8-6a5f5ad13d18"
                }
            );
        }
    }
}
