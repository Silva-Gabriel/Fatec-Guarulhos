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
    public partial class formCidadeInserir : Form
    {
        public formCidadeInserir()
        {
            InitializeComponent();
            fillEstado();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

                          
        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void formTipoTributoInserir_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())

                try
                {
                    
                    
                    OleDbConnection con = new OleDbConnection(Globals.ConnString);
                    con.Open();

                    String SQL;
                    SQL = "Insert Into g1_tblCidade (idEstado, descCidade) values ";
                    SQL += "('" + cboEstado.SelectedValue + "','" +txtdescCidade.Text + "')";


                    OleDbCommand cmd = new OleDbCommand(SQL,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados gravados com sucesso.");

                    UserI LC = new UserI();

                    LC.limparCampos(tabIdentTributo.Controls);
                                       
                    con.Close();

                    UserI fecharForm = new UserI();
                    fecharForm.abrirFecharForm(this,formEstado.ActiveForm);




                }
                catch (Exception erro)
                {
                    MessageBox.Show (erro.Message);
                }
                                                
                
            else
                MessageBox.Show("Favor preencher todos os campos.");
        }

        private bool ValidarForm()
        {
            bool FormValido;

            if (txtdescCidade.Text == "")
                FormValido = false;
            else if (txtdescCidade.Text == "")
                FormValido = false;
            else if (cboEstado.SelectedValue.ToString() == "")
                FormValido = false;
            else
                FormValido = true;
            return FormValido;




        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            UserI fechar = new UserI();
            fechar.abrirFecharForm(this, formEstado.ActiveForm);

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
    }

   
}
