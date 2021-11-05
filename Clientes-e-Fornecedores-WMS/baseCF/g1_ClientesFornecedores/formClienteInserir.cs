using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace baseCF
{
    public partial class formClienteInserir : Form
    {
        public formClienteInserir()
        {
            InitializeComponent();
           

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void formClienteInserir_Load(object sender, EventArgs e)
        {
            if (chkEditar.Checked)
            {
                mkdCNPJ.Enabled = false;
                mkdCPF.Enabled = false;
                txtNome.Enabled = false;
                txtNomeFantasia.Enabled = false;
                rbtnPF.Enabled = false;
                rbtnPJ.Enabled = false;
                cboStatusCadastro.Enabled = false;
               
            }


        }

        public void fillCboEstado()

        {
            try
            {
                
                
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblEstado ORDER BY g1_tblEstado.descEstado  ";


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboEstado.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cboEstado.DisplayMember = "siglaEstado";
                cboEstado.ValueMember = "idEstado";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void fillCboCidade()

        {
            try
            {
                
                
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblCidade ";

                SQL += "WHERE g1_tblCidade.idEstado=" + cboEstado.SelectedValue + " ";
                SQL += "ORDER BY g1_tblCidade.descCidade  ";


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboCidade.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cboCidade.DisplayMember = "descCidade";
                cboCidade.ValueMember = "idCidade";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void fillCboBairro()

        {
            try
            {
                
                
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblBairro ";

                SQL += "WHERE g1_tblBairro.idCidade=" + cboCidade.SelectedValue + " ";
                SQL += "ORDER BY g1_tblbairro.descBairro  ";


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboBairro.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cboBairro.DisplayMember = "descBairro";
                cboBairro.ValueMember = "idBairro";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void fillCboSegmento()

        {
            try
            {
                
                
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblSegmento ORDER BY g1_tblSegmento.descSegmento";


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboSegmento.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cboSegmento.DisplayMember = "descSegmento";
                cboSegmento.ValueMember = "idSegmento";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public void fillCboBanco()

        {
            try
            {
                
                
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblBanco ORDER BY g1_tblBanco.descBanco";


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboBanco.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cboBanco.DisplayMember = "descBanco";
                cboBanco.ValueMember = "idBanco";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void fillCboStatus()

        {
            try
            {
                
                
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblStatusCadastro";


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboStatusCadastro.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cboStatusCadastro.DisplayMember = "descStatusCadastro";
                cboStatusCadastro.ValueMember = "idStatusCadastro";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void cboEstado_MouseClick(object sender, MouseEventArgs e)
        {
            fillCboEstado();
        }

        private void cboEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillCboCidade();
            fillCboBairro();
        }

        private void cboCidade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillCboBairro();

        }

        private void cboBanco_MouseClick(object sender, MouseEventArgs e)
        {
            fillCboBanco();
        }

        private void cboSegmento_MouseClick(object sender, MouseEventArgs e)
        {
            fillCboSegmento();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            int statusCa;

            if (ValidarForm()) //Verifica se os dados obrigatórios foram preenchidos

            {
                MessageBox.Show("Favor preencher todos os campos obrigatórios (*).");
            }

            else //se todos foram preenchidos verifica se os campos foram preenchidos para verificar se fecha o cadastro.

            {

                if (ValidarStatus() == 2) //todos os dados preenchidos

                {
                    DialogResult RespUsuario = MessageBox.Show("Todos os dados foram preenchidos. Deseja finalizar esse cadastro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (RespUsuario.ToString() == "Yes")
                        {
                        statusCa = 2;
                        }
                    else
                        {
                        statusCa = 1;
                        }
                }
                else //caso ainda tenham campos em branco
                {
                    statusCa = 1;

                }
                
                if (ValidarDuplicidade() > 0)
                    {
                        MessageBox.Show("Esse cliente já se encontra registrado. Favor revisar os dados para prosseguir");
                    }
                else if (ValidarDuplicidade() < 0)
                    {

                    try
                        {
                            
                            
                            OleDbConnection con = new OleDbConnection(Globals.ConnString);
                            con.Open();


                            String SQL;
                            SQL = "UPDATE g1_tblClientes SET ";

                            SQL += "nome = " + "'" + txtNome.Text + "',";
                            SQL += " razaoSocial = '" + txtRazaoSocial.Text + "',";
                            SQL += "nomeFantasia = '" + txtNomeFantasia.Text + "',";
                            mkdCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            SQL += "CPF = '" + mkdCPF.Text + "',";
                            mkdCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            SQL += "CNPJ = '" + mkdCNPJ.Text + "',";
                            SQL += "inscricaoEstadual = '" + txtInsEstadual.Text + "',";
                            SQL += "inscricaoMunicipal = '" + txtInsMunicipal.Text + "',";
                            SQL += "idBanco = '" + cboBanco.SelectedValue + "',";
                            SQL += "agencia = '" + txtAgencia.Text + "',";
                            SQL += "contaCorrente = '" + txtContaCorrente.Text + "',";
                            SQL += "digitoContaCorrente = '" + txtDigitoVerificador.Text + "',";
                            SQL += "idSegmento = '" + cboSegmento.SelectedValue + "',";
                            SQL += "dataNascimento = '" + mkdDataNascimento.Text + "',";
                            SQL += "telefoneFixo = '" + mkdTelFixo.Text + "',";
                            SQL += "telefoneCelular = '" + mkdTelCelular.Text + "',";
                            SQL += "idEstado = '" + cboEstado.SelectedValue + "',";
                            SQL += "idCidade = '" + cboCidade.SelectedValue + "',";
                            SQL += "idBairro = '" + cboBairro.SelectedValue + "',";
                            SQL += "logradouro = '" + txtLogradouro.Text + "',";
                            SQL += "numero ='" + txtNumero.Text + "',";
                            SQL += "complemento = '" + txtComplemento.Text + "',";
                            SQL += "CEP = '" + mkdCEP.Text + "',";
                            SQL += "email = '" + txtEmail.Text + "',";
                            SQL += "nivelSLA = '" + txtNivelSLA.Text + "',";
                            SQL += "nomeContato = '" + txtContato.Text + "',";
                            SQL += "statusCadastro ='" + statusCa + "',";
                            SQL += "dadosAdicionais1 = '" + txtDadosAdicionais1.Text + "',";
                            SQL += "dadosAdicionais2 = '" + txtDadosAdicionais2.Text + "',";
                            SQL += "dadosAdicionais3= '" + txtDadosAdicionais3.Text + "'";
                            SQL += " WHERE idCliente = " + txtCodigo.Text;


                            OleDbCommand cmd = new OleDbCommand(SQL, con);
                            cmd.ExecuteNonQuery();

                            UserI LC = new UserI();

                            LC.limparCampos(tabControl1.Controls);

                            con.Close();

                            formCliente voltarFormCliente = new formCliente();
                            voltarFormCliente.ShowDialog();
                            this.Close();
                        }

                        catch (Exception erro)
                        {

                            MessageBox.Show(erro.Message);
                        }


                        MessageBox.Show("Dados gravados com sucesso");
                    }
                    else if (ValidarDuplicidade() == 0)
                    {
                        try
                        {
                            
                            
                            OleDbConnection con = new OleDbConnection(Globals.ConnString);
                            con.Open();


                            String SQL;
                            mkdCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            mkdCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                            SQL = "INSERT INTO g1_tblClientes (nome, razaoSocial, NomeFantasia, CPF, CNPJ, InscricaoEstadual, inscricaoMunicipal, idBanco, agencia, ";
                            SQL += "contaCorrente, digitoContaCorrente, idSegmento, dataNascimento, telefoneFixo, telefoneCelular, idEstado, idCidade, idBairro, ";
                            SQL += "logradouro, numero, complemento, CEP, Email, nivelSLA, nomeContato, statusCadastro, dadosAdicionais1, dadosAdicionais2, dadosAdicionais3) VALUES ";

                            SQL += "('" + txtNome.Text + "','" + txtRazaoSocial.Text + "','" + txtNomeFantasia.Text + "','" + mkdCPF.Text + "','" + mkdCNPJ.Text + "','" + txtInsEstadual.Text + "',";
                            SQL += "'" + txtInsMunicipal.Text + "','" + cboBanco.SelectedValue + "','" + txtAgencia.Text + "','" + txtContaCorrente.Text + "','" + txtDigitoVerificador.Text + "',";
                            SQL += "'" + cboSegmento.SelectedValue + "','" + mkdDataNascimento.Text + "','" + mkdTelFixo.Text + "','" + mkdTelCelular.Text + "','" + cboEstado.SelectedValue + "',";
                            SQL += "'" + cboCidade.SelectedValue + "','" + cboBairro.SelectedValue + "','" + txtLogradouro.Text + "','" + txtNumero.Text + "','" + txtComplemento.Text + "',";
                            SQL += "'" + mkdCEP.Text + "','" + txtEmail.Text + "','" + txtNivelSLA.Text + "','" + txtContato.Text + "','" + cboStatusCadastro.SelectedValue + "','" + txtDadosAdicionais1.Text + "','" + txtDadosAdicionais2.Text + "',";
                            SQL += "'" + txtDadosAdicionais3.Text + "')";



                            OleDbCommand cmd = new OleDbCommand(SQL, con);
                            cmd.ExecuteNonQuery();

                            UserI LC = new UserI();

                            LC.limparCampos(tabControl1.Controls);

                            con.Close();

                            formCliente voltarFormCliente = new formCliente();
                            voltarFormCliente.ShowDialog();
                            this.Close();
                        }

                        catch (Exception erro)
                        {

                            MessageBox.Show(erro.Message);
                        }
                    }

                }
        }   

        private bool ValidarForm()
        {
            bool camposBrancos;
            if (rbtnPF.Checked)
            {
                mkdCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (mkdCPF.Text != "" && txtNome.Text != "" && cboSegmento.SelectedValue != null && cboBairro.SelectedValue != null && cboBanco.SelectedValue != null && cboCidade.SelectedValue != null && cboEstado.SelectedValue!= null)
                {
                    camposBrancos = false;
                }
                else
                {
                    camposBrancos = true;
                }
            }
            else
            {
                mkdCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if(mkdCNPJ.Text !="" && txtNomeFantasia.Text !="" && cboSegmento.SelectedValue != null && cboBairro.SelectedValue != null && cboBanco.SelectedValue != null && cboCidade.SelectedValue != null && cboEstado.SelectedValue != null)
                {
                    camposBrancos = false;

                }
                else
                {
                    camposBrancos = true;
                }

            }

            return camposBrancos;

        }

        private int ValidarStatus()
        {
            int statusCadastro;

            if (rbtnPF.Checked)
            {
                mkdCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (mkdCPF.Text != ""
                    && txtNome.Text != ""
                    && cboBanco.SelectedValue != null
                    && txtAgencia.Text != ""
                    && txtContaCorrente.Text != ""
                    && txtDigitoVerificador.Text != ""
                    && cboSegmento.SelectedValue != null
                    && mkdDataNascimento.Text != ""
                    && mkdTelFixo.Text != ""
                    && mkdTelCelular.Text != ""
                    && cboEstado.SelectedValue != null
                    && cboCidade.SelectedValue != null
                    && cboBairro.SelectedValue != null
                    && txtLogradouro.Text != ""
                    && txtNumero.Text != ""
                    && txtComplemento.Text != ""
                    && mkdCEP.Text != ""
                    && txtEmail.Text != ""
                    && txtNivelSLA.Text != ""
                    && txtContato.Text != "")
                {
                    statusCadastro = 2;
                }

                else
                {
                    statusCadastro = 1;
                }
            }

            else
            { 
                mkdCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if
                    (mkdCNPJ.Text != ""
                    && txtNomeFantasia.Text != ""
                    && txtRazaoSocial.Text != ""
                    && txtInsEstadual.Text != ""
                    && txtInsMunicipal.Text != ""
                    && txtAgencia.Text != ""
                    && txtContaCorrente.Text != ""
                    && txtDigitoVerificador.Text != ""
                    && cboSegmento.SelectedValue != null
                    && mkdDataNascimento.Text != ""
                    && mkdTelFixo.Text != ""
                    && mkdTelCelular.Text != ""
                    && cboEstado.SelectedValue != null
                    && cboCidade.SelectedValue != null
                    && cboBairro.SelectedValue != null
                    && txtLogradouro.Text != ""
                    && txtNumero.Text != ""
                    && txtComplemento.Text != ""
                    && mkdCEP.Text != ""
                    && txtEmail.Text != ""
                    && txtNivelSLA.Text != ""
                    && txtContato.Text != "")
                {
                    statusCadastro = 2;
                }

                else
                {
                    statusCadastro = 1;
                }
            }

            return statusCadastro;
               

        }


        private void PFPJ()
        {

            if (rbtnPF.Checked == true)
            {
                
                txtInsEstadual.Enabled = false;
                txtInsMunicipal.Enabled = false;
                txtNomeFantasia.Enabled = false;
                txtRazaoSocial.Enabled = false;
                mkdCNPJ.Enabled = false;

                txtNome.Enabled = true;
                mkdCPF.Enabled = true;
                mkdDataNascimento.Enabled = true;


            }
            else
            {
                
                txtNome.Enabled = false;
                mkdCPF.Enabled = false;
                mkdDataNascimento.Enabled = false;

                txtInsEstadual.Enabled = true;
                txtInsMunicipal.Enabled = true;
                txtNomeFantasia.Enabled = true;
                txtRazaoSocial.Enabled = true;
                mkdCNPJ.Enabled = true;

            }
        }

        private void rbtnPF_CheckedChanged(object sender, EventArgs e)
        {
            PFPJ();
        }

        private void rbtnPJ_CheckedChanged(object sender, EventArgs e)
        {
            PFPJ();
        }

        private int ValidarDuplicidade()
        {
            if (chkEditar.Checked)
            {
                return -1;
            }
            else
            {
                try
                {
                    
                    
                    OleDbConnection con = new OleDbConnection(Globals.ConnString);
                    con.Open();

                    String SQL;
                    SQL = "SELECT COUNT (*) FROM g1_tblClientes ";





                    if (rbtnPF.Checked)
                    {
                        mkdCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        
                        SQL += "WHERE g1_tblClientes.CPF = " + "'" + mkdCPF.Text + "'" + " And g1_tblClientes.nome = " + "'" + txtNome.Text + "'";
                    }
                    else
                    {
                        mkdCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                        SQL += "WHERE g1_tblClientes.CNPJ = " + "'" + mkdCNPJ.Text + "'" + " And g1_tblClientes.nomeFantasia = " + "'" + txtNomeFantasia.Text + "'";
                    }


                    OleDbCommand cmd = new OleDbCommand(SQL, con);

                    int teste = (Int32)cmd.ExecuteScalar();

                    con.Close();

                    return teste;

                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    return 1;

                }
            }

        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            formMenuCadastro abrirFormMenuIncial= new formMenuCadastro();
            abrirFormMenuIncial.ShowDialog();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            formMenuCadastro abrirFormMenuCadastro = new formMenuCadastro();
            abrirFormMenuCadastro.ShowDialog();
            this.Close();
        }

        private void txtNomeFantasia_MouseMove(object sender, MouseEventArgs e)
        {
            if (rbtnPF.Checked)
            {
                ttlCamposObrigatorios.SetToolTip(this.txtNomeFantasia, "Campo de preenchimento obrigatório");
            }
        }

        private void mkdCPF_Move(object sender, EventArgs e)
        {
            if (rbtnPF.Checked)
            {
                ttlCamposObrigatorios.SetToolTip(this.mkdCPF, "Campo de preenchimento obrigatório");
            }
        }

        private void cboEstado_Move(object sender, EventArgs e)
        {
            
                ttlCamposObrigatorios.SetToolTip(this.cboEstado, "Campo obrigatório. Selecione um Estado para prosseguir.");
            
        }

        private void cboCidade_Move(object sender, EventArgs e)
        {
            ttlCamposObrigatorios.SetToolTip(this.cboCidade, "Campo obrigatório. Selecione uma Cidade para prosseguir.");
        }

        private void cboBairro_Move(object sender, EventArgs e)
        {
            ttlCamposObrigatorios.SetToolTip(this.cboBairro, "Campo obrigatório. Selecione um Bairro para prosseguir.");
        }

        private void cboSegmento_Move(object sender, EventArgs e)
        {
            ttlCamposObrigatorios.SetToolTip(this.cboSegmento, "Campo obrigatório. Selecione um Segmento para prosseguir.");
        }

        private void cboBanco_Move(object sender, EventArgs e)
        {
            ttlCamposObrigatorios.SetToolTip(this.cboBanco, "Campo obrigatório. Selecione um Banco para prosseguir.");
        }

        private void mkdCNPJ_Move(object sender, EventArgs e)
        {
            if (rbtnPJ.Checked)
            {
                ttlCamposObrigatorios.SetToolTip(this.mkdCNPJ, "Campo de preenchimento obrigatório");
            }
        }

        private void txtNomeFantasia_Move(object sender, EventArgs e)
        {
            if (rbtnPJ.Checked)
            {
                ttlCamposObrigatorios.SetToolTip(this.txtNomeFantasia, "Campo de preenchimento obrigatório");
            }
        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void txtRazaoSocial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
