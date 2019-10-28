using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApImc.Models;
namespace WebApImc.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoIMCController : ApiController
    {
        List<ObjectImc> listaDeObjetos = new List<ObjectImc>()
        {
            new ObjectImc() { Nome = "Felipe"},
            new ObjectImc() { Nome = "Cliber"},
            new ObjectImc() { Nome = "iomar"},

        };
        public List<ObjectImc> Get()
        {
            return listaDeObjetos;
        }
        public string Get(double peso, double altura, string nome)
        {
            var imc = peso / (altura * altura);
            return $"Seu IMC é {imc.ToString("N2")}, por causa de sua altura: {altura} e seu peso {peso}";
        }
        public ObjectImc Post(ObjectImc values)
        {
            ObjectImc imcCalc = values;
            imcCalc.ImcValue = imcCalc.Peso / (imcCalc.Altura * imcCalc.Altura);
            listaDeObjetos.Add(imcCalc);
            return imcCalc;
        }

    }
}
