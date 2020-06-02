using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Threading;

namespace PORTARIA
{
    public partial class frmExportarExcel : Form
    {
        public frmExportarExcel()
        {
            InitializeComponent();
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog s = new FolderBrowserDialog();

            txtCaminho.Text = s.SelectedPath.ToString();

            if (s.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = s.SelectedPath.ToString() + "\\PORTARIA-" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xlsx";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            if (txtCaminho.Text != string.Empty)
            {
                lblStatus.Text = "Salvando arquivo...";

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                excel.Workbooks.Add();

                //Pessoas
                Microsoft.Office.Interop.Excel._Worksheet workSheet = excel.ActiveSheet;
                workSheet.Name = "Pessoas";

                try
                {
                    workSheet.Cells[1, "A"] = "Código";
                    workSheet.Cells[1, "B"] = "Categoria";
                    workSheet.Cells[1, "C"] = "Nome";
                    workSheet.Cells[1, "D"] = "Documento";
                    workSheet.Cells[1, "E"] = "Telefone";
                    workSheet.Cells[1, "F"] = "Empresa";

                    List<Pessoa> pessoas = Pessoa.CarregarPessoa();
                    int row = 2;
                    foreach (Pessoa pessoa in pessoas)
                    {
                        workSheet.Cells[row, "A"] = pessoa.Codigo.ToString();
                        workSheet.Cells[row, "B"] = pessoa.Categoria;
                        workSheet.Cells[row, "C"] = pessoa.Nome;
                        workSheet.Cells[row, "D"] = pessoa.Documento;
                        workSheet.Cells[row, "E"] = pessoa.Tel;
                        workSheet.Cells[row, "F"] = pessoa.Empresa;

                        row++;
                    }

                    workSheet.Range["A1"].AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);

                    //Veículo e Motorista
                    Microsoft.Office.Interop.Excel.Worksheet workSheet2 =  excel.Worksheets.Add();
                    workSheet2.Name = "Motoristas e Veículos";

                    workSheet2.Cells[1, "A"] = "Código";
                    workSheet2.Cells[1, "B"] = "Código da Pessoa";
                    workSheet2.Cells[1, "C"] = "Modelo";
                    workSheet2.Cells[1, "D"] = "Marca";
                    workSheet2.Cells[1, "E"] = "Placa";
                    workSheet2.Cells[1, "F"] = "CNH";
                    workSheet2.Cells[1, "G"] = "VALIDADE";
                    workSheet2.Cells[1, "H"] = "MOPP";

                    List<VeiculoEMotorista> vems = VeiculoEMotorista.CarregarVEM();
                    int row2 = 2;
                    foreach (VeiculoEMotorista vem in vems)
                    {
                        workSheet2.Cells[row2, "A"] = vem.Codigo.ToString();
                        workSheet2.Cells[row2, "B"] = vem.CodPessoa.ToString();
                        workSheet2.Cells[row2, "C"] = vem.Modelo;
                        workSheet2.Cells[row2, "D"] = vem.Marca;
                        workSheet2.Cells[row2, "E"] = vem.Placa;
                        workSheet2.Cells[row2, "F"] = vem.CNH;
                        workSheet2.Cells[row2, "G"] = vem.Validade;
                        workSheet2.Cells[row2, "H"] = vem.MOPP;

                        row2++;
                    }

                    workSheet2.Range["A1"].AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);

                    //Registro
                    Microsoft.Office.Interop.Excel.Worksheet workSheet3 = excel.Worksheets.Add();
                    workSheet3.Name = "Entradas e Saídas de Pessoal";

                    workSheet3.Cells[1, "A"] = "Código";
                    workSheet3.Cells[1, "B"] = "Código da Pessoa";
                    workSheet3.Cells[1, "C"] = "Hora da Entrada";
                    workSheet3.Cells[1, "D"] = "Hora da Saída";
                    workSheet3.Cells[1, "E"] = "Data";
                    workSheet3.Cells[1, "F"] = "Placa da Carreta";

                    List<Registro> regs = Registro.CarregarRegistro();
                    int row3 = 2;
                    foreach (Registro reg in regs)
                    {
                        workSheet3.Cells[row3, "A"] = reg.Codigo.ToString();
                        workSheet3.Cells[row3, "B"] = reg.CodPessoa.ToString();
                        workSheet3.Cells[row3, "C"] = reg.HoraEntrada;
                        workSheet3.Cells[row3, "D"] = reg.HoraSaida;
                        workSheet3.Cells[row3, "E"] = reg.Datae;
                        workSheet3.Cells[row3, "F"] = reg.PlacaCarreta;

                        row3++;
                    }

                    workSheet3.Range["A1"].AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);

                    //Salvar
                    string fileName = string.Format(txtCaminho.Text);
                    excel.ActiveWorkbook.SaveAs(fileName);

                    MessageBox.Show(string.Format("O arquivo foi salvo com sucesso!", fileName));
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Exception",
                        "Erro ao salvar arquivo do Excel!\n" + exception.Message,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Quit Excel application
                    excel.Quit();

                    // Release COM objects (very important!)
                    if (excel != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

                    if (workSheet != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);

                    // Empty variables
                    excel = null;
                    workSheet = null;

                    // Force garbage collector cleaning
                    GC.Collect();
                }

            }
            else
            {
                MessageBox.Show("Escolha o local onde deseja salvar o arquivo!");
            }

            lblStatus.Text = "Pronto.";
            this.UseWaitCursor = false;
        }
    }
}
