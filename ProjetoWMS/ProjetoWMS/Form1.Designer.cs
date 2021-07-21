
namespace ProjetoWMS
{
    partial class FormLogin
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
            this.title = new System.Windows.Forms.Label();
            this.linkEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.botaoAutenticar = new System.Windows.Forms.Button();
            this.txtCredencial = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.linkEsqueciSenha);
            this.panel1.Controls.Add(this.botaoAutenticar);
            this.panel1.Controls.Add(this.txtCredencial);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(150, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 366);
            this.panel1.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Location = new System.Drawing.Point(66, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(168, 31);
            this.title.TabIndex = 3;
            this.title.Text = "Faça seu login";
            // 
            // linkEsqueciSenha
            // 
            this.linkEsqueciSenha.AutoSize = true;
            this.linkEsqueciSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkEsqueciSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkEsqueciSenha.LinkColor = System.Drawing.Color.Blue;
            this.linkEsqueciSenha.Location = new System.Drawing.Point(77, 331);
            this.linkEsqueciSenha.Name = "linkEsqueciSenha";
            this.linkEsqueciSenha.Size = new System.Drawing.Size(157, 18);
            this.linkEsqueciSenha.TabIndex = 2;
            this.linkEsqueciSenha.TabStop = true;
            this.linkEsqueciSenha.Text = "Esqueci minha senha";
            // 
            // botaoAutenticar
            // 
            this.botaoAutenticar.BackColor = System.Drawing.Color.DodgerBlue;
            this.botaoAutenticar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAutenticar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAutenticar.FlatAppearance.BorderSize = 0;
            this.botaoAutenticar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoAutenticar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoAutenticar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoAutenticar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoAutenticar.ForeColor = System.Drawing.Color.White;
            this.botaoAutenticar.Location = new System.Drawing.Point(50, 250);
            this.botaoAutenticar.Margin = new System.Windows.Forms.Padding(0);
            this.botaoAutenticar.Name = "botaoAutenticar";
            this.botaoAutenticar.Size = new System.Drawing.Size(203, 41);
            this.botaoAutenticar.TabIndex = 1;
            this.botaoAutenticar.Text = "Entrar";
            this.botaoAutenticar.UseVisualStyleBackColor = false;
            this.botaoAutenticar.Click += new System.EventHandler(this.aoClicar);
            // 
            // txtCredencial
            // 
            this.txtCredencial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCredencial.Location = new System.Drawing.Point(50, 116);
            this.txtCredencial.Name = "txtCredencial";
            this.txtCredencial.Size = new System.Drawing.Size(203, 26);
            this.txtCredencial.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(50, 179);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(203, 26);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::ProjetoWMS.Properties.Resources.logoFatec;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(12, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 55);
            this.panel2.TabIndex = 2;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormLogin";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLogin_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.LinkLabel linkEsqueciSenha;
        private System.Windows.Forms.Button botaoAutenticar;
        private System.Windows.Forms.TextBox txtCredencial;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panel2;
    }
}

