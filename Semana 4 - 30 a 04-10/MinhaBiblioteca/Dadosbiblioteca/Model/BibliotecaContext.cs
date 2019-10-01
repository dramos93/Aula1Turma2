using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dadosbiblioteca.Model
{
    public class BibliotecaContext
    {
        public int IdContadorLivro = 1;
        public List<Livros> ListaDeLivros { get; set; }
        public List<Livros> ListaLivrosExcluidos { get; set; }
        public BibliotecaContext()//Construtor
        {
            ListaDeLivros = new List<Livros>();
            ListaLivrosExcluidos = new List<Livros>();
            ListaDeLivros.Add(new Livros { IdLivro = IdContadorLivro++, NomeLivro = "João e Maria" ,LivroAtivo=false});
            ListaDeLivros.Add(new Livros { IdLivro = IdContadorLivro++, NomeLivro = "Meu Barco de Papel"});
            ListaDeLivros.Add(new Livros { IdLivro = IdContadorLivro++, NomeLivro = "Santidade" });
            ListaDeLivros.Add(new Livros { IdLivro = IdContadorLivro++, NomeLivro = "O segredo do Contentamento" });
            ListaDeLivros.Add(new Livros { IdLivro = IdContadorLivro++, NomeLivro = "Esposa Excelente",LivroAtivo=false });
            ListaDeLivros.Add(new Livros { IdLivro = IdContadorLivro++, NomeLivro = "O Evangelho no Centro" });
            ListaDeLivros.Add(new Livros { IdLivro = IdContadorLivro++, NomeLivro = "O Peregrino", LivroAtivo=false });
        }
        public List<Livros> GetListaDeLivros { get { return ListaDeLivros; }}
    }
}
