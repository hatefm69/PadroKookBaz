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
using ViewModels;
using WebFramework.Api;

namespace MyApi.Controllers.Api.v1
{
    [ApiVersion("1")]
    public class DispacherController : BaseController
    {
        public DispacherController()
        {
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

            var sender = new Person
            {
                NationalCode = model.sender.contact.national_code ?? string.Empty,
                Name = model.sender.name
            };
           var list= new List<Contact>();
            list.AddRange(new[] { new Contact { ContactType_Id = ContactTypeEnum.Address, Value = model.sender.contact.address ?? string.Empty } 
            ,
            new Contact { ContactType_Id = ContactTypeEnum.city, Value = model.sender.contact.city ?? string.Empty }
            ,
            new Contact { ContactType_Id = ContactTypeEnum.Mobile, Value = model.sender.contact.phone_number ?? string.Empty }
            ,
            new Contact { ContactType_Id = ContactTypeEnum.Postal_code, Value = model.sender.contact.postal_code ?? string.Empty }
            });
            sender.Contacts = list;

            var receiver=new Person
            {
                NationalCode=model.receiver.contact.national_code ?? string.Empty,
                Name = model.receiver.name
            };
            var list2 = new List<Contact>();
            list2.AddRange(new[]
            {
                new Contact { ContactType_Id = ContactTypeEnum.Address, Value = model.receiver.contact.address ?? string.Empty }
                ,
                new Contact { ContactType_Id = ContactTypeEnum.city, Value = model.receiver.contact.city ?? string.Empty }
                ,
                new Contact { ContactType_Id = ContactTypeEnum.Mobile, Value = model.receiver.contact.phone_number ?? string.Empty }
            ,
                new Contact { ContactType_Id = ContactTypeEnum.Postal_code, Value = model.receiver.contact.postal_code ?? string.Empty }
            });

            receiver.Contacts = list2;


            var entity = new Order
            {
                Sender = sender,
                Receiver = receiver,
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
                KookBaz_Id=id,
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
        public async Task<ApiResult<IEnumerable<ordervm2>>> ViewOrders(int id)
        {
            var orders =await _orderRepository.Table.Where(z => z.KookBaz_Id == id).Include(z=>z.Sender).ThenInclude(z=>z.Contacts).ThenInclude(z=>z.ContactType).Include(z=>z.Receiver).ThenInclude(z=>z.Contacts).Include(z=>z.Parcels).Select(z=> ordervm2.FromEntity(z)).ToListAsync();
            return orders;
            //show Orders
        }
    }
}
