using ClassAlunos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAlunos.Controller
{
    public class AlunosController
    {
        AlunosContext ContextDB = new AlunosContext();

        public IQueryable<Alunos> GetAlunos()
        {
            return ContextDB.ListaAlunos;
        }
        public void AddPessoa(Alunos item)
        {

            ContextDB.ListaAlunos.Add(item);
            ContextDB.SaveChanges();
        }
    }
}
