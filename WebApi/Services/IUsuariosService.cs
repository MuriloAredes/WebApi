﻿using Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Services
{
    interface IUsuariosService
    {
        Usuarios Login(string usuario, string senha);
    }
}