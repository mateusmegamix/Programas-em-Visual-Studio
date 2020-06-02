using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace PORTARIA
{
    class Database
    {
        public static string connectionString = "Data Source= Banco.db";
        private static string baseName = "Banco.db";

        public void CriarBanco()
        {
            if (!File.Exists(baseName))
            {
                SQLiteConnection.CreateFile(baseName);
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();

                StringBuilder sql = new StringBuilder();

                sql.AppendLine("CREATE TABLE IF NOT EXISTS PESSOA([CODIGO] INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("[CATEGORIA] VARCHAR(15), [NOME] VARCHAR(50), [DOCUMENTO] VARCHAR(15), [TEL] VARCHAR(15), ");
                sql.AppendLine("[EMPRESA] VARCHAR(15)); ");

                sql.AppendLine("CREATE TABLE IF NOT EXISTS VEICULOEMOTORISTA([CODIGO] INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("[CODPESSOA] INTEGER, [MODELO] VARCHAR(15), [MARCA] VARCHAR(15), [PLACA] VARCHAR(10), ");
                sql.AppendLine("[CNH] VARCHAR(15), [VALIDADE] VARCHAR(10), [MOPP] VARCHAR(10)); ");

                sql.AppendLine("CREATE TABLE IF NOT EXISTS REGISTRO([CODIGO] INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("[CODPESSOA] INTEGER, [HORAENTRADA] VARCHAR(10), [HORASAIDA] VARCHAR(10), ");
                sql.AppendLine("[PLACACARRETA] VARCHAR[10], [DATAE] VARCHAR(10)); ");

                SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar banco de dados" + ex.Message);
                }
            }
        }
    }
}
