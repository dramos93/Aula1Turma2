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
        static UsuarioController usuariosController = new UsuarioController();//está aqui para ser acessada de qualquer método.
        static LivrosController livrosController = new LivrosController();//está aqui para ser acessada de qualquer método.
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
            Console.WriteLine("6 - Remover Usuário");
            Console.WriteLine("5 - Cadastrar Usuário");
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
                case "3":
                    AdicionaLivro();
                    MostraMenuSistema();
                    break;
                case "4":
                    while (!RealizaLoginSistema())//Retorna Verdadeiro ou falso
                    Console.WriteLine("Login e Senha Inválidos");
                    MostraMenuSistema();
                    break;
                case "5":
                    AdicionaUsuario();
                    MostraMenuSistema();
                    break;
                case "6":
                    RemoverUsuarioPeloID();
                    MostraMenuSistema();
                    break;

                default:
                    Console.WriteLine("\nVocê digitou uma opção inválida, clique para sair e digitar novamente!");
                    Console.ReadKey();
                    MostraMenuSistema();
                    break;
            }
        }

        private static void RemoverUsuarioPeloID()
        {
            Console.WriteLine("Remver o usuário pelo ID no sistema: ");
            MostrarLogin();
            Console.WriteLine("Informe o ID para desativar do Sistema: ");
            int usuarioID = int.Parse(Console.ReadLine());
            usuariosController.RemoverUsuarioPorID(usuarioID);

            Console.WriteLine("Usuário Removido com sucesso");
            Console.ReadKey();

        }

        private static void AdicionaUsuario()
        {
            //Identificamos que o mesmo está na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar um novo Usuário dentro do sistema!\n");
            //Informamos que para dar continuidade ele deve invormar um nome para o livro
            Console.Write("Login do Usuário para Cadastro: ");
            //Obtemos esta informação do usuário
            var nomdeDoUsuario = Console.ReadLine();
            Console.Write("Senha do Usuário para Cadastro: ");
            //Obtemos esta informação do usuário
            var senhaDoUsuario = Console.ReadLine();

            
            //Aqui "atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
            //com o sinal de apenas um "=" temos atribuição, passagem de valor
            usuariosController.AdicionarUsuario(new Usuario()
            {
                //Aqui "atribuimos" o nome que demos ao livro na propriedade NOme de nosso livro
                //com o sinal de apenas um "=" temos atrubuição, passagem de valor
                Login = nomdeDoUsuario,
                Senha = senhaDoUsuario
            });
            // Indico que finalizamos o processo de cadastro do livro, assim o usuário já sabe que 
            //o mesmo doi realizado e sem erros
            Console.WriteLine("Usuário Cadastrado com Sucesso");
            //Readkey apenas para que ele visualize esta informação
            Console.ReadKey();
        }

        private static void AdicionaLivro()
        {
            //Identificamos que o mesmo está na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar Livro dentro do sistema!\n");
            //Informamos que para dar continuidade ele deve invormar um nome para o livro
            Console.Write("Nome do Livro para Cadastro: ");
            //Obtemos esta informação do usuário
            var nomeDoLivro = Console.ReadLine();
            //Aqui "atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
            //com o sinal de apenas um "=" temos atribuição, passagem de valor
            livrosController.AdicionarLivro(new Livro()
            {
                //Aqui "atribuimos" o nome que demos ao livro na propriedade NOme de nosso livro
                //com o sinal de apenas um "=" temos atrubuição, passagem de valor
                Nome = nomeDoLivro
            }) ;
            // Indico que finalizamos o processo de cadastro do livro, assim o usuário já sabe que 
            //o mesmo doi realizado e sem erros
            Console.WriteLine("Livro Cadastrado com Sucesso");
            //Readkey apenas para que ele visualize esta informação
            Console.ReadKey();
        }


        /// <summary>
        /// Método para mostrar a lista de usuários do sistema
        /// </summary>
        public static void MostrarLogin()
        {
            var listaUsuarios = usuariosController.RetornaListaDeUsuarios();
            listaUsuarios.ForEach(i => Console.WriteLine(i.Login+" "+i.Id));
            Console.ReadKey();
        }

        /// <summary>
        /// Apresenta o livro que foi colocado dentro da biblioteca Livro
        /// </summary>
        private static void MostrarLivro()
        {
            var listaLivros = livrosController.RetornaListaDeLivros();
            listaLivros.ForEach(i => Console.WriteLine($"{i.Id} {i.Nome}"));
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


            // criação de objeto, sempre com minúsculo. Tem que criar um objeto para acessar o método
            //Estanciar, colocar na memória
            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return (usuariosController.LoginSistema(usuario));

        }

       
    }
}
