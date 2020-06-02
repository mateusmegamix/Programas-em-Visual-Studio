using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaQuiminvest.Model.Repositories
{
    public class RepositoryEntradaSaida : IDisposable
    {
        private reatorEntities odb;
        private bool LiberaContexto = false;

        public RepositoryEntradaSaida()
        {
            odb = Helper.Data.getContexto();
        }
        public RepositoryEntradaSaida(reatorEntities _odb)
        {
            odb = _odb;
        }


        public EntradaSaida Selecionar(string Codigo)
        {
            return (from p in odb.EntradaSaida where p.Destino == Codigo select p).FirstOrDefault();
        }

        public List<EntradaSaida> SelecionarTodos()

        {
            return (from p in odb.EntradaSaida orderby p.Id select p).ToList();
        }

        public void Incluir(EntradaSaida oEntradaSaida)
        {
            odb.EntradaSaida.Add(oEntradaSaida);
            odb.SaveChanges();
        }

        public void Alterar(EntradaSaida oEntradaSaida, bool attach = false)
        {
            var local = odb.Set<EntradaSaida>().Local.FirstOrDefault(p => p.Id == oEntradaSaida.Id);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oEntradaSaida).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
        public void Excluir(EntradaSaida oEntradaSaida)
        {
            odb.EntradaSaida.Remove(oEntradaSaida);
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
