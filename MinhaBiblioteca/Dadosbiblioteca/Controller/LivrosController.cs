using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dadosbiblioteca.Model;

namespace Dadosbiblioteca.Controller
{
    public class LivrosController
    {
        private BibliotecaContext ListaLivrosContext = new BibliotecaContext();

        public List<Livros> MostrarListaLivros()
        {
            return ListaLivrosContext.GetListaDeLivros;
        }
    }
}
