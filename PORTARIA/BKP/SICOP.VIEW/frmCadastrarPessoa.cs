using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOP.MODEL;
using SICOP.CONTROLLER;
using System.IO;

namespace SICOP.VIEW
{
    public partial class frmCadastrarPessoa : Form
    {

        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        Image imgCaptured;
        Pessoa _pPessoa;
        CNH _pCNH;
        Veiculo _pVeiculo;
        bool _Alterar;

        public frmCadastrarPessoa(Pessoa pPessoa = null, CNH pCNH = null, Veiculo pVeiculo = null, bool Alterar = false)
        {
            InitializeComponent();
            imgCaptured = null;
            _pPessoa = pPessoa;
            _pCNH = pCNH;
            _pVeiculo = pVeiculo;
            _Alterar = Alterar;
        }

        private void LimparCampos()
        {
            ComportamentoCampos.LimpaCampos(this);
            txtNome.Focus();
            rbtTerceiro.Checked = true;
            txtRG.ReadOnly = true;
            txtCPF.ReadOnly = false;
            cbxMotorista.SelectedIndex = 0;
            cbxMOPP.Checked = true;
            imgCamera.BackgroundImage = null;
            imgCaptured = null;
            if (cbxDispositivo.Items.Count > 0)
            {
                cam.Stop();
                cbxDispositivo.SelectedIndex = 0;
            }
            cbxDispositivo.Enabled = true;
            btnCapturar.Enabled = false;
            btnCapturar.Text = "Capturar";
            ligada = false;
        }

        private bool VerificaCampos()
        {
            bool retorno = false;

            if ((txtNome.Text == string.Empty || ((txtCPF.ReadOnly == false && txtCPF.TextLength < 14) ||
                (txtRG.ReadOnly == false && txtRG.TextLength < 12)) || txtTelefone.Text == string.Empty ||
                txtEmpresa.Text == string.Empty) || (cbxMotorista.SelectedIndex == 0 && (txtNumeroCNH.Text == string.Empty ||
                txtCategoria.Text == string.Empty || txtValidadeCNH.Text == string.Empty || txtTipo.Text == string.Empty ||
                txtPlaca.Text == string.Empty || txtCidade.Text == string.Empty)))
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                retorno = false;
            }
            else
            {
                retorno = true;
            }
            return retorno;
        }

        private void CarregaAlterar()
        {
            switch (_pPessoa.PesVinculo)
            {
                case "TERCEIRO":
                    rbtTerceiro.Checked = true;
                    break;
                case "VISITANTE":
                    rbtVisitante.Checked = true;
                    break;
                case "COLABORADOR":
                    rbtColaborador.Checked = true;
                    txtEmpresa.Text = "QUIMINVEST";
                    txtEmpresa.Enabled = false;
                    break;
            }

            txtNome.Text = _pPessoa.PesNome;
            if (_pPessoa.PesDocumento.Length > 12)
            {
                txtCPF.Text = _pPessoa.PesDocumento;
            }
            else
            {
                txtRG.Text = _pPessoa.PesDocumento;
                txtRG.ReadOnly = false;
                txtCPF.ReadOnly = true;
            }
            txtTelefone.Text = _pPessoa.PesTelefone;
            txtEmpresa.Text = _pPessoa.PesEmpresa;

            if (_pCNH != null && _pVeiculo != null)
            {
                txtNumeroCNH.Text = _pCNH.CNHNumero;
                txtCategoria.Text = _pCNH.CNHCategoria;
                txtValidadeCNH.Text = _pCNH.CNHValidade;
                if (_pCNH.CNHMopp == "SIM")
                {
                    cbxMOPP.Checked = true;
                }
                else
                {
                    cbxMOPP.Checked = false;
                }

                txtTipo.Text = _pVeiculo.VeiTipo;
                txtPlaca.Text = _pVeiculo.VeiPlaca;
                txtCidade.Text = _pVeiculo.VeiCidadePlaca;

            }
            else
            {
                cbxMotorista.SelectedIndex = 1;
            }

        }

