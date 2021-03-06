﻿using System.Threading.Tasks;
using ViewModels;
using ViewModels.PadroModel;

namespace Services.Services.BS
{
    public interface IPadroService
    {
        Task<bool> CancelOrder(string id);
        Task<InfoCityVM> Cities();
        Task<DeliveryOptionVM> DeliveryOption(Delivery_optionsDTO model);
        Task<PostFinalizeVM> FinalizeOrder(string id, FinalizeDTO model);
        Task<GetFinalizeOptionsVM> FinalizeOrderOptions(string id);
        Task<OrderResultVM> orders(OrderDTO model);
        Task Login(LoginModel model);
    }
}