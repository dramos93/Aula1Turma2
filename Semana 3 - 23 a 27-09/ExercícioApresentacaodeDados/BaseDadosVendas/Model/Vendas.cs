using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDadosVendas.Model
{
    public  class Vendas
    {
        public int IdCarro { get; set; }
        public string ModeloCarro { get; set; }
        public double ValorCarro { get; set; }
        public int QuantidadeVendas { get; set; }
        public DateTime DataVendas { get; set; }
    }
}
