
using Application.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("v1/categorias")]
    public class CategoriaControler : Controller
    {
        CategoriesService CategoriesService = new CategoriesService();
        [HttpPost]
       // [Authorize]
        public async Task<ActionResult<dynamic>> AddCategorias([FromBody] string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return BadRequest(new { message = "Campo não pode estar NULL" });
            }
            else
            {
                var resultado = CategoriesService.add(nome);
                if (resultado == null)
                {
                    return BadRequest(new { message = "Categoria já Existente" });
                }
                else
                {
                    return Ok(new { message = "Cadastrado Com sucesso " });
                }


            }

        }

        [HttpGet]
        //[Authorize]

        public async Task<ActionResult<dynamic>> listarTodos()
        {
            var listar = CategoriesService.GetAll();
            foreach(x  in listar)

               return Ok(listar);
        }
    }
}
