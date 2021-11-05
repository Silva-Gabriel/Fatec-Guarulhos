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
    public partial class formCidade : Form
    {
        public formCidade()
        {
            InitializeComponent();
            fillEstado();
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            formCidadeInserir abrirForm = new formCidadeInserir();
            abrirForm.ShowDialog();


        }

        private void button5_Click(object sender, EventArgs e)
        {
           //Fecha esse form e volta ao menu principal
            UserI fechar = new UserI();
            fechar.abrirFecharForm(this, formMenuCadastro.ActiveForm);

        }

        

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

       
        
        public void Consultar()
        {

            try
            {
                
                
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL = "Select * from g1_tblCidade WHERE idEstado LIKE '" + '%' + cboEstado.SelectedValue + '%' + "'";
                

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "g1_tblCidade");


                dgCnsTipoTributo.DataSource = DS.Tables["g1_tblCidade"];

                dgCnsTipoTributo.Columns[0].HeaderText = "ID";
                dgCnsTipoTributo.Columns[1].HeaderText = "Descrição Cidade";
                dgCnsTipoTributo.Columns[2].HeaderText = "ID Estado";
               

                dgCnsTipoTributo.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgCnsTipoTributo.Columns[1].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgCnsTipoTributo.Columns[2].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
               


                dgCnsTipoTributo.Columns[0].Width = 50;
                dgCnsTipoTributo.Columns[1].Width = 150;
                dgCnsTipoTributo.Columns[2].Width = 150;
                


                int V = dgCnsTipoTributo.RowCount;

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

        public string RespUsuario() 
        {

           DialogResult RespUsuario = MessageBox.Show("Deseja excluir o item selecionado", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            return RespUsuario.ToString();
            
        
        }
       
        private void formTipoTributo_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
                                    
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formCidadeInserir formEstado= new formCidadeInserir();
            formEstado.txtCodigo.Text = dgCnsTipoTributo.SelectedCells[0].Value.ToString();
            formEstado.cboEstado.SelectedValue = dgCnsTipoTributo.SelectedCells[2].Value.ToString();
            formEstado.txtdescCidade.Text= dgCnsTipoTributo.SelectedCells[1].Value.ToString();
            
           // formTipoTributo.btnDesfazer.Visible = true;
            formEstado.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //if (RespUsuario() == "Yes")

            //{

            //    try
            //    {
                    
                    

            //        OleDbConnection con = new OleDbConnection(Globals.ConnString);
            //        con.Open();

            //        String cod = dgCnsTipoTributo.SelectedCells[0].Value.ToString();
            //        String SQL = "Delete from g1_tblCidade WHERE idCidade =" + cod;

            //        OleDbCommand cmd = new OleDbCommand(SQL, con);

            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Dados excluídos com sucesso");

            //        Consultar();


            //    }
            //    catch (Exception erro)
            //    {

            //        MessageBox.Show(erro.Message);
            //    }
            //}

            //else
            //{


            //}


            
        }

       

        private void groupBox1_Move(object sender, EventArgs e)
        {
            ttlAviso.SetToolTip(this.groupBox1, "Informe os parâmetros para iniciar a pesquisa.");
        }

        

        private void mkdSiglaEstado_KeyUp(object sender, KeyEventArgs e)
        {
            Consultar();
        }

        private void cboEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillCidade();
        }

        void fillEstado()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "Select * from g1_tblEstado";

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
                cboEstado.ValueMember = "IdEstado";
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
            

        }

        void fillCidade()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblCidade WHERE idEstado =" + cboEstado.SelectedValue;

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
                cboCidade.Text = "Selecione uma cidade";

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }


        }

        private void cboCidade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
