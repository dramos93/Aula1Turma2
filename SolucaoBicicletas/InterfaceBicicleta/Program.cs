using ClassBicicletas.Controller;
using ClassBicicletas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBicicleta
{
    class Program
    {
        static BicicletaController bicicletaController = new BicicletaController();
        static void Main(string[] args)
        {
            int opcao = int.MinValue;
            bool i;
            while (opcao != 0)
            { 
                Console.WriteLine("1 - Listar Todas Bicicletas");
                Console.WriteLine("2 - Adicionar Bicicleta");
                Console.WriteLine("3 - Atualizar Bicicleta");
                Console.WriteLine("4 - Remover bicicleta");
                Console.WriteLine("0 - Sair");
                Console.Write("\nDigite uma das opções Acima: ");
                i = int.TryParse(Console.ReadLine(),out opcao);
                Console.Clear();
                if (i)
                {
                    switch (opcao)
                    {
                        case 1:
                            ListarBicicleta();
                            break;
                        case 2:
                            AdicionarBicicleta();
                            break;
                        case 3:
                            AtualizarBicicleta();
                            break;
                        case 4:
                            RemoverBicicleta();
                            break;
                        case 0:
                            break;

                        default:
                            break;
                    }
                }
                else
                {

                }
                }
            }

        private static void RemoverBicicleta()
        {
            
        }


        private static void AtualizarBicicleta()
        {
            bool teste = true;
            ListarBicicleta();
            Console.Write("\ndigite Qual das Bicicletas Acima você quer Alterar: ");
            var _Id = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Modelo: ");
            var _modelo = Console.ReadLine();
            Console.Write("Digite a Marca: ");
            var _Marca = Console.ReadLine();
            Console.Write("Digite o Valor: ");
            double _Valor;
            bool x = double.TryParse(Console.ReadLine(), out _Valor);
            if (x)
            {
                teste = bicicletaController.InserirBicicleta(new Bicicleta { Modelo = _modelo, Marca = _Marca, Valor = _Valor, Id = _Id });
                Console.ReadKey();
            }

            if (teste)
            {
                Console.WriteLine("Alteração Concluída");
                Console.ReadKey();
            }
            else
            {
                Erro();
            }
        }


        private static void AdicionarBicicleta()
        {
            Console.WriteLine("Adicionando Nova Bicicleta");
            Console.Write("Digite o Modelo: ");
            var _modelo = Console.ReadLine();
            Console.Write("Digite a Marca: ");
            var _Marca = Console.ReadLine();
            Console.Write("Digite o Valor: ");
            double _Valor;
            bool x = double.TryParse(Console.ReadLine(), out _Valor);

            if (x)
            {
                bicicletaController.InserirBicicleta(new Bicicleta { Modelo=_modelo, Marca=_Marca, Valor= _Valor});
                Console.ReadKey();
            }

            else
            {
                Erro();
            }

        }


        private static void ListarBicicleta()
        {
            bicicletaController.GetBicicletas().ToList().ForEach(x => Console.WriteLine(string.Format("Id: {0,2} | Modelo: {1,-15} | Marca: {2,-15} | Valor: {3,8}", x.Id,x.Modelo,x.Marca,x.Valor.ToString("C")))); 
            Console.ReadKey();
        }


        private static void Erro()
        {
            Console.WriteLine("Erro, Volte e Tente Novamente");
            Console.Write("\nPressione qualquer tecla para sair...");
            Console.Clear();
        }
    }

}