using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBicicletas.Model
{
    public class Bicicleta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Modelo { get; set; }

        [Required]
        [MaxLength]
        public string Marca { get; set; }

        public double Valor { get; set; } = 0;

        public bool status { get; set; } = true;
    }
}