        private void frmCadastrarPessoa_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                cbxDispositivo.Items.Add(VideoCaptureDevice.Name);
            }
            if (cbxDispositivo.Items.Count > 0)
            {
                cbxDispositivo.SelectedIndex = 0;
                cam = new VideoCaptureDevice(webcam[cbxDispositivo.SelectedIndex].MonikerString);
                cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            }

            cbxMotorista.SelectedIndex = 0;
            if (_Alterar == true)
            {
                this.Text = "Alterar Cadastro";
                btnNovo.Enabled = false;
                CarregaAlterar();
            }
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            imgCamera.BackgroundImage = bit;
        }

        bool ligada = false;
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (cbxDispositivo.Text != string.Empty)
            {
                if (ligada == false)
                {
                    cam.Start();
                    btnCapturar.Enabled = true;
                    cbxDispositivo.Enabled = false;
                    ligada = true;
                }
                else
                {
                    cam.Stop();
                    imgCamera.BackgroundImage = null;
                    btnCapturar.Enabled = false;
                    cbxDispositivo.Enabled = true;
                    btnCapturar.Text = "Capturar";
                    ligada = false;
                }
            }
            else
            {
                MessageBox.Show("Nenhuma Webcam encontrada! Feche o programa, verifique se a câmera está conectado ao computador e se os drivers estão devidamente instalados e tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void rbtColaborador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtColaborador.Checked)
            {
                txtEmpresa.Enabled = false;
                txtEmpresa.Text = "QUIMINVEST";
            }
            else
            {
                txtEmpresa.Enabled = true;
                txtEmpresa.Text = string.Empty;
            }
        }

        private void cbxMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMotorista.SelectedIndex == 0)
            {
                gbxCNH.Enabled = true;
                gbxVeiculo.Enabled = true;
            }
            else
            {
                txtNumeroCNH.Text = string.Empty;
                txtCategoria.Text = string.Empty;
                txtValidadeCNH.Text = string.Empty;
                cbxMOPP.Checked = true;
                txtTipo.Text = string.Empty;
                txtPlaca.Text = string.Empty;
                txtCidade.Text = string.Empty;
                gbxCNH.Enabled = false;
                gbxVeiculo.Enabled = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.NumeroCPF(txtCPF, e);
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.NumeroRG(txtRG, e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.NumeroTelefone(txtTelefone, e);
        }

        private void txtCNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.NumeroCNH(txtNumeroCNH, e);
        }

        private void txtValidadeCNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.Data(txtValidadeCNH, e);
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.PlacaVeiculo(txtPlaca, e);
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.ApenasLetras(e);
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.ReadOnly = false;
            txtRG.ReadOnly = true;
            txtRG.Text = string.Empty;
            txtRG.TabStop = false;
        }

        private void txtRG_Enter(object sender, EventArgs e)
        {
            txtRG.ReadOnly = false;
            txtCPF.ReadOnly = true;
            txtCPF.Text = string.Empty;
            txtCPF.TabStop = false;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Text == "Capturar")
            {
                imgCaptured = imgCamera.BackgroundImage;
                cam.Stop();
                btnCapturar.Text = "Nova foto";
            }
            else
            {
                cam.Start();
                btnCapturar.Text = "Capturar";
                imgCaptured = null;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_Alterar == false)
            {
                if (VerificaCampos())
                {
                    //Pessoa
                    Pessoa oPessoa = new Pessoa();
                    oPessoa.PesNome = txtNome.Text;
                    if (txtCPF.Text == string.Empty)
                    {
                        oPessoa.PesDocumento = txtRG.Text;
                    }
                    else
                    {
                        oPessoa.PesDocumento = txtCPF.Text;
                    }
                    oPessoa.PesTelefone = txtTelefone.Text;
                    oPessoa.PesEmpresa = txtEmpresa.Text;
                    if (rbtTerceiro.Checked)
                        oPessoa.PesVinculo = "TERCEIRO";
                    if (rbtVisitante.Checked)
                        oPessoa.PesVinculo = "VISITANTE";
                    if (rbtColaborador.Checked)
                    {
                        oPessoa.PesVinculo = "COLABORADOR";
                        oPessoa.PesEmpresa = "QUIMINVEST";
                    }

                    bool registroFoiIncluido = false;
                    if (cbxMotorista.SelectedIndex == 0)
                    {
                        //CNH
                        CNH oCNH = new CNH();
                        oCNH.CNHPesCodigo = CPessoa.ObterCodigo() + 1;
                        oCNH.CNHNumero = txtNumeroCNH.Text;
                        oCNH.CNHCategoria = txtCategoria.Text;
                        oCNH.CNHValidade = txtValidadeCNH.Text;
                        if (cbxMOPP.Checked)
                        {
                            oCNH.CNHMopp = "SIM";
                        }
                        else
                        {
                            oCNH.CNHMopp = "NÃO";
                        }
                        //Veiculo
                        Veiculo oVeiculo = new Veiculo();
                        oVeiculo.VeiPesCodigo = CPessoa.ObterCodigo() + 1;
                        oVeiculo.VeiTipo = txtTipo.Text;
                        oVeiculo.VeiPlaca = txtPlaca.Text;
                        oVeiculo.VeiCidadePlaca = txtCidade.Text;

                        registroFoiIncluido = CPessoa.IncluirCompleto(oPessoa, oCNH, oVeiculo);
                    }
                    else
                    {
                        registroFoiIncluido = CPessoa.Incluir(oPessoa);
                    }

                    //Incluir
                    if (registroFoiIncluido == true)
                    {
                        try
                        {
                            if (!System.IO.Directory.Exists(@".\Captured Images\"))
                            {
                                System.IO.Directory.CreateDirectory(@".\Captured Images\");
                            }

                            if (imgCaptured != null)
                            {
                                string path = @".\Captured Images\" + Pessoa.ObterCodigo().ToString() + ".jpg";
                                FileStream fstream = new FileStream(path, FileMode.Create);
                                imgCaptured.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                fstream.Close();
                            }
                            LimparCampos();
                            MessageBox.Show("Registro salvo com sucesso!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao salvar imagem! Tente novamente.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar registro! Tente novamente.");
                    }
                }
            }
            else
            {
                if (VerificaCampos())
                {
                    //Pessoa
                    Pessoa oPessoa = new Pessoa();
                    oPessoa.PesCodigo = _pPessoa.PesCodigo;
                    oPessoa.PesNome = txtNome.Text;
                    if (txtCPF.Text == string.Empty)
                    {
                        oPessoa.PesDocumento = txtRG.Text;
                    }
                    else
                    {
                        oPessoa.PesDocumento = txtCPF.Text;
                    }
                    oPessoa.PesTelefone = txtTelefone.Text;
                    oPessoa.PesEmpresa = txtEmpresa.Text;
                    if (rbtTerceiro.Checked)
                        oPessoa.PesVinculo = "TERCEIRO";
                    if (rbtVisitante.Checked)
                        oPessoa.PesVinculo = "VISITANTE";
                    if (rbtColaborador.Checked)
                    {
                        oPessoa.PesVinculo = "COLABORADOR";
                        oPessoa.PesEmpresa = "QUIMINVEST";
                    }

                    bool registroFoiAlterado = false;
                    CNH oCNH = new CNH();
                    Veiculo oVeiculo = new Veiculo();
                    if (cbxMotorista.SelectedIndex == 0)
                    {
                        //CNH                      
                        oCNH.CNHPesCodigo = _pPessoa.PesCodigo;
                        oCNH.CNHNumero = txtNumeroCNH.Text;
                        oCNH.CNHCategoria = txtCategoria.Text;
                        oCNH.CNHValidade = txtValidadeCNH.Text;
                        if (cbxMOPP.Checked)
                        {
                            oCNH.CNHMopp = "SIM";
                        }
                        else
                        {
                            oCNH.CNHMopp = "NÃO";
                        }
                        //Veiculo                     
                        oVeiculo.VeiPesCodigo = _pPessoa.PesCodigo;
                        oVeiculo.VeiTipo = txtTipo.Text;
                        oVeiculo.VeiPlaca = txtPlaca.Text;
                        oVeiculo.VeiCidadePlaca = txtCidade.Text;

                        //Se existir CNH e Veiculo asscociados a esta pessoa, altera todos os objetos
                        //Se não, altera o objeto Pessoa e inclui o CNH e o Veiculo no banco
                        if(_pCNH != null && _pVeiculo != null)
                        {
                            registroFoiAlterado = CPessoa.AlterarCompleto(oPessoa, oCNH, oVeiculo);
                        }
                        else
                        {
                            registroFoiAlterado = CPessoa.Alterar(oPessoa) && CCNH.Incluir(oCNH) && CVeiculo.Incluir(oVeiculo);
                        }                
                    }
                    else
                    {
                        //Se existir CNH e Veiculo asscociados a esta pessoa, exclui estes objetos
                        //Se não, altera o objeto Pessoa
                        if (_pCNH != null && _pVeiculo != null)
                        {
                            registroFoiAlterado = CPessoa.Alterar(oPessoa) && CCNH.Excluir(_pCNH) && CVeiculo.Excluir(_pVeiculo);
                        }
                        else
                        {
                            registroFoiAlterado = CPessoa.Alterar(oPessoa);
                        }
                    }
                    //Alterar
                    if (registroFoiAlterado == true)
                    {
                        try
                        {
                            if (!System.IO.Directory.Exists(@".\Captured Images\"))
                            {
                                System.IO.Directory.CreateDirectory(@".\Captured Images\");
                            }

                            if (imgCaptured != null)
                            {

                                string path = @".\Captured Images\" + oPessoa.PesCodigo.ToString() + ".jpg";
                                if (System.IO.File.Exists(path))
                                {
                                    System.IO.File.Delete(path);
                                }
                                FileStream fstream = new FileStream(path, FileMode.Create);
                                imgCaptured.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                fstream.Close();

                                imgCaptured.Dispose();
                            }


                            MessageBox.Show("Registro alterado com sucesso!");
                            LimparCampos();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao alterar foto! Tente novamente.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar registro! Tente novamente.");
                    }
                }
            }
        }

        private void frmCadastrarPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_Alterar == true)
            {
                frmConsultarPessoa frm = new frmConsultarPessoa();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }

            //desliga webcam
            if (cbxDispositivo.Items.Count > 0)
            {
                cam.Stop();
            }
        }
    }
}
