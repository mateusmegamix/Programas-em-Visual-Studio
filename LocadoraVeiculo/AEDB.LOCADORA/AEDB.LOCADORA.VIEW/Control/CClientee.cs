using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AEDB.LOCADORA.MODEL;
using AEDB.LOCADORA.MODEL.Repositories;

namespace AEDB.LOCADORA.VIEW.Control
{
   public class CClientee
    {
        RepositoryClientee _Repository;
        public CClientee()
        {
            _Repository = new RepositoryClientee();
        }

        public void Incluir(Clientee oClientee)
        {
            _Repository.Incluir(oClientee);
        }

        public void Alterar (Clientee oClientee)
        {
            _Repository.Alterar(oClientee);
        }

        public void Excluir (Clientee oClientee)
        {
            _Repository.Excluir(oClientee);
        }

        public List<Clientee> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

    }
}
