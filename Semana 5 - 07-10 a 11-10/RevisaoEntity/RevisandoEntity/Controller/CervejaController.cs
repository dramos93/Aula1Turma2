using RevisandoEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Controller
{
    // 1 Deixar como public
    // 

    public class CervejaController
    {
        //Iniciamos nossa base de dados na Controller
        CervejaContextDB contextDB = new CervejaContextDB();

        public void AddCerveja(Cerveja item)
        {
            if(item.Nome.Contains("Cerveja")) //Aqui eu coloco uma condição que aceite apenas nomes que contenham Cerveja com C maiúsculo
            {
                contextDB.Cervejas.Add(item);
                contextDB.SaveChanges();
            }
        }

        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDB.Cervejas.Where(x => x.Nome.Contains("Cerveja"));
        }

    }
}
