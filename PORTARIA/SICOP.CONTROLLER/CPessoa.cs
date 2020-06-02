using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICOP.MODEL;

namespace SICOP.CONTROLLER
{
    public class CPessoa
    {
        public static List<Pessoa> CarregarPessoa()
        {
            return Pessoa.CarregarPessoa();
        }

        public static Pessoa CarregarPK(int id)
        {
            return Pessoa.CarregarPK(id);
        }

        public static int ObterCodigo()
        {
            return Pessoa.ObterCodigo();
        }

        public static bool Incluir(Pessoa pPessoa)
        {
            return Pessoa.Incluir(pPessoa);
        }

        public static bool IncluirCompleto(Pessoa pPessoa, CNH pCNH, Veiculo pVeiculo)
        {
            bool retorno = false;

            if(Pessoa.Incluir(pPessoa) && CNH.Incluir(pCNH) && Veiculo.Incluir(pVeiculo))
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool Alterar(Pessoa pPessoa)
        {
            return Pessoa.Alterar(pPessoa);
        }

        public static bool AlterarCompleto(Pessoa pPessoa, CNH pCNH, Veiculo pVeiculo)
        {
            bool retorno = false;

            if (Pessoa.Alterar(pPessoa) && CNH.Alterar(pCNH) && Veiculo.Alterar(pVeiculo))
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool Excluir(Pessoa pPessoa)
        {
            return Pessoa.Excluir(pPessoa);
        }

        public static bool ExcluirCompleto(Pessoa pPessoa, CNH pCNH, Veiculo pVeiculo)
        {
            bool retorno = false;

            if (Pessoa.Excluir(pPessoa) && CNH.Excluir(pCNH) && Veiculo.Excluir(pVeiculo))
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
