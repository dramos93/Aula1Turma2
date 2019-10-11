using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Inicialmente devemos deicar a classe publica
    public class Cerveja
    {
        [Key] //Aqui damos um using utilizando ctrl + ".". Essa Chave é primária, é auto incrementada
        public int Id { get; set; }
        [StringLength(50)] //Limita para 50 Caracteres dentro do nosso campo "Nome" dentro do Campo
        [Required]//Coloca o campo "Nome" como obrigatório
        public string Nome { get; set; }
        [StringLength(30)]
        public string Tipo { get; set; }
        public double Teor { get; set; }

    }
}
