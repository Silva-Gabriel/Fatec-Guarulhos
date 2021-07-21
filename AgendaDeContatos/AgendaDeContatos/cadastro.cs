using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Data.OleDb;


namespace AgendaDeContatos
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();

            List<TextBox> txtList = new List<TextBox>() { txtNome, txtSobrenome, txtEmail, txtCelular, txtTelefone, txtEndereco };
            List<string> descList = new List<string>() { "Nome", "Sobrenome", "Email", "Celular", "Telefone", "Bairro,rua,número" };
            marcaDagua(ref txtList, descList);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr i, string str);

        void marcaDagua(ref List<TextBox> txts, List<string> description)
        {
            for (int i = 0; i < txts.Count; i++)
            {
                SendMessage(txts[i].Handle, 0x1501, (IntPtr)0, description[i]);
            }
        }

        //Variável global de conexão com o banco de dados
        

        public void changeBackgroundColor(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);

            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(123, 104, 238), Color.FromArgb(240, 255, 255), 90F);

            graphics.FillRectangle(br, gradient_rect);
        }

        private void BackgroundGradient(object sender, PaintEventArgs e)
        {
            changeBackgroundColor(sender, e);
        }

        //Variável global
        string pasta = Application.StartupPath + @"/BD/Contatos.mdb";

        public void limparCampos()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtEmail.Clear();
            txtCelular.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            siglas.Text = "";
        }

        public bool verificacaoPK(string email) 
        {
            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;
            string SQL = "SELECT COUNT(1) FROM Contatos WHERE email = @email";

            OleDbConnection conectar = new OleDbConnection(StrConexao);
            OleDbCommand command = new OleDbCommand(SQL, conectar);
            command.Parameters.AddWithValue("@email", email);
            conectar.Open();

            var resultado = command.ExecuteScalar();

            if (resultado != null)
            {
                return (int)resultado > 0;
            }
            return false;
        }

        //Inserção dos dados no banco
        private void aoClicar_Cadastrar(object sender, EventArgs e)
        {
            try
            {

                if (verificacaoPK(txtEmail.Text) == false)
                {
                    if (txtNome.Text == "" || txtSobrenome.Text == "" || txtEmail.Text == "" || txtCelular.Text == "" || txtTelefone.Text == "" || siglas.Text == "")
                    {
                        MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Montando a conexão com o banco de dados
                        string caminho = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;
                        OleDbConnection conectar = new OleDbConnection(caminho);

                        conectar.Open();

                        //Montando a tabela
                        string SQL;
                        SQL = "Insert Into Contatos (nome, sobrenome, email, celular, telefoneResidencial, endereco, siglaEstado) Values ";
                        SQL += "('" + txtNome.Text + "','" + txtSobrenome.Text + "','" + txtEmail.Text + "','" + txtCelular.Text + "','" + txtTelefone.Text + "','" + txtEndereco.Text + "','" + siglas.Text + "')";

                        //criando o comando
                        OleDbCommand comando = new OleDbCommand(SQL, conectar);

                        //método sem retorno de dados
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados gravados com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparCampos();

                        conectar.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Email já cadastrado", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Atualização dos dados
        private void aoClicar_Atualizar(object sender, EventArgs e)
        {
            try
            {
                if (verificacaoPK(txtEmail.Text) == true)
                {
                    string caminho = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                    OleDbConnection conectar = new OleDbConnection(caminho);

                    conectar.Open();

                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = conectar;


                    if (txtNome.Text != "")
                    {
                        string up = "UPDATE Contatos SET nome = '" + txtNome.Text +
                                              "'WHERE email = '" + txtEmail.Text + "'";
                        comando.CommandText = up;
                    }

                    if (txtSobrenome.Text != "")
                    {
                        string up = "UPDATE Contatos SET sobrenome = '" + txtSobrenome.Text +
                                              "'WHERE email = '" + txtEmail.Text + "'";
                        comando.CommandText = up;
                    }

                    if (txtCelular.Text != "")
                    {
                        string up = "UPDATE Contatos SET celular = '" + txtCelular.Text +
                                              "'WHERE email = '" + txtEmail.Text + "'";
                        comando.CommandText = up;
                    }

                    if (txtTelefone.Text != "")
                    {
                        string up = "UPDATE Contatos SET telefoneResidencial = '" + txtTelefone.Text +
                                              "'WHERE email = '" + txtEmail.Text + "'";
                        comando.CommandText = up;
                    }

                    if (txtEndereco.Text != "")
                    {
                        string up = "UPDATE Contatos SET endereco = '" + txtEndereco.Text +
                                              "'WHERE email = '" + txtEmail.Text + "'";
                        comando.CommandText = up;
                    }

                    if (siglas.Text != "")
                    {
                        string up = "UPDATE Contatos SET siglaEstado = '" + siglas.Text +
                                              "'WHERE email = '" + txtEmail.Text + "'";
                        comando.CommandText = up;
                    }

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados alterados com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conectar.Dispose();

                    limparCampos();
                   
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aoClicar_Deletar(object sender, EventArgs e)
        {
            try
            {
                if (verificacaoPK(txtEmail.Text) == true)
                {
                    string caminho = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                    OleDbConnection conectar = new OleDbConnection(caminho);

                    conectar.Open();

                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = conectar;

                    comando.CommandText = "DELETE FROM Contatos WHERE email = '" + txtEmail.Text + "'";

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados excluídos com sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    limparCampos();

                    conectar.Dispose();
                }
                else
                {
                    MessageBox.Show("Email não cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception erro) 
            {
                MessageBox.Show(erro.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void aoClicar_Consultar(object sender, EventArgs e)
        {
            try
            {
                if (verificacaoPK(txtEmail.Text) == true)
                {
                    string caminho = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                    OleDbConnection conectar = new OleDbConnection(caminho);

                    string procurar = "SELECT * FROM Contatos WHERE email LIKE '" + txtEmail.Text + "'";

                    DataTable dados = new DataTable();

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(procurar, conectar);

                    conectar.Open();

                    adaptador.Fill(dados);

                    string nome, sobrenome, celular, telefone, endereco, sigla;

                    nome = (string)dados.Rows[0][1];
                    sobrenome = (string)dados.Rows[0][2];
                    celular = (string)dados.Rows[0][4];
                    telefone = (string)dados.Rows[0][5];
                    endereco = (string)dados.Rows[0][6];
                    sigla = (string)dados.Rows[0][7];

                    //Passando os dados para o forms de consulta
                    Consulta formConsulta = new Consulta(nome,sobrenome,celular,telefone,endereco,sigla);
                    formConsulta.Show();

                    limparCampos();
                    this.Visible = false;
                    

                    conectar.Close();
                }
                else
                {
                    MessageBox.Show("Por favor,preencha o campo Email corretamente para iniciar a consulta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}