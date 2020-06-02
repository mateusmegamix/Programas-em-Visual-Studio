using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APK.DESKTOP.MODEL;
using APK.DESKTOP.MODEL.Repositories;

namespace APK.DESKTOP.VIEW.Control
{
    public class CJogo : IDisposable
    {
        RepositoryJogo _Repository;
        public CJogo()
        {
            _Repository = new RepositoryJogo();
        }

        public void Incluir(CadastroJogo oJogo)
        {
            _Repository.Incluir(oJogo);
        }

        public CadastroJogo Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(CadastroJogo oJogo, bool attach = false)
        {
            _Repository.Alterar(oJogo, attach);
        }

        public void Excluir(CadastroJogo oJogo)
        {
            _Repository.Excluir(oJogo);
        }

        public List<CadastroJogo> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}