using Entities.Padro;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.AutoMapepr;

namespace ViewModels
{
    public class ContactTypeVM : BaseDto<ContactTypeVM, ContactType, ContactTypeEnum>
    {
        public string Value { get; set; }
    }
}
