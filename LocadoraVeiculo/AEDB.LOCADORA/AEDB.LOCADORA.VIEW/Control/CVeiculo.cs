using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AEDB.LOCADORA.MODEL;
using AEDB.LOCADORA.MODEL.Repositories;

namespace AEDB.LOCADORA.VIEW.Control
{
   public class CVeiculo
    {
        RepositoryVeiculo _Repository;
        public CVeiculo()
        {
            _Repository = new RepositoryVeiculo();
        }

        public void Incluir(Veiculo oVeiculo)
        {
            _Repository.Incluir(oVeiculo);
        }

        public void Alterar(Veiculo oVeiculo)
        {
            _Repository.Alterar(oVeiculo);
        }

        public void Excluir(Veiculo oVeiculo)
        {
            _Repository.Excluir(oVeiculo);
        }

        public List<Veiculo> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

    }
}

