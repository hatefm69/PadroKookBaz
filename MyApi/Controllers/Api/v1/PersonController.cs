using Data.Repositories;
using Entities.Padro;
using Microsoft.AspNetCore.Mvc;
using Models.Shipping;
using WebFramework.Api;

namespace MyApi.Controllers.Api.v1
{
    /// <summary>
    /// اطلاعات فروشندگان و خریداران
    /// </summary>
    [ApiVersion("1")]
    public class PersonController : CrudController<PersonDTO, Person>
    {
        public PersonController(IRepository<Person> repository):base(repository)
        {

        }
    }
}
