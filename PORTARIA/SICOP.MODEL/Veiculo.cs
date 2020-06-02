using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOP.MODEL
{
    public class Veiculo
    {
        public int VeiCodigo { get; set; }
        public int VeiPesCodigo { get; set; }
        public string VeiTipo { get; set; }
        public string VeiPlaca { get; set; }
        public string VeiCidadePlaca { get; set; }

        public static List<Veiculo> CarregarVeiculo()
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM Veiculo";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Veiculo> lista = new List<Veiculo>();
            while (dr.Read())
            {
                lista.Add(new Veiculo
                {
                    VeiCodigo = Convert.ToInt32(dr["VeiCodigo"]),
                    VeiPesCodigo = Convert.ToInt32(dr["VeiPesCodigo"]),
                    VeiTipo = dr["VeiTipo"].ToString(),
                    VeiPlaca = dr["VeiPlaca"].ToString(),
                    VeiCidadePlaca = dr["VeiCidadePlaca"].ToString(),
                });
            }

            return lista;
        }

        public static Veiculo CarregarPK(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM Veiculo WHERE VeiPesCodigo = " + id.ToString();

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Veiculo> lista = new List<Veiculo>();
            while (dr.Read())
            {
                lista.Add(new Veiculo
                {
                    VeiCodigo = Convert.ToInt32(dr["VeiCodigo"]),
                    VeiPesCodigo = Convert.ToInt32(dr["VeiPesCodigo"]),
                    VeiTipo = dr["VeiTipo"].ToString(),
                    VeiPlaca = dr["VeiPlaca"].ToString(),
                    VeiCidadePlaca = dr["VeiCidadePlaca"].ToString(),
                });
            }

            Veiculo retorno = null;
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
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM sqlite_sequence WHERE name = 'Veiculo'", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ultimoCodigo = Convert.ToInt32(dr["seq"]);
            }

            //ultimoCodigo++;

            return ultimoCodigo;
        }

        public static bool Incluir(Veiculo pVeiculo)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Veiculo (VeiPesCodigo, VeiTipo, VeiPlaca, VeiCidadePlaca) VALUES (@VeiPesCodigo, @VeiTipo, @VeiPlaca, @VeiCidadePlaca)", conn);
            cmd.Parameters.AddWithValue("VeiPesCodigo", pVeiculo.VeiPesCodigo);
            cmd.Parameters.AddWithValue("VeiTipo", pVeiculo.VeiTipo);
            cmd.Parameters.AddWithValue("VeiPlaca", pVeiculo.VeiPlaca);
            cmd.Parameters.AddWithValue("VeiCidadePlaca", pVeiculo.VeiCidadePlaca);

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

        public static bool Alterar(Veiculo pVeiculo)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("UPDATE Veiculo SET VeiTipo = @VeiTipo, VeiPlaca = @VeiPlaca, VeiCidadePlaca = @VeiCidadePlaca WHERE VeiPesCodigo = @VeiPesCodigo", conn);
            cmd.Parameters.AddWithValue("VeiPesCodigo", pVeiculo.VeiPesCodigo);
            cmd.Parameters.AddWithValue("VeiTipo", pVeiculo.VeiTipo);
            cmd.Parameters.AddWithValue("VeiPlaca", pVeiculo.VeiPlaca);
            cmd.Parameters.AddWithValue("VeiCidadePlaca", pVeiculo.VeiCidadePlaca);
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

        public static bool Excluir(Veiculo pVeiculo)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Veiculo WHERE VeiPesCodigo = @VeiPesCodigo", conn);
            cmd.Parameters.AddWithValue("VeiPesCodigo", pVeiculo.VeiPesCodigo);
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
