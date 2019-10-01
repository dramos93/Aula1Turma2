using ListantoPessoas2.Controller;
using ListantoPessoas2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListantoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {

            PessoaController pessoaController = new PessoaController();

            MostraIdentificador("Lista Ordenada");
            pessoaController.ListaDePessoasPublica.ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista Orndenada por nome");
            pessoaController.GetPessoasOrdenadasAsc().ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista Orndenada por Data de Nascimento");
            pessoaController.GetPessoasOrdenadasPelaDataNascimento().ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista os primo Ryco");
            pessoaController.GetPessoasOrdenadasComMaisPilasNaCarteira().ForEach(i => MostraInformacoes(i));//Se não for passado nenhum valor, o método recebe 500

            MostraIdentificador("Lista dos Maiores de Idade");
            pessoaController.GetPessoasComIdadeMaiorA().ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista dos Menores de 16 Anos");
            pessoaController.GetPessoasPessoasMenorQue().ForEach(i => MostraInformacoes(i));
        }
        /// <summary>
        /// Método que mostra a informação inicial de cada listagem
        /// </summary>
        /// <param name="nomeAcao">Identificador de listagem</param>
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("-------{0,20}-------",nomeAcao));
        }
        /// <summary>
        /// Método que mostra no console formatado nosso objetivo "Pessoa"
        /// </summary>
        /// <param name="i"></param>
        private static void MostraInformacoes(Pessoa i)
        {
            //Template que deixa mais bonitinho
            string template = "Id: {0,3} Nome: {1,10} Nascimento: {2,10} Carteira: {3,10}";
            string textoformatado = string.Format(template, i.Id, i.Nome, i.DataDeNascimento.ToShortDateString(), i.Carteira.ToString("C2")); // Aqui joga o texto formatado para uma variável
            Console.WriteLine(textoformatado);//Aqui apresenta o texto formatado
        }
    }
}
