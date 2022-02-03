using Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface IUserRepository
{
        Task<Usuarios> Login(String email, String senha);
        Task CreateLogin(Usuarios novoUsuario);
    }
}
