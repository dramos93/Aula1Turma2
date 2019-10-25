using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_IMC.Controllers
{
    public class IMCController : ApiController
    {
        public string CalculoIMC(string Nome, double Peso, double Altura)
        {
            return "Olá";
        }
    }
}
