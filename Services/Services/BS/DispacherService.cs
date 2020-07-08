using Common;
using Data.Contracts;
using Entities.Padro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ViewModels;

namespace Services.Services.BS
{
   public class DispacherService
    {
        private readonly string _token= @"de4txc/vHR5DMYOrKEz7fw==_DYHc1xvlxHnEPJ_3Mb3vkdZX3WxcHDZEdTkag==_JkaB6aBAbdT5Qu9ABRwGKQqaySeIJHvQX5OHbdqSyCM=";
        
        private readonly string _padroToken= @"eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjU4MjkyNzdlYjFhZTkwMjZiYjNiY2QyNGU0NzFmMGQxNmY2ODdkOGVkNDU4ZTRlYjQzOWQ1N2Y3NzZkOGU4MTk5NjliZGQ2Y2I4ODdkMGRjIn0.eyJhdWQiOiIxIiwianRpIjoiNTgyOTI3N2ViMWFlOTAyNmJiM2JjZDI0ZTQ3MWYwZDE2ZjY4N2Q4ZWQ0NThlNGViNDM5ZDU3Zjc3NmQ4ZTgxOTk2OWJkZDZjYjg4N2QwZGMiLCJpYXQiOjE1OTIyOTA0MTUsIm5iZiI6MTU5MjI5MDQxNSwiZXhwIjoxNjIzODI2NDE1LCJzdWIiOiI3OSIsInNjb3BlcyI6W119.PQESvObPGM-iO-aYp2gBe3VUlaVHOfHJj13D0-7y6WilU85v338FtlKaAoitS6s4Ik8FqAYJOFUF73dtgpKbLMXC7UM0C-dZjxlH8avTrOgHqRmlhPnVxlp39hBf2asHexIwJld5piljiXWEL8S0W7EuGVWFlw_xuBrvzeCDY-wtMy4C1lCjhAcdrvCn4S83tCirnvnKe1prFrmRZyu1vPQdfAtBQRvo-R9wwZkdLFihONTqPKTq_vhYMgqAZkXVogfikNUc-AgHn_OGwQtxnjvnDC387fCFWtz4WAWy0zf3jW6xLEYMu-51Lp934X4gscqsBsKMU0cPr052AsNKxTtZ9UMfNm0oUMzH0ePwB9SYuQdURi7T_oVDmRD1oYIJEqauoVFOsL8pHi_rEGVYvUD3z4a5N5PLZ9lgGRUqKw0R87Xnjeqv1kTUdjfdk47EeZQrBFTCiMHiuRdA9hlqa9xZeQTWsctC2oneAAWH4bNsEknT0HNdOFQe8Y71kEgPM_-O_3xKq221C2VXLqPH6AY6gPJ967uY79vFJAzeHO2kgbYiMKrn0w9Y9iwWBaphKfRr92eT5njUDtFv-14LfrBhwTp4fvtZpdlL9VtQN1pu-aL4sRfEAB5vJppzwZg5e0l3wp_pGAfKF2OT5OKGz3fvKHRRaUd0TeXxITRsZc8";



        private readonly IHttpClientFactory _clientFactory;
       
        private readonly SiteSettings siteSettings;

        private readonly IUnitOfWork _uow;
        private readonly DbSet<Order> _orders;

