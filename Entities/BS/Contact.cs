using Entities.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /// <summary>
    /// کلاس برای تیبل 
    /// </summary>
    public class Contact : BaseEntity
    {
        public string Value { get; set; }
        public ContactType ContactType { get; set; }
        public ContactTypeEnum ContactType_Id { get; set; }
        public Person Person { get; set; }
        public int Persion_Id { get; set; }
    }
    class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable(nameof(Contact), nameof(SchemaEnum.KookBaz));
            builder.Property(p => p.Value).IsRequired().HasMaxLength(100);

            builder.HasOne(z => z.ContactType).WithMany(z => z.Contacts).HasForeignKey(z => z.ContactType_Id);

            builder.HasOne(z => z.Person).WithMany(z => z.Contacts).HasForeignKey(z => z.Persion_Id);
        }
    }
}
