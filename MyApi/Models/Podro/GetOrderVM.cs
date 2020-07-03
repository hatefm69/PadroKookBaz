using Entities;
using LanguageExt.UnitsOfMeasure;
using Models.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Models.Podro
{
    public class GetOrderVM
    {
        public string  id{ get; set; }
        public decimal price { get; set; }
        public decimal discount { get; set; }
        public decimal sale_price { get; set; }
        public DateTime pickup_time { get; set; }
        public string pickup_to_time { get; set; }
        public int payment_type { get; set; }
        public string status { get; set; }
        public string provider_code { get; set; }
        //public OrderDTO order_detail { get; set; }
    }
}
