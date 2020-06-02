using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaQuiminvest.Model;
using SistemaQuiminvest.Model.Repositories;

namespace SistemaQuiminvest.Control
{
    public class oCtrlNotas : IDisposable
    {
        RepositoryCtrlNotas _Repository;
       
        public oCtrlNotas()
        {
            _Repository = new RepositoryCtrlNotas();
        }

        public void Incluir(CtrlNotasFiscais oCtrlNotasFiscais)
        {
            _Repository.Incluir(oCtrlNotasFiscais);
        }

        public CtrlNotasFiscais Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(CtrlNotasFiscais oCtrlNotasFiscais, bool attach = false)
        {
            _Repository.Alterar(oCtrlNotasFiscais, attach);
        }

        public void Excluir(CtrlNotasFiscais oCtrlNotasFiscais)
        {
            _Repository.Excluir(oCtrlNotasFiscais);
        }

        public List<CtrlNotasFiscais> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}
