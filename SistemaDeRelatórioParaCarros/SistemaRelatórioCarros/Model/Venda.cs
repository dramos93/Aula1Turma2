using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRelatorioCarros.Model
{
    //Aqui foi criado a ESTRUTURA de dados
    public class Venda //deixar a classe como pública
    {
        public int Id { get; set; }
        public string Carro { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
    }
}
