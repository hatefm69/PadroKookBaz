using System;

namespace ViewModels
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
    public class ContactDTO2
    {
        public string postal_code { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public string national_code { get; set; }
    }
}
