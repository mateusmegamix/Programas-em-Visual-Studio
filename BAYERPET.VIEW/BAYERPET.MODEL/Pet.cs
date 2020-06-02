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
    public class Pet
    {
        public int Pcodigo
        { get; set; }

        public string Pnome
        { get; set; }

        public string Pespecie
        { get; set; }

        public string Pcor
        { get; set; }

        public string Psexo
        { get; set; }

        public DateTime Pdataentrada
        { get; set; }

        public DateTime Phorasaida
        { get; set; }

        public string Pinfo
        { get; set; }

        Funcionario fake = new Pet
        {
            Pcodigo = 123,
            Pnome = "dog",
            Pespecie = "cachorro",
            Pcor = "amarelo",
            Psexo = "M",
            Pdataentrada = "12/12/2012",
            Phorasaida = "18:00",
            Pinfo = "rua:45 casa:9",
                                                             
        };



        MemoryStream stream = new MemoryStream();
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Pet);
        serializer.WriteObject(stream, fake);
        string json = return Encoding.Default.GetString(stream.ToArray());
    

            string Json = "{"Pcodigo"123,"Pnome":dog," Pespecie ":dog," Pcor":amarelo,"FPsexo":M,"Pdataentrada":12/12/2012,"Phorasaida":18:00,"Pinfo":rua:42 casa:8,}"; 

        MemoryStream stream = new MemoryStream(json);
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Pet));
        serializer = new DataContractJsonSerializer(typeof(Pet));
        Pet fake = (Pet)serializer.ReadObject(Stream);

        public static Pet Selecionar(int Pcodigo)
        {
            return (from p in MyGlobal.ListaPet where p.Pcodigo == Pcodigo select p).FirstOrDefault();
        }

        public static List<Pet> SelecionarTodos()
        {
            return (from p in MyGlobal.ListaPet orderby p.Pcodigo select p).ToList();
        }


        //..............................................................................
        public Pet _Pet = null;
        public Pet PetDoBayer
        {
            get
            {
                if (_Pet == null)
                {
                    CarregaPet();
                }
                return _Pet;
            }
        }
        private void CarregaPet()
        {
            _Pet = Pet.Selecionar(Pcodigo);
        }
        //................................................................................
        public void Incluir()
        {
            MyGlobal.ListaPet.Add(this);
        }

        public void Excluir()
        {
            Pet oPetExcluir = (from p in MyGlobal.ListaPet where p.Pcodigo == this.Pcodigo select p).FirstOrDefault();
            if (oPetExcluir == null)
            {
                throw new Exception("O pet não existe para ser excluido");
            }
            MyGlobal.ListaPet.Remove(oPetExcluir);
        }

        public void Alterar()
        {
            //Pet oPetAlterar = (from p in MyGlobal.ListaPet where p.Pcodigo == this.Pcodigo select p).FirstOrDefault();
            //if (oPetAlterar == null)
            //{
            //    throw new Exception("O Pet não existe para ser alterado");
            //}
            //MyGlobal.ListaPet.Remove(oPetAlterar);
            //MyGlobal.ListaPet.Add(oPetAlterar);

            bool Achou = false;
            foreach (Pet oPet in MyGlobal.ListaPet)
            {
                if (oPet.Pcodigo == this.Pcodigo)
                {

                    oPet.Pnome = this.Pnome;
                    oPet.Pespecie = Pespecie;
                    oPet.Psexo = Psexo;
                    oPet.Pcor = this.Pcor;
                    oPet.Pcodigo = this.Pcodigo;
                    oPet.Pinfo = this.Pinfo;
                    Achou = true;
                    return;
                }



                if (Achou == false)
                {
                    throw new Exception("O Pet não existe para ser alterado");
                }
            }
        }
    }
}
