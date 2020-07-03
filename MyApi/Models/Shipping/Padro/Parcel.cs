using Entities.Padro;
using WebFramework.Api;

namespace Models.Shipping
{
    /// <summary>
    /// جدول جزئیات و کالاهای بیجک
    /// </summary>
    public class ParcelDTO :BaseDto<ParcelDTO, Parcel>
    {
        public int id { get; set; }
        public int Weight { get; set; }
        public decimal Value { get; set; }
        public string Content { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
        public OrderDTO Order { get; set; }
        public int Order_Id { get; set; }
    }
}
