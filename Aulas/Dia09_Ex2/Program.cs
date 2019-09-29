using Dia09_Ex2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia09_Ex2
{
    class Program
    {
        static List<Pessoa> listaDeCadastro = new List<Pessoa>();
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite uma das opções Abaixo:");
            Console.WriteLine("1 - Lançar Cadastro de Pessoa\n2 - Listar Pessoas Cadastradas\n3 - Sair  ");
            var opcao = Console.ReadLine();
            Console.Clear();
            switch (opcao)
            {
                case "1":
                    CadastoPessoa();
                    Menu();
                    break;
                case "2":
                    MostrarCadastro();
                    Menu();
                    break;
                case "3":

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção Inválida: Digite umas das opções abaixo:\n");
                    Menu();
                    break;
            }

        }

        public static void MostrarCadastro()
        {
            listaDeCadastro.ForEach(cadastro => 
            Console.WriteLine($"Nome:{cadastro.nome}\nIdade: {cadastro.Idade}\nSexo: {SexoExtenso(cadastro.Sexo.ToString())}\nAltura: {cadastro.Altura}\n "));
            Console.ReadKey();
        }
        /// <summary>
        /// Aqui pega a letra e coloca o valor referente a ela
        /// </summary>
        /// <param name="sexoPorExt">Esse é p valor que está listado no cadastro.sexo</param>
        /// <returns></returns>
        public static object SexoExtenso(string sexoPorExt)
        {
           var sexo = "";
            if (sexoPorExt == "F")
            sexo = "Feminino";
            if (sexoPorExt == "M")
            sexo = "Masculino";
            return sexo;
        }
        /// <summary>
        /// Aqui é feito todo o cadastramento das pessoas
        /// </summary>
        public static void CadastoPessoa()
        {
            Console.WriteLine("Digite o nome da pessoa: ");
            var nomePessoa = Console.ReadLine();
            Console.WriteLine("Digite o idade da pessoa: ");
            int idadePessoa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sexo da pessoa, M - para homem, F - para Mulher: ");
            char sexoPessoa = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Altura: ");
            double alturaPessoa = double.Parse(Console.ReadLine());
            listaDeCadastro.Add(new Pessoa()
            {
                nome = nomePessoa,
                Idade = idadePessoa,
                Sexo = sexoPessoa,
                Altura = alturaPessoa
            });
        }
    }
}
