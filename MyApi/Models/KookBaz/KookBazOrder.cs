using Entities.Padro;
using Models.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Models.KookBaz
{
    public class KookBazOrderVM
    {
        public PersonDTO2 Sender { get; set; }
        public PersonDTO2 Receiver { get; set; }
    }
    public class PersonDTO2
    {
        public string address { get; set; }
        public string mobile { get; set; }
        public string postalCode { get; set; }
        public string nationalCode { get; set; }
    }
}
