using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APK.DESKTOP.MODEL.Repositories
{
    public class RepositoryFesta
    {
        private tccEntities odb;
        private bool LiberaContexto = false;
        public RepositoryFesta()
        {
            odb = Helper.Data.getContexto();
        }
        public RepositoryFesta(tccEntities _odb)
        {
            odb = _odb;
        }


        public CadastroFesta Selecionar(string Codigo)
        {
            return (from p in odb.CadastroFesta where p.DescricaoEvento == Codigo select p).FirstOrDefault();
        }

        public List<CadastroFesta> SelecionarTodos()

        {
            return (from p in odb.CadastroFesta orderby p.CodigoFesta select p).ToList();
        }

        public void Incluir(CadastroFesta oCadastroFesta)
        {
            //odb.Entry(oCadastroUsuario).State = System.Data.Entity.EntityState.Added;
            odb.CadastroFesta.Add(oCadastroFesta);
            odb.SaveChanges();
        }

        public void Alterar(CadastroFesta oCadastroFesta, bool attach = false)
        {
            if (attach)
            {
                odb.Entry(oCadastroFesta).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(CadastroFesta oCadastroFesta)
        {
            odb.CadastroFesta.Remove(oCadastroFesta);
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

