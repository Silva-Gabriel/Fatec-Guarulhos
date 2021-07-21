
namespace CalculadoraInterativa
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeparadorVirgula = new System.Windows.Forms.Button();
            this.Separador = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Fatorial = new System.Windows.Forms.Button();
            this.Modulo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tres = new System.Windows.Forms.Button();
            this.Dois = new System.Windows.Forms.Button();
            this.Um = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Seis = new System.Windows.Forms.Button();
            this.Cinco = new System.Windows.Forms.Button();
            this.Quatro = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Nove = new System.Windows.Forms.Button();
            this.Oito = new System.Windows.Forms.Button();
            this.Sete = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Subtrair = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.Somar = new System.Windows.Forms.Button();
            this.VerificaResultado = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.ElevarAoQuadrado = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.expressao = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Conversor = new System.Windows.Forms.Button();
            this.jogo = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.SeparadorVirgula);
            this.panel1.Controls.Add(this.Separador);
            this.panel1.Controls.Add(this.Zero);
            this.panel1.Location = new System.Drawing.Point(4, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SeparadorVirgula
            // 
            this.SeparadorVirgula.BackColor = System.Drawing.Color.White;
            this.SeparadorVirgula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparadorVirgula.Location = new System.Drawing.Point(20, 2);
            this.SeparadorVirgula.Name = "SeparadorVirgula";
            this.SeparadorVirgula.Size = new System.Drawing.Size(85, 50);
            this.SeparadorVirgula.TabIndex = 2;
            this.SeparadorVirgula.Text = ",";
            this.SeparadorVirgula.UseVisualStyleBackColor = false;
            this.SeparadorVirgula.Click += new System.EventHandler(this.SeparadorVirgula_Click);
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.White;
            this.Separador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Separador.Location = new System.Drawing.Point(202, 3);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(85, 50);
            this.Separador.TabIndex = 1;
            this.Separador.Text = ".";
            this.Separador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Separador.UseVisualStyleBackColor = false;
            this.Separador.Click += new System.EventHandler(this.Separador_Click);
            // 
            // Zero
            // 
            this.Zero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Zero.BackColor = System.Drawing.Color.White;
            this.Zero.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.ForeColor = System.Drawing.Color.Red;
            this.Zero.Location = new System.Drawing.Point(111, 2);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(85, 50);
            this.Zero.TabIndex = 0;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Fatorial
            // 
            this.Fatorial.BackColor = System.Drawing.Color.DodgerBlue;
            this.Fatorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fatorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fatorial.Location = new System.Drawing.Point(391, 347);
            this.Fatorial.Name = "Fatorial";
            this.Fatorial.Size = new System.Drawing.Size(83, 50);
            this.Fatorial.TabIndex = 2;
            this.Fatorial.Text = "n!";
            this.Fatorial.UseVisualStyleBackColor = false;
            this.Fatorial.Click += new System.EventHandler(this.Fatorial_Click);
            // 
            // Modulo
            // 
            this.Modulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.Modulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modulo.Location = new System.Drawing.Point(391, 291);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(83, 50);
            this.Modulo.TabIndex = 0;
            this.Modulo.Text = "%";
            this.Modulo.UseVisualStyleBackColor = false;
            this.Modulo.Click += new System.EventHandler(this.Modulo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Tres);
            this.panel2.Controls.Add(this.Dois);
            this.panel2.Controls.Add(this.Um);
            this.panel2.Location = new System.Drawing.Point(1, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 50);
            this.panel2.TabIndex = 1;
            // 
            // Tres
            // 
            this.Tres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tres.BackColor = System.Drawing.Color.White;
            this.Tres.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tres.ForeColor = System.Drawing.Color.Red;
            this.Tres.Location = new System.Drawing.Point(205, 1);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(85, 50);
            this.Tres.TabIndex = 2;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = false;
            this.Tres.Click += new System.EventHandler(this.Tres_Click);
            // 
            // Dois
            // 
            this.Dois.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dois.BackColor = System.Drawing.Color.White;
            this.Dois.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dois.ForeColor = System.Drawing.Color.Red;
            this.Dois.Location = new System.Drawing.Point(114, 0);
            this.Dois.Name = "Dois";
            this.Dois.Size = new System.Drawing.Size(85, 50);
            this.Dois.TabIndex = 1;
            this.Dois.Text = "2";
            this.Dois.UseVisualStyleBackColor = false;
            this.Dois.Click += new System.EventHandler(this.Dois_Click);
            // 
            // Um
            // 
            this.Um.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Um.BackColor = System.Drawing.Color.White;
            this.Um.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Um.ForeColor = System.Drawing.Color.Red;
            this.Um.Location = new System.Drawing.Point(23, -1);
            this.Um.Name = "Um";
            this.Um.Size = new System.Drawing.Size(85, 50);
            this.Um.TabIndex = 0;
            this.Um.Text = "1";
            this.Um.UseVisualStyleBackColor = false;
            this.Um.Click += new System.EventHandler(this.Um_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Seis);
            this.panel3.Controls.Add(this.Cinco);
            this.panel3.Controls.Add(this.Quatro);
            this.panel3.Location = new System.Drawing.Point(4, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 57);
            this.panel3.TabIndex = 2;
            // 
            // Seis
            // 
            this.Seis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Seis.BackColor = System.Drawing.Color.White;
            this.Seis.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seis.ForeColor = System.Drawing.Color.Red;
            this.Seis.Location = new System.Drawing.Point(202, 8);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(85, 50);
            this.Seis.TabIndex = 2;
            this.Seis.Text = "6";
            this.Seis.UseVisualStyleBackColor = false;
            this.Seis.Click += new System.EventHandler(this.Seis_Click);
            // 
            // Cinco
            // 
            this.Cinco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cinco.BackColor = System.Drawing.Color.White;
            this.Cinco.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cinco.ForeColor = System.Drawing.Color.Red;
            this.Cinco.Location = new System.Drawing.Point(111, 8);
            this.Cinco.Name = "Cinco";
            this.Cinco.Size = new System.Drawing.Size(85, 50);
            this.Cinco.TabIndex = 1;
            this.Cinco.Text = "5";
            this.Cinco.UseVisualStyleBackColor = false;
            this.Cinco.Click += new System.EventHandler(this.Cinco_Click);
            // 
            // Quatro
            // 
            this.Quatro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Quatro.BackColor = System.Drawing.Color.White;
            this.Quatro.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quatro.ForeColor = System.Drawing.Color.Red;
            this.Quatro.Location = new System.Drawing.Point(20, 7);
            this.Quatro.Name = "Quatro";
            this.Quatro.Size = new System.Drawing.Size(85, 50);
            this.Quatro.TabIndex = 0;
            this.Quatro.Text = "4";
            this.Quatro.UseVisualStyleBackColor = false;
            this.Quatro.Click += new System.EventHandler(this.Quatro_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.Nove);
            this.panel4.Controls.Add(this.Oito);
            this.panel4.Controls.Add(this.Sete);
            this.panel4.Location = new System.Drawing.Point(4, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 50);
            this.panel4.TabIndex = 5;
            // 
            // Nove
            // 
            this.Nove.BackColor = System.Drawing.Color.White;
            this.Nove.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nove.ForeColor = System.Drawing.Color.Red;
            this.Nove.Location = new System.Drawing.Point(202, 0);
            this.Nove.Name = "Nove";
            this.Nove.Size = new System.Drawing.Size(85, 50);
            this.Nove.TabIndex = 2;
            this.Nove.Text = "9";
            this.Nove.UseVisualStyleBackColor = false;
            this.Nove.Click += new System.EventHandler(this.Nove_Click);
            // 
            // Oito
            // 
            this.Oito.BackColor = System.Drawing.Color.White;
            this.Oito.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oito.ForeColor = System.Drawing.Color.Red;
            this.Oito.Location = new System.Drawing.Point(111, -1);
            this.Oito.Name = "Oito";
            this.Oito.Size = new System.Drawing.Size(85, 50);
            this.Oito.TabIndex = 1;
            this.Oito.Text = "8";
            this.Oito.UseVisualStyleBackColor = false;
            this.Oito.Click += new System.EventHandler(this.Oito_Click);
            // 
            // Sete
            // 
            this.Sete.BackColor = System.Drawing.Color.White;
            this.Sete.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sete.ForeColor = System.Drawing.Color.Red;
            this.Sete.Location = new System.Drawing.Point(20, -1);
            this.Sete.Name = "Sete";
            this.Sete.Size = new System.Drawing.Size(85, 50);
            this.Sete.TabIndex = 0;
            this.Sete.Text = "7";
            this.Sete.UseVisualStyleBackColor = false;
            this.Sete.Click += new System.EventHandler(this.Sete_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.Multiplicar);
            this.panel5.Controls.Add(this.Subtrair);
            this.panel5.Controls.Add(this.Dividir);
            this.panel5.Controls.Add(this.Somar);
            this.panel5.Location = new System.Drawing.Point(297, 236);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(88, 223);
            this.panel5.TabIndex = 6;
            // 
            // Multiplicar
            // 
            this.Multiplicar.BackColor = System.Drawing.Color.Gray;
            this.Multiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Multiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiplicar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicar.Location = new System.Drawing.Point(0, 56);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(83, 50);
            this.Multiplicar.TabIndex = 0;
            this.Multiplicar.Text = "x";
            this.Multiplicar.UseVisualStyleBackColor = false;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // Subtrair
            // 
            this.Subtrair.BackColor = System.Drawing.Color.Gray;
            this.Subtrair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subtrair.FlatAppearance.BorderSize = 0;
            this.Subtrair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Subtrair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtrair.Location = new System.Drawing.Point(0, 112);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(83, 50);
            this.Subtrair.TabIndex = 0;
            this.Subtrair.Text = "-";
            this.Subtrair.UseVisualStyleBackColor = false;
            this.Subtrair.Click += new System.EventHandler(this.Subtrair_Click);
            // 
            // Dividir
            // 
            this.Dividir.BackColor = System.Drawing.Color.Gray;
            this.Dividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dividir.FlatAppearance.BorderSize = 0;
            this.Dividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dividir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividir.Location = new System.Drawing.Point(0, -1);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(83, 50);
            this.Dividir.TabIndex = 0;
            this.Dividir.Text = "÷";
            this.Dividir.UseVisualStyleBackColor = false;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // Somar
            // 
            this.Somar.BackColor = System.Drawing.Color.Gray;
            this.Somar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Somar.FlatAppearance.BorderSize = 0;
            this.Somar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Somar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Somar.Location = new System.Drawing.Point(0, 168);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(83, 50);
            this.Somar.TabIndex = 1;
            this.Somar.Text = "+";
            this.Somar.UseVisualStyleBackColor = false;
            this.Somar.Click += new System.EventHandler(this.Somar_Click);
            // 
            // VerificaResultado
            // 
            this.VerificaResultado.BackColor = System.Drawing.Color.DarkTurquoise;
            this.VerificaResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerificaResultado.FlatAppearance.BorderSize = 0;
            this.VerificaResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VerificaResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificaResultado.Location = new System.Drawing.Point(391, 403);
            this.VerificaResultado.Name = "VerificaResultado";
            this.VerificaResultado.Size = new System.Drawing.Size(83, 50);
            this.VerificaResultado.TabIndex = 0;
            this.VerificaResultado.Text = "=";
            this.VerificaResultado.UseVisualStyleBackColor = false;
            this.VerificaResultado.Click += new System.EventHandler(this.VerificaResultado_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.Clear);
            this.panel6.Location = new System.Drawing.Point(17, 170);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(147, 62);
            this.panel6.TabIndex = 7;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.BackgroundImage = global::CalculadoraInterativa.Properties.Resources.gui_eraser_icon_157160;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(7, 9);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(133, 52);
            this.Clear.TabIndex = 2;
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ElevarAoQuadrado
            // 
            this.ElevarAoQuadrado.AutoSize = true;
            this.ElevarAoQuadrado.BackColor = System.Drawing.Color.DodgerBlue;
            this.ElevarAoQuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ElevarAoQuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ElevarAoQuadrado.FlatAppearance.BorderSize = 0;
            this.ElevarAoQuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ElevarAoQuadrado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElevarAoQuadrado.Location = new System.Drawing.Point(391, 235);
            this.ElevarAoQuadrado.Name = "ElevarAoQuadrado";
            this.ElevarAoQuadrado.Size = new System.Drawing.Size(83, 50);
            this.ElevarAoQuadrado.TabIndex = 0;
            this.ElevarAoQuadrado.Text = "x²";
            this.ElevarAoQuadrado.UseVisualStyleBackColor = false;
            this.ElevarAoQuadrado.Click += new System.EventHandler(this.ElevarAoQuadrado_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.expressao);
            this.panel7.Controls.Add(this.R);
            this.panel7.Location = new System.Drawing.Point(12, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(474, 135);
            this.panel7.TabIndex = 8;
            // 
            // expressao
            // 
            this.expressao.AutoSize = true;
            this.expressao.BackColor = System.Drawing.Color.Black;
            this.expressao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressao.ForeColor = System.Drawing.Color.White;
            this.expressao.Location = new System.Drawing.Point(28, 60);
            this.expressao.Name = "expressao";
            this.expressao.Size = new System.Drawing.Size(31, 32);
            this.expressao.TabIndex = 1;
            this.expressao.Text = "0";
            // 
            // R
            // 
            this.R.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R.BackColor = System.Drawing.Color.Black;
            this.R.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.R.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.ForeColor = System.Drawing.Color.Lime;
            this.R.Location = new System.Drawing.Point(3, 3);
            this.R.Multiline = true;
            this.R.Name = "R";
            this.R.ReadOnly = true;
            this.R.Size = new System.Drawing.Size(464, 125);
            this.R.TabIndex = 0;
            this.R.Text = "\r\n0";
            this.R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(24, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Calculadora interativa";
            // 
            // Conversor
            // 
            this.Conversor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Conversor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Conversor.FlatAppearance.BorderSize = 0;
            this.Conversor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conversor.Location = new System.Drawing.Point(391, 179);
            this.Conversor.Name = "Conversor";
            this.Conversor.Size = new System.Drawing.Size(83, 50);
            this.Conversor.TabIndex = 10;
            this.Conversor.Text = "R$ > $";
            this.Conversor.UseVisualStyleBackColor = false;
            this.Conversor.Click += new System.EventHandler(this.Conversor_Click);
            // 
            // jogo
            // 
            this.jogo.BackColor = System.Drawing.Color.Yellow;
            this.jogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogo.Location = new System.Drawing.Point(170, 180);
            this.jogo.Name = "jogo";
            this.jogo.Size = new System.Drawing.Size(121, 52);
            this.jogo.TabIndex = 11;
            this.jogo.Text = "Adivinhe o número";
            this.jogo.UseVisualStyleBackColor = false;
            this.jogo.Click += new System.EventHandler(this.jogo_Click);
            this.jogo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jogo_KeyDown);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.Yellow;
            this.show.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(297, 180);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(83, 50);
            this.show.TabIndex = 12;
            this.show.Text = "?";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::CalculadoraInterativa.Properties.Resources._3d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 465);
            this.Controls.Add(this.Fatorial);
            this.Controls.Add(this.show);
            this.Controls.Add(this.jogo);
            this.Controls.Add(this.Conversor);
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.ElevarAoQuadrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.VerificaResultado);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Dois;
        private System.Windows.Forms.Button Um;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Cinco;
        private System.Windows.Forms.Button Quatro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Nove;
        private System.Windows.Forms.Button Oito;
        private System.Windows.Forms.Button Sete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.Button VerificaResultado;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button ElevarAoQuadrado;
        private System.Windows.Forms.Button Modulo;
        private System.Windows.Forms.Button Separador;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.Label expressao;
        private System.Windows.Forms.Button Fatorial;
        private System.Windows.Forms.Button Conversor;
        private System.Windows.Forms.Button jogo;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button SeparadorVirgula;
    }
}

