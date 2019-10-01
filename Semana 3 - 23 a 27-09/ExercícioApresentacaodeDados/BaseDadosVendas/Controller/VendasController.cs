using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDadosVendas.Model;
namespace BaseDadosVendas.Controller
{

    public class VendasController

    {
        private RelatorioContext contextDB = new RelatorioContext();//

        public List<Vendas> RetornaListaVendas()
        {
            return contextDB.listaDeVendas;
        }



    }
}
