using Data.Repositories;
using Entities.Padro;
using Microsoft.AspNetCore.Mvc;
using Models.Shipping;
using WebFramework.Api;

namespace MyApi.Controllers.Api.v1
{
    /// <summary>
    /// بیجک
    /// </summary>
    [ApiVersion("1")]
    public class OrderController : CrudController<OrderEntityDTO , Order>
    {
        public OrderController(IRepository<Order> repository) : base(repository)
        {

        }
    }
}
