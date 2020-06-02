using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Runtime.InteropServices.ComTypes;

namespace BAYERPET.MODEL
{
    public class Cliente
    {

        //string Json = "{"Clicodigo":123,"Clinome":mateus pereira," CliCPF ":12395677744,"CliRG ":123456789,"Cliidade":25,"Clisexo":M,"Clitelefone":99999999,"Cliendereço":rua:42 casa:8,"Clicidade":Porto Real,"Clibairro":Freitas Soares}"; 

        //MemoryStream stream = new MemoryStream(json);
        //DataContractJsonSerializer serializer;
        //serializer = new DataContractJsonSerializer(typeof(Cliente));

        //Cliente fake = (Cliente)serializer.ReadObject(Stream);



        public int Clicodigo
        { get; set; }

        public string Clinome
        { get; set; }

        public string CliCPF
        { get; set; }

        public string CliRG // RG do cliente o cli serve para demonstrar q pertence ao cliente 
        { get; set; }

        public string Cliidade
        { get; set; }

        public string Clisexo
        { get; set; }

        public string Clitelefone
        { get; set; }

        public string Cliendereço
        { get; set; }

        public string Clicidade
        { get; set; }

        public string Clibairro
        { get; set; }

        public DateTime Clidatacadastro
        { get; set; }

        Cliente fake = new Cliente
        {
            Clicodigo = 123,
            Clinome = "mateus pereira",
            CliCPF = "12395677744",
            CliRG = "123456789",
            Cliidade = "25",
            Clisexo = "M",
            Clitelefone = "99999999",
            Cliendereço = "rua:42 casa:8",
            Clicidade = "Porto Real",
            Clibairro = "Freitas Soares",




        };
        MemoryStream stream = new MemoryStream();
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Cliente));

        serializer.WriteObject(stream, fake);  

        string json = return Encoding.Default.GetString(stream.ToArray());
    

            string Json = "{"Clicodigo":123,"Clinome":mateus pereira," CliCPF ":12395677744,"CliRG ":123456789,"Cliidade":25,"Clisexo":M,"Clitelefone":99999999,"Cliendereço":rua:42 casa:8,"Clicidade":Porto Real,"Clibairro":Freitas Soares}"; 

        MemoryStream stream = new MemoryStream(json);
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Cliente));
        serializer = new DataContractJsonSerializer(typeof(Cliente));
        Cliente fake = (Cliente)serializer.ReadObject(Stream);

   

        //....................................................................
        public Cliente _Cliente = null;
        public Cliente ClienteDoBayer
        {
            get
            {
                if (_Cliente == null)
                {
                    CarregaCliente();
                }
                return _Cliente;
            }
        }
        //................................................................
        private void CarregaCliente()
        {
            _Cliente = Cliente.Selecionar(Clicodigo);
        }
        //...................................................................
        

        public static Cliente Selecionar(int Clicodigo)
        {
            return (from p in MyGlobal.ListaCliente where p.Clicodigo == Clicodigo select p).FirstOrDefault();
            }

   

        public static List<Cliente> SelecionarTodos()
        {
            return (from p in MyGlobal.ListaCliente orderby p.Clicodigo select p).ToList();
        }

        public void Incluir()
        {
            MyGlobal.ListaCliente.Add(this);
        }

        public void Excluir()
        {
            Cliente oClienteExcluir = (from p in MyGlobal.ListaCliente where p.Clicodigo == this.Clicodigo select p).FirstOrDefault();
            if (oClienteExcluir == null)
            {
                throw new Exception("O Cliente não existe para ser excluido");
            }
            MyGlobal.ListaCliente.Remove(oClienteExcluir);
        }

        public void Alterar()
        {
            //Cliente oClienteAlterar = (from p in MyGlobal.ListaCliente where p.Clicodigo == this.Clicodigo select p).FirstOrDefault();
            //if (oClienteAlterar == null)
            //{
            //    throw new Exception("O Cliente não existe para ser alterado");
            //}
            //MyGlobal.ListaCliente.Remove(oClienteAlterar);
            //MyGlobal.ListaCliente.Add(oClienteAlterar);


            bool Achou = false;
            foreach (Cliente oCliente in MyGlobal.ListaCliente)
            {
                if (oCliente.Clicodigo == this.Clicodigo)
                {
                    oCliente.Clicodigo = this.Clicodigo;
                    oCliente.Clinome = this.Clinome;
                    oCliente.CliCPF = this.CliCPF;
                    oCliente.CliRG = this.CliRG;
                    oCliente.Cliidade = this.Cliidade;
                    oCliente.Clitelefone = this.Clitelefone;
                    oCliente.Cliendereço = this.Cliendereço;
                    oCliente.Clicidade = this.Clicidade;
                    oCliente.Clibairro = this.Clibairro;
                    oCliente.Clisexo = Clisexo;
                    Achou = true;
                    return;
                }
            }

            if (Achou == false)
            {
                throw new Exception("O Cliente não existe para ser alterado");
            }
        }
      


    }

}
