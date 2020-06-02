using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManutencaoQuiminvest.Model;
using ManutencaoQuiminvest.Model.Repositories;

namespace ManutencaoQuiminvest.Control
{
    public class oProduto : IDisposable
    {
        RepositoryProduto _Repository;
        public oProduto()
        {
            _Repository = new RepositoryProduto();
        }

        public void Incluir(Produto oProduto)
        {
            _Repository.Incluir(oProduto);
        }

        public Produto Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(Produto oProduto, bool attach = false)
        {
            _Repository.Alterar(oProduto, attach);
        }

        public void Excluir(Produto oProduto)
        {
            _Repository.Excluir(oProduto);
        }

        public List<Produto> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }


        public void Dispose()
        {
            _Repository.Dispose();
        }
        //====================================================
        //public Produto SelecionarProdutoNome(string Nome)
        //{
        //    return _Repository.SelecionarProdutoNome(Nome);
        //}
        //====================================================
    }
}
