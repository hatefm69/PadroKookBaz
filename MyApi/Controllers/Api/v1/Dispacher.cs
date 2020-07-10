using Microsoft.AspNetCore.Mvc;
using Services.Services.BS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ViewModels;
using ViewModels.PadroModel;
using WebFramework.Api;

namespace MyApi.Controllers.Api.v1
{
    [ApiVersion("1")]
    public class DispacherController : BaseController
    {
        private readonly IPadroService _padroService;
        private readonly IKookBazService _kookBazService;
        private readonly IDispacherService _dispacherService;

        public DispacherController(IPadroService padroService,IKookBazService kookBazService,IDispacherService dispacherService)
        {
            _padroService = padroService;
            _kookBazService = kookBazService;
            _dispacherService = dispacherService;
        }
        [HttpGet("[action]")]
        public virtual async Task<ApiResult<InfoCityVM>> GetCities(CancellationToken cancellationToken)
        {
            return await _padroService.Cities();
        }
        [HttpPost("[action]")]
        public virtual async Task LoginPadro(LoginModel model,CancellationToken cancellationToken)
        {
            await _padroService.Login(model);
        }
        [HttpPost("[action]")]
        public virtual async Task LoginKookBaz(ViewModels.KookBazModel.LoginModel model, CancellationToken cancellationToken)
        {
            await _kookBazService.Login(model);
        }
        /// <summary>
        /// ذخیره سفارش و نمایش زمان های تحویل
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public virtual async Task<ApiResult<GetFinalizeOptionsVM>> SaveOrder(int id, OrderDTO model, CancellationToken cancellationToken)
        {
            return await _dispacherService.SaveOrder(id, model, cancellationToken);
        }
        /// <summary>
        /// نمایش کرایه بار شرکت ها
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public virtual async Task<ApiResult<DeliveryOptionVM>> GetCost(Delivery_optionsDTO model, CancellationToken cancellationToken)
        {
            var padroDeliveryOption = await _padroService.DeliveryOption(model);

            return padroDeliveryOption;
        }

        /// <summary>
        /// فاینالی کردن سفارش
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ApiResult<PostFinalizeVM>> FinalizeOrder(string id, FinalizeDTO model, CancellationToken cancellationToken)
        {

            var t= await _dispacherService.FinalizeOrder(id, model, cancellationToken);
            if (t.IsSuccess)
                return Ok(t.Data);
            else
                return BadRequest();

        }
        /// <summary>
        /// لغو عملیات باربری
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpDelete("[action]")]
        public virtual async Task<ApiResult> CancelOrder(string id, CancellationToken cancellationToken)
        {

            var t= await _dispacherService.CancelOrder(id,cancellationToken);
            if (t.IsSuccess)
                return Ok();
            else
                return NotFound();
        }
        /// <summary>
        /// نمایش اطلاعات باربری
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
       [HttpGet("[action]")]
        public async Task<ApiResult<IEnumerable<Ordervm2>>> ViewOrders(int id)
        {

            var orders = await _dispacherService.ViewOrders(id);
            return orders.Data.ToList();
            //show Orders
        }
    }
}
