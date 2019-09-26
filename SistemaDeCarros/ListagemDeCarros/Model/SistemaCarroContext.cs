using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{

    public class SistemaCarroContext
    {
        private List<Carro> ListaCarros { get; set; }

        //Abaixo está o construtor
        public SistemaCarroContext()
        {
            ListaCarros = new List<Carro>();

            ListaCarros.Add(new Carro() { Id = 1, Marca = "BMW", Modelo = "  X1", Ano = "2019", Cilindradas = "1998 cm³", Portas = "4" });
            ListaCarros.Add(new Carro() { Id = 2, Marca = "BMW", Modelo = "  X3", Ano = "2019", Cilindradas = "1998 cm³", Portas = "4" });
            ListaCarros.Add(new Carro() { Id = 3, Marca = "BMW", Modelo = "  X5", Ano = "2017", Cilindradas = "2993 cm³", Portas = "4" });
            ListaCarros.Add(new Carro() { Id = 4, Marca = "BMW", Modelo = "  X6", Ano = "2018", Cilindradas = "4395 cm³", Portas = "4" });
            ListaCarros.Add(new Carro() { Id = 5, Marca = "BMW", Modelo = "  M3", Ano = "2015", Cilindradas = "2979 cm³", Portas = "2" });
            ListaCarros.Add(new Carro() { Id = 6, Marca = "BMW", Modelo = "  M6", Ano = "2013", Cilindradas = "4395 cm³", Portas = "2" });
            ListaCarros.Add(new Carro() { Id = 7, Marca = "BMW", Modelo = "320i", Ano = "2017", Cilindradas = "1997 cm³", Portas = "4" });
            ListaCarros.Add(new Carro() { Id = 8, Marca = "BMW", Modelo = "  Z4", Ano = "2020", Cilindradas = "2998 cm³", Portas = "2" });
            ListaCarros.Add(new Carro() { Id = 9, Marca = "BMW", Modelo = "  i8", Ano = "2020", Cilindradas = "1499 cm³", Portas = "2" });
            ListaCarros.Add(new Carro() { Id =10, Marca = "BMW", Modelo = "  i3", Ano = "2020", Cilindradas = " 647 cm³", Portas = "4" });
        }

        public List<Carro> ListaCarrosPublica { get { return ListaCarros; } }


        //public 
    }
}
