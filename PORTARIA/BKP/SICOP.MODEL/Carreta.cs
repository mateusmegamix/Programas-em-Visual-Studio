using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOP.MODEL
{
    public class Carreta
    {
        public int CarCodigo { get; set; }
        public int CarEntCodigo { get; set; }
        public int CarSaiCodigo { get; set; }
        public string CarTipo { get; set; }
        public string CarPlaca { get; set; }
        public string CarCidade { get; set; }

        public static List<Carreta> CarregarCarreta()
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM Carreta";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Carreta> lista = new List<Carreta>();
            while (dr.Read())
            {
                lista.Add(new Carreta
                {
                    CarCodigo = Convert.ToInt32(dr["CarCodigo"]),
                    CarEntCodigo = Convert.ToInt32(dr["CarEntCodigo"]),
                    CarSaiCodigo = Convert.ToInt32(dr["CarSaiCodigo"]),
                    CarTipo = dr["CarTipo"].ToString(),
                    CarPlaca = dr["CarPlaca"].ToString(),
                    CarCidade = dr["CarCidade"].ToString(),
                });
            }

            return lista;
        }

        public static Carreta CarregarPK(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM Carreta WHERE CarCodigo = " + id.ToString();

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Carreta> lista = new List<Carreta>();
            while (dr.Read())
            {
                lista.Add(new Carreta
                {
                    CarCodigo = Convert.ToInt32(dr["CarCodigo"]),
                    CarEntCodigo = Convert.ToInt32(dr["CarEntCodigo"]),
                    CarSaiCodigo = Convert.ToInt32(dr["CarSaiCodigo"]),
                    CarTipo = dr["CarTipo"].ToString(),
                    CarPlaca = dr["CarPlaca"].ToString(),
                    CarCidade = dr["CarCidade"].ToString(),
                });
            }

            Carreta retorno = null;
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
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM sqlite_sequence WHERE name = 'Carreta'", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ultimoCodigo = Convert.ToInt32(dr["seq"]);
            }

            //ultimoCodigo++;

            return ultimoCodigo;
        }

        public static bool Incluir(Carreta pCarreta)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Carreta (CarEntCodigo, CarSaiCodigo, CarTipo, CarPlaca, CarCidade) VALUES (@CarEntCodigo, @CarSaiCodigo, @CarTipo, @CarPlaca, @CarCidade)", conn);
            cmd.Parameters.AddWithValue("CarEntCodigo", pCarreta.CarEntCodigo);
            cmd.Parameters.AddWithValue("CarSaiCodigo", pCarreta.CarSaiCodigo);
            cmd.Parameters.AddWithValue("CarTipo", pCarreta.CarTipo);
            cmd.Parameters.AddWithValue("CarPlaca", pCarreta.CarPlaca);
            cmd.Parameters.AddWithValue("CarCidade", pCarreta.CarCidade);

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

        public static bool Alterar(Carreta pCarreta)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("UPDATE Carreta SET CarSaiCodigo = @CarSaiCodigo, CarTipo = @CarTipo, CarPlaca = @CarPlaca, CarCidade = @CarCidade WHERE CarEntCodigo = @CarEntCodigo", conn);
            cmd.Parameters.AddWithValue("CarEntCodigo", pCarreta.CarEntCodigo);
            cmd.Parameters.AddWithValue("CarSaiCodigo", pCarreta.CarSaiCodigo);
            cmd.Parameters.AddWithValue("CarTipo", pCarreta.CarTipo);
            cmd.Parameters.AddWithValue("CarPlaca", pCarreta.CarPlaca);
            cmd.Parameters.AddWithValue("CarCidade", pCarreta.CarCidade);
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

        public static bool Excluir(Carreta pCarreta)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Carreta WHERE CarEntCodigo = @CarEntCodigo", conn);
            cmd.Parameters.AddWithValue("CarEntCodigo", pCarreta.CarEntCodigo);
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
