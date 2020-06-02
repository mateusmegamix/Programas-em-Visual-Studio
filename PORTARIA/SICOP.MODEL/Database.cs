using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SICOP.MODEL
{
    public class Database
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

                sql.AppendLine("CREATE TABLE Carreta(");
                sql.AppendLine("CarCodigo INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("CarEntCodigo INTEGER, ");
                sql.AppendLine("CarSaiCodigo INTEGER, ");
                sql.AppendLine("CarTipo VARCHAR(15), ");
                sql.AppendLine("CarPlaca VARCHAR(8), ");
                sql.AppendLine("CarCidade VARCHAR(15)");
                sql.AppendLine(");");

                sql.AppendLine("CREATE TABLE CNH(");
                sql.AppendLine("CNHCodigo INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("CNHPesCodigo INTEGER, ");
                sql.AppendLine("CNHNumero VARCHAR(12), ");
                sql.AppendLine("CNHCategoria VARCHAR(5), ");
                sql.AppendLine("CNHValidade VARCHAR(10), ");
                sql.AppendLine("CNHMopp VARCHAR(8)");
                sql.AppendLine("); ");

                sql.AppendLine("CREATE TABLE Entrada(");
                sql.AppendLine("EntCodigo INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("EntPesCodigo INTEGER, ");
                sql.AppendLine("EntData VARCHAR(10), ");
                sql.AppendLine("EntHora VARCHAR(5)");          
                sql.AppendLine("); ");

                sql.AppendLine("CREATE TABLE Pessoa(");
                sql.AppendLine("PesCodigo INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("PesNome VARCHAR(50), ");
                sql.AppendLine("PesDocumento VARCHAR(14), ");
                sql.AppendLine("PesTelefone VARCHAR(15), ");
                sql.AppendLine("PesVinculo VARCHAR(11), ");
                sql.AppendLine("PesEmpresa VARCHAR(15)");
                sql.AppendLine("); ");

                sql.AppendLine("CREATE TABLE Saida(");
                sql.AppendLine("SaiCodigo INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("SaiPesCodigo INTEGER, ");
                sql.AppendLine("SaiData VARCHAR(10), ");
                sql.AppendLine("SaiHora VARCHAR(5)");             
                sql.AppendLine("); ");

                sql.AppendLine("CREATE TABLE Veiculo(");
                sql.AppendLine("VeiCodigo INTEGER PRIMARY KEY AUTOINCREMENT, ");
                sql.AppendLine("VeiPesCodigo INTEGER, ");
                sql.AppendLine("VeiTipo VARCHAR(10), ");
                sql.AppendLine("VeiPlaca VARCHAR(8),");
                sql.AppendLine("VeiCidadePlaca VARCHAR(15)");
                sql.AppendLine("); ");

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
