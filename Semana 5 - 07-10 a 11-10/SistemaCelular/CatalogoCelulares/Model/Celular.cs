﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class Celular : ControleUsuario //Herança
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]

        public string Marca{ get; set; }

        [MaxLength(30)]
        [Required]
        public string Modelo { get; set; }

        [Required]
        public double Preco { get; set; }
    }
}
