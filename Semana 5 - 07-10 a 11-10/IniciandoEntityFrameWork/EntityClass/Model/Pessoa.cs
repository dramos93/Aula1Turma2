using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class Pessoa
    {   
        [Key]//Aqui temos um anotação que indica que nossa chave é o campo logo abaixo da nossa anotação
             //e a palavra chabe [Key] significa 
        public int Id { get; set; }
        public String Nome { get; set; }

    }
}
