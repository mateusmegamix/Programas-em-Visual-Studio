using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICOP.MODEL;

namespace SICOP.CONTROLLER
{
    public class CSaida
    {
        public static List<Saida> CarregarSaida()
        {
            return Saida.CarregarSaida();
        }

        public static List<Saida> CarregarPK(int id)
        {
            return Saida.CarregarPK(id);
        }

        public static int ObterCodigo()
        {
            return Saida.ObterCodigo();
        }

        public static bool Incluir(Saida pSaida)
        {
            return Saida.Incluir(pSaida);
        }

        public static bool Alterar(Saida pSaida)
        {
            return Saida.Alterar(pSaida);
        }

        public static bool Excluir(Saida pSaida)
        {
            return Saida.Excluir(pSaida);
        }

    }
}
