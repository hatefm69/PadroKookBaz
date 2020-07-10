using System.Threading.Tasks;
using ViewModels;
using ViewModels.KookBazModel;

namespace Services.Services.BS
{
    public interface IKookBazService
    {
        Task<KookBazOrderVM> getOrder(int id);
        Task Login(LoginModel model);
    }
}