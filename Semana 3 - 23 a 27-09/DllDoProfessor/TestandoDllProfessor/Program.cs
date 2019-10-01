using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;


namespace TestandoDllProfessor
{
   
    class Program
    {
        static DocumentsAutoGenerate documentsAutoGenerate = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            ObterPasta();
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("1 - Criar Pasta");
            Console.WriteLine("2 - Deletar Pasta");
            Console.WriteLine("3 - Obter Pasta");
            Console.WriteLine("0 - SAIR");

            Console.WriteLine("Digite um das opções acima");
            var n = Console.ReadLine();

            if (n == "1" )
            {
                CriarPasta();
                Menu();
            }
            if (n == "2")
            {
                DeletarPasta();
                Menu();
            }
            if (n == "3")
            {
                ObterPasta();
                Menu();
            }
        }

        private static void ObterPasta()
        {
            documentsAutoGenerate.ObterPastasDiretorioMeuDocumentos().ForEach(i => Console.WriteLine($"{i}"));
        }

        private static void DeletarPasta()
        {
            Console.Clear();
            int j = 0;
            documentsAutoGenerate.ObterPastasDiretorioMeuDocumentos().ForEach(i => Console.WriteLine($"{j++} Pasta: {i}"));
            Console.Write("\nDigite o número da Pasta que deseja Deletar: ");
            int n = int.Parse(Console.ReadLine());

            string diretorio = documentsAutoGenerate.ObterPastasDiretorioMeuDocumentos().ElementAt(n) ;
            documentsAutoGenerate.DeletarPastaMeusDocumentos(diretorio,true);
        }

        private static void CriarPasta()
        {
            Console.WriteLine("Digite o nome da pasta que será criada: ");
            documentsAutoGenerate.CriarPastaMeusDocumentos(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