        public DispacherService(IHttpClientFactory clientFactory, IConfiguration configuration, IUnitOfWork uow)
        {
            this.siteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
            _clientFactory = clientFactory;
            _uow = uow ?? throw new ArgumentNullException(nameof(_uow));

            _orders = _uow.Set<Order>();
     
        }
        public virtual async Task<GetFinalizeOptionsVM> SaveOrder(int id, OrderDTO model, CancellationToken cancellationToken)
        {
            var kookbaz = await new KookBazService(_clientFactory).getOrder(id, _token);
            model.sender.contact = kookbaz.Sender.To();
            model.sender.name = kookbaz.Sender.fullName ?? "*";

            model.receiver.contact = kookbaz.Receiver.To();
            model.receiver.name = kookbaz.Receiver.fullName ?? "*";

            var sender = new Person
            {
                NationalCode = model.sender.contact.national_code ?? string.Empty,
                Name = model.sender.name
            };
            var list = new List<Contact>();
            list.AddRange(new[] { new Contact { ContactType_Id = ContactTypeEnum.Address, Value = model.sender.contact.address ?? string.Empty }
            ,
            new Contact { ContactType_Id = ContactTypeEnum.city, Value = model.sender.contact.city ?? string.Empty }
            ,
            new Contact { ContactType_Id = ContactTypeEnum.Mobile, Value = model.sender.contact.phone_number ?? string.Empty }
            ,
            new Contact { ContactType_Id = ContactTypeEnum.Postal_code, Value = model.sender.contact.postal_code ?? string.Empty }
            });
            sender.Contacts = list;

            var receiver = new Person
            {
                NationalCode = model.receiver.contact.national_code ?? string.Empty,
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
                KookBaz_Id = id,
                Status = "معلق"
            };
            await _orders.AddAsync(entity, cancellationToken);

            model.parcels = entity.Parcels.Select(x => new ParcelDTO
            {
                id = x.Id,
                content = x.Content,
                value = x.Value ?? 0,
                weight = x.Weight ?? 0,
                dimension = new Dimension
                {
                    depth = x.Depth ?? 0,
                    height = x.Height ?? 0,
                    width = x.Width ?? 0
                }
            }).ToList();
            model.receiver.contact.national_code = kookbaz.Receiver.nationalCode ?? "0018862470";
            model.sender.contact.national_code = kookbaz.Sender.nationalCode ?? "0018862470";
            var padroOrders = await new PadroService(siteSettings.PordoUrl, _clientFactory).orders(model, _padroToken);

            entity.Order_Id = padroOrders.order_id;
            _orders.Update(entity);
            var options = await new PadroService(siteSettings.PordoUrl, _clientFactory).FinalizeOrderOptions(padroOrders.order_id, _padroToken);

            options.Order_Id = entity.Order_Id;
            return options;
        }

        public async Task<ServiceResult<PostFinalizeVM>> FinalizeOrder(string id, finalizeDTO model, CancellationToken cancellationToken)
        {
            //save State
            var order = _orders.FirstOrDefault(z => z.Order_Id == id);
            if (!DateTime.TryParse(model.Pickup_date, out var date))
            {
                return new ServiceResult<PostFinalizeVM>(false, ApiResultStatusCode.BadRequest,null,"تاریخ ارسالی صحیح نمی باشد.");
            }
            order.Pickup_date_Dm = date;
            order.Option_id = model.Option_id;
            order.Status = "نهایی";
            order.Comment = model.Comment;
            _orders.Update(order);
            return await new PadroService(siteSettings.PordoUrl, _clientFactory).FinalizeOrder(id, model, _padroToken);
        }

        public virtual async Task<ServiceResult> CancelOrder(string id, CancellationToken cancellationToken)
        {
            var result = await new PadroService(siteSettings.PordoUrl, _clientFactory).CancelOrder(id, _token);
            if (result)
            {
                //save state
                var order = _orders.FirstOrDefault(z => z.Order_Id == id);
                order.Status = "لغو";
                return new ServiceResult(true, ApiResultStatusCode.Success);
            }

            return new ServiceResult(false, ApiResultStatusCode.NotFound);
        }
        public async Task<ServiceResult<IEnumerable<ordervm2>>> ViewOrders(int id)
        {
            var orders = await _orders.Where(z => z.KookBaz_Id == id).Include(z => z.Sender).ThenInclude(z => z.Contacts).ThenInclude(z => z.ContactType).Include(z => z.Receiver).ThenInclude(z => z.Contacts).Include(z => z.Parcels).Select(z => ordervm2.FromEntity(z)).ToListAsync();
            return orders;
            //show Orders
        }
    }
}
