﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImoveisWebApiCore.Models
{
    public class ImoveisContext : DbContext
    {
        public ImoveisContext(DbContextOptions<ImoveisContext> options) : base(options)
        {

        }

        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }
        public DbSet<Proprietário> Proprietários { get; set; }

    }
}
