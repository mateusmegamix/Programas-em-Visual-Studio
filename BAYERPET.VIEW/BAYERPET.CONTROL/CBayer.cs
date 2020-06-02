using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAYERPET.MODEL;

namespace BAYERPET.CONTROL
{
    public class CBayer
    {
        public CBayer()
        { }
        public List<Cliente> SelecionarCliente()
        {
            return Cliente.SelecionarTodos();
        }
        public List<Pet> SelecionarPet()
        {
            return Pet.SelecionarTodos();
        }
        public List<Funcionario> SelecionarFuncionario()
        {
            return Funcionario.SelecionarTodos();
        }
        public Cliente SelecionarCliente(int  Clicodigo)
        {
            return Cliente.Selecionar(Clicodigo);
        }

        public Pet SelecionarPet(int Pcodigo)
        {
            return Pet.Selecionar(Pcodigo);
        }
    }
}


