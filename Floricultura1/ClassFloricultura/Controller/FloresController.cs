using ClassFloricultura.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFloricultura.Controller
{
    public class FloresController
    {
        public FloresContext floresController = new FloresContext();

        /// <summary>
        /// Método que Retorna Lista de Flores
        /// </summary>
        /// <returns>Lista de Flores</returns>
        public IQueryable<Flores> GettFlores()
        {
            return floresController.Flor;
        }

        public bool AddFlor(Flores item)
        {
            var retornoNome = (string.IsNullOrWhiteSpace(item.Nome));
            if (!retornoNome)
                return false;
            else
            {
                floresController.Flor.Add(item);
                floresController.SaveChanges();
                return true;
            }
        }
    }
}
