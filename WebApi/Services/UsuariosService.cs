using Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Repository;

namespace WebApi.Services
{
    public class UsuariosService : IUsuariosService
    {
        public Usuarios Login(string username, string senha)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(senha))
                return null;

            var user = UserRepository.Get(username, senha);

            // check if username exists
            if (user == null)
                return null;


            return user;
        }
    }
}
