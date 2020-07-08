using System.Threading.Tasks;
using ViewModels;

namespace Services.Services.BS
{
    public interface IPadroService
    {
        Task<bool> CancelOrder(string id);
        Task<InfoCityVM> Cities();
        Task<DeliveryOptionVM> DeliveryOption(Delivery_optionsDTO model);
        Task<PostFinalizeVM> FinalizeOrder(string id, finalizeDTO model);
        Task<GetFinalizeOptionsVM> FinalizeOrderOptions(string id);
        Task<OrderResultVM> orders(OrderDTO model);
    }
}