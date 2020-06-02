using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICOP.MODEL;

namespace SICOP.CONTROLLER
{
    public class CCarreta
    {
        public static List<Carreta> CarregarCarreta()
        {
            return Carreta.CarregarCarreta();
        }

        public static Carreta CarregarPK(int id)
        {
            return Carreta.CarregarPK(id);
        }

        public static int ObterCodigo()
        {
            return Carreta.ObterCodigo();
        }

        public static bool Incluir(Carreta pCarreta)
        {
            return Carreta.Incluir(pCarreta);
        }

        public static bool Alterar(Carreta pCarreta)
        {
            return Carreta.Alterar(pCarreta);
        }

        public static bool Excluir(Carreta pCarreta)
        {
            return Carreta.Excluir(pCarreta);
        }

    }
}
