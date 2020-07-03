using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.SqlServer
{
    public class Parcel : BaseEntity, IMyEntity
    {
        public int id { get; set; }
        public int Weight { get; set; }
        public decimal Value { get; set; }
        public string Content { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
        public Order Order { get; set; }
        public int Order_Id { get; set; }
    }
    internal class ParcelConfiguration : IEntityTypeConfiguration<Parcel>
    {
        public void Configure(EntityTypeBuilder<Parcel> builder)
        {
            builder.ToTable(nameof(Parcel), nameof(SchemaEnum.KookBaz));

            builder.HasOne(z => z.Order).WithMany(z => z.Parcels).HasForeignKey(z => z.Order_Id);
        }
    }
}
