using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReatorModel.Repositories;
using ReatorModel;

namespace QuiminVestReator.Control
{
    public class oVeiculo : IDisposable
    {
        Repositoryveiculo _Repository;

        public oVeiculo()
        {
            _Repository = new Repositoryveiculo();
        }

        public void Incluir(ReatorModel.EntradaSaida oVeiculo)
        {
            _Repository.Incluir(oVeiculo);
        }

        public ReatorModel.EntradaSaida Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(ReatorModel.EntradaSaida oVeiculo, bool attach = false)
        {
            _Repository.Alterar(oVeiculo, attach);
        }

        public void Excluir(ReatorModel.EntradaSaida oVeiculo)
        {
            _Repository.Excluir(oVeiculo);
        }

        public List<ReatorModel.EntradaSaida> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}