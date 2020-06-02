using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APK.DESKTOP.MODEL;
using APK.DESKTOP.MODEL.Repositories;

namespace APK.DESKTOP.VIEW.Control
{
    public class oCliente : IDisposable
    {
        RepositoryCliente _Repository;
        public oCliente()
        {
            _Repository = new RepositoryCliente();
        }

        public void Incluir(CadastroCliente oCliente)
        {
            _Repository.Incluir(oCliente);
        }

        public CadastroCliente Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(CadastroCliente oCliente, bool attach = false)
        {
            _Repository.Alterar(oCliente, attach);
        }

        public void Excluir(CadastroCliente oCliente)
        {
            _Repository.Excluir(oCliente);
        }

        public List<CadastroCliente> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}

