using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Padro
{
    /// <summary>
    /// جدول اطلاعات تماس
    /// </summary>
    public class Contact : BaseEntity,IMyEntity
    {
        public string Value { get; set; }
        public ContactType ContactType { get; set; }
        public ContactTypeEnum ContactType_Id { get; set; }
        public Person Person { get; set; }
        public int? Persion_Id { get; set; }
    }
    class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable(nameof(Contact), nameof(SchemaEnum.KookBaz));
            builder.Property(p => p.Value).IsRequired().HasMaxLength(100);

            builder.HasOne(z => z.ContactType).WithMany(z => z.Contacts).HasForeignKey(z => z.ContactType_Id);

            builder.HasOne(z => z.Person).WithMany(z => z.Contacts).HasForeignKey(z => z.Persion_Id);


            builder.Property(z => z.Persion_Id).IsRequired(false);
            builder.Property(z => z.Value).IsRequired(false).HasMaxLength(500);

        }
    }
}
