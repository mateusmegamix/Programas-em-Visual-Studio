using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AEDB.LOCADORA.MODEL;
namespace AEDB.LOCADORA.MODEL.Repositories
{
    public class RepositoryClientee
    {
        private danielgomesEntities odb;

        public RepositoryClientee()
        {
            odb = Helper.Data.getContexto();
        }

        public RepositoryClientee(danielgomesEntities _odb)
        {
            odb = _odb;
        }
        public Clientee Selecionar(int Codigo)
        {
            return (from p in odb.Clientee where p.CodCli == Codigo select p).FirstOrDefault();
        }

        public List<Clientee> SelecionarTodos()
        {
            return (from p in odb.Clientee orderby p.Nome select p).ToList();
        }

        public void Incluir(Clientee oClientee)
        {
            //odb.Entry(oClientee).State = System.Data.Entity.EntityState.Added;
            odb.Clientee.Add(oClientee);
            odb.SaveChanges();
        }

        public void Alterar(Clientee oClientee)
        {
            odb.Entry(oClientee).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void Excluir(Clientee oClientee)
        {
            odb.Entry(oClientee).State = System.Data.Entity.EntityState.Deleted;
            odb.SaveChanges();
        }
    }
}
