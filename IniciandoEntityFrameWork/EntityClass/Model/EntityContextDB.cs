using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : DbContext
        //DbContext , classe pronta que Contém todos os processos de conexão
        //com o banco de dados da listafem das tabelas
        //seleção das informações
    {
        public DbSet<Pessoa> ListaPessoas { get; set; }
        //DbSet => Palavra Reservada para o Entity que indica que vamos definir uma tabela do nosso banco de dados
        //<Pessoa>Aqui definimos nossa tabela  pessoa, ou seja, especificamos qual de nossas classes será uma 
        //referência de uma tabela no banco de dados ela vai ao banco com o nome que definimos em nossa classe
        //ListaPessoas { get; set; } => Nesta parte liberamos nossa tabela para acessar

    }
}
