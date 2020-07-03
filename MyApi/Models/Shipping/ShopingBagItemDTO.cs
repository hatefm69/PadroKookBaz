using Entities;
using WebFramework.Api;

namespace Models.Shipping
{
    /// <summary>
    /// جدول اطلاعات سفارش کوک باز
    /// </summary>
    public class ShopingBagItemDTO :BaseDto<ShopingBagItemDTO, ShopingBagItem>
    {
        public OrderDetailDTO OrderDetail { get; set; }
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
}
