using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace SistemaRelatorioCarros.Controller
{
    /// <summary>
    /// Copia da massa de informações pra "vendasContext"
    /// </summary>
    public class VendasController//temos que colocar em public
    {
        SistemaVendasContext vendasContext = new SistemaVendasContext(); //copiar a massa de informações pra "vendasContext"

        public List<Venda> GetVenda(int mes=0)
        {
            //retornamos nossa venda sem nenhum filtro nesse momento
            if (mes == 0)
                return vendasContext.ListaVendasPublica;
            else
                return vendasContext.ListaVendasPublica.FindAll(x => x.Data.Month == mes);//apenas podemos apresentar os dados dessa lista, mas sem modificar os dados da lista principal
        }
    }

}
