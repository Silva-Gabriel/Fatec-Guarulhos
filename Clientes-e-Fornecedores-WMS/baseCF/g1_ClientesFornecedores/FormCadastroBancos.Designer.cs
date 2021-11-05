
namespace baseCF
{
    partial class FormCadastroBancos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroBancos));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.permissõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscar = new System.Windows.Forms.Button();
            this.descricaoBanco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.visualizar = new System.Windows.Forms.Button();
            this.codigoBanco = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.novocadastro = new System.Windows.Forms.Button();
            this.excluircadastro = new System.Windows.Forms.Button();
            this.editarcadastro = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1233, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.preferênciasToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.arquivoToolStripMenuItem.Text = "Sistema";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.optionToolStripMenuItem.Text = "Sair";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // preferênciasToolStripMenuItem
            // 
            this.preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            this.preferênciasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.preferênciasToolStripMenuItem.Text = "Preferências";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem1,
            this.permissõesToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editarToolStripMenuItem.Text = "Usuário";
            // 
            // optionToolStripMenuItem1
            // 
            this.optionToolStripMenuItem1.Name = "optionToolStripMenuItem1";
            this.optionToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.optionToolStripMenuItem1.Text = "Ver matrícula";
            // 
            // permissõesToolStripMenuItem
            // 
            this.permissõesToolStripMenuItem.Name = "permissõesToolStripMenuItem";
            this.permissõesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.permissõesToolStripMenuItem.Text = "Permissões";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem2});
            this.exibirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.exibirToolStripMenuItem.Text = "Ajuda";
            // 
            // optionToolStripMenuItem2
            // 
            this.optionToolStripMenuItem2.Name = "optionToolStripMenuItem2";
            this.optionToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            this.optionToolStripMenuItem2.Text = "Suporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1079, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "User: 00000000";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDataHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(428, 51);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(140, 21);
            this.lblDataHora.TabIndex = 3;
            this.lblDataHora.Text = "19/05/2021, 00:00";
            this.lblDataHora.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1078, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "FAWS WMS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(426, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "FATEC Warehouse System";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // menup
            // 
            this.menup.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menup.Image = ((System.Drawing.Image)(resources.GetObject("menup.Image")));
            this.menup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menup.Location = new System.Drawing.Point(991, 635);
            this.menup.Name = "menup";
            this.menup.Size = new System.Drawing.Size(88, 38);
            this.menup.TabIndex = 1;
            this.menup.Text = "        Menu";
            this.menup.UseVisualStyleBackColor = false;
            this.menup.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.descricaoBanco);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.visualizar);
            this.groupBox1.Controls.Add(this.codigoBanco);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 116);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro - Bancos";
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar.Location = new System.Drawing.Point(864, 63);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(116, 38);
            this.buscar.TabIndex = 21;
            this.buscar.Text = "        Pesquisar";
            this.buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // descricaoBanco
            // 
            this.descricaoBanco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoBanco.Location = new System.Drawing.Point(272, 79);
            this.descricaoBanco.Name = "descricaoBanco";
            this.descricaoBanco.Size = new System.Drawing.Size(199, 23);
            this.descricaoBanco.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Descrição do Banco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Código do Banco:";
            // 
            // visualizar
            // 
            this.visualizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.visualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.visualizar.Image = ((System.Drawing.Image)(resources.GetObject("visualizar.Image")));
            this.visualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visualizar.Location = new System.Drawing.Point(732, 63);
            this.visualizar.Name = "visualizar";
            this.visualizar.Size = new System.Drawing.Size(116, 38);
            this.visualizar.TabIndex = 17;
            this.visualizar.Text = "        Ver todos";
            this.visualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visualizar.UseVisualStyleBackColor = false;
            this.visualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // codigoBanco
            // 
            this.codigoBanco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoBanco.Location = new System.Drawing.Point(145, 79);
            this.codigoBanco.Name = "codigoBanco";
            this.codigoBanco.Size = new System.Drawing.Size(83, 23);
            this.codigoBanco.TabIndex = 4;
            this.codigoBanco.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.codigo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.codigo.Location = new System.Drawing.Point(37, 59);
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Size = new System.Drawing.Size(86, 43);
            this.codigo.TabIndex = 3;
            this.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbanco,
            this.codBanco,
            this.descBanco});
            this.dataGridView1.Location = new System.Drawing.Point(18, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(956, 241);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idbanco
            // 
            this.idbanco.DataPropertyName = "idBanco";
            this.idbanco.HeaderText = "Código";
            this.idbanco.MinimumWidth = 6;
            this.idbanco.Name = "idbanco";
            this.idbanco.Width = 70;
            // 
            // codBanco
            // 
            this.codBanco.DataPropertyName = "descBanco";
            this.codBanco.HeaderText = "Código do Banco";
            this.codBanco.MinimumWidth = 6;
            this.codBanco.Name = "codBanco";
            this.codBanco.Width = 125;
            // 
            // descBanco
            // 
            this.descBanco.DataPropertyName = "codBanco";
            this.descBanco.HeaderText = "Descrição do Banco";
            this.descBanco.MinimumWidth = 6;
            this.descBanco.Name = "descBanco";
            this.descBanco.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(83, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 270);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado Consulta Cadastro - Bancos";
            // 
            // novocadastro
            // 
            this.novocadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.novocadastro.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.novocadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novocadastro.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novocadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.novocadastro.Image = ((System.Drawing.Image)(resources.GetObject("novocadastro.Image")));
            this.novocadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novocadastro.Location = new System.Drawing.Point(9, 18);
            this.novocadastro.Name = "novocadastro";
            this.novocadastro.Size = new System.Drawing.Size(88, 38);
            this.novocadastro.TabIndex = 19;
            this.novocadastro.Text = "        Novo";
            this.novocadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novocadastro.UseVisualStyleBackColor = false;
            this.novocadastro.Click += new System.EventHandler(this.button6_Click);
            // 
            // excluircadastro
            // 
            this.excluircadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.excluircadastro.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.excluircadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluircadastro.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluircadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excluircadastro.Image = ((System.Drawing.Image)(resources.GetObject("excluircadastro.Image")));
            this.excluircadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluircadastro.Location = new System.Drawing.Point(9, 106);
            this.excluircadastro.Name = "excluircadastro";
            this.excluircadastro.Size = new System.Drawing.Size(88, 38);
            this.excluircadastro.TabIndex = 19;
            this.excluircadastro.Text = "       Excluir";
            this.excluircadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluircadastro.UseVisualStyleBackColor = false;
            this.excluircadastro.Click += new System.EventHandler(this.button8_Click);
            // 
            // editarcadastro
            // 
            this.editarcadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.editarcadastro.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.editarcadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarcadastro.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarcadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editarcadastro.Image = ((System.Drawing.Image)(resources.GetObject("editarcadastro.Image")));
            this.editarcadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarcadastro.Location = new System.Drawing.Point(9, 62);
            this.editarcadastro.Name = "editarcadastro";
            this.editarcadastro.Size = new System.Drawing.Size(88, 38);
            this.editarcadastro.TabIndex = 20;
            this.editarcadastro.Text = "        Editar";
            this.editarcadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarcadastro.UseVisualStyleBackColor = false;
            this.editarcadastro.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.editarcadastro);
            this.groupBox3.Controls.Add(this.novocadastro);
            this.groupBox3.Controls.Add(this.excluircadastro);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1093, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(97, 152);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox4.Location = new System.Drawing.Point(0, 626);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1264, 59);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // FormCadastroBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1233, 679);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 718);
            this.MinimumSize = new System.Drawing.Size(1022, 630);
            this.Name = "FormCadastroBancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAWS WMS - Consultar Bancos";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissõesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button menup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button novocadastro;
        private System.Windows.Forms.Button excluircadastro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn descBanco;
        public System.Windows.Forms.TextBox codigoBanco;
        public System.Windows.Forms.TextBox descricaoBanco;
        public System.Windows.Forms.Button editarcadastro;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button visualizar;
        public System.Windows.Forms.Button buscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

