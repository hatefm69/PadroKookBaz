using System.Threading.Tasks;
using ViewModels;

namespace Services.Services.BS
{
    public interface IKookBazService
    {
        Task<KookBazOrderVM> getOrder(int id);
    }
}