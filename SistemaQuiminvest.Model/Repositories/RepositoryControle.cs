using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaQuiminvest.Model.Repositories
{
    public class RepositoryControle : IDisposable
    {
        private reatorEntities odb;
        private bool LiberaContexto = false;

        public RepositoryControle()
        {
            odb = Helper.Data.getContexto();
        }
        public RepositoryControle(reatorEntities _odb)
        {
            odb = _odb;
        }


        public controle Selecionar(string Codigo)
        {
            return (from p in odb.controle where p.Etapa == Codigo select p).FirstOrDefault();
        }

        public List<controle> SelecionarTodos()

        {
            return (from p in odb.controle orderby p.Id select p).ToList();
        }

        public void Incluir(controle oControle)
        {
            odb.controle.Add(oControle);
            odb.SaveChanges();
        }

        public void Alterar(controle oControle, bool attach = false)
        {
            var local = odb.Set<controle>().Local.FirstOrDefault(p => p.Id == oControle.Id);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oControle).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
        public void Excluir(controle oControle)
        {
            odb.controle.Remove(oControle);
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
