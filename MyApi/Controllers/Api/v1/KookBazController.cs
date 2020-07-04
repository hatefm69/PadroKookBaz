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
    [ApiVersion("1")]
    public class KookBazController:BaseController
    {

        private string Token = @"de4txc/vHR5DMYOrKEz7fw==_DYHc1xvlxHnEPJ_3Mb3vkdZX3WxcHDZEdTkag==_JkaB6aBAbdT5Qu9ABRwGKQqaySeIJHvQX5OHbdqSyCM=";
        private readonly IHttpClientFactory _clientFactory;

        public KookBazController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet("[action]")]
        public virtual async Task<ApiResult<KookBazOrderVM>> Order(int id,CancellationToken cancellationToken)
        {

            string url = "http://api.kookbaz98.ir";
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url + $"/paymentmanagement/v2/orders/{id}");

            //var JWToken = HttpContext.Session.GetString("JWToken");
            //if (!string.IsNullOrEmpty(JWToken))
            {
                request.Headers.Add("Authorization", "Bearer " + Token);
            }

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<KookBazOrderVM>(await response.Content.ReadAsStringAsync());

            return api;
        }
    }
}
