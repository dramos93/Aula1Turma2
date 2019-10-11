using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext : DbContext
    {
        public DbSet<Livro> livros { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        //Propriedade que armazena ID dos livros adicionados ao sistema
        public int IdContadorLivros { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1;
        public List<Livro> ListaDeLivros { get; set; }

        public List<Usuario> ListaDeUsuarios { get; set; }


        //criando um construtor
        public LocacaoContext()
        {
            //criamos um lista usuário em memória
            ListaDeUsuarios = new List<Usuario>();
            //Adicionamos o Usuário
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123"
            });
        }
        //Cria-se 


    }
}
