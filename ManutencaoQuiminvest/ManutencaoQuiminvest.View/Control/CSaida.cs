using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManutencaoQuiminvest.Model;
using ManutencaoQuiminvest.Model.Repositories;

namespace ManutencaoQuiminvest.Control
{
    public class oSaida : IDisposable
    {
        RepositorySaida _Repository;
        RepositoryEntrada _RepositoryEntrada;
        public oSaida()
        {
            _Repository = new RepositorySaida();
            _RepositoryEntrada = new RepositoryEntrada();
        }

        public void Incluir(Saida oProduto)
        {
            _Repository.Incluir(oProduto);
        }

        public Saida Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(Saida oProduto, bool attach = false)
        {
            _Repository.Alterar(oProduto, attach);
        }

        public void Excluir(Saida oProduto)
        {
            _Repository.Excluir(oProduto);
        }

        public List<Saida> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

        public List<Entrada> SelecionarTodosProdutos()
        {
            return _RepositoryEntrada.SelecionarTodos();
        }

        //====================================================
        public Entrada SelecionarProdutoNome(string Nome)
        {
            return _RepositoryEntrada.SelecionarProdutoNome(Nome);
        }
        //====================================================
    }
}
