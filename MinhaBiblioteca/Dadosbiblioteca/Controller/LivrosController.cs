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
        public List<Livros> MostrarLivrosDisponiveis(bool opcao)
        {
            return ListaLivrosContext.GetListaDeLivros.Where(x => (x.LivroAtivo== opcao)).ToList<Livros>();
        }
        public void AdicionarLivro(Livros nome)
        {
            nome.IdLivro = ListaLivrosContext.IdContadorLivro++;
            ListaLivrosContext.ListaDeLivros.Add(nome);
        }
    }
}
