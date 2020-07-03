using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.User
{
    public class Role : IdentityRole<int>, IEntity,IMyEntity
    {
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        public DateTime Create_Dm { get; set; }
        public string Create_Ds { get; set ; }
        public DateTime? LastUpdate_Dm { get ; set;  }
        public string LastUpdate_Ds { get ; set;  }
    }
    

    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}
