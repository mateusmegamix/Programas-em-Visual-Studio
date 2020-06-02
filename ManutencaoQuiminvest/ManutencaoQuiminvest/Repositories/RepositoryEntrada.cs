using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutencaoQuiminvest.Model.Repositories
{
    public class RepositoryEntrada : IDisposable
    {
        private ManutencaoEntities odb;
        private bool LiberaContexto = false;

        public RepositoryEntrada()
        {
            odb = Helper.Data.getContexto();
        }

        public RepositoryEntrada(ManutencaoEntities _odb)
        {
            odb = _odb;
        }

        public Entrada Selecionar(string Codigo)
        {
            return (from p in odb.Entrada where p.Produto == Codigo select p).FirstOrDefault();
        }

        public List<Entrada> SelecionarTodos()

        {
            return (from p in odb.Entrada orderby p.Id select p).ToList();
        }

        public void Incluir(Entrada oProduto)
        {
            odb.Entrada.Add(oProduto);
            odb.SaveChanges();
        }

        public void Alterar(Entrada oProduto, bool attach = false)
        {
            var local = odb.Set<Entrada>().Local.FirstOrDefault(p => p.Id == oProduto.Id);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oProduto).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
        public void Excluir(Entrada oProduto)
        {
            odb.Entrada.Remove(oProduto);
            //odb.Entry(oCadastroUsuario).State = System.Data.Entity.EntityState.Deleted;

            odb.SaveChanges();
        }

        //====================================================
        public Entrada SelecionarProdutoNome(string Nome)
        {
            return odb.Entrada.Where(p => p.Produto.Equals(Nome)).FirstOrDefault();
        }
        //====================================================

        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }
    }
}
