using Microsoft.AspNetCore.Mvc;
using MyApi.Models.KookBaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WebFramework.Api;

namespace MyApi.Controllers.Api.v1
{

  


    //    /// <summary>
    //    /// دریافت اطلاعات از سیستم کوک باز
    //    /// </summary>
    //    [ApiVersion("1")]
    //    public class KookBazController:BaseController
    //    {
    //        private string Token = @"de4txc/vHR5DMYOrKEz7fw==_DYHc1xvlxHnEPJ_3Mb3vkdZX3WxcHDZEdTkag==_JkaB6aBAbdT5Qu9ABRwGKQqaySeIJHvQX5OHbdqSyCM=";
    //        private readonly IHttpClientFactory _clientFactory;
    //        public KookBazController(IHttpClientFactory clientFactory)
    //        {
    //            _clientFactory = clientFactory;
    //        }
    //        /// <summary>
    //        /// دریافت سفارش از سیستم کوک باز
    //        /// </summary>
    //        /// <param name="id">2608</param>
    //        /// <param name="cancellationToken"></param>
    //        /// <returns></returns>
    //        [HttpGet("[action]")]
    //        public virtual async Task<ApiResult<KookBazOrderVM>> Order(int id,CancellationToken cancellationToken)
    //        {
    //            return await new KookBaz(_clientFactory).getOrder(id,Token);
    //        }
    //    }
}
