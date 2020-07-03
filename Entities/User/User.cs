using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.User
{
    public class User : IdentityUser<int>, IEntity,IMyEntity
    {
        public User()
        {
            IsActive = true;
        }
        public DateTime Create_Dm { get; set; }
        public string Create_Ds { get; set; }
        public DateTime? LastUpdate_Dm { get; set; }
        public string LastUpdate_Ds { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public GenderType Gender { get; set; }
        public bool IsActive { get; set; }
        public string Avatar { get; set; }
        public string BirthDate_Ds { get; set; }
        public string BirthDate_Dm { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }
        public string NationalCode { get; set; }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(z => z.Id).ValueGeneratedNever();
            builder.Property(p => p.UserName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(100).IsUnicode();
        }
    }

    public enum GenderType
    {
        [Display(Name = "مرد")]
        Male = 1,

        [Display(Name = "زن")]
        Female = 2
    }
}
