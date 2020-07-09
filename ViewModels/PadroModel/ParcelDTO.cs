using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    /// <summary>
    /// جدول جزئیات و کالاهای بیجک
    /// </summary>
    public class ParcelDTO //:BaseDto<ParcelDTO, Parcel>
    {
        public int id { get; set; }
        public int weight { get; set; }
        public decimal value { get; set; }
        public DimensionDTO dimension { get; set; }
        public string content { get; set; }

        //public OrderDTO Order { get; set; }
        //public int Order_Id { get; set; }
    }
}
