using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    /// <summary>
    /// جدول اطلاعات سفارش کوک باز
    /// </summary>
    public class ShopingBagItem : BaseEntity, IMyEntity
    {
        public OrderDetail OrderDetail { get; set; }
        public int OrderDetail_Id { get; set; }
        public decimal Discount { get; set; }
        public int CurrencyId { get; set; }
        //public int Attributes { get; set; }
        public int MaxCount { get; set; }
        public int ObjectId { get; set; }
        //public int id { get; set; }
        public int PaymentType { get; set; }
        public int AllowCountGiftUseUser { get; set; }
        public int GiftId { get; set; }
        //public int Gifts { get; set; }
        public int Count { get; set; }
        public decimal Amount { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
    internal class ShopingBagItemConfiguration : IEntityTypeConfiguration<ShopingBagItem>
    {
        public void Configure(EntityTypeBuilder<ShopingBagItem> builder)
        {
            builder.ToTable(nameof(OrderDetail), nameof(SchemaEnum.KookBaz));
            builder.HasOne(z => z.OrderDetail).WithMany(z => z.Items).HasForeignKey(z => z.OrderDetail_Id);
        }
    }
}
