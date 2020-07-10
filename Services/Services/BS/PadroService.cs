using Common;
using Common.Utilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using ViewModels.PadroModel;

namespace Services.Services.BS
{
    public class PadroService : IPadroService, IScopedDependency
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IHostingEnvironment _env;
        private readonly SiteSettings siteSettings;
        private readonly string Token;

        public PadroService(IConfiguration configuration, IHttpClientFactory clientFactory, IHostingEnvironment env)
        {
            this.siteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
            _clientFactory = clientFactory;


            _env = env;
            Token = openToken()?.access_token;
        }

        public async Task Login(LoginModel model)
        {
          

            string url = siteSettings.PordoUrl;
          
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url + $"/login");

            var formVariables = new List<KeyValuePair<string, string>>();
       
            formVariables.Add(new KeyValuePair<string, string>("email", model.email));
            formVariables.Add(new KeyValuePair<string, string>("password", model.password));

            FormUrlEncodedContent content = new FormUrlEncodedContent(formVariables);
            request.Content = content;

            //var content = new MultipartFormDataContent();

            //StringContent stringContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            //content.Add(stringContent);

            //request.Content = content;

            //request.Headers.Add("Authorization", "Bearer " + Token);
            //request.Headers.Add("Accept", "application/json");
            // request.Headers.Add("Content-Type", "application/json");

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<PadroToken>(await response.Content.ReadAsStringAsync());

            saveToken(api);



            return;

            

        }
        private void saveToken(PadroToken model)
        {
            System.IO.File.WriteAllText(_env.ContentRootPath + "/PadroConfig/padroToken.txt", model.ToJson());
        }
        private PadroToken openToken()
        {
            if (System.IO.File.Exists(_env.ContentRootPath + "/PadroConfig/padroToken.txt"))
            {
                var json = System.IO.File.ReadAllText(_env.ContentRootPath + "/PadroConfig/padroToken.txt");
                return json.FromJson<PadroToken>();
            }
            return null;

        }
        public async Task<OrderResultVM> orders(OrderDTO model)
        {
            string url = siteSettings.PordoUrl;
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

        public async Task<DeliveryOptionVM> DeliveryOption(Delivery_optionsDTO model)
        {

            string url = siteSettings.PordoUrl;
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

        public async Task<GetFinalizeOptionsVM> FinalizeOrderOptions(string id)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url + $"/orders/{id}/finalize");

            request.Headers.Add("Authorization", "Bearer " + Token);

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<GetFinalizeOptionsVM>(await response.Content.ReadAsStringAsync());


            return api;
        }

        public async Task<PostFinalizeVM> FinalizeOrder(string id, FinalizeDTO model)
        {

            string url = siteSettings.PordoUrl;
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

        public async Task<bool> CancelOrder(string id)
        {

            string url = siteSettings.PordoUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Delete, url + $"/orders/{id}");

            request.Headers.Add("Authorization", "Bearer " + Token);

            var response = await client.SendAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;

            return false;
        }

        public virtual async Task<InfoCityVM> Cities()
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
    }
}
