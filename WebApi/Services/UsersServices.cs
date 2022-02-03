using Application.Entities;
using Application.Repository;
using System.Threading.Tasks;
using WebApi.Services.Interfaces;

namespace WebApi.Services
{
    public class UsersServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UsersServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateUser(Usuarios user)
        {
            await _userRepository.CreateLogin(user);
        }

        public async Task<Usuarios> Login(string email, string senha)
        {   if(string.IsNullOrEmpty(email)|| string.IsNullOrEmpty(senha))
                return null;
            
            var user =  _userRepository.Login(email, senha);

            if(user == null)
                return null;

            return await user;
        }
    }
}
