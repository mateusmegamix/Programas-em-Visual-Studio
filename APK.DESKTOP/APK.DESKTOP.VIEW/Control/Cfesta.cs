using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APK.DESKTOP.MODEL;
using APK.DESKTOP.MODEL.Repositories;

namespace APK.DESKTOP.VIEW.Control
{
    public class Cfesta : IDisposable
    {
        RepositoryFesta _Repository;
        public Cfesta()
        {
            _Repository = new RepositoryFesta();
        }

        public void Incluir(CadastroFesta oFesta)
        {
            _Repository.Incluir(oFesta);
        }

        public CadastroFesta Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(CadastroFesta oFesta, bool attach = false)
        {
            _Repository.Alterar(oFesta, attach);
        }

        public void Excluir(CadastroFesta oFesta)
        {
            _Repository.Excluir(oFesta);
        }

        public List<CadastroFesta> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}

