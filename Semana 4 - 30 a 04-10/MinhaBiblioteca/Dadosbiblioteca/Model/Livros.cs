using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dadosbiblioteca.Model
{
    public class Livros
    {
        public string NomeLivro  { get; set; }
        public int IdLivro { get; set; }
        public bool LivroAtivo { get; set; } = true;

    }
}
