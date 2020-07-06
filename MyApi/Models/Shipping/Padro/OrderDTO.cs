using Entities.Padro;
using System;
using System.Collections.Generic;
using WebFramework.Api;

namespace Models.Shipping
{
    public class OrderResultVM
    {
        public string order_id { get; set; }
    }
    /// <summary>
    /// جدول بیجک
    /// </summary>
    public class OrderDTO 
    {
        public PersonDTO sender { get; set; } = new PersonDTO();
        public PersonDTO receiver { get; set; } = new PersonDTO();



        public string provider_code { get; set; }
        public int payment_type { get; set; }
        public string receiver_comment { get; set; }
        public IEnumerable<ParcelDTO> parcels { get; set; }
        //public string Order_id { get; set; }


        //public DateTime Pickup_date_Dm { get; set; }
        //public string Pickup_date_Ds { get; set; }
        //public string Comment { get; set; }
        //public int Option_id { get; set; }
        //public string  Status { get; set; }
    }
}
