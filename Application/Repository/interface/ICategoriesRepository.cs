using Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface ICategoriesRepository
    {
        Task<IEnumerable<Categorias>> GetAll();
        Task<Categorias> GetById(long idCategoria);
        Task Add(Categorias novaCategoria);
        Task DeleteById(long idCategoria);
        Task UpdateCategories(long id, string nome);
    }
}
