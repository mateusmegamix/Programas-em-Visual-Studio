using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICOP.MODEL;

namespace SICOP.CONTROLLER
{
    public class CCNH
    {
        public static List<CNH> CarregarCNH()
        {
            return CNH.CarregarCNH();
        }

        public static CNH CarregarPK(int id)
        {
            return CNH.CarregarPK(id);
        }

        public static int ObterCodigo()
        {
            return CNH.ObterCodigo();
        }

        public static bool Incluir(CNH pCNH)
        {
            return CNH.Incluir(pCNH);
        }

        public static bool Alterar(CNH pCNH)
        {
            return CNH.Alterar(pCNH);
        }

        public static bool Excluir(CNH pCNH)
        {
            return CNH.Excluir(pCNH);
        }

    }
}
