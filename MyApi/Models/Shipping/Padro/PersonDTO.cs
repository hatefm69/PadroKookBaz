using Entities.Padro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebFramework.Api;

namespace Models.Shipping
{
    /// <summary>
    /// جدول مشتریان
    /// </summary>
    public class PersonDTO //: BaseDto<PersonDTO,Person>
    {
        public string name { get; set; }
        public ContactDTO2 contact { get; set; }
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
