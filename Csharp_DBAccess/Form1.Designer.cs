
namespace IntegracaoBD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.salvar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsobrenome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outro = new System.Windows.Forms.RadioButton();
            this.feminino = new System.Windows.Forms.RadioButton();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.nascimento = new System.Windows.Forms.DateTimePicker();
            this.txtoutro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvar.Location = new System.Drawing.Point(12, 274);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(87, 33);
            this.salvar.TabIndex = 11;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = false;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.Color.Coral;
            this.atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.atualizar.Location = new System.Drawing.Point(125, 274);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(87, 33);
            this.atualizar.TabIndex = 12;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = false;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.Red;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Excluir.Location = new System.Drawing.Point(234, 274);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(87, 33);
            this.Excluir.TabIndex = 13;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.Color.White;
            this.consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.consultar.Location = new System.Drawing.Point(336, 274);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(87, 33);
            this.consultar.TabIndex = 14;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.Consultar_click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(21, 20);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(195, 24);
            this.txtnome.TabIndex = 1;
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsobrenome.Location = new System.Drawing.Point(222, 20);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(186, 24);
            this.txtsobrenome.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(21, 50);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(387, 24);
            this.txtemail.TabIndex = 3;
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(21, 110);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(160, 24);
            this.txtcelular.TabIndex = 5;
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(21, 80);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(387, 24);
            this.txtcpf.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.outro);
            this.panel1.Controls.Add(this.feminino);
            this.panel1.Controls.Add(this.masculino);
            this.panel1.Controls.Add(this.nascimento);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.txtcpf);
            this.panel1.Controls.Add(this.txtoutro);
            this.panel1.Controls.Add(this.txtcelular);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtsobrenome);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 176);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(187, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gênero:";
            // 
            // outro
            // 
            this.outro.AutoSize = true;
            this.outro.Location = new System.Drawing.Point(222, 154);
            this.outro.Name = "outro";
            this.outro.Size = new System.Drawing.Size(51, 17);
            this.outro.TabIndex = 9;
            this.outro.TabStop = true;
            this.outro.Text = "Outro";
            this.outro.UseVisualStyleBackColor = true;
            this.outro.CheckedChanged += new System.EventHandler(this.outro_CheckedChanged);
            // 
            // feminino
            // 
            this.feminino.AutoSize = true;
            this.feminino.Location = new System.Drawing.Point(154, 154);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(67, 17);
            this.feminino.TabIndex = 8;
            this.feminino.TabStop = true;
            this.feminino.Text = "Feminino";
            this.feminino.UseVisualStyleBackColor = true;
            this.feminino.CheckedChanged += new System.EventHandler(this.feminino_CheckedChanged);
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(85, 154);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(73, 17);
            this.masculino.TabIndex = 7;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            this.masculino.CheckedChanged += new System.EventHandler(this.masculino_CheckedChanged);
            // 
            // nascimento
            // 
            this.nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nascimento.Location = new System.Drawing.Point(313, 114);
            this.nascimento.Name = "nascimento";
            this.nascimento.Size = new System.Drawing.Size(95, 20);
            this.nascimento.TabIndex = 6;
            this.nascimento.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // txtoutro
            // 
            this.txtoutro.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoutro.Location = new System.Drawing.Point(284, 150);
            this.txtoutro.Name = "txtoutro";
            this.txtoutro.Size = new System.Drawing.Size(124, 24);
            this.txtoutro.TabIndex = 10;
            this.txtoutro.Visible = false;
            this.txtoutro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(57, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cadastro de clientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(435, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsobrenome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton outro;
        private System.Windows.Forms.RadioButton feminino;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.DateTimePicker nascimento;
        private System.Windows.Forms.TextBox txtoutro;
        private System.Windows.Forms.Label label3;
    }
}

