using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICOP.MODEL;

namespace SICOP.CONTROLLER
{
    public class CEntrada
    {
        public static List<Entrada> CarregarEntrada()
        {
            return Entrada.CarregarEntrada();
        }

        public static List<Entrada> CarregarPK(int id)
        {
            return Entrada.CarregarPK(id);
        }

        public static int ObterCodigo()
        {
            return Entrada.ObterCodigo();
        }

        public static bool Incluir(Entrada pEntrada)
        {
            return Entrada.Incluir(pEntrada);
        }

        public static bool Alterar(Entrada pEntrada)
        {
            return Entrada.Alterar(pEntrada);
        }

        public static bool Excluir(Entrada pEntrada)
        {
            return Entrada.Excluir(pEntrada);
        }

    }
}
