using Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Repository;

namespace WebApi.Services
{
    public class CategoriesService : ICategoriesService
    {
        CategoriaRepository categoriesRepository = new CategoriaRepository();
        public string add(string nome)
        {
            
           return categoriesRepository.Adiciona(nome);

        }

        public List<Categorias> GetAll()
        {
            return categoriesRepository.ListarTodos();
        }
    }
}
