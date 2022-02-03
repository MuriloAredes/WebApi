using Application.Context;
using Application.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly ProvaContext _dbcontext;
        public CategoriesRepository(ProvaContext provaContext)
        {
            _dbcontext = provaContext;
        }

        public async Task Add(Categorias novaCategoria)
        {
             
             await _dbcontext.Categorias.AddAsync(novaCategoria);
             await _dbcontext.SaveChangesAsync();
        }

        public async Task DeleteById(long idCategoria)
        {
              _dbcontext.Remove(idCategoria);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Categorias>> GetAll()
        {
            return 
        }

        public async Task<Categorias> GetById(long idCategoria)
        {
            return await _dbcontext.Categorias.FindAsync(idCategoria);
        }

        public Task UpdateCategories(long id, string nome)
        {
            throw new NotImplementedException();
        }
    }
}
