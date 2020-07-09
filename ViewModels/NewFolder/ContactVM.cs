using Entities.Padro;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.AutoMapepr;

namespace ViewModels
{
    public class ContactVM : BaseDto<ContactVM, Contact>
    {
        public string Value { get; set; }
        public ContactTypeVM ContactType { get; set; }
        //public ContactTypeEnum ContactType_Id { get; set; }
    }
}
