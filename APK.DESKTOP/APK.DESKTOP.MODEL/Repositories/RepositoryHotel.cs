using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APK.DESKTOP.MODEL.Repositories
{
    public class RepositoryHotel
    {
        private tccEntities odb;
        private bool LiberaContexto = false;

        public RepositoryHotel()
        {
            odb = Helper.Data.getContexto();
        }
        public RepositoryHotel(tccEntities _odb)
        {
            odb = _odb;
        }

        public CadastroHotel Selecionar(string Codigo)
        {
            return (from p in odb.CadastroHotel where p.Categoria == Codigo select p).FirstOrDefault();
        }

        public List<CadastroHotel> SelecionarTodos()

        {
            return (from p in odb.CadastroHotel orderby p.CodigoHotel select p).ToList();
        }

        public void Incluir(CadastroHotel oHotel)
        {
            //odb.Entry(oCadastroUsuario).State = System.Data.Entity.EntityState.Added;
            odb.CadastroHotel.Add(oHotel);
            odb.SaveChanges();
        }

        public void Alterar(CadastroHotel oCadastroHotel, bool attach = false)
        {
            if (attach)
            {
                odb.Entry(oCadastroHotel).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(CadastroHotel oCadastroHotel)
        {
            odb.CadastroHotel.Remove(oCadastroHotel);
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

