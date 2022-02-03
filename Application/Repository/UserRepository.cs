using Application.Context;
using Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ProvaContext _dbcontext;
        public UserRepository(ProvaContext context)
        {
            _dbcontext = context;
        }

        public async Task CreateLogin(Usuarios usuarios)
        {   //Refazer
            _dbcontext.Usuarios.Add(usuarios);
            await _dbcontext.SaveChangesAsync(); 
        }

        public async Task<Usuarios> Login(string email, string senha)
        {   //testar
            return _dbcontext.Usuarios.Find(email, senha);
        }
    }
}
