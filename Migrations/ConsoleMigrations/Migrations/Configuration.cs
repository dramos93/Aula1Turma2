namespace ConsoleMigrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleMigrations.Model.MigrationsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Migrations.Model.MigrationsContext";
        }

        protected override void Seed(ConsoleMigrations.Model.MigrationsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Usuarios.AddOrUpdate(x => x.Nome , new Model.Usuario() { Nome= "Felipe", Login = "admin", Senha = "admin", Email = "admin@admin.com.br", Nivel = Model.Nivel.Administrador });
        }
    }
}
