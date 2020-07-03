using Entities;
using System.Collections.Generic;
using WebFramework.Api;

namespace Models.Shipping
{
    /// <summary>
    /// جدول اطلاعات سفارش دریافتی از سیستم کوکباز
    /// </summary>
    public class OrderDetailDTO : BaseDto<OrderDetailDTO, OrderDetail>
    {
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string PostalCode { get; set; }
        public decimal ShipingAmount { get; set; }
        public decimal MinShipingAmountForFree { get; set; }
        public bool IsNeedAddress { get; set; }
        public IEnumerable<ShopingBagItemDTO> Items { get; set; }
    }
}
