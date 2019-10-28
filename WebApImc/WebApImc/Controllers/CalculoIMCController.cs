using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApImc.Controllers
{
    [EnableCors(origins:"*", headers: "*", methods: "*")]
    public class CalculoIMCController : ApiController
    {

        public  string Get()
        {
            return "Olá, você está conectado na WebAPI";
        }
        public string Get(double peso, double altura, string nome)
        {
            var imc = peso / (altura * altura);
            return $"Seu IMC é {imc.ToString("N2")}, por causa de sua altura: {altura} e seu peso {peso}";
        }
        public string Post([FromBody] string values)
        {
            return "";
        }
    }
}
