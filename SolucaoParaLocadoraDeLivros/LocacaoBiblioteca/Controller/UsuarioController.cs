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
        //Crinado privado  para impedir o programador de adicionar um ID ou alterar fora da Classe
        private int IdContador = 1;
        /// <summary>
        /// Aqui foi Criado o Construtor
        /// </summary>
        public UsuarioController()//Aqui está criando o construtor
        {
            Usuarios = new List<Usuario>(); //Assinatura para criar o 
            Usuarios.Add(new Usuario()
            {
                Id = IdContador++,
                Login = "Admin",
                Senha = "Admin"
            });
            Usuarios.Add(new Usuario()
            {
                Id = IdContador++,
                Login = "Daniel",
                Senha = "123456"
            });
        }
        /// <summary>
        /// Perguntamos pra lista se exite usuario && senha
        /// 
        /// </summary>
        /// <param name="usuarios">Retorna True or False </param>
        /// <returns></returns>
        public bool LoginSistema(Usuario usuarios)
        {
            return Usuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }
        private List<Usuario> Usuarios { get; set; }
        public void AdicionarUsuario(Usuario parametroUsuario)
        {
            //Adicionamos o Livro em nossa lista
            parametroUsuario.Id = IdContador++;
            Usuarios.Add(parametroUsuario);
        }
        public List<Usuario> RetornaListaDeUsuarios()
        {
            return Usuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Método que desativa um registro de uuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadorID">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorID(int identificadorID)
        {
            //Aqui usamos o método FirstOrDefault para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            Usuarios.FirstOrDefault(x => x.Id == identificadorID).Ativo = false;
        }
    }
}
