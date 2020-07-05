using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
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

    public class Padro
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly string _pordoUrl;

        public Padro(string pordoUrl, IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _pordoUrl = pordoUrl;
        }
        public async Task<OrderResultVM> orders(OrderDTO model, string Token)
        {
            string url = _pordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url + $"/orders");

            StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            request.Content = content;

            request.Headers.Add("Authorization", "Bearer " + Token);
            //request.Headers.Add("Accept", "application/json");
            // request.Headers.Add("Content-Type", "application/json");

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<OrderResultVM>(await response.Content.ReadAsStringAsync());


            return api;
        }

        public async Task<ApiResult<DeliveryOptionVM>> DeliveryOption(Delivery_optionsDTO model, string Token)
        {

            string url = _pordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url + $"/delivery-options");

            StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            request.Content = content;

            request.Headers.Add("Authorization", "Bearer " + Token);

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<DeliveryOptionVM>(await response.Content.ReadAsStringAsync());


            return api;
        }

        public async Task<ApiResult<GetFinalizeOptionsVM>> FinalizeOrderOptions(string id, string Token)
        {

            string url = _pordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url + $"/orders/{id}/finalize");

            request.Headers.Add("Authorization", "Bearer " + Token);

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<GetFinalizeOptionsVM>(await response.Content.ReadAsStringAsync());


            return api;
        }

        public async Task<ApiResult<PostFinalizeVM>> FinalizeOrder(string id, finalizeDTO model, string Token)
        {

            string url = _pordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url + $"/orders/{id}/finalize");

            StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            request.Content = content;

            request.Headers.Add("Authorization", "Bearer " + Token);


            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<PostFinalizeVM>(await response.Content.ReadAsStringAsync());
            return api;
        }

        public async Task<bool> CancelOrder(string id, string Token)
        {

            string url = _pordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Delete, url + $"/orders/{id}");

            request.Headers.Add("Authorization", "Bearer " + Token);

            var response = await client.SendAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;

            return false;
        }

    }

    /// <summary>
    /// اتصال به سیستم پادرو
    /// </summary>
    [ApiVersion("1")]
    public class PadroController : BaseController
    {
        public string Token { get; set; } = @"eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjU4MjkyNzdlYjFhZTkwMjZiYjNiY2QyNGU0NzFmMGQxNmY2ODdkOGVkNDU4ZTRlYjQzOWQ1N2Y3NzZkOGU4MTk5NjliZGQ2Y2I4ODdkMGRjIn0.eyJhdWQiOiIxIiwianRpIjoiNTgyOTI3N2ViMWFlOTAyNmJiM2JjZDI0ZTQ3MWYwZDE2ZjY4N2Q4ZWQ0NThlNGViNDM5ZDU3Zjc3NmQ4ZTgxOTk2OWJkZDZjYjg4N2QwZGMiLCJpYXQiOjE1OTIyOTA0MTUsIm5iZiI6MTU5MjI5MDQxNSwiZXhwIjoxNjIzODI2NDE1LCJzdWIiOiI3OSIsInNjb3BlcyI6W119.PQESvObPGM-iO-aYp2gBe3VUlaVHOfHJj13D0-7y6WilU85v338FtlKaAoitS6s4Ik8FqAYJOFUF73dtgpKbLMXC7UM0C-dZjxlH8avTrOgHqRmlhPnVxlp39hBf2asHexIwJld5piljiXWEL8S0W7EuGVWFlw_xuBrvzeCDY-wtMy4C1lCjhAcdrvCn4S83tCirnvnKe1prFrmRZyu1vPQdfAtBQRvo-R9wwZkdLFihONTqPKTq_vhYMgqAZkXVogfikNUc-AgHn_OGwQtxnjvnDC387fCFWtz4WAWy0zf3jW6xLEYMu-51Lp934X4gscqsBsKMU0cPr052AsNKxTtZ9UMfNm0oUMzH0ePwB9SYuQdURi7T_oVDmRD1oYIJEqauoVFOsL8pHi_rEGVYvUD3z4a5N5PLZ9lgGRUqKw0R87Xnjeqv1kTUdjfdk47EeZQrBFTCiMHiuRdA9hlqa9xZeQTWsctC2oneAAWH4bNsEknT0HNdOFQe8Y71kEgPM_-O_3xKq221C2VXLqPH6AY6gPJ967uY79vFJAzeHO2kgbYiMKrn0w9Y9iwWBaphKfRr92eT5njUDtFv-14LfrBhwTp4fvtZpdlL9VtQN1pu-aL4sRfEAB5vJppzwZg5e0l3wp_pGAfKF2OT5OKGz3fvKHRRaUd0TeXxITRsZc8";

        private readonly IHttpClientFactory _clientFactory;
        private readonly SiteSettings siteSettings;

        public PadroController(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            this.siteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
        }
        /// <summary>
        /// دریافت شهر های کشور
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public virtual async Task<ApiResult<InfoCityVM>> Cities(CancellationToken cancellationToken)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url + $"/cities");

            //var JWToken = HttpContext.Session.GetString("JWToken");
            //if (!string.IsNullOrEmpty(JWToken))
            {
                request.Headers.Add("Authorization", "Bearer " + Token);
            }

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<InfoCityVM>(await response.Content.ReadAsStringAsync());

            return api;
        }
        /// <summary>
        /// باطل کردن سفارش
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpDelete("[action]")]
        public virtual async Task<ApiResult> CancelOrder(string id, CancellationToken cancellationToken)
        {

            var result = await new Padro(siteSettings.PordoUrl, _clientFactory).CancelOrder(id, Token);
            if (result)
                return Ok();

            return NotFound();
        }
        /// <summary>
        /// گزینه های انتخاب باربری انتخابی برای فاینال کردن سفارش
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public virtual async Task<ApiResult<GetFinalizeOptionsVM>> FinalizeOrderOptions(string id, CancellationToken cancellationToken)
        {
            return await new Padro(siteSettings.PordoUrl, _clientFactory).FinalizeOrderOptions(id, Token);
        }
        /// <summary>
        /// فاینالی کردن سفارش
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public virtual async Task<ApiResult<PostFinalizeVM>> FinalizeOrder(string id, finalizeDTO model, CancellationToken cancellationToken)
        {

            return await new Padro(siteSettings.PordoUrl, _clientFactory).FinalizeOrder(id, model, Token);
        }
        /// <summary>
        /// ثبت سفارش
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public virtual async Task<ApiResult<OrderResultVM>> Orders(OrderDTO model, CancellationToken cancellationToken)
        {
            return await new Padro(siteSettings.PordoUrl, _clientFactory).orders(model, Token);
        }
        /// <summary>
        /// شرکتهای سفارش گیرنده با قیمت
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public virtual async Task<ApiResult<DeliveryOptionVM>> DeliveryOption(Delivery_optionsDTO model, CancellationToken cancellationToken)
        {

            return await new Padro(siteSettings.PordoUrl, _clientFactory).DeliveryOption(model, Token);
        }
        /// <summary>
        /// نمایش وضعیت سفارش
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public virtual async Task<ApiResult<GetOrderVM>> GetOrder(string id, CancellationToken cancellationToken)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url + $"/orders/{id}");

            //StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            //request.Content = content;

            request.Headers.Add("Authorization", "Bearer " + Token);

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<GetOrderVM>(await response.Content.ReadAsStringAsync());


            return api;
        }
    }
}
