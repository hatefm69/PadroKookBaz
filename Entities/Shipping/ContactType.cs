using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// کلاس برای تیبل 
    /// </summary>
    public class ContactType : BaseEntity<ContactTypeEnum>
    {
        public string Value { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
    }
    public enum ContactTypeEnum
    {
        [Display(Name = "تلفن ثابت")]
        Tel = 1,
        [Display(Name = "موبایل")]
        Mobile = 2,
        [Display(Name = "آدرس")]
        Address = 3,
        [Display(Name = "مکان سیستمی")]
        LocationSystem = 4,
        [Display(Name = "مکان دستی")]
        LocationManual = 5,
        [Display(Name = "کد پستی")]
        Postal_code = 6,
        [Display(Name = "شهر")]
        city = 6
    }
    internal class ContactTypeConfiguration : IEntityTypeConfiguration<ContactType>
    {
        public void Configure(EntityTypeBuilder<ContactType> builder)
        {
            builder.ToTable(nameof(ContactType), nameof(SchemaEnum.KookBaz));
            builder.Property(p => p.Value).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.HasMany(z => z.Contacts).WithOne(z => z.ContactType).HasForeignKey(z => z.ContactType_Id);
        }
    }
}
