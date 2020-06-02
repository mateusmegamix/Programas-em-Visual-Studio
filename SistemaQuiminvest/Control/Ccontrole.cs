using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaQuiminvest.Model;
using SistemaQuiminvest.Model.Repositories;

namespace SistemaQuiminvest.Control
{
    public class oControle : IDisposable
    {
        RepositoryControle _Repository;
        public oControle()
        {
            _Repository = new RepositoryControle();
        }

        public void Incluir(controle oControle)
        {
            _Repository.Incluir(oControle);
        }

        public controle Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(controle oControle, bool attach = false)
        {
            _Repository.Alterar(oControle, attach);
        }

        public void Excluir(controle oControle)
        {
            _Repository.Excluir(oControle);
        }

        public List<controle> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}