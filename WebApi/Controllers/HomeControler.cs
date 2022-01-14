using Application.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Auth;

namespace WebApi.Controllers
{
    [Route("v1/account")]
    public class HomeControler : Controller
    {
        UsuariosService UsuariosService = new UsuariosService();
        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]

        public async Task<ActionResult<dynamic>> auth([FromBody] Usuarios modelo)
        {
            var user = UsuariosService.Login(modelo.Email, modelo.Senha);

            if (user == null)
                return NotFound(new { message = "Usuario não encontrado" });

            var token = TokenService.GenerateToken(user);
          
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
