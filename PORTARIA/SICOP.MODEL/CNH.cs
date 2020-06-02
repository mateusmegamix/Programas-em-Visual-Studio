using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOP.MODEL
{
    public class CNH
    {

        public int CNHCodigo { get; set; }
        public int CNHPesCodigo { get; set; }
        public string CNHNumero { get; set; }
        public string CNHValidade { get; set; }
        public string CNHMopp { get; set; }
        public string CNHCategoria { get; set; }

        public static List<CNH> CarregarCNH()
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM CNH";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<CNH> lista = new List<CNH>();
            while (dr.Read())
            {
                lista.Add(new CNH
                {
                    CNHCodigo = Convert.ToInt32(dr["CNHCodigo"]),
                    CNHPesCodigo = Convert.ToInt32(dr["CNHPesCodigo"]),
                    CNHNumero = dr["CNHNumero"].ToString(),
                    CNHValidade = dr["CNHValidade"].ToString(),
                    CNHMopp = dr["CNHMopp"].ToString(),
                    CNHCategoria = dr["CNHCategoria"].ToString(),
                });
            }

            return lista;
        }

        public static CNH CarregarPK(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM CNH WHERE CNHPesCodigo = " + id.ToString();

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<CNH> lista = new List<CNH>();
            while (dr.Read())
            {
                lista.Add(new CNH
                {
                    CNHCodigo = Convert.ToInt32(dr["CNHCodigo"]),
                    CNHPesCodigo = Convert.ToInt32(dr["CNHPesCodigo"]),
                    CNHNumero = dr["CNHNumero"].ToString(),
                    CNHValidade = dr["CNHValidade"].ToString(),
                    CNHMopp = dr["CNHMopp"].ToString(),
                    CNHCategoria = dr["CNHCategoria"].ToString(),
                });
            }

            CNH retorno = null;
            if (lista.Count > 0)
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
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM sqlite_sequence WHERE name = 'CNH'", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ultimoCodigo = Convert.ToInt32(dr["seq"]);
            }

            //ultimoCodigo++;

            return ultimoCodigo;
        }

        public static bool Incluir(CNH pCNH)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO CNH (CNHPesCodigo, CNHNumero, CNHValidade, CNHMopp, CNHCategoria) VALUES (@CNHPesCodigo, @CNHNumero, @CNHValidade, @CNHMopp, @CNHCategoria)", conn);
            cmd.Parameters.AddWithValue("CNHPesCodigo", pCNH.CNHPesCodigo);
            cmd.Parameters.AddWithValue("CNHNumero", pCNH.CNHNumero);
            cmd.Parameters.AddWithValue("CNHValidade", pCNH.CNHValidade);
            cmd.Parameters.AddWithValue("CNHMopp", pCNH.CNHMopp);
            cmd.Parameters.AddWithValue("CNHCategoria", pCNH.CNHCategoria);

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

        public static bool Alterar(CNH pCNH)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("UPDATE CNH SET CNHNumero = @CNHNumero, CNHValidade = @CNHValidade, CNHMopp = @CNHMopp, CNHCategoria = @CNHCategoria WHERE CNHPesCodigo = @CNHPesCodigo", conn);
            cmd.Parameters.AddWithValue("CNHPesCodigo", pCNH.CNHPesCodigo);
            cmd.Parameters.AddWithValue("CNHNumero", pCNH.CNHNumero);
            cmd.Parameters.AddWithValue("CNHValidade", pCNH.CNHValidade);
            cmd.Parameters.AddWithValue("CNHMopp", pCNH.CNHMopp);
            cmd.Parameters.AddWithValue("CNHCategoria", pCNH.CNHCategoria);
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

        public static bool Excluir(CNH pCNH)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM CNH WHERE CNHPesCodigo = @CNHPesCodigo", conn);
            cmd.Parameters.AddWithValue("CNHPesCodigo", pCNH.CNHPesCodigo);
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
