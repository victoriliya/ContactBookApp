using ContactBookApplication.Entities;
using System.Threading.Tasks;

namespace ContactBookApplication.Services.Interfaces
{
    public interface IAuthRepository
    {
        Task<bool> MakeAdmin(User user);
        Task<bool> MakeRegular(User user);
    }
}
