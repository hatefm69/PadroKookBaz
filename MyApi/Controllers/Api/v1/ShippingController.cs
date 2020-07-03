using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Models.Shipping;
using MyApi.Models.Podro;
using MyApi.Models.Shipping.Padro;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebFramework.Api;

namespace MyApi.Controllers.Api.v1
{
    public class ShippingController:BaseController
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly SiteSettings siteSettings;

        public ShippingController(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            this.siteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
        }
        [HttpGet("[action]")]
        public virtual async Task<ApiResult<InfoCityVM>> Cities(CancellationToken cancellationToken)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url + $"/cities");

            //var JWToken = HttpContext.Session.GetString("JWToken");
            //if (!string.IsNullOrEmpty(JWToken))
            //{
            //    request.Headers.Add("Authorization", "Bearer " + JWToken.Replace("\"", ""));
            //}

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<InfoCityVM>(await response.Content.ReadAsStringAsync());

            return api;
        }
        [HttpDelete("[action]")]
        public virtual async Task<ApiResult> CancelOrder(string id, CancellationToken cancellationToken)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Delete, url + $"/orders/{id}");

            //var JWToken = HttpContext.Session.GetString("JWToken");
            //if (!string.IsNullOrEmpty(JWToken))
            //{
            //    request.Headers.Add("Authorization", "Bearer " + JWToken.Replace("\"", ""));
            //}

            var response = await client.SendAsync(request);
       
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return Ok();

            return NotFound();
        }
        [HttpGet("[action]")]
        public virtual async Task<ApiResult<GetFinalizeOptionsVM>> FinalizeOrderOptions(string id, CancellationToken cancellationToken)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url + $"/orders/{id}/finalize");

            //var JWToken = HttpContext.Session.GetString("JWToken");
            //if (!string.IsNullOrEmpty(JWToken))
            //{
            //    request.Headers.Add("Authorization", "Bearer " + JWToken.Replace("\"", ""));
            //}

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<GetFinalizeOptionsVM>(await response.Content.ReadAsStringAsync());


            return api;
        }

        [HttpPost("[action]")]
        public virtual async Task<ApiResult<GetFinalizeOptionsVM>> FinalizeOrder(string id,finalizeDTO model, CancellationToken cancellationToken)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url + $"/orders/{id}/finalize");

            StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            request.Content = content;

            //var JWToken = HttpContext.Session.GetString("JWToken");
            //if (!string.IsNullOrEmpty(JWToken))
            //{
            //    request.Headers.Add("Authorization", "Bearer " + JWToken.Replace("\"", ""));
            //}

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<GetFinalizeOptionsVM>(await response.Content.ReadAsStringAsync());


            return api;
        }


        [HttpPost("[action]")]
        public virtual async Task<ApiResult<string>> Orders(OrderDTO model, CancellationToken cancellationToken)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url + $"/orders");

            StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            request.Content = content;

            //var JWToken = HttpContext.Session.GetString("JWToken");
            //if (!string.IsNullOrEmpty(JWToken))
            //{
            //    request.Headers.Add("Authorization", "Bearer " + JWToken.Replace("\"", ""));
            //}

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync());


            return api;
        }


        [HttpPost("[action]")]
        public virtual async Task<ApiResult<DeliveryOptionVM>> DeliveryOption(Delivery_optionsDTO model, CancellationToken cancellationToken)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url + $"/delivery-options");

            StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            request.Content = content;

            //var JWToken = HttpContext.Session.GetString("JWToken");
            //if (!string.IsNullOrEmpty(JWToken))
            //{
            //    request.Headers.Add("Authorization", "Bearer " + JWToken.Replace("\"", ""));
            //}

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<DeliveryOptionVM>(await response.Content.ReadAsStringAsync());


            return api;
        }


        [HttpPost("[action]")]
        public virtual async Task<ApiResult<GetOrderVM>> GetOrder(string id, CancellationToken cancellationToken)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url + $"/orders/{id}");

            //StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            //request.Content = content;

            //var JWToken = HttpContext.Session.GetString("JWToken");
            //if (!string.IsNullOrEmpty(JWToken))
            //{
            //    request.Headers.Add("Authorization", "Bearer " + JWToken.Replace("\"", ""));
            //}

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<GetOrderVM>(await response.Content.ReadAsStringAsync());


            return api;
        }




    }
}
