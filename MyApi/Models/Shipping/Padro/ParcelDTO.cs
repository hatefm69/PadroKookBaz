using Entities.Padro;
using System.Collections.Generic;
using WebFramework.Api;

namespace Models.Shipping
{
    /// <summary>
    /// جدول جزئیات و کالاهای بیجک
    /// </summary>
    public class ParcelDTO //:BaseDto<ParcelDTO, Parcel>
    {
        public int id { get; set; }
        public int weight { get; set; }
        public decimal value { get; set; }
        public Dimension dimension { get; set; }
        public string content { get; set; }

        //public OrderDTO Order { get; set; }
        //public int Order_Id { get; set; }
    }
    /// <summary>
    /// خصوصيات كالا
    /// </summary>
    public class Dimension
    {
        public int width { get; set; }
        public int height { get; set; }
        public int depth { get; set; }
    }
}
