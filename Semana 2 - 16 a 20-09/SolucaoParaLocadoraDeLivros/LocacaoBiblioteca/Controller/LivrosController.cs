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
        LocacaoContext contextDB = new LocacaoContext();

        //listagem
        /// <summary>
        /// Método que mostra os livros
        /// </summary>
        /// <returns>Retorna se o livro foi adicionado com sucesso(true)</returns>
        public IQueryable<Livro> Getlivros(bool retorno)
        {
            return contextDB.livros.Where(x => x.Ativo == retorno);
        }
       
        /// <summary>
        /// Método que adiciona o livo em nossa lista já "instanciada" criada dentro do 
        /// Construtor
        /// </summary>
        /// <param name="parametroLivro"></param>
        public bool AdicionarLivro(Livro parametroLivro)
        {
            if (string.IsNullOrWhiteSpace(parametroLivro.Nome))
                return false;
            else
            {
                contextDB.livros.Add(parametroLivro);
                contextDB.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Método para Remover Livro
        /// </summary>
        /// <param name="identificadorID">Id do livro </param>
        /// <returns>Retorna se o livro foi bem sucedido ou não</returns>
        public bool RemoverLivroPorID(int identificadorID)
        {
            if (string.IsNullOrWhiteSpace(identificadorID.ToString()))
                return false;
            var livro = contextDB.livros.FirstOrDefault<Livro>(x => x.Id == identificadorID);
            if (livro == null)
                return false;
            else
            {
                livro.Ativo = false;
                livro.DataAlteracao = DateTime.Now;
                contextDB.SaveChanges();
                return true;
            }

        }

        /// <summary>
        /// Cria e Retorna uma lista de livro que estão desativados
        /// </summary>
        /// <returns></returns>
        public List<Livro> MostrarLivrosRemovidos()//Retorna a lista de livro
        {
            return contextDB.livros.Where(x => (x.Ativo == false)).ToList<Livro>(); ;//essa é a lista criada
        }

        public bool AtualizarLivro(Livro NLivro)
        {
            var y = contextDB.livros.FirstOrDefault<Livro>(x => x.Id == NLivro.Id);

            if (y != null)
            {
                y.DataAlteracao = DateTime.Now;
                y.Nome = NLivro.Nome;
                contextDB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
}
