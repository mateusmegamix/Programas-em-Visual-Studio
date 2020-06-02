using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAYERPET.MODEL;

namespace BAYERPET.CONTROL
{
    public class CadFuncionario
    {
        public Funcionario SelecionarFuncionario(int Fcodigo)
        {
            return Funcionario.Selecionar(Fcodigo);
        }
        public void IncluirFuncionario(Funcionario oFuncionario)
        {
            oFuncionario.Incluir();
        }

        public void ExcluirFuncionario(Funcionario oFuncionario)
        {
            oFuncionario.Excluir();
        }

        public void AlterarFuncionario(Funcionario oFuncionario)
        {
            oFuncionario.Alterar();
        }
    }
}
