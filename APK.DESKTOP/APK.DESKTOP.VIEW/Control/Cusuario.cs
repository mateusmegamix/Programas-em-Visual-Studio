using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APK.DESKTOP.MODEL;
using APK.DESKTOP.MODEL.Repositories;

namespace APK.DESKTOP.VIEW.Control
{
    public class Cusuario : IDisposable
    {
        RepositoryUsuario _Repository;
        public Cusuario()
        {
            _Repository = new RepositoryUsuario();
        }

        public void Incluir(CadastroUsuario oUsuario)
        {
            _Repository.Incluir(oUsuario);
        }

        public CadastroUsuario Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(CadastroUsuario oUsuario, bool attach = false)
        {
            _Repository.Alterar(oUsuario, attach);
        }

        public void Excluir(CadastroUsuario oUsuario)
        {
            _Repository.Excluir(oUsuario);
        }

        public List<CadastroUsuario> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}

