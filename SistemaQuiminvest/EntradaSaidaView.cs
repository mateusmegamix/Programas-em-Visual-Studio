using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaQuiminvest.Model;
using System.IO;

namespace SistemaQuiminvest
{
    public partial class EntradaSaidaView : Form
    {
        private bool Incluir = true;
        private Control.oVeiculo _Control = new Control.oVeiculo();
        int id=0;
        public Principal MdiContainer { get; internal set; }
        public EntradaSaidaView()
        {
            InitializeComponent();
        }

        private void EntradaSaidaView_Load(object sender, EventArgs e)
        {
            
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CarregaGrid();

            cbFuncionario.SelectedIndex = -1;
            cbFuncionario.Focus();

            List<funcionario> Funcionarios = _Control.SelecionarTodosFuncionarios();
            foreach(var x in Funcionarios)
            {
                cbFuncionario.Items.Add(x.Nome);
            }

        }

        private void CarregaFuncionario(funcionario oFuncionario)
        {
            cbFuncionario.SelectedValue = oFuncionario.Nome;
        }

        private void CarregaGrid()
        {
            GrdVeiculo.AutoGenerateColumns = false;
            GrdVeiculo.DataSource = _Control.SelecionarTodos();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            ((Principal)this.MdiContainer).MnuEntradaESaidaDeCarros.Enabled = true;
            this.Close();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void BtnSalvarEntradaSaida_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                //if ((TxtSenhaVeiculo == TxtConfirmarSenhaVeiculo) && (TxtSenhaVeiculo != null))
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

                if (Incluir)
                {                   
                    _Control.Incluir(oVeiculo);
                    Incluir = true;
                    MessageBox.Show("Cadastro de Entrada e saida  de veículo foi realizada com sucesso!");
                }

                else
                {
                    oVeiculo.Id = id;
                    _Control.Alterar(oVeiculo);
                    Incluir = true;
                    LimpaCampos();
                    MessageBox.Show("Os dados foram alterados com sucessso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


            
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
        
        txtDestino.Text = "";
        txtHoraEntrada.Text = "";
        txtHoraSaida.Text = "";
        txtKmEntrada.Text = "";
        txtKmSaida.Text = "";
        TxtPlaca.Text = "";
        txtVeiculo.Text = "";
        cbFuncionario.Text = "";

            Incluir = true;
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
                    id = oVeiculo.Id;


                }
                else if (GrdVeiculo.Columns[e.ColumnIndex].Name == "BtnExcluir") 
                    if (MessageBox.Show("Se confirmar será impossível recuperar os dados. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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
    

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            CREntradaSaida oes = new CREntradaSaida();
            oes.ShowDialog();
        }

        private void EntradaSaidaView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuEntradaESaidaDeCarros.Enabled = true;
        }
    }
}
