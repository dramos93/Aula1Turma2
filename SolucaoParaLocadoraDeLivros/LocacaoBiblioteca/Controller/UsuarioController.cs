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
        public bool LoginSistema(Usuario usuarios)
        {
            if (usuarios.Login == "Admin" && usuarios.Senha== "Admin")
                return true;
            else
                return false;                 
        }
    }
}
