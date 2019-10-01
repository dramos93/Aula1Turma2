using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public int IdContadorCerveja { get; set; } = 1;
        public List<Cerveja> listaDeCerveja { get; set;}
        public SistemaCervejaContext()
        {
            listaDeCerveja = new List<Cerveja>();
            listaDeCerveja.Add(new Cerveja() { Id = IdContadorCerveja++, Nome = "Antarctica Pilsen",      Litros = 0.300, Alcool = 4.7, Valor = 02.19 });
            listaDeCerveja.Add(new Cerveja() { Id = IdContadorCerveja++, Nome = "Brahma Chopp Pilsen",    Litros = 0.355, Alcool = 4.8, Valor = 03.29 });
            listaDeCerveja.Add(new Cerveja() { Id = IdContadorCerveja++, Nome = "Bohemia Imperial",       Litros = 0.550, Alcool = 5.2, Valor = 19.90 });
            listaDeCerveja.Add(new Cerveja() { Id = IdContadorCerveja++, Nome = "Patagonia Weisse",       Litros = 0.740, Alcool = 4.4, Valor = 11.13 });
            listaDeCerveja.Add(new Cerveja() { Id = IdContadorCerveja++, Nome = "Franziskaner Hell",      Litros = 0.500 ,Alcool = 5.0, Valor = 13.93}) ;
        }
    }
}
