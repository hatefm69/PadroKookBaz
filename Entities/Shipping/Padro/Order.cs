using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Entities.Padro
{
    /// <summary>
    /// جدول بیجک
    /// </summary>
    public class Order : BaseEntity, IMyEntity
    {
        public Person Receiver { get; set; }
        public int? Receiver_Id { get; set; }
        public Person Sender { get; set; }
        public int? Sender_Id { get; set; }
        public string Provider_code { get; set; }
        public int? Payment_type { get; set; }
        public string Receiver_comment { get; set; }
        public IEnumerable<Parcel> Parcels { get; set; }


        public DateTime? Pickup_date_Dm { get; set; }
        public string Pickup_date_Ds { get; set; }
        public string Comment { get; set; }
        public int? Option_id { get; set; }
        public string  Status { get; set; }
        public string Order_Id { get; set; }
        public int KookBaz_Id { get; set; }
    }
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(nameof(Order), nameof(SchemaEnum.KookBaz));

           // builder.HasOne(z => z.Sender).WithMany(z => z.Orders).HasForeignKey(z => z.Sender_Id);
            builder.HasOne(z => z.Receiver).WithMany(z => z.Orders).HasForeignKey(z => z.Receiver_Id);
            builder.Property(x => x.Sender_Id).IsRequired(false);
            builder.Property(x => x.Receiver_Id).IsRequired(false);
            builder.HasMany(z => z.Parcels).WithOne(z => z.Order).HasForeignKey(z => z.Order_Id);


            builder.Property(z => z.Order_Id).IsRequired(false);
            builder.Property(z => z.Status).IsRequired(false).HasMaxLength(50);
            builder.Property(z => z.Option_id).IsRequired(false);
            builder.Property(z => z.Comment).IsRequired(false).HasMaxLength(500);
            builder.Property(z => z.Pickup_date_Ds).IsRequired(false).HasMaxLength(10);
            builder.Property(z => z.Pickup_date_Dm).IsRequired(false);
            builder.Property(z => z.Receiver_comment).IsRequired(false).HasMaxLength(100);
            builder.Property(z => z.Payment_type).IsRequired(false);
            builder.Property(z => z.Provider_code).IsRequired(false).HasMaxLength(50);
        }
    }





}
