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
        /// <summary>
        /// Aqui foi Criado o Construtor
        /// </summary>
        public UsuarioController()//Aqui está criando o construtor
        {
            Usuarios = new List<Usuario>(); //Assinatura para criar o 
            Usuarios.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin"
            });
            Usuarios.Add(new Usuario()
            {
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
        public List<Usuario> Usuarios { get; set; }
    }
}
