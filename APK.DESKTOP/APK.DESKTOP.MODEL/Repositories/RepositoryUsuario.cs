using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APK.DESKTOP.MODEL.Repositories
{
   public class RepositoryUsuario : IDisposable
    {
        private tccEntities odb;
        private bool LiberaContexto = false;

        public RepositoryUsuario()
        {
            odb = Helper.Data.getContexto();
        }
        public RepositoryUsuario(tccEntities _odb)
        {
            odb = _odb;
        }

        public CadastroUsuario Selecionar (string Codigo)
        {
            return (from p in odb.CadastroUsuario where p.NomeUsuario == Codigo select p).FirstOrDefault();
        }

        public List<CadastroUsuario> SelecionarTodos()

        {
            return (from p in odb.CadastroUsuario orderby p.CodigoUsuario select p).ToList();
        }

        public void Alterar(CadastroUsuario oCadastroUsuario, bool attach = false)
        {
            if (attach)
            {
                odb.Entry(oCadastroUsuario).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Incluir (CadastroUsuario oCadastroUsuario)
        {
            //odb.Entry(oCadastroUsuario).State = System.Data.Entity.EntityState.Added;
            odb.CadastroUsuario.Add(oCadastroUsuario);
            odb.SaveChanges();
        }

        public void Excluir (CadastroUsuario oCadastroUsuario)
        {
            odb.CadastroUsuario.Remove(oCadastroUsuario);
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

