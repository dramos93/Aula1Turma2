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
        private LocacaoContext contextDB = new LocacaoContext();

        //public  LivrosController()
        //{


        //}

        
        /// <summary>
        /// Método que adiciona o livo em nossa lista já "instanciada" criada dentro do 
        /// Construtor
        /// </summary>
        /// <param name="parametroLivro"></param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = contextDB.IdContadorLivros++;
            //Adicionamos o Livro em nossa lista
            contextDB.ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()//Retorna a lista de livro
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>(); ;//essa é a lista criada
        }
        /// <summary>
        /// Aqui é removido os Livros da Lista
        /// </summary>
        /// <param name="identificadorID">Recebe o número do ID do Livro que será Removido</param>
        public void RemoverLivroPorID(int identificadorID)
        {
            //Aqui usamos o método FirstOrDefault para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificadorID);
            if (livro != null)
                livro.Ativo = false;
        }
        /// <summary>
        /// Cria e Retorna uma lista de livro que estão desativados
        /// </summary>
        /// <returns></returns>
        public List<Livro> MostrarLivrosRemovidos()//Retorna a lista de livro
        {
            return contextDB.ListaDeLivros.Where(x => (x.Ativo == false)).ToList<Livro>(); ;//essa é a lista criada
        }
        
    }
}
