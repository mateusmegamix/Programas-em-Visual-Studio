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
    public class Registro
    {
        public int Codigo { get; set; }
        public int CodPessoa { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSaida { get; set; }
        public string Datae { get; set; }
        public string PlacaCarreta { get; set; }

        public static List<Registro> CarregarRegistro()
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM REGISTRO";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Registro> lista = new List<Registro>();
            while (dr.Read())
            {
                lista.Add(new Registro
                {
                    Codigo = Convert.ToInt32(dr["CODIGO"]),
                    CodPessoa = Convert.ToInt32(dr["CODPESSOA"]),
                    HoraEntrada = dr["HORAENTRADA"].ToString(),
                    HoraSaida = dr["HORASAIDA"].ToString(),
                    Datae = dr["DATAE"].ToString(),
                    PlacaCarreta = dr["PLACACARRETA"].ToString(),
                });
            }

            return lista;
        }

        public static List<Registro> CarregarPK(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM REGISTRO WHERE CODPESSOA = " + id.ToString() + " ORDER BY DATAE DESC";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Registro> lista = new List<Registro>();
            while (dr.Read())
            {
                lista.Add(new Registro
                {
                    Codigo = Convert.ToInt32(dr["CODIGO"]),
                    CodPessoa = Convert.ToInt32(dr["CODPESSOA"]),
                    HoraEntrada = dr["HORAENTRADA"].ToString(),
                    HoraSaida = dr["HORASAIDA"].ToString(),
                    Datae = dr["DATAE"].ToString(),
                    PlacaCarreta = dr["PLACACARRETA"].ToString(),
                });
            }

            return lista;
        }

        public static bool CarregarEntradas(int id)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM REGISTRO WHERE CODPESSOA = " + id.ToString() + " AND HORASAIDA = '--'";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Registro> lista = new List<Registro>();
            while (dr.Read())
            {
                lista.Add(new Registro
                {
                    Codigo = Convert.ToInt32(dr["CODIGO"]),
                    CodPessoa = Convert.ToInt32(dr["CODPESSOA"]),
                    HoraEntrada = dr["HORAENTRADA"].ToString(),
                    HoraSaida = dr["HORASAIDA"].ToString(),
                    Datae = dr["DATAE"].ToString(),
                    PlacaCarreta = dr["PLACACARRETA"].ToString(),
                });
            }

            if(lista.Count > 0)
            {
                if (lista[0].HoraSaida == "--")
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        public static List<Registro> CarregarData(string data)
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM REGISTRO WHERE DATAE = '" + data +"'";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Registro> lista = new List<Registro>();
            while (dr.Read())
            {
                lista.Add(new Registro
                {
                    Codigo = Convert.ToInt32(dr["CODIGO"]),
                    CodPessoa = Convert.ToInt32(dr["CODPESSOA"]),
                    HoraEntrada = dr["HORAENTRADA"].ToString(),
                    HoraSaida = dr["HORASAIDA"].ToString(),
                    Datae = dr["DATAE"].ToString(),
                    PlacaCarreta = dr["PLACACARRETA"].ToString(),
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
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM sqlite_sequence WHERE name = 'REGISTRO'", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ultimoCodigo = Convert.ToInt32(dr["seq"]);
            }

            //ultimoCodigo++;

            return ultimoCodigo;
        }

        public static bool Incluir(Registro pRegistro)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO REGISTRO (CODPESSOA, HORAENTRADA, HORASAIDA, DATAE, PLACACARRETA) VALUES (@CODPESSOA, @HORAENTRADA, @HORASAIDA, @DATAE, @PLACACARRETA)", conn);
            cmd.Parameters.AddWithValue("CODPESSOA", pRegistro.CodPessoa);
            cmd.Parameters.AddWithValue("HORAENTRADA", pRegistro.HoraEntrada);
            cmd.Parameters.AddWithValue("HORASAIDA", pRegistro.HoraSaida);
            cmd.Parameters.AddWithValue("DATAE", pRegistro.Datae);
            cmd.Parameters.AddWithValue("PLACACARRETA", pRegistro.PlacaCarreta);
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

        public static bool Alterar(Registro pRegistro)
        {
            bool retorno = false;

            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("UPDATE REGISTRO SET HORASAIDA = @HORASAIDA, PLACACARRETA = @PLACACARRETA WHERE CODIGO == (SELECT MAX(CODIGO) FROM REGISTRO WHERE CODPESSOA = @CODPESSOA)", conn);
            cmd.Parameters.AddWithValue("CODPESSOA", pRegistro.CodPessoa);
            cmd.Parameters.AddWithValue("HORASAIDA", pRegistro.HoraSaida);
            cmd.Parameters.AddWithValue("PLACACARRETA", pRegistro.PlacaCarreta);
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
