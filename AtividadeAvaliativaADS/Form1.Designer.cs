
namespace AtividadeAvaliativaADS
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
            this.Descricao = new System.Windows.Forms.Label();
            this.lblGiroDeEstoque = new System.Windows.Forms.Label();
            this.lblCobertura = new System.Windows.Forms.Label();
            this.txtGiroEstoque = new System.Windows.Forms.TextBox();
            this.txtCobertura = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonAnalisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.BackColor = System.Drawing.Color.Transparent;
            this.Descricao.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao.ForeColor = System.Drawing.Color.White;
            this.Descricao.Location = new System.Drawing.Point(66, 38);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(358, 26);
            this.Descricao.TabIndex = 7;
            this.Descricao.Text = "Atividade Avaliativa ADS";
            // 
            // lblGiroDeEstoque
            // 
            this.lblGiroDeEstoque.AutoSize = true;
            this.lblGiroDeEstoque.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiroDeEstoque.Location = new System.Drawing.Point(62, 22);
            this.lblGiroDeEstoque.Name = "lblGiroDeEstoque";
            this.lblGiroDeEstoque.Size = new System.Drawing.Size(109, 20);
            this.lblGiroDeEstoque.TabIndex = 1;
            this.lblGiroDeEstoque.Text = "Giro do estoque";
            // 
            // lblCobertura
            // 
            this.lblCobertura.AutoSize = true;
            this.lblCobertura.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCobertura.Location = new System.Drawing.Point(81, 22);
            this.lblCobertura.Name = "lblCobertura";
            this.lblCobertura.Size = new System.Drawing.Size(70, 20);
            this.lblCobertura.TabIndex = 1;
            this.lblCobertura.Text = "Cobertura";
            // 
            // txtGiroEstoque
            // 
            this.txtGiroEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiroEstoque.BackColor = System.Drawing.Color.Black;
            this.txtGiroEstoque.ForeColor = System.Drawing.Color.White;
            this.txtGiroEstoque.Location = new System.Drawing.Point(3, 47);
            this.txtGiroEstoque.Multiline = true;
            this.txtGiroEstoque.Name = "txtGiroEstoque";
            this.txtGiroEstoque.ReadOnly = true;
            this.txtGiroEstoque.Size = new System.Drawing.Size(231, 88);
            this.txtGiroEstoque.TabIndex = 7;
            this.txtGiroEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCobertura
            // 
            this.txtCobertura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCobertura.BackColor = System.Drawing.Color.Black;
            this.txtCobertura.ForeColor = System.Drawing.Color.White;
            this.txtCobertura.Location = new System.Drawing.Point(3, 47);
            this.txtCobertura.Multiline = true;
            this.txtCobertura.Name = "txtCobertura";
            this.txtCobertura.ReadOnly = true;
            this.txtCobertura.Size = new System.Drawing.Size(234, 91);
            this.txtCobertura.TabIndex = 6;
            this.txtCobertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblCobertura);
            this.panel1.Controls.Add(this.txtCobertura);
            this.panel1.Location = new System.Drawing.Point(141, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 149);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblGiroDeEstoque);
            this.panel2.Controls.Add(this.txtGiroEstoque);
            this.panel2.Location = new System.Drawing.Point(141, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 146);
            this.panel2.TabIndex = 5;
            // 
            // ButtonAnalisa
            // 
            this.ButtonAnalisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAnalisa.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonAnalisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAnalisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAnalisa.ForeColor = System.Drawing.Color.Black;
            this.ButtonAnalisa.Location = new System.Drawing.Point(14, 10);
            this.ButtonAnalisa.Name = "ButtonAnalisa";
            this.ButtonAnalisa.Size = new System.Drawing.Size(93, 47);
            this.ButtonAnalisa.TabIndex = 8;
            this.ButtonAnalisa.Text = "Analisar";
            this.ButtonAnalisa.UseVisualStyleBackColor = false;
            this.ButtonAnalisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.Location = new System.Drawing.Point(24, 22);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 35);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Limpar";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.Clear);
            this.panel4.Location = new System.Drawing.Point(343, 435);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(116, 60);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.ButtonAnalisa);
            this.panel5.Location = new System.Drawing.Point(186, 435);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 60);
            this.panel5.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AtividadeAvaliativaADS.Properties.Resources.top1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 498);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.Label lblGiroDeEstoque;
        private System.Windows.Forms.Label lblCobertura;
        private System.Windows.Forms.TextBox txtGiroEstoque;
        private System.Windows.Forms.TextBox txtCobertura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonAnalisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

