using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Entities
{
    public class Person : BaseEntity, IMyEntity
    {
        public string Name { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Order> Orders { get; set; }

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
