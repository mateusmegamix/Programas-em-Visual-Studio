using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AEDB.LOCADORA.MODEL;
using AEDB.LOCADORA.MODEL.Repositories;

namespace AEDB.LOCADORA.VIEW.Control
{
    public class CFuncionario
    {
        RepositoryFuncionario _Repository;

        public CFuncionario()
        {
            _Repository = new RepositoryFuncionario();
        }

        public void Incluir(Funcionario oFuncionario)
        {
            _Repository.Incluir(oFuncionario);
        }

        public void Alterar(Funcionario oFuncionario)
        {
            _Repository.Alterar(oFuncionario);
        }

        public void Excluir(Funcionario oFuncionario)
        {
            _Repository.Excluir(oFuncionario);
        }

        public List<Funcionario> SelecionarTodos()
        {
           return _Repository.SelecionarTodos();
        }
    }
}
