using Common;
using Common.Utilities;
using Data.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using ViewModels.KookBazModel;

namespace Services.Services.BS
{

    public class KookBazService : IKookBazService, IScopedDependency
    {
        private readonly string _token;//= @"de4txc/vHR5DMYOrKEz7fw==_DYHc1xvlxHnEPJ_3Mb3vkdZX3WxcHDZEdTkag==_JkaB6aBAbdT5Qu9ABRwGKQqaySeIJHvQX5OHbdqSyCM=";
        //private readonly string _token2 = @"de4txc/vHR5DMYOrKEz7fw==_DYHc1xvlxHnEPJ_3Mb3vkdZX3WxcHDZEdTkag==_JkaB6aBAbdT5Qu9ABRwGKQqaySeIJHvQX5OHbdqSyCM=";
        private readonly string _x_clientId = @"cloudware:app:3SSbr35BHPXXKExNL4zRHwHF7Sdo8I4xMTrEgVci";
        private readonly SiteSettings siteSettings;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IHostingEnvironment _env;

        public KookBazService(IHttpClientFactory clientFactory, IHostingEnvironment env, IConfiguration configuration)
        {
            this.siteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
            _clientFactory = clientFactory;
            _env = env;
            _token = openToken()?.sessionId;
        }

        public async Task Login(LoginModel model)
        {
            string url = siteSettings.KookBazUrl;

            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url + $"/usermanagement/v2/account/login");

            //var formVariables = new List<KeyValuePair<string, string>>();

            //formVariables.Add(new KeyValuePair<string, string>("cell", model.cell));
            //formVariables.Add(new KeyValuePair<string, string>("password", model.password));

            //FormUrlEncodedContent content = new FormUrlEncodedContent(formVariables);
            StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            request.Headers.Add("x-clientId", _x_clientId);
            request.Content = content;

            var response = await client.SendAsync(request);

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<KookBazModelToken>(await response.Content.ReadAsStringAsync());

            saveToken(api);

            return;
        }

        private void saveToken(KookBazModelToken model)
        {
            model.sessionId = model.sessionId.Replace("Bearer ", "");
            System.IO.File.WriteAllText(_env.ContentRootPath + "/PadroConfig/kookBazToken.txt", model.ToJson());
        }
        private KookBazModelToken openToken()
        {
            if (System.IO.File.Exists(_env.ContentRootPath + "/PadroConfig/kookBazToken.txt"))
            {
                var json = System.IO.File.ReadAllText(_env.ContentRootPath + "/PadroConfig/kookBazToken.txt");
                return json.FromJson<KookBazModelToken>();
            }
            return null;

        }
        public async Task<KookBazOrderVM> getOrder(int id)
        {
            string url = siteSettings.KookBazUrl;
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url + $"/paymentmanagement/v2/orders/{id}");
            {
                request.Headers.Add("Authorization", "Bearer " + _token);
            }

            var response = await client.SendAsync(request);

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<KookBazOrderVM>(await response.Content.ReadAsStringAsync());

            return api;
        }
    }
}
