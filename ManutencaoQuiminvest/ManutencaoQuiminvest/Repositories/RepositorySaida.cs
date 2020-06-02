using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutencaoQuiminvest.Model.Repositories
{
    public class RepositorySaida : IDisposable
    {
        private ManutencaoEntities odb;
        private bool LiberaContexto = false;

        public RepositorySaida()
        {
            odb = Helper.Data.getContexto();
        }

        public RepositorySaida(ManutencaoEntities _odb)
        {
            odb = _odb;
        }

        public Saida Selecionar(string Codigo)
        {
            return (from p in odb.Saida where p.Produto == Codigo select p).FirstOrDefault();
        }

        public List<Saida> SelecionarTodos()

        {
            return (from p in odb.Saida orderby p.Id select p).ToList();
        }

        public void Incluir(Saida oProduto)
        {
            odb.Saida.Add(oProduto);
            odb.SaveChanges();
        }

        public void Alterar(Saida oProduto, bool attach = false)
        {
            var local = odb.Set<Saida>().Local.FirstOrDefault(p => p.Id == oProduto.Id);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oProduto).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
        public void Excluir(Saida oProduto)
        {
            odb.Saida.Remove(oProduto);
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
