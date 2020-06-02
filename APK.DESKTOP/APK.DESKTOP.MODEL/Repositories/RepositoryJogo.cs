using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APK.DESKTOP.MODEL.Repositories
{
   public class RepositoryJogo
    {
        private tccEntities odb;
        private bool LiberaContexto = false;

        public RepositoryJogo()
        {
            odb = Helper.Data.getContexto();
        }
        public RepositoryJogo(tccEntities _odb)
        {
            odb = _odb;
        }

        public CadastroJogo Selecionar(string Codigo)
        {
            return (from p in odb.CadastroJogo where p.AddMembrosj == Codigo select p).FirstOrDefault();
        }

        public List<CadastroJogo> SelecionarTodos()

        {
            return (from p in odb.CadastroJogo orderby p.CodigoJogo select p).ToList();
        }

        public void Incluir(CadastroJogo oCadastroJogo)
        {
            //odb.Entry(oCadastroUsuario).State = System.Data.Entity.EntityState.Added;
            odb.CadastroJogo.Add(oCadastroJogo);
            odb.SaveChanges();
        }

        public void Alterar(CadastroJogo oCadastroJogo, bool attach = false)
        {
            if (attach)
            {
                odb.Entry(oCadastroJogo).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(CadastroJogo oCadastroJogo)
        {
            odb.CadastroJogo.Remove(oCadastroJogo);
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

