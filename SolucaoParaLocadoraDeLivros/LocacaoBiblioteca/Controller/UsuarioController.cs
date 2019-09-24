using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que conté s métodos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {

        public LocacaoContext contextDB = new LocacaoContext();        
        //Crinado privado  para impedir o programador de adicionar um ID ou alterar fora da Classe

        /// <summary>
        /// Aqui foi Criado o Construtor
        /// </summary>
        public UsuarioController()//Aqui está criando o construtor
        {
           
        }
        /// <summary>
        /// Perguntamos pra lista se exite usuario && senha
        /// 
        /// </summary>
        /// <param name="usuarios">Retorna True or False </param>
        /// <returns></returns>
        public bool LoginSistema(Usuario usuarios)
        {
            return RetornaListaDeUsuarios().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }
        private List<Usuario> Usuarios { get; set; }
        public void AdicionarUsuario(Usuario parametroUsuario)
        {
            //Adicionamos o Livro em nossa lista
            parametroUsuario.Id = contextDB.IdContadorUsuarios++;
            contextDB.ListaDeUsuarios.Add(parametroUsuario);
        }
        public List<Usuario> RetornaListaDeUsuarios()
        {
            return contextDB.ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Método que desativa um registro de uuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadorID">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorID(int identificadorID)
        {
            //Aqui usamos o método FirstOrDefault para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            var use = contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadorID);
            if (use != null)
                use.Ativo = false;
            //aqui colocar o usuário excluído
        }
    }
}
