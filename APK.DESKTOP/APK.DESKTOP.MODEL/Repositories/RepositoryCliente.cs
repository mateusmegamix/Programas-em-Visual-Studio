using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APK.DESKTOP.MODEL.Repositories
{
    public class RepositoryCliente: IDisposable
    {
        private tccEntities odb;
        private bool LiberaContexto = false;

        public RepositoryCliente()
        {
            odb = Helper.Data.getContexto();
        }
        public RepositoryCliente (tccEntities _odb)
        {
            odb = _odb;
        }


        public CadastroCliente Selecionar(string Codigo)
        {
            return (from p in odb.CadastroCliente where p.TipoEvento == Codigo select p).FirstOrDefault();
        }

        public List<CadastroCliente> SelecionarTodos()

        {
            return (from p in odb.CadastroCliente orderby p.CodigoCliente select p).ToList();
        }

        public void Incluir(CadastroCliente oCadastroCliente)
        {
            odb.CadastroCliente.Add(oCadastroCliente);
            odb.SaveChanges();
        }

        public void Alterar(CadastroCliente oCadastroCliente, bool attach = false)
        {
         if (attach)
            {
                odb.Entry(oCadastroCliente).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }
public void Excluir(CadastroCliente oCadastroCliente)
        {
            odb.CadastroCliente.Remove(oCadastroCliente);
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

