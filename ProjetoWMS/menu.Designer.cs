
namespace FAWS_WMS
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.picDivisorH = new System.Windows.Forms.PictureBox();
            this.picDivisorV = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnRecebimento = new System.Windows.Forms.Button();
            this.btnArmazem = new System.Windows.Forms.Button();
            this.btnExpedicao = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrDataHora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivisorH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivisorV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(81, 110);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(317, 108);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSystemName.Location = new System.Drawing.Point(83, 221);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(244, 30);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "Fatec Warehouse System";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCompanyName.Location = new System.Drawing.Point(652, 204);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(146, 25);
            this.lblCompanyName.TabIndex = 9;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(830, 210);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(194, 32);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "00/00/0000, 00:00";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblUser.Location = new System.Drawing.Point(700, 233);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(95, 15);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User: 00000000";
            // 
            // picDivisorH
            // 
            this.picDivisorH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picDivisorH.Location = new System.Drawing.Point(81, 265);
            this.picDivisorH.Name = "picDivisorH";
            this.picDivisorH.Size = new System.Drawing.Size(940, 2);
            this.picDivisorH.TabIndex = 10;
            this.picDivisorH.TabStop = false;
            // 
            // picDivisorV
            // 
            this.picDivisorV.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picDivisorV.Location = new System.Drawing.Point(815, 202);
            this.picDivisorV.Name = "picDivisorV";
            this.picDivisorV.Size = new System.Drawing.Size(1, 50);
            this.picDivisorV.TabIndex = 11;
            this.picDivisorV.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.Menu;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.DarkGray;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(87, 289);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(181, 123);
            this.btnClientes.TabIndex = 12;
            this.btnClientes.Text = "Clientes e Fornecedores";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.SystemColors.Menu;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.DarkGray;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdutos.Location = new System.Drawing.Point(274, 289);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(181, 123);
            this.btnProdutos.TabIndex = 13;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnRecebimento
            // 
            this.btnRecebimento.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecebimento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecebimento.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRecebimento.Image = ((System.Drawing.Image)(resources.GetObject("btnRecebimento.Image")));
            this.btnRecebimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecebimento.Location = new System.Drawing.Point(461, 289);
            this.btnRecebimento.Name = "btnRecebimento";
            this.btnRecebimento.Size = new System.Drawing.Size(181, 123);
            this.btnRecebimento.TabIndex = 14;
            this.btnRecebimento.Text = "Recebimento";
            this.btnRecebimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecebimento.UseVisualStyleBackColor = false;
            this.btnRecebimento.Click += new System.EventHandler(this.btnRecebimento_Click);
            // 
            // btnArmazem
            // 
            this.btnArmazem.BackColor = System.Drawing.SystemColors.Menu;
            this.btnArmazem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArmazem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmazem.ForeColor = System.Drawing.Color.DarkGray;
            this.btnArmazem.Image = ((System.Drawing.Image)(resources.GetObject("btnArmazem.Image")));
            this.btnArmazem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArmazem.Location = new System.Drawing.Point(648, 289);
            this.btnArmazem.Name = "btnArmazem";
            this.btnArmazem.Size = new System.Drawing.Size(181, 123);
            this.btnArmazem.TabIndex = 15;
            this.btnArmazem.Text = "Armazém";
            this.btnArmazem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArmazem.UseVisualStyleBackColor = false;
            this.btnArmazem.Click += new System.EventHandler(this.btnArmazem_Click);
            // 
            // btnExpedicao
            // 
            this.btnExpedicao.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExpedicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpedicao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpedicao.ForeColor = System.Drawing.Color.DarkGray;
            this.btnExpedicao.Image = ((System.Drawing.Image)(resources.GetObject("btnExpedicao.Image")));
            this.btnExpedicao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExpedicao.Location = new System.Drawing.Point(835, 289);
            this.btnExpedicao.Name = "btnExpedicao";
            this.btnExpedicao.Size = new System.Drawing.Size(181, 123);
            this.btnExpedicao.TabIndex = 16;
            this.btnExpedicao.Text = "Expedição";
            this.btnExpedicao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpedicao.UseVisualStyleBackColor = false;
            this.btnExpedicao.Click += new System.EventHandler(this.btnExpedicao_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.toolStripMenuItem1,
            this.preferênciasToolStripMenuItem});
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.sistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sistemaToolStripMenuItem.Image")));
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // preferênciasToolStripMenuItem
            // 
            this.preferênciasToolStripMenuItem.Enabled = false;
            this.preferênciasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("preferênciasToolStripMenuItem.Image")));
            this.preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            this.preferênciasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferênciasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.preferênciasToolStripMenuItem.Text = "Preferências";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permissõesToolStripMenuItem});
            this.usuárioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.usuárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuárioToolStripMenuItem.Image")));
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // permissõesToolStripMenuItem
            // 
            this.permissõesToolStripMenuItem.Enabled = false;
            this.permissõesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("permissõesToolStripMenuItem.Image")));
            this.permissõesToolStripMenuItem.Name = "permissõesToolStripMenuItem";
            this.permissõesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.permissõesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.permissõesToolStripMenuItem.Text = "Permissões";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suporteToolStripMenuItem});
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ajudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripMenuItem.Image")));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("suporteToolStripMenuItem.Image")));
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.suporteToolStripMenuItem.Text = "Suporte";
            this.suporteToolStripMenuItem.Click += new System.EventHandler(this.suporteToolStripMenuItem_Click);
            // 
            // tmrDataHora
            // 
            this.tmrDataHora.Enabled = true;
            this.tmrDataHora.Interval = 1;
            this.tmrDataHora.Tick += new System.EventHandler(this.tmrDataHora_Tick);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1099, 486);
            this.Controls.Add(this.btnExpedicao);
            this.Controls.Add(this.btnArmazem);
            this.Controls.Add(this.btnRecebimento);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.picDivisorV);
            this.Controls.Add(this.picDivisorH);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAWS WMS - Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivisorH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDivisorV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        internal System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox picDivisorH;
        private System.Windows.Forms.PictureBox picDivisorV;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnRecebimento;
        private System.Windows.Forms.Button btnArmazem;
        private System.Windows.Forms.Button btnExpedicao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.Timer tmrDataHora;
    }
}