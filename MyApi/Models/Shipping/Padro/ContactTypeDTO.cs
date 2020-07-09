using Entities.Padro;
using System.Collections.Generic;
using ViewModels.AutoMapepr;
using WebFramework.Api;

namespace Models.Shipping
{
    /// <summary>
    /// جدول نوع اطلاعات تماس
    /// </summary>
    public class ContactTypeDTO :BaseDto<ContactTypeDTO, ContactType, ContactTypeEnum>
    {
        public string Value { get; set; }
        public IEnumerable<ContactDTO> Contacts { get; set; }
    }
}
