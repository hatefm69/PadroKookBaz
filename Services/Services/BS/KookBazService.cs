using Common;
using Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Services.Services.BS
{

    public class KookBazService : IKookBazService, IScopedDependency
    {
        private readonly string _token = @"de4txc/vHR5DMYOrKEz7fw==_DYHc1xvlxHnEPJ_3Mb3vkdZX3WxcHDZEdTkag==_JkaB6aBAbdT5Qu9ABRwGKQqaySeIJHvQX5OHbdqSyCM=";
        private readonly IHttpClientFactory _clientFactory;
        public KookBazService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<KookBazOrderVM> getOrder(int id)
        {
            string url = "http://api.kookbaz98.ir";
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url + $"/paymentmanagement/v2/orders/{id}");

            //var JWToken = HttpContext.Session.GetString("JWToken");
            //if (!string.IsNullOrEmpty(JWToken))
            {
                request.Headers.Add("Authorization", "Bearer " + _token);
            }

            var response = await client.SendAsync(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //    return Unauthorized();

            var api = Newtonsoft.Json.JsonConvert.DeserializeObject<KookBazOrderVM>(await response.Content.ReadAsStringAsync());

            return api;
        }
    }




    //public interface IAnswerService
    //{
    //    void AddAnswer(AddAnswerModel answer);
    //    AnswerModel GetAnswers(long OrderId);
    //}

    //public class AnswerService : IAnswerService
    //{
    //    private readonly IUnitOfWork _uow;
    //    private readonly DbSet<Answer> _answers;
    //    private readonly DbSet<Option> _options;
    //    private readonly DbSet<Question> _questions;

    //    public AnswerService(IUnitOfWork uow)
    //    {
    //        _uow = uow ?? throw new ArgumentNullException(nameof(_uow));

    //        _answers = _uow.Set<Answer>();
    //        _options = _uow.Set<Option>();
    //        _questions = _uow.Set<Question>();
    //    }

    //    public void AddAnswer(AddAnswerModel model)
    //    {
    //        Answer answer = new Answer()
    //        {
    //            OptionId = model.OptionId,
    //            OrderId = model.OrderId
    //        };
    //        _answers.Add(answer);
    //        _uow.SaveChanges();
    //    }
    //    public AnswerModel GetAnswers(long OrderId)
    //    {

    //        var query = (from a in _answers.Where(x => x.OrderId == OrderId)
    //                     join o in _options
    //                         on a.OptionId equals o.OptionId
    //                     join q in _questions
    //                         on o.QuestionId equals q.QuestionId
    //                     select new QuestionsAnswerModel
    //                     {
    //                         QuestionId = q.QuestionId,
    //                         Questions = q.Questions,
    //                         Answer = o.Options
    //                     }).ToList();


    //        AnswerModel answer = new AnswerModel()
    //        {
    //            OrderId = OrderId,
    //            questionsAnswers = query
    //        };

    //        return answer;
    //    }
    //}
}
