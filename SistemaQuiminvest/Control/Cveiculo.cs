using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaQuiminvest.Model;
using SistemaQuiminvest.Model.Repositories;

namespace SistemaQuiminvest.Control
{
    public class oVeiculo : IDisposable
    {
        RepositoryEntradaSaida _Repository;
        RepositoryFuncionarios _RepositorieFuncionario;
        public oVeiculo()
        {
            _Repository = new RepositoryEntradaSaida();
            _RepositorieFuncionario = new RepositoryFuncionarios();
        }

        public void Incluir(EntradaSaida oVeiculo)
        {
            _Repository.Incluir(oVeiculo);
        }

        public EntradaSaida Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(EntradaSaida oVeiculo, bool attach = false)
        {
            _Repository.Alterar(oVeiculo, attach);
        }

        public void Excluir(EntradaSaida oVeiculo)
        {
            _Repository.Excluir(oVeiculo);
        }

        public List<EntradaSaida> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

        public List<funcionario> SelecionarTodosFuncionarios()
        {
            return _RepositorieFuncionario.SelecionarTodos();
        }

    }
}
