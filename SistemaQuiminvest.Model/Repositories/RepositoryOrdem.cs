using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaQuiminvest.Model.Repositories
{
    public class RepositoryOrdem  : IDisposable
    {
        private reatorEntities odb;
        private bool LiberaContexto = false;

        public RepositoryOrdem()
        {
            odb = Helper.Data.getContexto();
        }
        public RepositoryOrdem(reatorEntities _odb)
        {
            odb = _odb;
        }


        public OrdemP Selecionar(string Codigo)
        {
            return (from p in odb.OrdemPSet where p.ProdutoOP == Codigo select p).FirstOrDefault();
        }

        public List<OrdemP> SelecionarTodos()

        {
            return (from p in odb.OrdemPSet orderby p.Id select p).ToList();
        }

        public void Incluir(OrdemP oOrdemP)
        {
            odb.OrdemPSet.Add(oOrdemP);
            odb.SaveChanges();
        }

        public void Alterar(OrdemP oOrdemP, bool attach = false)
        {
            var local = odb.Set<OrdemP>().Local.FirstOrDefault(p => p.Id == oOrdemP.Id);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oOrdemP).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
        public void Excluir(OrdemP oOrdemP)
        {
            odb.OrdemPSet.Remove(oOrdemP);
            //odb.Entry(oCadastroUsuario).State = System.Data.Entity.EntityState.Deleted;

            odb.SaveChanges();
        }

        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }
    }
}
