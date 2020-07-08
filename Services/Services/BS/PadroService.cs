using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Services.Services.BS
{
    public class PadroService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly string _pordoUrl;

        public PadroService(string pordoUrl, IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _pordoUrl = pordoUrl;
        }
        public async Task<OrderResultVM> orders(OrderDTO model, string Token)
        {
            string url = _pordoUrl;
            model.receiver.contact.city = "2301";
            model.sender.contact.city = "2301";

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

        public async Task<DeliveryOptionVM> DeliveryOption(Delivery_optionsDTO model, string Token)
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

        public async Task<GetFinalizeOptionsVM> FinalizeOrderOptions(string id, string Token)
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

        public async Task<PostFinalizeVM> FinalizeOrder(string id, finalizeDTO model, string Token)
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
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return null;
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

        public virtual async Task<InfoCityVM> Cities(string Token)
        {

            string url = _pordoUrl;
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
    }
}
