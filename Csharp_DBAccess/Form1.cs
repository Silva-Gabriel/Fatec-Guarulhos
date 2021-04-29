using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace IntegracaoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txtnome);
            tList.Add(txtsobrenome);
            tList.Add(txtemail);
            tList.Add(txtcelular);
            tList.Add(txtcpf);
            tList.Add(txtoutro);
            sList.Add("Nome");
            sList.Add("Sobrenome");
            sList.Add("Email");
            sList.Add("Telefone/Celular");
            sList.Add("CPF xxx.xxx.xxx-xx");
            sList.Add("Personalizado");
            SetCueBanner(ref tList, sList);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int i = 0; i < textBox.Count; i++)
            {
                SendMessage(textBox[i].Handle, 0x1501, (IntPtr)1, CueText[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public bool VerificaCPF(string CPF) 
        {
            string pasta = Application.StartupPath + @"/BD/BDusers.mdb";
            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;
            string SQL = "SELECT COUNT(1) FROM Clientes WHERE CPF = @CPF";

            OleDbConnection conectar = new OleDbConnection(StrConexao);
            OleDbCommand command = new OleDbCommand(SQL, conectar);
            command.Parameters.AddWithValue("@CPF",CPF);
            conectar.Open();

            var resultado = command.ExecuteScalar();

            if (resultado != null) 
            {
                return (int)resultado > 0;
            }
            return false;
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCPF(txtcpf.Text) == false)
                {
                    string pasta = Application.StartupPath + @"/BD/BDusers.mdb";

                    string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                    OleDbConnection conectar = new OleDbConnection(StrConexao);

                    //Abre a conexão
                    conectar.Open();

                    // Monta string SQL para a tabela Clientes
                    String SQL;
                    SQL = "Insert Into Clientes (nome, sobrenome,datanascimento, telefone, email, CPF) Values ";
                    SQL += "('" + txtnome.Text + "','" + txtsobrenome.Text + "','" + nascimento.Value + "','" + txtcelular.Text + "','" + txtemail.Text + "','" + txtcpf.Text + "')";

                    // Cria o comando do SQL na conexão aberta
                    OleDbCommand comando = new OleDbCommand(SQL, conectar);

                    // Médodo para executar o comando SQL que não retorna dados.
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados gravados com sucesso");
                    // Limpa os dados em tela.
                    txtnome.Clear();
                    txtsobrenome.Clear();
                    txtcelular.Clear();
                    txtcpf.Clear();

                    conectar.Close();
                }
                else 
                {
                    MessageBox.Show("CPF já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);

            }
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCPF(txtcpf.Text) == true)
                {
                    // Monta o caminho até o arquivo de Banco de dados
                    string pasta = Application.StartupPath + @"/BD/BDusers.mdb";
                    // Monta a string de conexão com o Banco de dados Access
                    string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                    // Criar objeto de conexão
                    OleDbConnection conectar = new OleDbConnection(StrConexao);

                    //Abre a conexão
                    conectar.Open();

                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = conectar;


                    string cons = "UPDATE Clientes SET sobrenome = '" + txtsobrenome.Text +
                                          "',telefone = '" + txtcelular.Text +
                                          "',email = '" + txtemail.Text +
                                          "+'WHERE CPF = '" + txtcpf.Text + "'";

                    comando.CommandText = cons;

                    // Médodo para executar o comando SQL que não retorna dados.
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados alterados com sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    conectar.Dispose();
                    txtnome.Clear();
                    txtsobrenome.Clear();
                    txtcelular.Clear();
                    txtcpf.Clear();
                }
                else 
                {
                    MessageBox.Show("Não foi possível encontrar o CPF no banco de dados!", "Erro na atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);

            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (VerificaCPF(txtcpf.Text) == true)
                {
                    // Monta o caminho até o arquivo de Banco de dados
                    string pasta = Application.StartupPath + @"/BD/BDusers.mdb";
                    // Monta a string de conexão com o Banco de dados Access
                    string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                    // Executa a conexão com o Banco de dados
                    OleDbConnection conectar = new OleDbConnection(StrConexao);

                    //Abre a conexão
                    conectar.Open();

                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = conectar;

                    // Monta string SQL para a tabela Clientes
                    //String SQL;
                    comando.CommandText = "DELETE FROM Clientes WHERE CPF = '" + txtcpf.Text + "'";


                    // Médodo para executar o comando SQL que não retorna dados.
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados excluidos com sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    // Limpa os dados em tela.
                    txtnome.Clear();
                    txtsobrenome.Clear();
                    txtcelular.Clear();
                    txtcpf.Clear();

                    //FEcha a conexão com o Banco de dados
                    conectar.Dispose();
                }
                else
                {
                    MessageBox.Show("Não foi possível encontrar o CPF no banco de dados!", "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);

            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                // Monta o caminho até o arquivo de Banco de dados
                string pasta = Application.StartupPath + @"/BD/BDusers.mdb";
                // Monta a string de conexão com o Banco de dados Access
                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;
                // Executa a conexão com o Banco de dados
                OleDbConnection conectar = new OleDbConnection(StrConexao);

                string procura = "SELECT * FROM Clientes";

                if (txtcpf.Text != "")
                {
                    procura = "SELECT * FROM Clientes WHERE CPF LIKE '" + txtcpf.Text + "'";
                }

                DataTable dados = new DataTable();

                OleDbDataAdapter adpt = new OleDbDataAdapter(procura, conectar);

                //Abre a conexão
                conectar.Open();

                adpt.Fill(dados);

                txtnome.Text = (string)dados.Rows[0][1];
                txtsobrenome.Text = (string)dados.Rows[0][2];
                txtemail.Text = (string)dados.Rows[0][3];
                txtcelular.Text = (string)dados.Rows[0][4];
                nascimento.Value = (DateTime)dados.Rows[0][5];
                txtcpf.Text = (string)dados.Rows[0][6];

                conectar.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void outro_CheckedChanged(object sender, EventArgs e)
        {
            if (outro.Checked == true)
            {
                txtoutro.Visible = true;
            }
        }

        private void masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (masculino.Checked == true)
            {
                txtoutro.Visible = false;
            }
        }

        private void feminino_CheckedChanged(object sender, EventArgs e)
        {
            if (feminino.Checked == true)
            {
                txtoutro.Visible = false;
            }
        }
    }
}
