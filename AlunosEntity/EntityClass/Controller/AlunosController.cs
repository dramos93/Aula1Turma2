using EntityClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Controller
{

    public class AlunosController
    {
        EntityAlunosContext context = new EntityAlunosContext();
        public IQueryable<Aluno> GetAlunos()
        {
            //Retorna os alunos dentro do sistema
            return context.Alunos;
        }
        public void AddAluno(Aluno item)
        {
            context.Alunos.Add(item);
            context.SaveChanges();
        }
    }
}
