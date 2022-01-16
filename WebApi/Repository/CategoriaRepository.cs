using Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Repository
{
    public class CategoriaRepository
    {
        List<Categorias> categorias = new List<Categorias>();
        Random GeradorId = new Random();

        public string Adiciona(string nome)
        {
            foreach (var i in categorias)
            {
                if (i.Nome.Equals(nome))
                {
                    return null;
                }
            }
             categorias.Add(new Categorias { Id = GeradorId.Next(100), Nome = nome });
           
          return "Cadastrado com Sucesso";


        }

        public List<Categorias> ListarTodos()
        {
            

            return categorias;
        }
    }
}
