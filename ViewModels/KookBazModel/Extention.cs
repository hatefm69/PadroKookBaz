using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public static class Extention
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
