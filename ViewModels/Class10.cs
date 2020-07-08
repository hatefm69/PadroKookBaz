using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class ordervm2 //: WebFramework.Api.BaseDto<ordervm2, Order>
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
    public class PersonV2 //: BaseDto<PersonV2, Person>
    {
        public string Name { get; set; }
        public IEnumerable<ContactVM> Contacts { get; set; }
        //public IEnumerable<Order> Orders { get; set; }

        //[Required]
        //[StringLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
       // public GenderType Gender { get; set; }
        public string Image { get; set; }
        public string BirthDate_Ds { get; set; }
        public DateTime? BirthDate_Dm { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }
        public string NationalCode { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
    }
    public class ContactVM //: BaseDto<ContactVM, Contact>
    {
        public string Value { get; set; }
        public ContactTypeVM ContactType { get; set; }
        //public ContactTypeEnum ContactType_Id { get; set; }
    }
    public class ContactTypeVM //: BaseDto<ContactTypeVM, ContactType, ContactTypeEnum>
    {
        public string Value { get; set; }
    }
    public class Parcelv2 //: BaseDto<Parcelv2, Parcel>
    {
        //public int id { get; set; }
        public int? Weight { get; set; }
        public decimal? Value { get; set; }
        public string Content { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? Depth { get; set; }
    }

    public class parcel_totalVM
    {
        public decimal total_value { get; set; }
        public decimal total_weight { get; set; }
    }

}
