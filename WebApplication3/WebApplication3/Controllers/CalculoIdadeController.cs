using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class CalculoIdadeController : ApiController
    {
        public string Get()
        {
            return "App para poder Beber";
        }
        public string Get(int anoNascimento, string nomeUsuario = "Default")
        {
            if((DateTime.Now.Year) - anoNascimento >= 18)
            {
                return $"Olá {nomeUsuario}, Você pode Beber";
            }
            else
            {
                return $"Olá {nomeUsuario}, Vai beber suco de uva seu fedido";
            }
        }
    }
}
