using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutencaoQuiminvest.Model.Repositories
{
    public class RepositoryProduto : IDisposable
    {
        private ManutencaoEntities odb;
        private bool LiberaContexto = false;

        public RepositoryProduto()
        {
            odb = Model.Helper.Data.getContexto();
        }

        public RepositoryProduto(ManutencaoEntities _odb)
        {
            odb = _odb;
        }

        public Produto Selecionar(string Codigo)
        {
            return (from p in odb.Produto where p.Produtos == Codigo select p).FirstOrDefault();
        }

        public List<Produto> SelecionarTodos()

        {
            return (from p in odb.Produto orderby p.Id select p).ToList();
        }

        public void Incluir(Produto oProduto)
        {
            odb.Produto.Add(oProduto);
            odb.SaveChanges();
        }

        public void Alterar(Produto oProduto, bool attach = false)
        {
            var local = odb.Set<Produto>().Local.FirstOrDefault(p => p.Id == oProduto.Id);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oProduto).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }
        public void Excluir(Produto oProduto)
        {
            odb.Produto.Remove(oProduto);
            //odb.Entry(oCadastroUsuario).State = System.Data.Entity.EntityState.Deleted;

            odb.SaveChanges();
        }
        //====================================================
        public Produto SelecionarProdutoNome(string Nome)
        {
            return odb.Produto.Where(p => p.Produtos.Equals(Nome)).FirstOrDefault();
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
