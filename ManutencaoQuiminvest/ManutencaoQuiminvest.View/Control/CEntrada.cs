using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManutencaoQuiminvest.Model;
using ManutencaoQuiminvest.Model.Repositories;


namespace ManutencaoQuiminvest.Control
{
    public class oEntrada : IDisposable
    {
        RepositoryEntrada _Repository;
        RepositoryProduto _RepositoryProduto;
        public oEntrada()
        {
            _Repository = new RepositoryEntrada();
            _RepositoryProduto = new RepositoryProduto();
        }

        public void Incluir(Entrada oProduto)
        {
            _Repository.Incluir(oProduto);
        }

        public Entrada Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(Entrada oProduto, bool attach = false)
        {
            _Repository.Alterar(oProduto, attach);
        }

        public void Excluir(Entrada oProduto)
        {
            _Repository.Excluir(oProduto);
        }

        public List<Entrada> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

        public List<Produto> SelecionarTodosProdutos()
        {
            return _RepositoryProduto.SelecionarTodos();
        }

        //====================================================
        public Produto SelecionarProdutoNome(string Nome)
        {
            return _RepositoryProduto.SelecionarProdutoNome(Nome);
        }
        //====================================================
    }
}
