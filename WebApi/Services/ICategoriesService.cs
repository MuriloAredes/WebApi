using Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Services
{
    interface ICategoriesService
    {
         public string add(string nome);
         public List<Categorias> GetAll();
    }
}
