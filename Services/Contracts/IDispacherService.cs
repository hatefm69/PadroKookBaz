using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ViewModels;

namespace Services.Services.BS
{
    public interface IDispacherService
    {
        Task<ServiceResult> CancelOrder(string id, CancellationToken cancellationToken);
        Task<ServiceResult<PostFinalizeVM>> FinalizeOrder(string id, FinalizeDTO model, CancellationToken cancellationToken);
        Task<GetFinalizeOptionsVM> SaveOrder(int id, OrderDTO model, CancellationToken cancellationToken);
        Task<ServiceResult<IEnumerable<Ordervm2>>> ViewOrders(int id);
    }
}