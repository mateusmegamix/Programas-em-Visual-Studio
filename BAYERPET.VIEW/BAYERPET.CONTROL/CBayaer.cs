using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAYERPET.MODEL;
using BAYERPET.CONTROL;

namespace BAYERPET.CONTROL
{
    public class CBayaer
    {
        public CBayer()
        { }
        public List<Cliente> SelecionarCliente()
        {
            return Cliente.SelecionarTodos();
        }
    }
}
