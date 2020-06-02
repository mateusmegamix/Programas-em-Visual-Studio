using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace PORTARIA
{
    public partial class frmCadastrarPessoa : Form
    {
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        Image imgCaptured;
        Pessoa _pPessoa;
        VeiculoEMotorista _pVEM;
        bool _Alterar;
        public frmCadastrarPessoa(Pessoa pPessoa = null, VeiculoEMotorista pVEM = null, bool Alterar = false)
        {
            InitializeComponent();
            imgCaptured = null;
            _pPessoa = pPessoa;
            _Alterar = Alterar;
            _pVEM = pVEM;
        }

        private void LimparCampos()
        {
            ComportamentoCampos.LimpaCampos(this);
            txtNome.Focus();
            rbtTerceiro.Checked = true;
            txtRG.ReadOnly = true;
            txtCPF.ReadOnly = false;
            cbxNAOSEAPLICA.Checked = false;
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
                txtEmpresa.Text == string.Empty) || (!cbxNAOSEAPLICA.Checked && (txtMarca.Text == string.Empty || 
                txtModelo.Text == string.Empty || txtPlaca.Text == string.Empty || txtCNH.Text == string.Empty ||
                txtValidadeCNH.Text == string.Empty)))
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
            switch (_pPessoa.Categoria)
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

            txtNome.Text = _pPessoa.Nome;
            if (_pPessoa.Documento.Length > 12)
            {
                txtCPF.Text = _pPessoa.Documento;
            }
            else
            {
                txtRG.Text = _pPessoa.Documento;
                txtRG.ReadOnly = false;
                txtCPF.ReadOnly = true;
            }
            txtTelefone.Text = _pPessoa.Tel;
            txtEmpresa.Text = _pPessoa.Empresa;

            if (_pVEM != null)
            {
                txtMarca.Text = _pVEM.Marca;
                txtModelo.Text = _pVEM.Modelo;
                txtPlaca.Text = _pVEM.Placa;
                txtCNH.Text = _pVEM.CNH;
                txtValidadeCNH.Text = _pVEM.Validade;
                if (_pVEM.MOPP == "COM MOPP")
                {
                    cbxMOPP.Checked = true;
                }
                else
                {
                    cbxMOPP.Checked = false;
                }
            }
            else
            {
                cbxNAOSEAPLICA.Checked = true;
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

            this.Text = "Cadastro de pessoal - Você está cadastrando";
            if (_Alterar == true)
            {
                this.Text = "Cadastro de pessoal - Você está alterando";
                btnNovo.Enabled = false;
                CarregaAlterar();
            }
        }

        bool ligada = false;
        private void btnLigar_Click(object sender, EventArgs e)
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

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            imgCamera.BackgroundImage = bit;
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

        private void cbxNAOSEAPLICA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNAOSEAPLICA.Checked)
            {
                txtModelo.Enabled = false;
                txtModelo.Text = string.Empty;
                txtMarca.Enabled = false;
                txtMarca.Text = string.Empty;
                txtPlaca.Enabled = false;
                txtPlaca.Text = string.Empty;
                txtCNH.Enabled = false;
                txtCNH.Text = string.Empty;
                txtValidadeCNH.Enabled = false;
                txtValidadeCNH.Text = string.Empty;
                cbxMOPP.Enabled = false;
                cbxMOPP.Checked = false;
            }
            else
            {
                txtModelo.Enabled = true;
                txtMarca.Enabled = true;
                txtPlaca.Enabled = true;
                txtCNH.Enabled = true;
                txtValidadeCNH.Enabled = true;
                cbxMOPP.Enabled = true;
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.NumeroCPF(txtCPF, e);
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.NumeroRG(txtRG, e);
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.PlacaVeiculo(txtPlaca, e);
        }

        private void txtValidadeCNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.Data(txtValidadeCNH, e);    
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ComportamentoCampos.LetrasMaiusculas(txtNome, e);
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            ComportamentoCampos.LetrasMaiusculas(txtEmpresa, e);
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            ComportamentoCampos.LetrasMaiusculas(txtModelo, e);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            ComportamentoCampos.LetrasMaiusculas(txtMarca, e);
        }

        private void txtCNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.NumeroCNH(txtCNH, e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComportamentoCampos.NumeroTelefone(txtTelefone, e);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_Alterar == false)
            {
                Pessoa pessoa = new Pessoa();
                if (VerificaCampos() == true)
                {
                    pessoa.Nome = txtNome.Text;
                    if(txtCPF.Text == string.Empty)
                    {
                        pessoa.Documento = txtRG.Text;
                    }
                    else
                    {
                        pessoa.Documento = txtCPF.Text;
                    }
                    pessoa.Tel = txtTelefone.Text;
                    pessoa.Empresa = txtEmpresa.Text;

                    if (rbtTerceiro.Checked)
                        pessoa.Categoria = "TERCEIRO";
                    if (rbtVisitante.Checked)
                        pessoa.Categoria = "VISITANTE";
                    if (rbtColaborador.Checked)
                    {
                        pessoa.Categoria = "COLABORADOR";
                        pessoa.Empresa = "QUIMINVEST";
                    }

                    VeiculoEMotorista vem = new VeiculoEMotorista();
                    if (cbxNAOSEAPLICA.Checked == false)
                    {
                        vem.CodPessoa = Pessoa.ObterCodigo() + 1;
                        vem.Modelo = txtModelo.Text;
                        vem.Marca = txtMarca.Text;
                        vem.Placa = txtPlaca.Text;
                        vem.CNH = txtCNH.Text;
                        vem.Validade = txtValidadeCNH.Text;
                        if (cbxMOPP.Checked)
                        {
                            vem.MOPP = "COM MOPP";
                        }
                        else
                        {
                            vem.MOPP = "SEM MOPP";
                        }
                    }
                    else
                    {
                        vem = null;
                    }

                    bool ok = false;
                    if (Pessoa.Incluir(pessoa))
                    {

                        if (vem != null)
                        {
                            ok = VeiculoEMotorista.Incluir(vem);

                        }
                        else
                        {
                            ok = true;
                        }
                    }
                    if (ok == true)
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
                Pessoa pessoa = new Pessoa();
                if (VerificaCampos() == true)
                {
                    pessoa.Codigo = _pPessoa.Codigo;
                    pessoa.Nome = txtNome.Text;
                    if (txtCPF.Text == string.Empty)
                    {
                        pessoa.Documento = txtRG.Text;
                    }
                    else
                    {
                        pessoa.Documento = txtCPF.Text;
                    }
                    pessoa.Tel = txtTelefone.Text;
                    pessoa.Empresa = txtEmpresa.Text;

                    if (rbtTerceiro.Checked)
                        pessoa.Categoria = "TERCEIRO";
                    if (rbtVisitante.Checked)
                        pessoa.Categoria = "VISITANTE";
                    if (rbtColaborador.Checked)
                    {
                        pessoa.Categoria = "COLABORADOR";
                        pessoa.Empresa = "QUIMINVEST";
                    }

                    //Atualiza informações do veículo/motorista ou exclui caso existam informações
                    //mas elas não se aplicam mais a esta pessoa (cbxNAOSEPALICA.Checked == true)
                    VeiculoEMotorista vem = new VeiculoEMotorista();
                    if (cbxNAOSEAPLICA.Checked == false)
                    {
                        vem.CodPessoa = _pPessoa.Codigo;
                        vem.Modelo = txtModelo.Text;
                        vem.Marca = txtMarca.Text;
                        vem.Placa = txtPlaca.Text;
                        vem.CNH = txtCNH.Text;
                        vem.Validade = txtValidadeCNH.Text;
                        if (cbxMOPP.Checked)
                        {
                            vem.MOPP = "COM MOPP";
                        }
                        else
                        {
                            vem.MOPP = "SEM MOPP";
                        }
                    }
                    else
                    {
                        vem = null;
                    }

                    bool ok = false;
                    if (Pessoa.Alterar(pessoa))
                    {
                        if (vem != null)
                        {
                            List<VeiculoEMotorista> lista = VeiculoEMotorista.CarregarPK(pessoa.Codigo);

                            if (lista.Count > 0) //se já existe um veiculo atribuido a essa pessoa, altera as informações dele
                            {
                                ok = VeiculoEMotorista.Alterar(vem);
                            }
                            else
                            {
                                ok = VeiculoEMotorista.Incluir(vem); //Se não, atribui um novo veiculo a essa pessoa
                            }
                        }
                        else
                        {
                            if (_pVEM != null)
                            {
                                ok = VeiculoEMotorista.Excluir(_pVEM); //Se havia um veiculo atribuido e o usuario removeu as informações, exclui esse veiculo.
                            }
                            else
                            {
                                ok = true;
                            }
                        }
                    }
                    if (ok == true)
                    {
                        try
                        {
                            if (!System.IO.Directory.Exists(@".\Captured Images\"))
                            {
                                System.IO.Directory.CreateDirectory(@".\Captured Images\");
                            }

                            if (imgCaptured != null)
                            {

                                string path = @".\Captured Images\" + pessoa.Codigo.ToString() + ".jpg";
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
