using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaQuiminvest.Model;
using SistemaQuiminvest.Model.Repositories;

namespace SistemaQuiminvest.Control
{
    public class oCordem : IDisposable
    {
        RepositoryOrdem _Repository;
        public oCordem()
        {
            _Repository = new RepositoryOrdem();
        }

        public void Incluir(OrdemP oOrdemP)
        {
            _Repository.Incluir(oOrdemP);
        }

        public OrdemP Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(OrdemP oOrdemP, bool attach = false)
        {
            _Repository.Alterar(oOrdemP, attach);
        }

        public void Excluir(OrdemP oOrdemP)
        {
            _Repository.Excluir(oOrdemP);
        }

        public List<OrdemP> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
