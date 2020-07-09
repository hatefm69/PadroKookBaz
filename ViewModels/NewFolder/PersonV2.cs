using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
 
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

}
