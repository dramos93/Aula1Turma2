using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioForWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informa a palavra de busca: ");
            var wordCount = FindByWhile(Console.ReadLine());

            Console.WriteLine($"Encontrados: {wordCount}");
            Console.ReadKey();
        }
        /// <summary>
        /// Método de busca dentro da Aplicação
        /// </summary>
        /// <param name="wordFind">Parâmetros de até 3 caracteres</param>
        /// <returns>Retorna a quantidade encontrada da expressão</returns>
        private static  int FindByWhile(string wordFind)
        {
            var contentToFind = TextContent();
            var wordFindCountLenght = wordFind.Length;
            var lengthText = contentToFind.Length-(wordFindCountLenght-1);
            var contWordFind = 0;
            int i = 0;
            while (i < lengthText)
            {
                var compareWord = string.Empty;
                var b = 0;
                while (b < wordFindCountLenght)
                {
                    compareWord += contentToFind[i+b].ToString();
                    b++;
                }
                if (wordFind == compareWord)
                    contWordFind++;
                i++;
            }
            return contWordFind;
        }
        /// <summary>
        /// Esse método retorna um texto grande para analisar
        /// </summary>
        /// <returns>O conteúdo do texto em string</returns>
        private static  string  TextContent()
        {
            return @"          Caros amigos, a constante divulgação das informações nos obriga à análise do sistema de formação de quadros que corresponde às necessidades. Por outro lado, a complexidade dos estudos efetuados garante a contribuição de um grupo importante na determinação das diretrizes de desenvolvimento para o futuro. O que temos que ter sempre em mente é que a contínua expansão de nossa atividade cumpre um papel essencial na formulação do fluxo de informações. Gostaria de enfatizar que o fenômeno da Internet auxilia a preparação e a composição dos métodos utilizados na avaliação de resultados. Do mesmo modo, o consenso sobre a necessidade de qualificação facilita a criação das novas proposições.

          É importante questionar o quanto o desenvolvimento contínuo de distintas formas de atuação desafia a capacidade de equalização das direções preferenciais no sentido do progresso. Nunca é demais lembrar o peso e o significado destes problemas, uma vez que a execução dos pontos do programa é uma das consequências do remanejamento dos quadros funcionais. As experiências acumuladas demonstram que a consolidação das estruturas prepara-nos para enfrentar situações atípicas decorrentes dos procedimentos normalmente adotados.

          Todas estas questões, devidamente ponderadas, levantam dúvidas sobre se o desafiador cenário globalizado possibilita uma melhor visão global dos conhecimentos estratégicos para atingir a excelência. Pensando mais a longo prazo, o início da atividade geral de formação de atitudes acarreta um processo de reformulação e modernização dos modos de operação convencionais. Não obstante, a determinação clara de objetivos pode nos levar a considerar a reestruturação dos paradigmas corporativos.

          Acima de tudo, é fundamental ressaltar que a mobilidade dos capitais internacionais representa uma abertura para a melhoria dos relacionamentos verticais entre as hierarquias. Por conseguinte, o entendimento das metas propostas talvez venha a ressaltar a relatividade dos níveis de motivação departamental. É claro que a hegemonia do ambiente político ainda não demonstrou convincentemente que vai participar na mudança das posturas dos órgãos dirigentes com relação às suas atribuições. A nível organizacional, a expansão dos mercados mundiais promove a alavancagem do retorno esperado a longo prazo.";
        }

    }
}
