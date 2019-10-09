using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;


namespace CellDu
{
    class Program
    {
        // 1 - Colocar Console App para startar o projeto - OK
        // 2 - Aicinoar Referência Catélogo Celulares - OK
        // 3 - Adicionar Entity em nosso projeto - OK
        // 4 - Adicionar Using ao nosso projeto - OK

        static CelularesControllerr celulares = new CelularesControllerr();

        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {

                Console.WriteLine("Menu, Escolha uma Opção");
                Console.WriteLine("1 - Inserir Celulares");
                Console.WriteLine("2 - Mostrar Celular");
                Console.WriteLine("3 - Remover Celular");
                Console.WriteLine("4 - listar Celular");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;
                    case 0:;
                        break;
                    case 2 :
                        AtualizarCelular();
                        break;
                    case 3 :
                        RemoverCelular();
                        break;
                    case 4 :
                        ListarCelular();
                        break;
                    default:
                        Console.WriteLine("Opcão Inválida");
                        Console.WriteLine("Pressionar Qualquer Tecla para Voltar ao Menu");
                        break;
                }

                Console.ReadKey(true);
                Console.Clear();
            }
            
        }

        //Inserir
        public static void InserirCelular()
        {
            Console.WriteLine("--Inserir Celular --");
            Console.WriteLine("Informe o Marca do Celular");

            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do Celular");

            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor do Celular");

            var valor = double.Parse(Console.ReadLine());

            var resultado = celulares.InserirCelular(new Celular() { Marca = marca, Modelo = modelo, Preco = valor });

            if (resultado)
                Console.WriteLine("Celular Cadastrado com Sucesso");
            else
                Console.WriteLine("Erro ao cadastrar o Celular");


        }
        //Atualizar
        public static void AtualizarCelular()
        {
            Console.WriteLine("--Atualizar Celular --");

            ListarCelular();
            Console.WriteLine("Informe o Id do Celular");

            var celularId = int.Parse(Console.ReadLine());

            var celular = celulares.GetCelularer().FirstOrDefault<Celular>(x => x.Id == celularId);

            if (celular == null)
            {
                Console.WriteLine("Id Informado Inválido");
            }

            Console.WriteLine("Informe a Marca do Celular");
            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do Celular");
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço do Celular");
            celular.Preco = double.Parse(Console.ReadLine());

            var resultado = celulares.AtualizarCelular(celular);

            if (resultado)
                Console.WriteLine("Celular atualizado com Sucesso!");
            else
            {
                Console.WriteLine("Erro ao Atualizar o Celular");
            }
        }
        //Remover
        public static void RemoverCelular()
        {
            Console.WriteLine("--Remover Celular--");
            ListarCelular();
            Console.WriteLine("Informe o Id do Celular");

            var celularId = int.Parse(Console.ReadLine());

            var resultado = celulares.RemoverCelular(celularId);
            if(resultado)
                Console.WriteLine("Celular Removido com Sucesso");
            else
                Console.WriteLine("Erro ao Remover o Aparelho");
        }
        //listar
        public static void ListarCelular()
        {
            celulares.GetCelularer().ToList<Celular>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Valor: {x.Preco}"));
        }
    }
}
