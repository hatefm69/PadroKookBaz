using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    /// <summary>
    /// جدول مشتریان
    /// </summary>
    public class PersonDTO //: BaseDto<PersonDTO,Person>
    {
        public string name { get; set; }
        public ContactDTO2 contact { get; set; }
    }
}
