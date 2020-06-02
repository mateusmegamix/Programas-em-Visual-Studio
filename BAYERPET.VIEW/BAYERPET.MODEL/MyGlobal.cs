using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYERPET.MODEL
{
    public static class MyGlobal
    {
        private static List<Cliente> _ListaCliente = new List<Cliente>();
        public static List<Cliente> ListaCliente
        {
            get { return _ListaCliente; }
            set { _ListaCliente = value; }
        }
        private static List<Pet> _ListaPet = new List<Pet>();

        public static List<Pet> ListaPet
        {
           get { return _ListaPet; }
           set { _ListaPet = value;  }
        }
        private static List<Funcionario> _ListaFuncionario = new List<Funcionario>();

        public static List<Funcionario> ListaFuncionario
        {
            get { return _ListaFuncionario; }
            set { _ListaFuncionario = value; }
        }
    }
}
