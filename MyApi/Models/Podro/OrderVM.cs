using Models.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Models.Podro
{
    public class OrderVM 
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
        public string Status { get; set; }

        public string tracking_id { get; set; }
        //public int reference_id { get; set; }
        public string service_type { get; set; }
        public string provider_code { get; set; }
        public parcel_totalVM parcel_total { get; set; }
    }
    public class parcel_totalVM
    {
        public decimal total_value { get; set; }
        public decimal total_weight { get; set; }
    }

}
