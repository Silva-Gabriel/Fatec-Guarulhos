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

    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();
        }


        void fillCboStatus()

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

                dt.Load(dr);

                cboStatus.DataSource = (dt);

                //cboTipoTributo.Items.Clear();
                cboStatus.DisplayMember = "descStatusCadastro";
                cboStatus.ValueMember = "idStatusCadastro";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        void fillCboCidade()

        {
            try
            {


                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT g1_tblCidade.IdCidade , g1_tblCidade.descCidade FROM ";

                SQL += "g1_tblCidade INNER JOIN g1_tblClientes ON ";
                SQL += "g1_tblCidade.idCidade = g1_tblClientes.IdCidade GROUP BY ";
                SQL += "g1_tblCidade.idCidade , g1_tblCidade.descCidade ORDER BY g1_tblCidade.descCidade  ";


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
        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            formClienteInserir abrirFormClienteInserir = new formClienteInserir();
            abrirFormClienteInserir.fillCboStatus();
            abrirFormClienteInserir.cboStatusCadastro.SelectedValue = 1;
            abrirFormClienteInserir.rbtnPJ.Checked = true;
            abrirFormClienteInserir.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            formMenuCadastro abrirFormMenuInicial = new formMenuCadastro();
            abrirFormMenuInicial.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void rbtnPF_CheckedChanged(object sender, EventArgs e)
        {
            selecionarCliente();
        }

        private void cboStatus_MouseClick(object sender, MouseEventArgs e)
        {
            fillCboStatus();

        }

        private void cboStatus_Leave(object sender, EventArgs e)
        {
            if (cboStatus.SelectedValue == (null))

            {
                cboStatus.Text = "Selecione um status";
            }
        }

        private void cboCidade_Leave(object sender, EventArgs e)
        {
            if (cboCidade.SelectedValue == (null))

            {
                cboCidade.Text = "Selecione uma cidade";
            }
        }

        private void cboCidade_MouseClick(object sender, MouseEventArgs e)
        {
            fillCboCidade();
        }

        private void formCliente_Load(object sender, EventArgs e)
        {
            rbtnPJ.Checked = true;
            selecionarCliente();
            picBuscar.Visible = true;
            picBuscarClaro.Visible = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void selecionarCliente()
        {
            if (rbtnPF.Checked == true)
            {
                txtNomeFantasia.Enabled = false;
                txtNomeFantasia.Clear();
                mskCNPJ.Enabled = false;
                mskCNPJ.Clear();

                txtNomeCliente.Enabled = true;
                mskCPF.Enabled = true;
                lblCNPJ.Text = "CNPJ";
                lblNomeFantasia.Text = "Nome Fantasia";
                lblCPF.Text = "CPF *";
                lblNomeCliente.Text = "Nome do Cliente *";
            }
            else
            {
                txtNomeFantasia.Enabled = true;
                mskCNPJ.Enabled = true;
                txtNomeCliente.Enabled = false;
                txtNomeCliente.Clear();
                mskCPF.Enabled = false;
                mskCPF.Clear();
                lblCNPJ.Text = "CNPJ *";
                lblNomeFantasia.Text = "Nome Fantasia *";
                lblCPF.Text = "CPF";
                lblNomeCliente.Text = "Nome do Cliente";

            }
        }



        public void Consultar()
        {

            try
            {


                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();


                String SQL;





                if (rbtnPF.Checked == true)


                {
                    mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    SQL = "SELECT g1_tblClientes.idCliente, g1_tblClientes.nome, g1_tblClientes.razaoSocial, g1_tblClientes.nomeFantasia, g1_tblClientes.CPF, g1_tblClientes.CNPJ, g1_tblClientes.inscricaoEstadual, g1_tblClientes.inscricaoMunicipal, g1_tblClientes.idBanco, g1_tblClientes.agencia, g1_tblClientes.contaCorrente, g1_tblClientes.digitoContaCorrente, g1_tblClientes.idSegmento, g1_tblClientes.dataNascimento, g1_tblClientes.telefoneFixo, g1_tblClientes.telefoneCelular, g1_tblClientes.idEstado, g1_tblClientes.idCidade, g1_tblClientes.idBairro, g1_tblClientes.logradouro, g1_tblClientes.numero, g1_tblClientes.complemento, g1_tblClientes.CEP, g1_tblClientes.email, g1_tblClientes.nivelSLA, g1_tblClientes.nomeContato, g1_tblClientes.statusCadastro, g1_tblClientes.dadosAdicionais1, g1_tblClientes.dadosAdicionais2, g1_tblClientes.dadosAdicionais3, g1_tblStatusCadastro.descStatusCadastro, g1_tblCidade.descCidade, g1_tblEstado.siglaEstado ";
                    SQL += "FROM g1_tblEstado INNER JOIN((g1_tblStatusCadastro INNER JOIN g1_tblClientes ON g1_tblStatusCadastro.idStatusCadastro = g1_tblClientes.statusCadastro) INNER JOIN g1_tblCidade ON g1_tblClientes.idCidade = g1_tblCidade.idCidade) ON(g1_tblClientes.idEstado = g1_tblEstado.idEstado) AND(g1_tblEstado.idEstado = g1_tblCidade.idEstado) ";
                    SQL += "WHERE g1_tblCidade.idCidade LIKE '" + '%' + cboCidade.SelectedValue + '%' + "'";
                    SQL += " And g1_tblStatusCadastro.idStatusCadastro LIKE '" + '%' + cboStatus.SelectedValue + '%' + "'";
                    SQL += " And g1_tblClientes.nome LIKE '" + '%' + txtNomeCliente.Text + '%' + "'";
                    SQL += " And g1_tblClientes.CPF LIKE '" + '%' + mskCPF.Text + '%' + "'";
                }

                else


                {
                    mskCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    SQL = "SELECT g1_tblClientes.idCliente, g1_tblClientes.nome, g1_tblClientes.razaoSocial, g1_tblClientes.nomeFantasia, g1_tblClientes.CPF, g1_tblClientes.CNPJ, g1_tblClientes.inscricaoEstadual, g1_tblClientes.inscricaoMunicipal, g1_tblClientes.idBanco, g1_tblClientes.agencia, g1_tblClientes.contaCorrente, g1_tblClientes.digitoContaCorrente, g1_tblClientes.idSegmento, g1_tblClientes.dataNascimento, g1_tblClientes.telefoneFixo, g1_tblClientes.telefoneCelular, g1_tblClientes.idEstado, g1_tblClientes.idCidade, g1_tblClientes.idBairro, g1_tblClientes.logradouro, g1_tblClientes.numero, g1_tblClientes.complemento, g1_tblClientes.CEP, g1_tblClientes.email, g1_tblClientes.nivelSLA, g1_tblClientes.nomeContato, g1_tblClientes.statusCadastro, g1_tblClientes.dadosAdicionais1, g1_tblClientes.dadosAdicionais2, g1_tblClientes.dadosAdicionais3, g1_tblStatusCadastro.descStatusCadastro, g1_tblCidade.descCidade, g1_tblEstado.siglaEstado ";
                    SQL += "FROM g1_tblEstado INNER JOIN((g1_tblStatusCadastro INNER JOIN g1_tblClientes ON g1_tblStatusCadastro.idStatusCadastro = g1_tblClientes.statusCadastro) INNER JOIN g1_tblCidade ON g1_tblClientes.idCidade = g1_tblCidade.idCidade) ON(g1_tblClientes.idEstado = g1_tblEstado.idEstado) AND(g1_tblEstado.idEstado = g1_tblCidade.idEstado) ";
                    SQL += "WHERE g1_tblCidade.idCidade LIKE '" + '%' + cboCidade.SelectedValue + '%' + "'";
                    SQL += " AND g1_tblStatusCadastro.idStatusCadastro LIKE '" + '%' + cboStatus.SelectedValue + '%' + "'";
                    SQL += " AND g1_tblClientes.nomeFantasia LIKE '" + '%' + txtNomeFantasia.Text + '%' + "'";
                    SQL += " And g1_tblClientes.CNPJ LIKE '" + '%' + mskCNPJ.Text + '%' + "'";



                    //  SQL += " And g1_tblClientes.CNPJ=" + mskCNPJ.Text;
                }

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "g1_Clientes");


                dgnClientes.DataSource = DS.Tables["g1_Clientes"];

                for (int i = 1; i < 30; i++)
                {

                    dgnClientes.Columns[i].Visible = false;
                }

                dgnClientes.Columns[0].HeaderText = "Id Cadastro";
                dgnClientes.Columns[30].HeaderText = "Status do Cadastro";
                dgnClientes.Columns[31].HeaderText = "Município";
                dgnClientes.Columns[32].HeaderText = "Estado";

                dgnClientes.Columns[0].Width = 70;

                if (rbtnPF.Checked == true)
                {
                    dgnClientes.Columns[1].Visible = true;
                    dgnClientes.Columns[4].Visible = true;
                    dgnClientes.Columns[1].HeaderText = "Nome do Cliente";

                    dgnClientes.Columns[1].Width = 250;
                    dgnClientes.Columns[4].Width = 100;

                    foreach (DataGridViewRow row in dgnClientes.Rows)
                    {
                        if (row.Cells[4].Value != null)
                        {
                            row.Cells[4].Value = Convert.ToInt64(row.Cells[4].Value).ToString(@"000\.000\.000\-00");
                        }
                    }




                }

                else
                {
                    dgnClientes.Columns[3].Visible = true;
                    dgnClientes.Columns[5].Visible = true;
                    dgnClientes.Columns[3].HeaderText = "Nome Fantasia";

                    dgnClientes.Columns[3].Width = 250;
                    dgnClientes.Columns[5].Width = 125;

                    foreach (DataGridViewRow row in dgnClientes.Rows)
                    {
                        if (row.Cells[5].Value != null)
                        {
                            row.Cells[5].Value = Convert.ToInt64(row.Cells[5].Value).ToString(@"00\.000\.000\/0000\-00");
                        }
                    }
                }



                dgnClientes.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgnClientes.Columns[1].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgnClientes.Columns[3].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgnClientes.Columns[4].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgnClientes.Columns[5].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgnClientes.Columns[30].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgnClientes.Columns[31].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgnClientes.Columns[32].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);




                int V = dgnClientes.RowCount;

                if (V > 0)
                {
                    btnExcluir.Enabled = true;
                    btnEditar.Enabled = true;

                }

                else
                {

                    btnExcluir.Enabled = false;
                    btnEditar.Enabled = false;

                }

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {


        }

        private void picBuscarClaro_Click(object sender, EventArgs e)
        {

            dgnClientes.DataSource = null;


            Boolean resp = ((mskCNPJ.MaskFull) | (mskCPF.MaskFull) | (txtNomeCliente.Text != "") | (txtNomeFantasia.Text != ""));

            if (resp == true)


            {
                Consultar();
            }

            else
            {

                MessageBox.Show("Favor preencher um parâmetro válido para realizar a pesquisa");
            }


        }

        private void picBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            picBuscar.Visible = false;
            picBuscarClaro.Visible = true;

        }

        private void formCliente_MouseMove(object sender, MouseEventArgs e)
        {
            picBuscar.Visible = true;
            picBuscarClaro.Visible = false;

        }

        private void groupBox1_Move(object sender, EventArgs e)
        {

        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            picBuscar.Visible = true;
            picBuscarClaro.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formClienteInserir FormCliente = new formClienteInserir();

            FormCliente.fillCboEstado();
            FormCliente.fillCboBanco();
            FormCliente.fillCboCidade();
            FormCliente.fillCboSegmento();
            FormCliente.fillCboStatus();
            FormCliente.fillCboBairro();


            FormCliente.txtCodigo.Text = dgnClientes.SelectedCells[0].Value.ToString();
            FormCliente.rbtnPF.Checked = rbtnPF.Checked;
            FormCliente.rbtnPJ.Checked = rbtnPJ.Checked;
            FormCliente.txtNome.Text = dgnClientes.SelectedCells[1].Value.ToString();
            FormCliente.txtRazaoSocial.Text = dgnClientes.SelectedCells[2].Value.ToString();
            FormCliente.txtNomeFantasia.Text = dgnClientes.SelectedCells[3].Value.ToString();
            FormCliente.mkdCPF.Text = dgnClientes.SelectedCells[4].Value.ToString();
            FormCliente.mkdCNPJ.Text = dgnClientes.SelectedCells[5].Value.ToString();
            FormCliente.txtInsEstadual.Text = dgnClientes.SelectedCells[6].Value.ToString();
            FormCliente.txtInsMunicipal.Text = dgnClientes.SelectedCells[7].Value.ToString();
            FormCliente.cboBanco.SelectedValue = dgnClientes.SelectedCells[8].Value.ToString();
            FormCliente.txtAgencia.Text = dgnClientes.SelectedCells[9].Value.ToString();
            FormCliente.txtContaCorrente.Text = dgnClientes.SelectedCells[10].Value.ToString();
            FormCliente.txtDigitoVerificador.Text = dgnClientes.SelectedCells[11].Value.ToString();
            FormCliente.cboSegmento.SelectedValue = dgnClientes.SelectedCells[12].Value.ToString();
            FormCliente.mkdDataNascimento.Text = dgnClientes.SelectedCells[13].Value.ToString();
            FormCliente.mkdTelFixo.Text = dgnClientes.SelectedCells[14].Value.ToString();
            FormCliente.mkdTelCelular.Text = dgnClientes.SelectedCells[15].Value.ToString();
            FormCliente.cboEstado.SelectedValue = dgnClientes.SelectedCells[16].Value.ToString();
            FormCliente.cboCidade.SelectedValue = dgnClientes.SelectedCells[17].Value.ToString();
            FormCliente.cboBairro.SelectedValue = dgnClientes.SelectedCells[18].Value.ToString();
            FormCliente.txtLogradouro.Text = dgnClientes.SelectedCells[19].Value.ToString();
            FormCliente.txtNumero.Text = dgnClientes.SelectedCells[20].Value.ToString();
            FormCliente.txtComplemento.Text = dgnClientes.SelectedCells[21].Value.ToString();
            FormCliente.mkdCEP.Text = dgnClientes.SelectedCells[22].Value.ToString();
            FormCliente.txtEmail.Text = dgnClientes.SelectedCells[23].Value.ToString();
            FormCliente.txtNivelSLA.Text = dgnClientes.SelectedCells[24].Value.ToString();
            FormCliente.txtContato.Text = dgnClientes.SelectedCells[25].Value.ToString();
            FormCliente.cboStatusCadastro.SelectedValue = dgnClientes.SelectedCells[26].Value.ToString();
            FormCliente.txtDadosAdicionais1.Text = dgnClientes.SelectedCells[27].Value.ToString();
            FormCliente.txtDadosAdicionais2.Text = dgnClientes.SelectedCells[28].Value.ToString();
            FormCliente.txtDadosAdicionais3.Text = dgnClientes.SelectedCells[29].Value.ToString();
            FormCliente.chkEditar.Checked = true;

            FormCliente.txtCodigo.ReadOnly = true;



            FormCliente.ShowDialog();

        }

        private void rbtnPJ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}

