using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOP.MODEL
{
    public class Entrada
    {
        public int EntCodigo { get; set; }
        public int EntPesCodigo { get; set; }
        public string EntData { get; set; }
        public string EntHora { get; set; }

        public static List<Entrada> CarregarEntrada()
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM Entrada";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Entrada> lista = new List<Entrada>();
            while (dr.Read())
            {
                lista.Add(new Entrada
                {
                    EntCodigo = Convert.ToInt32(dr["EntCodigo"]),
                    EntPesCodigo = Convert.ToInt32(dr["EntPesCodigo"]),
                    EntData = dr["EntData"].ToString(),
                    EntHora = dr["EntHora"].ToString(),
                });
            }

            return lista;
        }

        public static List<Entrada> CarregarPK(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM Entrada WHERE EntPesCodigo = " + id.ToString();

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Entrada> lista = new List<Entrada>();
            while (dr.Read())
            {
                lista.Add(new Entrada
                {
                    EntCodigo = Convert.ToInt32(dr["EntCodigo"]),
                    EntPesCodigo = Convert.ToInt32(dr["EntPesCodigo"]),
                    EntData = dr["EntData"].ToString(),
                    EntHora = dr["EntHora"].ToString(),
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
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM sqlite_sequence WHERE name = 'Entrada'", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ultimoCodigo = Convert.ToInt32(dr["seq"]);
            }

            //ultimoCodigo++;

            return ultimoCodigo;
        }

        public static bool Incluir(Entrada pEntrada)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Entrada (EntPesCodigo, EntData, EntHora) VALUES (@EntPesCodigo, @EntData, @EntHora)", conn);
            cmd.Parameters.AddWithValue("EntPesCodigo", pEntrada.EntPesCodigo);
            cmd.Parameters.AddWithValue("EntData", pEntrada.EntData);
            cmd.Parameters.AddWithValue("EntHora", pEntrada.EntHora);

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

        public static bool Alterar(Entrada pEntrada)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("UPDATE Entrada SET EntData = @EntData, EntHora = @EntHora WHERE EntPesCodigo = @EntPesCodigo", conn);
            cmd.Parameters.AddWithValue("EntPesCodigo", pEntrada.EntPesCodigo);
            cmd.Parameters.AddWithValue("EntData", pEntrada.EntData);
            cmd.Parameters.AddWithValue("EntHora", pEntrada.EntHora);
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

        public static bool Excluir(Entrada pEntrada)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Entrada WHERE EntPesCodigo = @EntPesCodigo", conn);
            cmd.Parameters.AddWithValue("EntPesCodigo", pEntrada.EntPesCodigo);
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
