using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Controller;    //não podemos esquecer de referenciar aqui
using SistemaRelatorioCarros.Model;         //não podemos esquecer de referenciar aqui

//Primeiro Referenciar com o outro projeto
//Segundo fazer um using do Controller
namespace InterfaceSistemaRelatório
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            MostrarMenuRelatorio();
            Console.WriteLine("Informações das Vendas Realizadas Durante o Ano de 2019");
            vendasController.GetVenda().ForEach(i => ImprimeInformacoes(i));
            Console.ReadKey();
        }

        private static void MostrarMenuRelatorio()
        {
            Console.Clear();

            Console.WriteLine("Menu de Relatórios");
            Console.WriteLine("1 - Menu por Período Mensal");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.MinValue;

            while(menuEscolhido != 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());
                switch (menuEscolhido)
                {
                    case 1:
                        Console.WriteLine("Informe o mês para realizar o filtro: ");
                        //obtemos a informação do mês
                        var mesEscolhido = int.Parse(Console.ReadLine());
                        Console.Clear();

                        //Passamos o mês na mesma função para obter os valores
                        var listaDoPeriodoEscolhido = vendasController.GetVenda(mesEscolhido);

                        //passamos o mês na mesma função para obter as vendas
                        listaDoPeriodoEscolhido.
                            //Aqui imprime as informações para usuário
                            ForEach(i => ImprimeInformacoes(i));

                        var totalMes = listaDoPeriodoEscolhido.
                            //Somamos todos os registros multiplicando o valor vezes a quantidade de vendas
                            Sum(x => x.Valor * x.Quantidade);
                        var MediaMes = listaDoPeriodoEscolhido.
                            //Somamos todos os registros multiplicando o valor vezes a quantidade de vendas e tirando a média
                            Average(x => x.Valor * x.Quantidade);

                        //Mostramos o mês escolhido e o valor total neste mês gerado
                        Console.WriteLine($"\nTotal do mês {mesEscolhido} é: {totalMes.ToString("C2")}");
                        
                        //Mostramos o mês escolhido e o valor total neste mês gerado
                        Console.WriteLine($"\nA média do mês {mesEscolhido} é: {MediaMes.ToString("C2")}");

                        Console.ReadKey();
                        MostrarMenuRelatorio();
                        break;
                    case 0 : break;
                    default:
                        MostrarMenuRelatorio();
                        break;
                }
            }
        }

        public static void ImprimeInformacoes(Venda vendas)
        {
            Console.WriteLine(string.Format("Id: {0,-3} Carro: {1,-25} Valor: {2,-10} Quantidade: {3,-3} Data{4,12}"
                ,vendas.Id
                ,vendas.Carro
                ,vendas.Valor.ToString("C2")
                ,vendas.Quantidade
                ,vendas.Data.ToShortDateString()));
        }
    }
}

/*
    1 - Sei que temos uma planilha do Excel e temos os dados dentro dela.
     pegar a planilha. ok
    2 - Ao analisar a planilha temos a seguinte estrutura.
          Id,Carro,Valor,Quantidade,Data
    
    Etapas de criação da minha aplicação  resumo 
        1 - Criar minha class Library
        	1.2 - Cria minha Estrutura de Dados dentro da Model -  ok
        	1.3 - Criar minha massa de dados Context dentro da Model - ok
        	1.4 - Criar meu controle de dados dentro da Controller - Ok
        2 - Criar meu console App
    
    
    
    Etapas de criação da minha aplicação resumo do resumo
        1 - Criar minha class Library  ok 
        2 - Criar meu console App ok
        
    
    Etapas para mostrar o conteúdo das vendas de 2019
    	1 - Precisamos Obter as informações de vendas do nosso Context - ok
    	2 - Na nossa controller criamos uma forma de retornar estas informações para nosso console app. ok
    	3 - No console app vamos apresentar estas informações para o Usuário. 
    
     Etapas para criar o relatório de vendas 
    	1- Devemos criar um menu para ele ter a opção de mostrar o relatório
    	2 - Pegar o mês que ele deseja visualizar este relatório 	
    	     2.1 - Adicionar esta opção Controller 
    	3 - Apresentar estas informações para o usuários
    	4 - Somar total de vendas e apresentar ao usuário na mesma tela
    	5 - Mostrar a media de vendas para aquele período 
     
*/
