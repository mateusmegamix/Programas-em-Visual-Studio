using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICOP.MODEL;

namespace SICOP.CONTROLLER
{
    public class CVeiculo
    {
        public static List<Veiculo> CarregarVeiculo()
        {
            return Veiculo.CarregarVeiculo();
        }

        public static Veiculo CarregarPK(int id)
        {
            return Veiculo.CarregarPK(id);
        }

        public static int ObterCodigo()
        {
            return Veiculo.ObterCodigo();
        }

        public static bool Incluir(Veiculo pVeiculo)
        {
            return Veiculo.Incluir(pVeiculo);
        }

        public static bool Alterar(Veiculo pVeiculo)
        {
            return Veiculo.Alterar(pVeiculo);
        }

        public static bool Excluir(Veiculo pVeiculo)
        {
            return Veiculo.Excluir(pVeiculo);
        }

    }
}
