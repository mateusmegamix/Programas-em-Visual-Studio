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
    public class Funcionario
    {
        public int Fcodigo
        { get; set; }

        public string Fnome
        { get; set; }

        public string FCPF
        { get; set; }

        public string FRG // RG do funcionario o cli serve para demonstrar q pertence ao funcionario 
        { get; set; }

        public string Fidade
        { get; set; }

        public string Fsexo
        { get; set; }

        public string Ftelefone
        { get; set; }

        public string Fendereço
        { get; set; }

        public string Fcidade
        { get; set; }

        public string Fbairro
        { get; set; }

        Funcionario fake = new Funcionario
        {
        Fcodigo = 123,
            Fnome = "mateus pereira",
            FCPF = "12395677744",
            FRG = "123456789",
            Fidade = "25",
            Fsexo = "M",
            Ftelefone = "99999999",
            Fendereço = "rua:42 casa:8",
            Fcidade = "Porto Real",
            Fbairro = "Freitas Soares",
        };



        MemoryStream stream = new MemoryStream();
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Funcionario);

        serializer.WriteObject(stream, fake);  

        string json = return Encoding.Default.GetString(stream.ToArray());
    

            string Json = "{"Fcodigo":1343,"Fnome":mateus pereira," FCPF ":12395677744,"FRG ":123456789,"Fidade":25,"Fsexo":M,"Ftelefone":99999999,"Fendereço":rua:42 casa:8,"Fcidade":Porto Real,"Fbairro":Freitas Soares}"; 

        MemoryStream stream = new MemoryStream(json);
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Funcionario));
        serializer = new DataContractJsonSerializer(typeof(Funcionario));
        Funcionario fake = (Funcionario)serializer.ReadObject(Stream);







        public static Funcionario Selecionar(int Fcodigo)
        {
            return (from p in MyGlobal.ListaFuncionario where p.Fcodigo == Fcodigo select p).FirstOrDefault();
        }

        public static List<Funcionario> SelecionarTodos()
        {
            return (from p in MyGlobal.ListaFuncionario orderby p.Fcodigo select p).ToList();
        }

        public void Incluir()
        {
            MyGlobal.ListaFuncionario.Add(this);
        }

        public void Excluir()
        {
            Funcionario oFuncionarioExcluir = (from p in MyGlobal.ListaFuncionario where p.Fcodigo == this.Fcodigo select p).FirstOrDefault();
            if (oFuncionarioExcluir == null)
            {
                throw new Exception("O Funcionario não existe para ser excluido");
            }
            MyGlobal.ListaFuncionario.Remove(oFuncionarioExcluir);
        }

        public void Alterar()
        {
            ////Funcionario oFuncionarioAlterar = (from p in MyGlobal.ListaFuncionario where p.Fcodigo == this.Fcodigo select p).FirstOrDefault();
            ////if (oFuncionarioAlterar == null)
            ////{
            ////    throw new Exception("O Funcionario não existe para ser alterado");
            ////}
            ////MyGlobal.ListaFuncionario.Remove(oFuncionarioAlterar);
            ////MyGlobal.ListaFuncionario.Add(oFuncionarioAlterar);

            bool Achou = false;
            foreach (Funcionario oFuncionario in MyGlobal.ListaFuncionario)
            {
                if (oFuncionario.Fcodigo == this.Fcodigo)
                {
                    oFuncionario.Fcodigo = this.Fcodigo;
                    oFuncionario.Fnome = this.Fnome;
                    oFuncionario.FCPF = this.FCPF;
                    oFuncionario.FRG = this.FRG;
                    oFuncionario.Fidade = this.Fidade;
                    oFuncionario.Ftelefone = this.Ftelefone;
                    oFuncionario.Fendereço = this.Fendereço;
                    oFuncionario.Fcidade = this.Fcidade;
                    oFuncionario.Fbairro = this.Fbairro;
                    oFuncionario.Fsexo = this.Fsexo;

                    Achou = true;
                    return;
                }



                if (Achou == false)
                {
                    throw new Exception("O Funcionario não existe para ser alterado");
                }
            }

        }
    }
}
