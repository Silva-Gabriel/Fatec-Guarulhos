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
    public partial class formEstadoInserir : Form
    {
        public formEstadoInserir()
        {
            InitializeComponent();
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
                    SQL = "Insert Into g1_tblEstado (siglaEstado, descEstado) values ";
                    SQL += "('" + mkdSiglaEstado.Text + "','" + txtdescEstado.Text + "')";


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

            if (txtdescEstado.Text == "")
                FormValido = false;
            else if (txtdescEstado.Text == "")
                FormValido = false;
            else if (mkdSiglaEstado.Text == "")
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
    }

   
}
