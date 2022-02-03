using Application.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Services.Interfaces
{
    public interface ICategoriesServices
    {
        Task<IEnumerable<Categorias>> GetAll();
        bool Add(Categorias novaCategoria);

    }
}

