using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        SistemaCarroContext SistemaCarroContext = new SistemaCarroContext(); //instanciamos

        public List<Carro> Listar()
        {
            return SistemaCarroContext.ListaCarrosPublica;
        }

    }

}
