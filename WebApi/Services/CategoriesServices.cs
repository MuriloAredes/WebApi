using Application.Entities;
using Application.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Services.Interfaces;

namespace WebApi.Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly ICategoriesRepository _iCategoriesRepository;
        public CategoriesServices(ICategoriesRepository iCategoriesRepository)
        {
            _iCategoriesRepository = iCategoriesRepository;
        }

        public bool Add(Categorias novaCategoria)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Categorias>> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
