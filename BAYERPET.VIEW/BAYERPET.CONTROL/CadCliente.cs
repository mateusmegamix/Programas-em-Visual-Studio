using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAYERPET.MODEL;

namespace BAYERPET.CONTROL
{
    public class CadCliente
    {
    
        public Cliente SelecionarCliente(int Clicodigo)
        {
            return Cliente.Selecionar(Clicodigo);
        }
        public void IncluirCliente(Cliente oCliente)
        {
            oCliente.Incluir();
        }

        public void ExcluirCliente(Cliente oCliente)
        {
            oCliente.Excluir();
        }

        public void AlterarCliente(Cliente oCliente)
        {
            oCliente.Alterar();
        }



    }
}
