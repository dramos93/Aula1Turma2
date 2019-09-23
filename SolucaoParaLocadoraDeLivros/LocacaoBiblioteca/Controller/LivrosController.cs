using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        private int IdContador = 1;
        public  LivrosController()
        {

            Livros = new List<Livro>();
            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Segundo Livro",
            }) ;
            Livros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Os Barcos de Papel",
            });
        }

        private List<Livro> Livros { get; set; }
        /// <summary>
        /// Método que adiciona o livo em nossa lista já "instanciada" criada dentro do 
        /// Construtor
        /// </summary>
        /// <param name="parametroLivro"></param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = IdContador++;
            //Adicionamos o Livro em nossa lista
            Livros.Add(parametroLivro);

            
        }
        public List<Livro> RetornaListaDeLivros()//Retorna a lista de livro
        {
            return Livros;//essa é a lista criada
        }
    }
}
