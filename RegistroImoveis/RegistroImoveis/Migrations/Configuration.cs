namespace RegistroImoveis.Migrations
{
    using RegistroImoveis.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistroImoveis.Models.MigrationsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RegistroImoveis.Models.MigrationsContext context)
        {
            //add proprietario value
            
            context.Proprietarios.AddOrUpdate(X => X.Email, new Proprietarios()
            {
                Nome = "Abigail",
                Email="abab@gmail.com",
                DataNascimento = DateTime.Now 
            });
            context.SaveChanges();
            context.Imovels.AddOrUpdate(X => X.Id , new Imovel()
            {
                Logradouro = "Augusto Ruschi",
                Bairro = "Itoupava Central",
                Complemento = "Casa 04",
                Cep = 89069080,
                Municipio = "Blumenau",
                Numero = "212",
                Proprietario = 1,
                ValorDoImovel = 250000,
            });
            context.SaveChanges();
        }
    }
}
