using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReatorModel;
using System.IO;

namespace QuiminVestReator
{

    public partial class EntradaSaidaView : Form
    {
        private bool Incluir = true;
        private Control.oVeiculo _Control = new Control.oVeiculo();
        public TelaPrincipal MdiContainer { get; internal set; }
        public EntradaSaidaView()
        {
            InitializeComponent();
        }

        private void EntradaSaida_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'reatorDataSet2.EntradaSaida'. Você pode movê-la ou removê-la conforme necessário.
            this.entradaSaidaTableAdapter.Fill(this.reatorDataSet2.EntradaSaida);
            CarregaGrid();

        }

        private void CarregaGrid()
        {
            GrdVeiculo.AutoGenerateColumns = false;
            GrdVeiculo.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvarEntradaSaida_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                //if ((TxtSenhaVeiculo == TxtConfirmarSenhaVeiculo) && (TxtSenhaVeiculo != null))

                if (Incluir)
                {
                    EntradaSaida oVeiculo = new EntradaSaida();
                    oVeiculo.Funcionario = cbFuncionario.Text;
                    oVeiculo.Data = txtData.Text;
                    oVeiculo.Destino = txtDestino.Text;
                    oVeiculo.HoraEntrada = txtHoraEntrada.Text;
                    oVeiculo.HoraSaida = txtHoraSaida.Text;
                    oVeiculo.KmEntrada = txtKmEntrada.Text;
                    oVeiculo.KmSaida = txtKmSaida.Text;
                    oVeiculo.Placa = TxtPlaca.Text;
                    oVeiculo.Veiculo = txtVeiculo.Text;

                    _Control.Incluir(oVeiculo);
                }
            }


            txtData.Text = "";
            txtDestino.Text = "";
            txtHoraEntrada.Text = "";
            txtHoraSaida.Text = "";
            txtKmEntrada.Text = "";
            txtKmSaida.Text = "";
            TxtPlaca.Text = "";
            txtVeiculo.Text = "";
            cbFuncionario.Text = "";

            CarregaGrid();
        }
        private void LimpaCampos()
        {
            txtData.Text = "";
            txtDestino.Text = "";
            txtHoraEntrada.Text = "";
            txtHoraSaida.Text = "";
            txtKmEntrada.Text = "";
            txtKmSaida.Text = "";
            TxtPlaca.Text = "";
            txtVeiculo.Text = "";
            cbFuncionario.Text = "";
        }


        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void GrdVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdVeiculo.Rows[e.RowIndex].DataBoundItem != null)
            {
                EntradaSaida oVeiculo = ((EntradaSaida)GrdVeiculo.Rows[e.RowIndex].DataBoundItem);
                if (GrdVeiculo.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    txtData.Text = oVeiculo.Data;
                    txtDestino.Text = oVeiculo.Destino;
                    txtHoraEntrada.Text = oVeiculo.HoraEntrada;
                    txtHoraSaida.Text = oVeiculo.HoraSaida;
                    txtKmEntrada.Text = oVeiculo.KmEntrada;
                    txtKmSaida.Text = oVeiculo.KmSaida;
                    TxtPlaca.Text = oVeiculo.Placa;
                    txtVeiculo.Text = oVeiculo.Veiculo;
                    cbFuncionario.Text = oVeiculo.Funcionario;
                    

                }
                else if (GrdVeiculo.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Deseja realmente excluir?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Control.Excluir(oVeiculo);

                        txtData.Text = "";
                        txtDestino.Text = "";
                        txtHoraEntrada.Text = "";
                        txtHoraSaida.Text = "";
                        txtKmEntrada.Text = "";
                        txtKmSaida.Text = "";
                        TxtPlaca.Text = "";
                        txtVeiculo.Text = "";
                        cbFuncionario.Text = "";

                        CarregaGrid();
                    }
                }
            }
        }
    }
    
}
