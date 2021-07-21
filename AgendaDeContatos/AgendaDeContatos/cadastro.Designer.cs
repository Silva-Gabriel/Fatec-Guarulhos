
namespace AgendaDeContatos
{
    partial class principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoConsultar = new System.Windows.Forms.Button();
            this.botaoDeletar = new System.Windows.Forms.Button();
            this.botaoAtualizar = new System.Windows.Forms.Button();
            this.botaoInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.siglas = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.tituloPrincipal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.botaoConsultar);
            this.panel1.Controls.Add(this.botaoDeletar);
            this.panel1.Controls.Add(this.botaoAtualizar);
            this.panel1.Controls.Add(this.botaoInserir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.siglas);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtSobrenome);
            this.panel1.Location = new System.Drawing.Point(12, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 313);
            this.panel1.TabIndex = 1;
            // 
            // botaoConsultar
            // 
            this.botaoConsultar.BackColor = System.Drawing.Color.Gray;
            this.botaoConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoConsultar.FlatAppearance.BorderSize = 0;
            this.botaoConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoConsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoConsultar.ForeColor = System.Drawing.Color.White;
            this.botaoConsultar.Location = new System.Drawing.Point(351, 269);
            this.botaoConsultar.Name = "botaoConsultar";
            this.botaoConsultar.Size = new System.Drawing.Size(90, 36);
            this.botaoConsultar.TabIndex = 12;
            this.botaoConsultar.Text = "Consultar";
            this.botaoConsultar.UseVisualStyleBackColor = false;
            this.botaoConsultar.Click += new System.EventHandler(this.aoClicar_Consultar);
            // 
            // botaoDeletar
            // 
            this.botaoDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoDeletar.FlatAppearance.BorderSize = 0;
            this.botaoDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoDeletar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoDeletar.ForeColor = System.Drawing.Color.White;
            this.botaoDeletar.Location = new System.Drawing.Point(243, 269);
            this.botaoDeletar.Name = "botaoDeletar";
            this.botaoDeletar.Size = new System.Drawing.Size(90, 36);
            this.botaoDeletar.TabIndex = 11;
            this.botaoDeletar.Text = "Deletar";
            this.botaoDeletar.UseVisualStyleBackColor = false;
            this.botaoDeletar.Click += new System.EventHandler(this.aoClicar_Deletar);
            // 
            // botaoAtualizar
            // 
            this.botaoAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.botaoAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAtualizar.FlatAppearance.BorderSize = 0;
            this.botaoAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoAtualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoAtualizar.ForeColor = System.Drawing.Color.White;
            this.botaoAtualizar.Location = new System.Drawing.Point(134, 269);
            this.botaoAtualizar.Name = "botaoAtualizar";
            this.botaoAtualizar.Size = new System.Drawing.Size(90, 36);
            this.botaoAtualizar.TabIndex = 10;
            this.botaoAtualizar.Text = "Atualizar";
            this.botaoAtualizar.UseVisualStyleBackColor = false;
            this.botaoAtualizar.Click += new System.EventHandler(this.aoClicar_Atualizar);
            // 
            // botaoInserir
            // 
            this.botaoInserir.BackColor = System.Drawing.Color.SteelBlue;
            this.botaoInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoInserir.FlatAppearance.BorderSize = 0;
            this.botaoInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoInserir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoInserir.ForeColor = System.Drawing.Color.White;
            this.botaoInserir.Location = new System.Drawing.Point(25, 269);
            this.botaoInserir.Name = "botaoInserir";
            this.botaoInserir.Size = new System.Drawing.Size(90, 36);
            this.botaoInserir.TabIndex = 9;
            this.botaoInserir.Text = "Cadastrar";
            this.botaoInserir.UseVisualStyleBackColor = false;
            this.botaoInserir.Click += new System.EventHandler(this.aoClicar_Cadastrar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(318, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado:";
            // 
            // siglas
            // 
            this.siglas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siglas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siglas.FormattingEnabled = true;
            this.siglas.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.siglas.Location = new System.Drawing.Point(389, 202);
            this.siglas.Name = "siglas";
            this.siglas.Size = new System.Drawing.Size(53, 25);
            this.siglas.Sorted = true;
            this.siglas.TabIndex = 8;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndereco.Location = new System.Drawing.Point(24, 202);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(283, 25);
            this.txtEndereco.TabIndex = 7;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.Location = new System.Drawing.Point(24, 159);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(417, 25);
            this.txtTelefone.TabIndex = 6;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCelular.Location = new System.Drawing.Point(24, 112);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(417, 25);
            this.txtCelular.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(25, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(417, 25);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(25, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 25);
            this.txtNome.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSobrenome.Location = new System.Drawing.Point(243, 11);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(199, 25);
            this.txtSobrenome.TabIndex = 3;
            // 
            // tituloPrincipal
            // 
            this.tituloPrincipal.AutoSize = true;
            this.tituloPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.tituloPrincipal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tituloPrincipal.ForeColor = System.Drawing.Color.Azure;
            this.tituloPrincipal.Location = new System.Drawing.Point(60, 25);
            this.tituloPrincipal.Name = "tituloPrincipal";
            this.tituloPrincipal.Size = new System.Drawing.Size(377, 43);
            this.tituloPrincipal.TabIndex = 0;
            this.tituloPrincipal.Text = "Agenda de contatos";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(491, 426);
            this.Controls.Add(this.tituloPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "principal";
            this.Opacity = 0.96D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de contatos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.principal_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BackgroundGradient);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoConsultar;
        private System.Windows.Forms.Button botaoDeletar;
        private System.Windows.Forms.Button botaoAtualizar;
        private System.Windows.Forms.Button botaoInserir;
        private System.Windows.Forms.Label tituloPrincipal;
        protected System.Windows.Forms.ComboBox siglas;
        protected System.Windows.Forms.TextBox txtEndereco;
        protected System.Windows.Forms.TextBox txtTelefone;
        protected System.Windows.Forms.TextBox txtCelular;
        protected System.Windows.Forms.TextBox txtEmail;
        protected System.Windows.Forms.TextBox txtSobrenome;
        protected System.Windows.Forms.TextBox txtNome;
    }
}

