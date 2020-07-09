using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class Ordervm2 : WebFramework.Api.BaseDto<ordervm2, Order>
    {
        public PersonV2 Receiver { get; set; }
        public int? Receiver_Id { get; set; }
        public PersonV2 Sender { get; set; }
        public int? Sender_Id { get; set; }
        public string Provider_code { get; set; }
        public int? Payment_type { get; set; }
        public string Receiver_comment { get; set; }
        public IEnumerable<Parcelv2> Parcels { get; set; }


        public DateTime? Pickup_date_Dm { get; set; }
        public string Pickup_date_Ds { get; set; }
        public string Comment { get; set; }
        public int? Option_id { get; set; }
        public string Status { get; set; }
        public string Order_Id { get; set; }
        public int KookBaz_Id { get; set; }
    }
}
