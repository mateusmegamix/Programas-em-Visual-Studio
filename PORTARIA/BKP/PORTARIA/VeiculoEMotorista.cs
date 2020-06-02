using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PORTARIA
{
    public class VeiculoEMotorista
    {
        public int Codigo { get; set; }
        public int CodPessoa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string CNH { get; set; }
        public string Validade { get; set; }
        public string MOPP { get; set; }

        public static List<VeiculoEMotorista> CarregarVEM()
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM VEICULOEMOTORISTA";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<VeiculoEMotorista> lista = new List<VeiculoEMotorista>();
            while (dr.Read())
            {
                lista.Add(new VeiculoEMotorista
                {
                    Codigo = Convert.ToInt32(dr["CODIGO"]),
                    CodPessoa = Convert.ToInt32(dr["CODPESSOA"]),
                    Modelo = dr["MODELO"].ToString(),
                    Marca = dr["MARCA"].ToString(),
                    Placa = dr["PLACA"].ToString(),
                    CNH = dr["CNH"].ToString(),
                    Validade = dr["VALIDADE"].ToString(),
                    MOPP = dr["MOPP"].ToString(),
                });
            }

            return lista;
        }

        public static List<VeiculoEMotorista> CarregarPK(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM VEICULOEMOTORISTA WHERE CODPESSOA = " + id.ToString();

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<VeiculoEMotorista> lista = new List<VeiculoEMotorista>();
            while (dr.Read())
            {
                lista.Add(new VeiculoEMotorista
                {
                    Codigo = Convert.ToInt32(dr["CODIGO"]),
                    CodPessoa = Convert.ToInt32(dr["CODPESSOA"]),
                    Modelo = dr["MODELO"].ToString(),
                    Marca = dr["MARCA"].ToString(),
                    Placa = dr["PLACA"].ToString(),
                    CNH = dr["CNH"].ToString(),
                    Validade = dr["VALIDADE"].ToString(),
                    MOPP = dr["MOPP"].ToString(),
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
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM sqlite_sequence WHERE name = 'VEICULOEMOTORISTA'", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ultimoCodigo = Convert.ToInt32(dr["seq"]);
            }

            //ultimoCodigo++;

            return ultimoCodigo;
        }

        public static bool Incluir(VeiculoEMotorista pVEM)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO VEICULOEMOTORISTA (CODPESSOA, MODELO, MARCA, PLACA, CNH, VALIDADE, MOPP) VALUES (@CODPESSOA, @MODELO, @MARCA, @PLACA, @CNH, @VALIDADE, @MOPP)", conn);
            cmd.Parameters.AddWithValue("CODPESSOA", pVEM.CodPessoa);
            cmd.Parameters.AddWithValue("MODELO", pVEM.Modelo);
            cmd.Parameters.AddWithValue("MARCA", pVEM.Marca);
            cmd.Parameters.AddWithValue("PLACA", pVEM.Placa);
            cmd.Parameters.AddWithValue("CNH", pVEM.CNH);
            cmd.Parameters.AddWithValue("VALIDADE", pVEM.Validade);
            cmd.Parameters.AddWithValue("MOPP", pVEM.MOPP);
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

        public static bool Alterar(VeiculoEMotorista pVEM)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("UPDATE VEICULOEMOTORISTA SET MODELO = @MODELO, MARCA = @MARCA, PLACA = @PLACA, CNH = @CNH, VALIDADE = @VALIDADE, MOPP = @MOPP WHERE CODPESSOA = @CODPESSOA", conn);
            cmd.Parameters.AddWithValue("CODPESSOA", pVEM.CodPessoa);
            cmd.Parameters.AddWithValue("MODELO", pVEM.Modelo);
            cmd.Parameters.AddWithValue("MARCA", pVEM.Marca);
            cmd.Parameters.AddWithValue("PLACA", pVEM.Placa);
            cmd.Parameters.AddWithValue("CNH", pVEM.CNH);
            cmd.Parameters.AddWithValue("VALIDADE", pVEM.Validade);
            cmd.Parameters.AddWithValue("MOPP", pVEM.MOPP);
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

        public static bool Excluir(VeiculoEMotorista pVEM)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM VEICULOEMOTORISTA WHERE CODPESSOA = @CODPESSOA", conn);
            cmd.Parameters.AddWithValue("CODPESSOA", pVEM.CodPessoa);
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
