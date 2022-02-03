using Application.Context;
using Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProvaContext _dbcontext;
        public ProdutoRepository(ProvaContext provaContext)
        {
            _dbcontext = provaContext;
        }

        public string Add(Produtos novoProduto)
        {   if (novoProduto == null)
                return null;
            if (novoProduto.PrecoUnitario <= 0)
                return "numero preco menor que zero !";
            _dbcontext.Add(novoProduto);
            _dbcontext.SaveChanges();

            return "Cadastrado com sucesso !";
        }

        public void Delete(Produtos produto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produtos>> GetAll(string term, int page, int pageSizeS)
        {
            throw new NotImplementedException();
        }

        public long GetById(long idProduto)
        {
            throw new NotImplementedException();
        }

        public string GetByNome(string nomeProduto)
        {
            throw new NotImplementedException();
        }

        public Produtos GetProduto(long idProduto)
        {
            throw new NotImplementedException();
        }

        public void Upadate(Produtos produto)
        {
            throw new NotImplementedException();
        }
    }
}
