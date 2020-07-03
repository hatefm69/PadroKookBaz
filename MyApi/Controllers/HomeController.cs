//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Common.HttpClient;
//using Data;
//using Entities.SqlServer;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using RabbitMQ.Client.Impl;
//using WebFramework.Api;
//using WebFramework.Session;

//namespace MyApi.Controllers
//{
//    public class HomeController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//        [HttpPost]
//        public async Task<IActionResult> Index(string username, string password)
//        {
//            HttpClient client = new HttpClient();
//            string url = "https://token.dinavision.org/api/v1/Users/Token";

//            var formVariables = new List<KeyValuePair<string, string>>();
//            formVariables.Add(new KeyValuePair<string, string>("grant_type", "password"));
//            formVariables.Add(new KeyValuePair<string, string>("username", username));
//            formVariables.Add(new KeyValuePair<string, string>("password", password));

//            FormUrlEncodedContent content = new FormUrlEncodedContent(formVariables);
//            var result = await client.PostAsync(url, content);
//            AccessToken api = Newtonsoft.Json.JsonConvert.DeserializeObject<AccessToken>(await result.Content.ReadAsStringAsync());


//            HttpContext.Session.Set("JWToken", api.access_token);

//            if (api.access_token!=null)
//            {
//                return Redirect("ServerApp/Calls");
//                //return RedirectToAction("ServerApp", "Calls");
//            }

//            return View();
//        }
//    }
//}
