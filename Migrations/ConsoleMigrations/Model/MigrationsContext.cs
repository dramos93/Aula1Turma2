﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConsoleMigrations.Model
{
    public class MigrationsContext : DbContext
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}