using Entities.Padro;
using System.Collections.Generic;
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
        public IEnumerable<Dimension> Dimension { get; set; }
        //public string Content { get; set; }

        //public OrderDTO Order { get; set; }
        //public int Order_Id { get; set; }
    }
    public class Dimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
    }
}
