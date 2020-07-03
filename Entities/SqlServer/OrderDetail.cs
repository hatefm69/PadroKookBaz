using Entities.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// کلاس برای تیبل 
    /// </summary>
    public class OrderDetail : BaseEntity, IMyEntity
    {
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string PostalCode { get; set; }
        public decimal ShipingAmount { get; set; }
        public decimal MinShipingAmountForFree { get; set; }
        public bool IsNeedAddress { get; set; }
        public IEnumerable<ShopingBagItem> Items { get; set; }
    }

    internal class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable(nameof(OrderDetail), nameof(SchemaEnum.KookBaz));
            builder.HasMany(z => z.Items).WithOne(z => z.OrderDetail).HasForeignKey(z => z.OrderDetail_Id);
        }
    }




}
