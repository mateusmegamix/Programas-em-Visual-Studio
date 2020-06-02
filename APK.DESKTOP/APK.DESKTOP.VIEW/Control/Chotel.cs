using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APK.DESKTOP.MODEL;
using APK.DESKTOP.MODEL.Repositories;

namespace APK.DESKTOP.VIEW.Control
{
    public class Chotel : IDisposable
    {
        RepositoryHotel _Repository;
        public Chotel()
        {
            _Repository = new RepositoryHotel();
        }

        public void Incluir(CadastroHotel oHotel)
        {
            _Repository.Incluir(oHotel);
        }

        public CadastroHotel Selecionar(string Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }

        public void Alterar(CadastroHotel oHotel, bool attach = false)
        {
            _Repository.Alterar(oHotel, attach);
        }

        public void Excluir(CadastroHotel oHotel)
        {
            _Repository.Excluir(oHotel);
        }

        public List<CadastroHotel> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}

