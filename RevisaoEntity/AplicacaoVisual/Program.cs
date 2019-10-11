using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisandoEntity.Model;
using RevisandoEntity.Controller;



namespace AplicacaoVisual
{
    class Program
    {
        // 1 - Setar a aplicação visual do projeto
        // 2 - Vamos Adicionar EntityFramework ao nosso projeto Console
        // 3 - Colocar em nosso Using o System.Data.Entity
        // 4 - Adicionar a Referência da nossa ClassLibrary

        //static CervejaContextDB cerveja = new CervejaContextDB();         //usamos ctrl + "." para dar um using

        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            //cerveja.Cervejas.Add(new Cerveja { Nome = "Golimar" });
            //cerveja.SaveChanges();

            //cerveja.Cervejas.ToList<Cerveja>().ForEach(i => Console.WriteLine(i.Nome));

            cerveja.AddCerveja(new Cerveja { Nome = "Cerveja Ambev" }); 

            cerveja.GetCervejas().ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}
