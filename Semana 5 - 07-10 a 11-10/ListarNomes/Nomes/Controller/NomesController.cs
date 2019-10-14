using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nomes.Model;

namespace Nomes.Controller
{
    public class NomesController
    {
        public NomesContext GetNomesContext = new NomesContext();

        /// <summary>
        /// Método Responsável por enviar todos os nomes
        /// </summary>
        /// <returns>Envia a lista de Nomes</returns>
        public IQueryable<Name> ListarNomes()
        {
            return GetNomesContext.GetNomes;
        }

        public bool AdicionarNome(Name item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
                return false;
            else
            {
                GetNomesContext.GetNomes.Add(item);
                GetNomesContext.SaveChanges();
                return true;
            }
        }
    }
}
