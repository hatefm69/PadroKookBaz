using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Models.Podro
{

    public class DeliveryOptionVM
    {
        public IEnumerable<Quote> Quotes { get; set; }
    }

    public class Quote
    {
        public string Provider_name { get; set; }
        public string provider_code { get; set; }
        public string provider_logo { get; set; }
        public decimal price { get; set; }
        public decimal sale_price { get; set; }
        public decimal discount_value { get; set; }
        public int from_hours { get; set; }
        public int to_hours { get; set; }
        public string service_type { get; set; }
        public string service_type_label { get; set; }
    }


}
