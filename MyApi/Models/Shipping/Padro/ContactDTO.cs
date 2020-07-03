using Entities.Padro;
using WebFramework.Api;

namespace Models.Shipping
{
    /// <summary>
    /// جدول اطلاعات تماس
    /// </summary>
    public class ContactDTO : BaseDto<ContactDTO, Contact>
    {
        public string Value { get; set; }
        public ContactTypeDTO ContactType { get; set; }
        public ContactTypeEnum ContactType_Id { get; set; }
        public PersonDTO Person { get; set; }
        public int Persion_Id { get; set; }
    }
}
