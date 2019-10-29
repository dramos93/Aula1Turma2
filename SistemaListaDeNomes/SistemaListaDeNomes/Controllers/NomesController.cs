using SistemaListaDeNomes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemaListaDeNomes.Controllers
{
    public class NomesController : ApiController
    {

        public List<Pessoa> listaPessoas = new List<Pessoa>()
        {
            new Pessoa() { Nome = "Daniel", Idade= 19 },
            new Pessoa() { Nome = "Eduardo", Idade= 24 },
            new Pessoa() { Nome = "Renata", Idade=  21},
            new Pessoa() { Nome = "Ana Cláudia", Idade= 30 },
            new Pessoa() { Nome = "Magda", Idade=  35},
            new Pessoa() { Nome = "Abigail", Idade= 23 },
            new Pessoa() { Nome = "Edson", Idade=  36},
            new Pessoa() { Nome = "Jorge", Idade= 24 },
            new Pessoa() { Nome = "Luis", Idade= 31 },
            new Pessoa() { Nome = "Matheus", Idade= 10 },
        };
        //public List<Pessoa> Post()
        //{
        //    return listaPessoas.OrderByDescending(x => x.Idade).ToList();
        //}
        public List<Pessoa> Post(Pessoa pessoa)
        {
            listaPessoas.Add(pessoa);
            return listaPessoas.OrderByDescending(x => x.Idade).ToList();
        }

    }
}
