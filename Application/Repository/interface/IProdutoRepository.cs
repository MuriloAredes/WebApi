using Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produtos>> GetAll(String term, int page, int pageSizeS);
        Produtos GetProduto(long idProduto);
        String GetByNome(String nomeProduto);
        long GetById(long idProduto);
        void Add(Produtos novoProduto);
        void Upadate(Produtos produto);
        void Delete(Produtos produto);
    }
}
