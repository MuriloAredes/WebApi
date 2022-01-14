using Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Repository
{
    public class UserRepository
    {
        public static Usuarios Get(string email, string senha)
        {
            var users = new List<Usuarios>();

            users.Add(new Usuarios { Id = 1, Email = "prova@doubleit.com.br", Senha = "Prova@DoubleIt21", Nome = "Candidato" });
            return users.Where(x => x.Email.ToLower() == email.ToLower() && x.Senha == senha).FirstOrDefault();

        }
    }
}
