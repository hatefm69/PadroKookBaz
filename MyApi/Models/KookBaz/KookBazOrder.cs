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
        public string fullName { get; set; }
    }

    public static class extention
    {
        public static ContactDTO2 To(this PersonDTO2 model)
        {
            return new ContactDTO2
            {
                address = model.address,
                national_code = model.nationalCode,
                phone_number = model.mobile,
                postal_code = model.postalCode
            };
        }
    }
}
