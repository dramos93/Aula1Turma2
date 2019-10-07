﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAlunos.Model
{
    public class Alunos
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set;}
        public int Idade { get; set; }
    }
}
