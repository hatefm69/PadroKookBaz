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
    public class PersonDTO : BaseDto<PersonDTO,Person>
    {
        public string Name { get; set; }
        public IEnumerable<ContactDTO> Contacts { get; set; }
        public IEnumerable<OrderDTO> Orders { get; set; }

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
