using Entities.Padro;
using System;
using System.Collections.Generic;
using WebFramework.Api;

namespace Models.Shipping
{
    /// <summary>
    /// جدول بیجک
    /// </summary>
    public class OrderDTO :BaseDto<OrderDTO, Order>
    {
        public PersonDTO Receiver { get; set; }
        public int Receiver_Id { get; set; }
        public PersonDTO Sender { get; set; }
        public int Sender_Id { get; set; }
        public string Provider_code { get; set; }
        public int Payment_type { get; set; }
        public string Receiver_comment { get; set; }
        public IEnumerable<ParcelDTO> Parcels { get; set; }
        public string Order_id { get; set; }


        public DateTime Pickup_date_Dm { get; set; }
        public string Pickup_date_Ds { get; set; }
        public string Comment { get; set; }
        public int Option_id { get; set; }
        public string  Status { get; set; }
    }
}
