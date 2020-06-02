using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAYERPET.MODEL;

namespace BAYERPET.CONTROL
{
    public class CadAnimal
    {
        public Pet SelecionarPet(int Pcodigo)
            {
            return Pet.Selecionar( Pcodigo);
            }
        public void IncluirPet(Pet oPet)
        {
            oPet.Incluir();
        }
        public Cliente SelecionarCliente(int Clicodigo)
        {
            return Cliente.Selecionar(Clicodigo);
        }
        public List<Cliente> TodosClientes()
        {
            return Cliente.SelecionarTodos();
        }

        public void ExcluirPet(Pet oPet)
        {
            oPet.Excluir();
        }

        public void AlterarPet(Pet oPet)
        {

        }
    }
}
