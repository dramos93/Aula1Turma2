using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListantoPessoas2.Model;

namespace ListantoPessoas2.Controller
{
    class PessoaController
    {

        private List<Pessoa> listaDePessoas { get; set; }
        /// <summary>
        ///  Ometoso conatrutor ajuda a indicar nosa classe para utilizarmos de
        ///  maneira corretaas informações internas, cm isso podemos iniciar nossa
        ///  lista de pessoas  sem depender do usuario ou programador na parte da interfasce
        /// </summary>
        public PessoaController()
        {
            listaDePessoas = new List<Pessoa>();

            #region listaDePessoas.Add(new Pessoa() { Id = 1, Nome = "Spears  ", DataDeNascimento = DateTime.Parse("07/11/2004"), Carteira = 846.96 });
            listaDePessoas.Add(new Pessoa() { Id = 2, Nome = "Swanson  ", DataDeNascimento = DateTime.Parse("20/06/2003"), Carteira = 233.09 });
            listaDePessoas.Add(new Pessoa() { Id = 3, Nome = "Gay      ", DataDeNascimento = DateTime.Parse("03/12/2001"), Carteira = 911.92 });
            listaDePessoas.Add(new Pessoa() { Id = 4, Nome = "Gregory  ", DataDeNascimento = DateTime.Parse("02/01/2000"), Carteira = 469.01 });
            listaDePessoas.Add(new Pessoa() { Id = 5, Nome = "Olson    ", DataDeNascimento = DateTime.Parse("18/07/2001"), Carteira = 261.90 });
            listaDePessoas.Add(new Pessoa() { Id = 6, Nome = "Garza    ", DataDeNascimento = DateTime.Parse("01/04/2000"), Carteira = 360.41 });
            listaDePessoas.Add(new Pessoa() { Id = 7, Nome = "Sweet    ", DataDeNascimento = DateTime.Parse("12/03/2003"), Carteira = 312.76 });
            listaDePessoas.Add(new Pessoa() { Id = 8, Nome = "Cline    ", DataDeNascimento = DateTime.Parse("26/03/2002"), Carteira = 484.51 });
            listaDePessoas.Add(new Pessoa() { Id = 9, Nome = "Oliver   ", DataDeNascimento = DateTime.Parse("05/07/2004"), Carteira = 513.76 });
            listaDePessoas.Add(new Pessoa() { Id = 10, Nome = "Vang     ", DataDeNascimento = DateTime.Parse("10/07/2000"), Carteira = 271.05 });
            listaDePessoas.Add(new Pessoa() { Id = 11, Nome = "Maddox   ", DataDeNascimento = DateTime.Parse("29/05/2004"), Carteira = 783.97 });
            listaDePessoas.Add(new Pessoa() { Id = 12, Nome = "Garrett  ", DataDeNascimento = DateTime.Parse("03/06/2006"), Carteira = 154.11 });
            listaDePessoas.Add(new Pessoa() { Id = 13, Nome = "Mcintosh ", DataDeNascimento = DateTime.Parse("06/07/2006"), Carteira = 902.80 });
            listaDePessoas.Add(new Pessoa() { Id = 14, Nome = "Yang     ", DataDeNascimento = DateTime.Parse("29/04/2005"), Carteira = 550.48 });
            listaDePessoas.Add(new Pessoa() { Id = 15, Nome = "Hendricks", DataDeNascimento = DateTime.Parse("05/09/2003"), Carteira = 410.56 });
            listaDePessoas.Add(new Pessoa() { Id = 16, Nome = "Cain     ", DataDeNascimento = DateTime.Parse("12/01/2002"), Carteira = 221.13 });
            listaDePessoas.Add(new Pessoa() { Id = 17, Nome = "Blackburn", DataDeNascimento = DateTime.Parse("10/05/2000"), Carteira = 135.67 });
            listaDePessoas.Add(new Pessoa() { Id = 18, Nome = "Howe     ", DataDeNascimento = DateTime.Parse("27/09/2005"), Carteira = 360.14 });
            listaDePessoas.Add(new Pessoa() { Id = 19, Nome = "Pratt    ", DataDeNascimento = DateTime.Parse("18/09/2000"), Carteira = 991.83 });
            listaDePessoas.Add(new Pessoa() { Id = 20, Nome = "Sherman  ", DataDeNascimento = DateTime.Parse("20/02/2003"), Carteira = 667.00 });
            #endregion
        }



        /// <summary>
        /// \Temos uma propriedade agora que nos retorna nossa lista com 
        /// </summary>
        public List<Pessoa> ListaDePessoasPublica
        {
            get { return listaDePessoas; }
        }

        /// <summary>
        /// Método que retorna nossa lista de pessoas ordenadas de forma Asc
        /// pelo nome de cada uma
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> GetPessoasOrdenadasAsc()
        {
            return listaDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>();
        }
        /// <summary>
        /// Método público que retorna a lista ordenada pela data de nascimento
        /// da maior data para a menor data
        /// </summary>
        /// <returns>Retorna Lista Com Mais novos pros mais velhos</returns>
        public List<Pessoa> GetPessoasOrdenadasPelaDataNascimento()
        {
            return listaDePessoas.OrderByDescending(x => x.DataDeNascimento).ToList<Pessoa>();
        }
        /// <summary>
        /// Método que retorna as pessoas com determinado valor dentro da carteira
        /// Caso não seja informado o valor, ele vai pegar o R$500
        /// </summary>
        /// <returns>Retorna a lista com o valor definido e ordenado do maior pro menor</returns>
        public List<Pessoa> GetPessoasOrdenadasComMaisPilasNaCarteira(double valor = 500)
        {
            return listaDePessoas.FindAll(x=>x.Carteira>valor).OrderByDescending(x => x.Carteira).ToList<Pessoa>();
        }
        /// <summary>
        /// Método que retorna a lista de pessoas com idade maio que a 
        /// idade informada, caso não seja informado um valor, será usado default que é 18
        /// </summary>
        /// <param name="idade">Idade Informada</param>
        /// <returns>Retorna a lista de Pessoas pela idade informada</returns>
        public List<Pessoa> GetPessoasComIdadeMaiorA(int idade = 18)
        {
            return listaDePessoas.FindAll(x => (DateTime.Now.Year - x.DataDeNascimento.Year) >= idade).OrderByDescending(x => x.DataDeNascimento).ToList<Pessoa>();
        }
        /// <summary>
        /// Método que retorna a lista de pessoas com idade menor que a 
        /// idade informada, caso não seja informado um valor, será usado default que é 16
        /// </summary>
        /// <param name="idade">Idade Informada</param>
        /// <returns>Retorna a lista de Pessoas pela idade informada</returns>
        public List<Pessoa> GetPessoasPessoasMenorQue(int idade = 16)
        {
            return listaDePessoas.FindAll(x => (DateTime.Now.Year - x.DataDeNascimento.Year) < idade).OrderByDescending(x => x.DataDeNascimento).ToList<Pessoa>();
        }
    }

}

