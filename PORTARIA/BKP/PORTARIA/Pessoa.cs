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
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Categoria { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Tel { get; set; }
        public string Empresa { get; set; }

        public static List<Pessoa> CarregarPessoa()
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM PESSOA";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Pessoa> lista = new List<Pessoa>();
            while (dr.Read())
            {
                lista.Add(new Pessoa
                {
                    Codigo = Convert.ToInt32(dr["CODIGO"]),
                    Categoria = dr["CATEGORIA"].ToString(),
                    Nome = dr["NOME"].ToString(),
                    Documento = dr["DOCUMENTO"].ToString(),
                    Tel = dr["TEL"].ToString(),
                    Empresa = dr["EMPRESA"].ToString(),
                });
            }

            return lista;
        }

        public static List<Pessoa> CarregarPK(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(Database.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string comando = "SELECT * FROM PESSOA WHERE CODIGO = " + id.ToString();

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            List<Pessoa> lista = new List<Pessoa>();
            while (dr.Read())
            {
                lista.Add(new Pessoa
                {
                    Codigo = Convert.ToInt32(dr["CODIGO"]),
                    Categoria = dr["CATEGORIA"].ToString(),
                    Nome = dr["NOME"].ToString(),
                    Documento = dr["DOCUMENTO"].ToString(),
                    Tel = dr["TEL"].ToString(),
                    Empresa = dr["EMPRESA"].ToString(),
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
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM sqlite_sequence WHERE name = 'PESSOA'", conn);
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

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO PESSOA (CATEGORIA, NOME, DOCUMENTO, TEL, EMPRESA) VALUES (@CATEGORIA, @NOME, @DOCUMENTO, @TEL, @EMPRESA)", conn);
            cmd.Parameters.AddWithValue("CATEGORIA", pPessoa.Categoria);
            cmd.Parameters.AddWithValue("NOME", pPessoa.Nome);
            cmd.Parameters.AddWithValue("DOCUMENTO", pPessoa.Documento);
            cmd.Parameters.AddWithValue("TEL", pPessoa.Tel);
            cmd.Parameters.AddWithValue("EMPRESA", pPessoa.Empresa);
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

            SQLiteCommand cmd = new SQLiteCommand("UPDATE PESSOA SET CATEGORIA = @CATEGORIA, NOME = @NOME, DOCUMENTO = @DOCUMENTO, TEL = @TEL, EMPRESA = @EMPRESA WHERE CODIGO = @CODIGO", conn);
            cmd.Parameters.AddWithValue("CODIGO", pPessoa.Codigo);
            cmd.Parameters.AddWithValue("CATEGORIA", pPessoa.Categoria);
            cmd.Parameters.AddWithValue("NOME", pPessoa.Nome);
            cmd.Parameters.AddWithValue("DOCUMENTO", pPessoa.Documento);
            cmd.Parameters.AddWithValue("TEL", pPessoa.Tel);
            cmd.Parameters.AddWithValue("EMPRESA", pPessoa.Empresa);
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

            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM PESSOA WHERE CODIGO = @CODIGO", conn);
            cmd.Parameters.AddWithValue("CODIGO", pPessoa.Codigo);
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
