namespace prjJogoForca
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnLetra = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtletra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPalavra = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbForca = new System.Windows.Forms.PictureBox();
            this.pbBoneco = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbLetras = new System.Windows.Forms.Label();
            this.lbCronometro = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbDica = new System.Windows.Forms.Label();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.pnLetra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLetra
            // 
            this.pnLetra.BackColor = System.Drawing.Color.Transparent;
            this.pnLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLetra.Controls.Add(this.btnJogar);
            this.pnLetra.Controls.Add(this.txtletra);
            this.pnLetra.Controls.Add(this.label1);
            this.pnLetra.Location = new System.Drawing.Point(51, 39);
            this.pnLetra.Name = "pnLetra";
            this.pnLetra.Size = new System.Drawing.Size(195, 152);
            this.pnLetra.TabIndex = 0;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Black;
            this.btnJogar.FlatAppearance.BorderSize = 0;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.ForeColor = System.Drawing.Color.Red;
            this.btnJogar.Location = new System.Drawing.Point(45, 101);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(101, 34);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtletra
            // 
            this.txtletra.BackColor = System.Drawing.Color.Black;
            this.txtletra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtletra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtletra.ForeColor = System.Drawing.Color.Red;
            this.txtletra.Location = new System.Drawing.Point(45, 66);
            this.txtletra.MaxLength = 1;
            this.txtletra.Multiline = true;
            this.txtletra.Name = "txtletra";
            this.txtletra.Size = new System.Drawing.Size(101, 29);
            this.txtletra.TabIndex = 1;
            this.txtletra.Text = "A";
            this.txtletra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtletra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtletra_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE LETRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPalavra
            // 
            this.pnPalavra.BackColor = System.Drawing.Color.Transparent;
            this.pnPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPalavra.Location = new System.Drawing.Point(266, 39);
            this.pnPalavra.Name = "pnPalavra";
            this.pnPalavra.Size = new System.Drawing.Size(566, 152);
            this.pnPalavra.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(824, 247);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(861, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pbForca
            // 
            this.pbForca.BackColor = System.Drawing.Color.Transparent;
            this.pbForca.Image = ((System.Drawing.Image)(resources.GetObject("pbForca.Image")));
            this.pbForca.Location = new System.Drawing.Point(81, 222);
            this.pbForca.Name = "pbForca";
            this.pbForca.Size = new System.Drawing.Size(209, 371);
            this.pbForca.TabIndex = 2;
            this.pbForca.TabStop = false;
            // 
            // pbBoneco
            // 
            this.pbBoneco.BackColor = System.Drawing.Color.Transparent;
            this.pbBoneco.Location = new System.Drawing.Point(208, 277);
            this.pbBoneco.Name = "pbBoneco";
            this.pbBoneco.Size = new System.Drawing.Size(171, 281);
            this.pbBoneco.TabIndex = 3;
            this.pbBoneco.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(956, 451);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(253, 142);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(438, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lbLetras
            // 
            this.lbLetras.BackColor = System.Drawing.Color.Orange;
            this.lbLetras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetras.ForeColor = System.Drawing.Color.Black;
            this.lbLetras.Location = new System.Drawing.Point(0, 634);
            this.lbLetras.Name = "lbLetras";
            this.lbLetras.Padding = new System.Windows.Forms.Padding(10);
            this.lbLetras.Size = new System.Drawing.Size(1291, 67);
            this.lbLetras.TabIndex = 10;
            // 
            // lbCronometro
            // 
            this.lbCronometro.AutoSize = true;
            this.lbCronometro.BackColor = System.Drawing.Color.Transparent;
            this.lbCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCronometro.ForeColor = System.Drawing.Color.White;
            this.lbCronometro.Location = new System.Drawing.Point(695, 545);
            this.lbCronometro.Name = "lbCronometro";
            this.lbCronometro.Size = new System.Drawing.Size(36, 20);
            this.lbCronometro.TabIndex = 11;
            this.lbCronometro.Text = "120";
            this.lbCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbDica
            // 
            this.lbDica.BackColor = System.Drawing.Color.Transparent;
            this.lbDica.Location = new System.Drawing.Point(359, 207);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(296, 23);
            this.lbDica.TabIndex = 12;
            this.lbDica.Text = "DICA:";
            this.lbDica.Click += new System.EventHandler(this.lbDica_Click);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.Black;
            this.btnNovoJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoJogo.FlatAppearance.BorderSize = 0;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.ForeColor = System.Drawing.Color.White;
            this.btnNovoJogo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoJogo.Image")));
            this.btnNovoJogo.Location = new System.Drawing.Point(782, 484);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(125, 126);
            this.btnNovoJogo.TabIndex = 3;
            this.btnNovoJogo.Text = "NOVO JOGO";
            this.btnNovoJogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            this.btnNovoJogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnNovoJogo_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1291, 701);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.lbDica);
            this.Controls.Add(this.lbCronometro);
            this.Controls.Add(this.lbLetras);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbBoneco);
            this.Controls.Add(this.pbForca);
            this.Controls.Add(this.pnPalavra);
            this.Controls.Add(this.pnLetra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO DA FORCA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnLetra.ResumeLayout(false);
            this.pnLetra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtletra;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Panel pnPalavra;
        private System.Windows.Forms.PictureBox pbForca;
        private System.Windows.Forms.PictureBox pbBoneco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbLetras;
        private System.Windows.Forms.Label lbCronometro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.Button btnNovoJogo;
    }
}

