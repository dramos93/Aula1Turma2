using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API_IMC.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class IMCController : ApiController
    {
        //public string Get()
        //{
        //    return "App para Calcular IMC";
        //}
        public string Get(double Peso, double Altura, string Nome)
        {
            var _imc = (Peso) / (Altura * Altura);
            ////http://localhost:64921/API/IMC?Nome=Daniel&Altura=100&Peso=100
            return $"Olá {Nome} seu IMC é {_imc}, e ele foi calculado de acordo com sua Altura: {Altura} e Peso:{Peso} Kg";
        }

    }
}
