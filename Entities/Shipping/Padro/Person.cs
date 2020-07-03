using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Padro
{
    /// <summary>
    /// جدول مشتریان
    /// </summary>
    public class Person : BaseEntity, IMyEntity
    {
        public string Name { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Order> Orders { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string Image { get; set; }
        public string BirthDate_Ds { get; set; }
        public string BirthDate_Dm { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }
        public string NationalCode { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }

    }
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable(nameof(Person), nameof(SchemaEnum.KookBaz));

            builder.HasMany(z => z.Contacts).WithOne(z => z.Person).HasForeignKey(z => z.Persion_Id);
            builder.HasMany(z => z.Orders).WithOne(z => z.Receiver).HasForeignKey(z => z.Receiver_Id);
            builder.HasMany(z => z.Orders).WithOne(z => z.Sender).HasForeignKey(z => z.Sender_Id);
        }
    }


}
