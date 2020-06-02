using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOP.MODEL
{
    public class Pessoa
    {
        public int PesCodigo { get; set; }
        public string PesNome { get; set; }
        public string PesDocumento { get; set; }
        public string PesTelefone { get; set; }
        public string PesVinculo { get; set; }
        public string PesEmpresa { get; set; }

        public static List<Pessoa> CarregarPessoa()
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM Pessoa";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Pessoa> lista = new List<Pessoa>();
            while (dr.Read())
            {
                lista.Add(new Pessoa
                {
                    PesCodigo = Convert.ToInt32(dr["PesCodigo"]),
                    PesNome = dr["PesNome"].ToString(),
                    PesDocumento = dr["PesDocumento"].ToString(),
                    PesTelefone = dr["PesTelefone"].ToString(),
                    PesVinculo = dr["PesVinculo"].ToString(),
                    PesEmpresa = dr["PesEmpresa"].ToString(),
                });
            }

            return lista;
        }

        public static Pessoa CarregarPK(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM Pessoa WHERE PesCodigo = " + id.ToString();

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Pessoa> lista = new List<Pessoa>();
            while (dr.Read())
            {
                lista.Add(new Pessoa
                {
                    PesCodigo = Convert.ToInt32(dr["PesCodigo"]),
                    PesNome = dr["PesNome"].ToString(),
                    PesDocumento = dr["PesDocumento"].ToString(),
                    PesTelefone = dr["PesTelefone"].ToString(),
                    PesVinculo = dr["PesVinculo"].ToString(),
                    PesEmpresa = dr["PesEmpresa"].ToString(),
                });
            }

            Pessoa retorno = null;
            if(lista.Count > 0)
            {
                retorno = lista[0];
            }
            return retorno;
        }

        public static int ObterCodigo()
        {
            int ultimoCodigo = -1;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM sqlite_sequence WHERE name = 'Pessoa'", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ultimoCodigo = Convert.ToInt32(dr["seq"]);
            }

            //ultimoCodigo++;

            return ultimoCodigo;
        }

        public static bool Incluir(Pessoa pPessoa)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Pessoa (PesNome, PesDocumento, PesTelefone, PesVinculo, PesEmpresa) VALUES (@PesNome, @PesDocumento, @PesTelefone, @PesVinculo, @PesEmpresa)", conn);
            cmd.Parameters.AddWithValue("PesNome", pPessoa.PesNome);
            cmd.Parameters.AddWithValue("PesDocumento", pPessoa.PesDocumento);
            cmd.Parameters.AddWithValue("PesTelefone", pPessoa.PesTelefone);
            cmd.Parameters.AddWithValue("PesVinculo", pPessoa.PesVinculo);
            cmd.Parameters.AddWithValue("PesEmpresa", pPessoa.PesEmpresa);
            try
            {
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool Alterar(Pessoa pPessoa)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("UPDATE Pessoa SET PesNome = @PesNome, PesDocumento = @PesDocumento, PesTelefone = @PesTelefone, PesVinculo = @PesVinculo, PesEmpresa = @PesEmpresa WHERE PesCodigo = @PesCodigo", conn);
            cmd.Parameters.AddWithValue("PesCodigo", pPessoa.PesCodigo);
            cmd.Parameters.AddWithValue("PesNome", pPessoa.PesNome);
            cmd.Parameters.AddWithValue("PesDocumento", pPessoa.PesDocumento);
            cmd.Parameters.AddWithValue("PesTelefone", pPessoa.PesTelefone);
            cmd.Parameters.AddWithValue("PesVinculo", pPessoa.PesVinculo);
            cmd.Parameters.AddWithValue("PesEmpresa", pPessoa.PesEmpresa);
            try
            {
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool Excluir(Pessoa pPessoa)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Pessoa WHERE PesCodigo = @PesCodigo", conn);
            cmd.Parameters.AddWithValue("PesCodigo", pPessoa.PesCodigo);
            try
            {
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
