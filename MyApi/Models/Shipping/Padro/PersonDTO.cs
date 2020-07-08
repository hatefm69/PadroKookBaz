using Entities.Padro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebFramework.Api;

namespace Models.Shipping
{
    public class OrderEntityDTO : BaseDto<OrderEntityDTO, Order>
    {
        public PersonEntityDTO Receiver { get; set; }
        public int Receiver_Id { get; set; }
        public PersonEntityDTO Sender { get; set; }
        public int Sender_Id { get; set; }
        public string Provider_code { get; set; }
        public int Payment_type { get; set; }
        public string Receiver_comment { get; set; }
        public IEnumerable<ParcelEntityDTO> Parcels { get; set; }
        public string Order_id { get; set; }


        public DateTime Pickup_date_Dm { get; set; }
        public string Pickup_date_Ds { get; set; }
        public string Comment { get; set; }
        public int Option_id { get; set; }
        public string Status { get; set; }
    }
    public class ParcelEntityDTO:BaseDto<ParcelEntityDTO, Parcel>
    {
        //public int id { get; set; }
        public int Weight { get; set; }
        public decimal Value { get; set; }
        public string Content { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
    }

    public class ContactEntityDTO :BaseDto<ContactEntityDTO, Contact>
    {
        public string Value { get; set; }
        public ContactTypeDTO ContactType { get; set; }
        public ContactTypeEnum ContactType_Id { get; set; }
        public PersonEntityDTO Person { get; set; }
        public int Persion_Id { get; set; }
    }
    public class PersonEntityDTO :BaseDto<PersonEntityDTO, Person>
    {
        public string Name { get; set; }
        public IEnumerable<ContactEntityDTO> Contacts { get; set; }
        public IEnumerable<OrderEntityDTO> Orders { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string Image { get; set; }
        public string BirthDate_Ds { get; set; }
        public string BirthDate_Dm { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }
        public string NationalCode { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }

    }






 }
