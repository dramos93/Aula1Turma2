using EntityClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Controller
{

    public class PessoaController
    {
        //Realizo minha Conexão com o banco de Dados
        EntityContextDB ContextDB = new EntityContextDB();

        //IQueryable => Aqui temos nossa primeira Interface com a classe IQueryable. 
        //Essa classe contém várias funcionalidades prontas para usar igual ao banco de dados como os selects
        //<Pessoa> => Definimos o tipo que irá retornar
        //GetPessoas => Damos um nome ao nosso método
        public IQueryable<Pessoa> GetPessoas()//Nome do nosso método
        {
            return ContextDB.ListaPessoas;
        }
        public void AddPessoa(Pessoa item)
        {
            //ContextDB, nosso banco de Dados
            //.ListaPessoas, nossa tabela Pessoa
            //item que será adicionado
            ContextDB.ListaPessoas.Add(item);
            ContextDB.SaveChanges();
        }
    }
}
