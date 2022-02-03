using Application.Entities;
using System.Threading.Tasks;

namespace WebApi.Services.Interfaces
{
    public interface IUserServices
    {
        Task<Usuarios> Login(string email, string senha);
        Task CreateUser(Usuarios user);
    }
}
