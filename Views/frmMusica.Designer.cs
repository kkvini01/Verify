namespace Verify.Views
{
    partial class frmMusica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTituloMusica = new System.Windows.Forms.TextBox();
            this.txtNomeCompositor = new System.Windows.Forms.TextBox();
            this.txtNumReprod = new System.Windows.Forms.TextBox();
            this.btnCadastrarMusica = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGeneroMusical = new System.Windows.Forms.TextBox();
            this.dtpDataLancamentoMusica = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdMusica = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbIdAlbumMusica = new System.Windows.Forms.ComboBox();
            this.cbIdArtistaMusica = new System.Windows.Forms.ComboBox();
            this.txtDuracaoSegundos = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compositor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duração Musica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Reproduções";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Titulo Musica";
            // 
            // txtTituloMusica
            // 
            this.txtTituloMusica.Location = new System.Drawing.Point(569, 25);
            this.txtTituloMusica.Multiline = true;
            this.txtTituloMusica.Name = "txtTituloMusica";
            this.txtTituloMusica.Size = new System.Drawing.Size(200, 21);
            this.txtTituloMusica.TabIndex = 4;
            // 
            // txtNomeCompositor
            // 
            this.txtNomeCompositor.Location = new System.Drawing.Point(64, 95);
            this.txtNomeCompositor.Name = "txtNomeCompositor";
            this.txtNomeCompositor.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCompositor.TabIndex = 5;
            // 
            // txtNumReprod
            // 
            this.txtNumReprod.Location = new System.Drawing.Point(386, 95);
            this.txtNumReprod.Name = "txtNumReprod";
            this.txtNumReprod.Size = new System.Drawing.Size(100, 20);
            this.txtNumReprod.TabIndex = 7;
            // 
            // btnCadastrarMusica
            // 
            this.btnCadastrarMusica.Location = new System.Drawing.Point(23, 370);
            this.btnCadastrarMusica.Name = "btnCadastrarMusica";
            this.btnCadastrarMusica.Size = new System.Drawing.Size(97, 34);
            this.btnCadastrarMusica.TabIndex = 8;
            this.btnCadastrarMusica.Text = "Cadastrar";
            this.btnCadastrarMusica.UseVisualStyleBackColor = true;
            this.btnCadastrarMusica.Click += new System.EventHandler(this.btnCadastrarMusica_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Lançamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Genero Musical";
            // 
            // txtGeneroMusical
            // 
            this.txtGeneroMusical.Location = new System.Drawing.Point(352, 375);
            this.txtGeneroMusical.Multiline = true;
            this.txtGeneroMusical.Name = "txtGeneroMusical";
            this.txtGeneroMusical.Size = new System.Drawing.Size(134, 27);
            this.txtGeneroMusical.TabIndex = 12;
            // 
            // dtpDataLancamentoMusica
            // 
            this.dtpDataLancamentoMusica.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLancamentoMusica.Location = new System.Drawing.Point(614, 375);
            this.dtpDataLancamentoMusica.Name = "dtpDataLancamentoMusica";
            this.dtpDataLancamentoMusica.Size = new System.Drawing.Size(107, 20);
            this.dtpDataLancamentoMusica.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Id Musica";
            // 
            // txtIdMusica
            // 
            this.txtIdMusica.Location = new System.Drawing.Point(12, 26);
            this.txtIdMusica.Name = "txtIdMusica";
            this.txtIdMusica.ReadOnly = true;
            this.txtIdMusica.Size = new System.Drawing.Size(45, 20);
            this.txtIdMusica.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Id Artista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Id Album";
            // 
            // cbIdAlbumMusica
            // 
            this.cbIdAlbumMusica.FormattingEnabled = true;
            this.cbIdAlbumMusica.Location = new System.Drawing.Point(75, 26);
            this.cbIdAlbumMusica.Name = "cbIdAlbumMusica";
            this.cbIdAlbumMusica.Size = new System.Drawing.Size(45, 21);
            this.cbIdAlbumMusica.TabIndex = 30;
            // 
            // cbIdArtistaMusica
            // 
            this.cbIdArtistaMusica.FormattingEnabled = true;
            this.cbIdArtistaMusica.Location = new System.Drawing.Point(137, 26);
            this.cbIdArtistaMusica.Name = "cbIdArtistaMusica";
            this.cbIdArtistaMusica.Size = new System.Drawing.Size(45, 21);
            this.cbIdArtistaMusica.TabIndex = 31;
            // 
            // txtDuracaoSegundos
            // 
            this.txtDuracaoSegundos.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtDuracaoSegundos.Location = new System.Drawing.Point(224, 95);
            this.txtDuracaoSegundos.Name = "txtDuracaoSegundos";
            this.txtDuracaoSegundos.Size = new System.Drawing.Size(109, 20);
            this.txtDuracaoSegundos.TabIndex = 33;
            // 
            // frmMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDuracaoSegundos);
            this.Controls.Add(this.cbIdArtistaMusica);
            this.Controls.Add(this.cbIdAlbumMusica);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdMusica);
            this.Controls.Add(this.dtpDataLancamentoMusica);
            this.Controls.Add(this.txtGeneroMusical);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastrarMusica);
            this.Controls.Add(this.txtNumReprod);
            this.Controls.Add(this.txtNomeCompositor);
            this.Controls.Add(this.txtTituloMusica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMusica";
            this.Text = "frmMusica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTituloMusica;
        private System.Windows.Forms.TextBox txtNomeCompositor;
        private System.Windows.Forms.TextBox txtNumReprod;
        private System.Windows.Forms.Button btnCadastrarMusica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGeneroMusical;
        private System.Windows.Forms.DateTimePicker dtpDataLancamentoMusica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdMusica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbIdAlbumMusica;
        private System.Windows.Forms.ComboBox cbIdArtistaMusica;
        private System.Windows.Forms.DateTimePicker txtDuracaoSegundos;
    }
}