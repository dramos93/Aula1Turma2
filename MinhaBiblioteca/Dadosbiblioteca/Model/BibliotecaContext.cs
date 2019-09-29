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
        public List<Livros> listaDeLivros { get; set; }
        public List<LivrosExcluidos> SetLivrosExcluidos { get; set; }
        public BibliotecaContext()//Construtor
        {
            listaDeLivros.Add(new Livros { IdLivro = IdContadorLivro++, NomeLivro = "João e Maria" });
            listaDeLivros.Add(new Livros { IdLivro = IdContadorLivro++, NomeLivro = "Meu Barco de Papel"});
            listaDeLivros.Add(new Livros { IdLivro = IdContadorLivro++, NomeLivro = "Fé para Hoje" });
        }
        public List<Livros> GetListaDeLivros { get; }
    }
}
