using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VolumeWebApiCore.Models
{
    public class Objeto
    {
        [Key]
        public int Id { get; set; }

        public string NomeObjeto { get; set; }
        public double Densidade { get; set; }
        public double VolumeTotal{ get; set; }

        public double Peso { get; set; }
        

    }
}
