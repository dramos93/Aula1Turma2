using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;
namespace ListagemDeCervejas.Controller
{
    public class CervejaControler
    {
        private SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();//Aqui eu instanciei

        /// <summary>
        /// Aqui eu retorno a lista de cerveja para quem chamar meu método
        /// Posso utilizar para mostrar, selecionar e filtrar a minha lista
        /// </summary>
        /// <returns>Método que utilizo para Mostrar, selecionar e filtrar a Lista de Cerveja</returns>
        public List<Cerveja> ListagemDeCervejas()
        {
            return sistemaCervejaContext.listaDeCerveja;
        }

        public void AdicionarCerveja(Cerveja cerveja)
        {
            cerveja.Id = sistemaCervejaContext.IdContadorCerveja++;
            sistemaCervejaContext.listaDeCerveja.Add(cerveja);          

        }
        public double VolumeCerveja()
        {
            return sistemaCervejaContext.listaDeCerveja.Sum(i => i.Litros);
        }

        public double ValorTotalCerveja()
        {
            return sistemaCervejaContext.listaDeCerveja.Sum(i => i.Valor);
        }
    }
}
