using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        //Criação das memórias carregadas
        static UsuarioController usuarios = new UsuarioController();//está aqui para ser acessada de qualquer método.
        static LivrosController livros = new LivrosController();//está aqui para ser acessada de qualquer método.
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");
            while (!RealizaLoginSistema())//Retorna Verdadeiro ou falso
                Console.WriteLine("Login e Senha Inválidos");

            MostraMenuSistema();
            Console.ReadKey();

        }
        /// <summary>
        /// Aqui mostra o menu do sistema
        /// </summary>
        private static void MostraMenuSistema()
        {
            Console.Clear();
            Console.WriteLine("SISTEMA DE LOCAÇÂO DE LIVRO 1.0");
            Console.WriteLine("Menu Sistema");
            Console.WriteLine("4 - Fazer LogOff");
            Console.WriteLine("3 - Cadastrar Livros");
            Console.WriteLine("2 - Listar Livros");
            Console.WriteLine("1 - Listar Usuário");
            Console.WriteLine("0 - Sair");
            EscolherOpcao(Console.ReadKey().KeyChar.ToString());
        }
        /// <summary>
        /// Aqui tem as escolhas do menu e para qual método deve ir
        /// </summary>
        /// <param name="v">é o valor que foi inserido no menu</param>
        private static void EscolherOpcao(string v)
        {
            Console.Clear();
            switch (v)
            {
                case   "0" : ;
                    break;
                case   "1" :
                    MostrarLogin();
                    Console.ReadKey();
                    MostraMenuSistema();
                    break;
                case "2":
                    MostrarLivro();
                    Console.ReadKey();
                    MostraMenuSistema();
                    break;
                case "4":
                    while (!RealizaLoginSistema())//Retorna Verdadeiro ou falso
                    Console.WriteLine("Login e Senha Inválidos");
                    MostraMenuSistema();
                    break;

                default:
                    Console.WriteLine("\nVocê digitou uma opção inválida, clique para sair e digitar novamente!");
                    Console.ReadKey();
                    MostraMenuSistema();
                    break;
            }
        }
        /// <summary>
        /// Método para mostrar a lista de usuários do sistema
        /// </summary>
        private static void MostrarLogin()
        {
            usuarios.Usuarios.ForEach(i => Console.WriteLine(i.Login));
            Console.ReadKey();
        }

        /// <summary>
        /// Apresenta o livro que foi colocado dentro da biblioteca Livro
        /// </summary>
        private static void MostrarLivro()
        {

            livros.Livros.ForEach(i => Console.WriteLine(i.Nome));
            Console.ReadKey();
        }

        /// <summary>
        /// Método que realiza os procedimento completos de login dentro do 
        /// sistema como solicitação de login e senha pelo console, assim com o
        /// as respectivas validações que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados estiverem corretos</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("INFORME SEU LOGIN E SENHA PARA ACESSAR O SISTEMA");
            Console.WriteLine("LOGIN: ");
            var loginDoUsuario = Console.ReadLine();
            Console.WriteLine("Senha: ");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();
            // criação de objeto, sempre com minúsculo. Tem que criar um objeto para acessar o método
            //Estanciar, colocar na memória
            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return (usuarioController.LoginSistema(usuario));

        }

    }
}
