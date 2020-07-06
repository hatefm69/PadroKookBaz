using Common;
using Data;
using Data.Repositories;
using Entities.Padro;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Shipping;
using MyApi.Models.KookBaz;
using MyApi.Models.Podro;
using MyApi.Models.Shipping.Padro;
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
    public class DispacherController : BaseController
    {
        private string Token = @"de4txc/vHR5DMYOrKEz7fw==_DYHc1xvlxHnEPJ_3Mb3vkdZX3WxcHDZEdTkag==_JkaB6aBAbdT5Qu9ABRwGKQqaySeIJHvQX5OHbdqSyCM=";
        private readonly IHttpClientFactory _clientFactory;
        private readonly IRepository<Order> _orderRepository;
        private readonly SiteSettings siteSettings;
        private readonly string padroToken = @"eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjU4MjkyNzdlYjFhZTkwMjZiYjNiY2QyNGU0NzFmMGQxNmY2ODdkOGVkNDU4ZTRlYjQzOWQ1N2Y3NzZkOGU4MTk5NjliZGQ2Y2I4ODdkMGRjIn0.eyJhdWQiOiIxIiwianRpIjoiNTgyOTI3N2ViMWFlOTAyNmJiM2JjZDI0ZTQ3MWYwZDE2ZjY4N2Q4ZWQ0NThlNGViNDM5ZDU3Zjc3NmQ4ZTgxOTk2OWJkZDZjYjg4N2QwZGMiLCJpYXQiOjE1OTIyOTA0MTUsIm5iZiI6MTU5MjI5MDQxNSwiZXhwIjoxNjIzODI2NDE1LCJzdWIiOiI3OSIsInNjb3BlcyI6W119.PQESvObPGM-iO-aYp2gBe3VUlaVHOfHJj13D0-7y6WilU85v338FtlKaAoitS6s4Ik8FqAYJOFUF73dtgpKbLMXC7UM0C-dZjxlH8avTrOgHqRmlhPnVxlp39hBf2asHexIwJld5piljiXWEL8S0W7EuGVWFlw_xuBrvzeCDY-wtMy4C1lCjhAcdrvCn4S83tCirnvnKe1prFrmRZyu1vPQdfAtBQRvo-R9wwZkdLFihONTqPKTq_vhYMgqAZkXVogfikNUc-AgHn_OGwQtxnjvnDC387fCFWtz4WAWy0zf3jW6xLEYMu-51Lp934X4gscqsBsKMU0cPr052AsNKxTtZ9UMfNm0oUMzH0ePwB9SYuQdURi7T_oVDmRD1oYIJEqauoVFOsL8pHi_rEGVYvUD3z4a5N5PLZ9lgGRUqKw0R87Xnjeqv1kTUdjfdk47EeZQrBFTCiMHiuRdA9hlqa9xZeQTWsctC2oneAAWH4bNsEknT0HNdOFQe8Y71kEgPM_-O_3xKq221C2VXLqPH6AY6gPJ967uY79vFJAzeHO2kgbYiMKrn0w9Y9iwWBaphKfRr92eT5njUDtFv-14LfrBhwTp4fvtZpdlL9VtQN1pu-aL4sRfEAB5vJppzwZg5e0l3wp_pGAfKF2OT5OKGz3fvKHRRaUd0TeXxITRsZc8";

        public DispacherController(IHttpClientFactory clientFactory, IConfiguration configuration, IRepository<Order> orderRepository)
        {
            _clientFactory = clientFactory;
            _orderRepository = orderRepository;
            this.siteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
        }
        [HttpGet("[action]")]
        public virtual async Task<ApiResult<InfoCityVM>> GetCities(CancellationToken cancellationToken)
        {
            return await new Padro(siteSettings.PordoUrl, _clientFactory).Cities(padroToken);
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
            var kookbaz = await new KookBaz(_clientFactory).getOrder(id, Token);
            model.sender.contact = kookbaz.Sender.To();
            model.sender.name = kookbaz.Sender.fullName??"*";

            model.receiver.contact = kookbaz.Receiver.To();
            model.receiver.name = kookbaz.Receiver.fullName??"*";

            var entity = new Order
            {
                Sender = new Person
                {
                    Name = model.sender.name
                },
                //Receiver=new Person
                //{
                //    Name=model.sender.name
                //},
                Parcels = model.parcels.Select(x => new Parcel
                {
                    Content = x.content,
                    Weight = x.weight,
                    Height = x.dimension.height,
                    Width = x.dimension.width,
                    Depth = x.dimension.depth
                }).ToList(),
                Receiver_comment = model.receiver_comment,
                Payment_type = model.payment_type,
                Provider_code = model.provider_code,
            
                Status = "معلق"
            };
            await _orderRepository.AddAsync(entity, cancellationToken);

            model.parcels = entity.Parcels.Select(x => new ParcelDTO
            {
                id = x.Id,
                content = x.Content,
                value = x.Value??0,
                weight = x.Weight??0,
                dimension = new Dimension
                {
                    depth = x.Depth??0,
                    height = x.Height??0,
                    width = x.Width??0
                }
            }).ToList();
            model.receiver.contact.national_code = kookbaz.Receiver.nationalCode ?? "0018862470";
            model.sender.contact.national_code = kookbaz.Sender.nationalCode ?? "0018862470";
            var padroOrders = await new Padro(siteSettings.PordoUrl, _clientFactory).orders(model, padroToken);

            entity.Order_Id = padroOrders.order_id;
           await _orderRepository.UpdateAsync(entity, cancellationToken);


            var options = await new Padro(siteSettings.PordoUrl, _clientFactory).FinalizeOrderOptions(padroOrders.order_id, padroToken);

            options.Data.Order_Id = entity.Order_Id;




            //save order to dataBase

            return options;
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
            var padroDeliveryOption = await new Padro(siteSettings.PordoUrl, _clientFactory).DeliveryOption(model, padroToken);

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
        public async Task<ApiResult<PostFinalizeVM>> FinalizeOrder(string id, finalizeDTO model, CancellationToken cancellationToken)
        {
            //save State
            var order = _orderRepository.Table.FirstOrDefault(z => z.Order_Id == id);
            if(!DateTime.TryParse(model.Pickup_date, out var date))
            {
                return BadRequest("تاریخ ارسالی صحیح نمی باشد.");
            }
            order.Pickup_date_Dm = date;
            order.Option_id = model.Option_id;
            order.Status = "نهایی";
            order.Comment = model.Comment;
            await _orderRepository.UpdateAsync(order, cancellationToken);
            return await new Padro(siteSettings.PordoUrl, _clientFactory).FinalizeOrder(id, model, padroToken);
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

            var result = await new Padro(siteSettings.PordoUrl, _clientFactory).CancelOrder(id, Token);
            if (result)
            {
                //save state
                var order = _orderRepository.Table.FirstOrDefault(z => z.Order_Id == id);
                order.Status = "لغو";
                return Ok();
            }

            return NotFound();
        }
        /// <summary>
        /// نمایش اطلاعات باربری
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
       [HttpGet("[action]")]
        public async Task ViewOrders(int id)
        {
            var order = _orderRepository.Table.Where(z => z.Id == id).ToListAsync();
            //show Orders
        }
    }
}
