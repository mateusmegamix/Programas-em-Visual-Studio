using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOP.MODEL
{
    public class Saida
    {
        public int SaiCodigo { get; set; }
        public int SaiPesCodigo { get; set; }
        public string SaiData { get; set; }
        public string SaiHora { get; set; }

        public static List<Saida> CarregarSaida()
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM Saida";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Saida> lista = new List<Saida>();
            while (dr.Read())
            {
                lista.Add(new Saida
                {
                    SaiCodigo = Convert.ToInt32(dr["SaiCodigo"]),
                    SaiPesCodigo = Convert.ToInt32(dr["SaiPesCodigo"]),
                    SaiData = dr["SaiData"].ToString(),
                    SaiHora = dr["SaiHora"].ToString(),
                });
            }

            return lista;
        }

        public static List<Saida> CarregarPK(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM Saida WHERE SaiPesCodigo = " + id.ToString();

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Saida> lista = new List<Saida>();
            while (dr.Read())
            {
                lista.Add(new Saida
                {
                    SaiCodigo = Convert.ToInt32(dr["SaiCodigo"]),
                    SaiPesCodigo = Convert.ToInt32(dr["SaiPesCodigo"]),
                    SaiData = dr["SaiData"].ToString(),
                    SaiHora = dr["SaiHora"].ToString(),
                });
            }

            return lista;
        }

        public static int ObterCodigo()
        {
            int ultimoCodigo = -1;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM sqlite_sequence WHERE name = 'Saida'", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ultimoCodigo = Convert.ToInt32(dr["seq"]);
            }

            //ultimoCodigo++;

            return ultimoCodigo;
        }

        public static bool Incluir(Saida pSaida)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Saida (SaiPesCodigo, SaiData, SaiHora) VALUES (@SaiPesCodigo, @SaiData, @SaiHora)", conn);
            cmd.Parameters.AddWithValue("SaiPesCodigo", pSaida.SaiPesCodigo);
            cmd.Parameters.AddWithValue("SaiData", pSaida.SaiData);
            cmd.Parameters.AddWithValue("SaiHora", pSaida.SaiHora);

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

        public static bool Alterar(Saida pSaida)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("UPDATE Saida SET SaiData = @SaiData, SaiHora = @SaiHora WHERE SaiPesCodigo = @SaiPesCodigo", conn);
            cmd.Parameters.AddWithValue("SaiPesCodigo", pSaida.SaiPesCodigo);
            cmd.Parameters.AddWithValue("SaiData", pSaida.SaiData);
            cmd.Parameters.AddWithValue("SaiHora", pSaida.SaiHora);
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

        public static bool Excluir(Saida pSaida)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Saida WHERE SaiPesCodigo = @SaiPesCodigo", conn);
            cmd.Parameters.AddWithValue("SaiPesCodigo", pSaida.SaiPesCodigo);
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
