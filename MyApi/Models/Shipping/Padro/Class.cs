using Models.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Models.Shipping.Padro
{
    public class Delivery_optionsDTO
    {
        public string Source_city { get; set; }
        public string Destination_city { get; set; }
        public IEnumerable<ParcelDTO> Parcels { get; set; }
    }


}
