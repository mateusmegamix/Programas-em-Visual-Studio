using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaQuiminvest.Model.Repositories
{
    public class RepositoryCtrlNotas : IDisposable
    {
        private reatorEntities odb;
        private bool LiberaContexto = false;

        public RepositoryCtrlNotas()
        {
            odb = Helper.Data.getContexto();
        }
        public RepositoryCtrlNotas(reatorEntities _odb)
        {
            odb = _odb;
        }


        public CtrlNotasFiscais Selecionar(string Codigo)
        {
            return (from p in odb.CtrlNotasFiscais where p.NumeroNF == Codigo select p).FirstOrDefault();
        }

        public List<CtrlNotasFiscais> SelecionarTodos()

        {
            return (from p in odb.CtrlNotasFiscais orderby p.Id select p).ToList();
        }

        public void Incluir(CtrlNotasFiscais oCtrlNotasFiscais)
        {
            odb.CtrlNotasFiscais.Add(oCtrlNotasFiscais);
            odb.SaveChanges();
        }

        public void Alterar(CtrlNotasFiscais oCtrlNotasFiscais, bool attach = false)
        {
            var local = odb.Set<CtrlNotasFiscais>().Local.FirstOrDefault(p => p.Id == oCtrlNotasFiscais.Id);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oCtrlNotasFiscais).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
        public void Excluir(CtrlNotasFiscais oCtrlNotasFiscais)
        {
            odb.CtrlNotasFiscais.Remove(oCtrlNotasFiscais);
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

