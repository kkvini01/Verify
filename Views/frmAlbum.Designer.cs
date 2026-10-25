namespace Verify.Views
{
    partial class frmAlbum
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
            this.label5 = new System.Windows.Forms.Label();
            this.picBox_CapaUrl = new System.Windows.Forms.PictureBox();
            this.btnCadastrarAlbum = new System.Windows.Forms.Button();
            this.txtGravadora = new System.Windows.Forms.TextBox();
            this.txtNumeroFaixas = new System.Windows.Forms.TextBox();
            this.dtpDataLancamentoAlbum = new System.Windows.Forms.DateTimePicker();
            this.dtp_DuracaoTotal = new System.Windows.Forms.DateTimePicker();
            this.cb_TipoAlbum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdAlbum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIdArtistaAlbum = new System.Windows.Forms.ComboBox();
            this.txtNomeAlbum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCapaUrl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CapaUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gravadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Lançamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duração Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero Faixas";
            // 
            // picBox_CapaUrl
            // 
            this.picBox_CapaUrl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_CapaUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_CapaUrl.Location = new System.Drawing.Point(557, 12);
            this.picBox_CapaUrl.Name = "picBox_CapaUrl";
            this.picBox_CapaUrl.Size = new System.Drawing.Size(231, 208);
            this.picBox_CapaUrl.TabIndex = 5;
            this.picBox_CapaUrl.TabStop = false;
            // 
            // btnCadastrarAlbum
            // 
            this.btnCadastrarAlbum.Location = new System.Drawing.Point(27, 380);
            this.btnCadastrarAlbum.Name = "btnCadastrarAlbum";
            this.btnCadastrarAlbum.Size = new System.Drawing.Size(107, 58);
            this.btnCadastrarAlbum.TabIndex = 6;
            this.btnCadastrarAlbum.Text = "Cadastrar";
            this.btnCadastrarAlbum.UseVisualStyleBackColor = true;
            this.btnCadastrarAlbum.Click += new System.EventHandler(this.btnCadastrarAlbum_Click_1);
            // 
            // txtGravadora
            // 
            this.txtGravadora.Location = new System.Drawing.Point(27, 127);
            this.txtGravadora.Name = "txtGravadora";
            this.txtGravadora.Size = new System.Drawing.Size(107, 20);
            this.txtGravadora.TabIndex = 8;
            // 
            // txtNumeroFaixas
            // 
            this.txtNumeroFaixas.Location = new System.Drawing.Point(315, 223);
            this.txtNumeroFaixas.Name = "txtNumeroFaixas";
            this.txtNumeroFaixas.Size = new System.Drawing.Size(109, 20);
            this.txtNumeroFaixas.TabIndex = 12;
            // 
            // dtpDataLancamentoAlbum
            // 
            this.dtpDataLancamentoAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLancamentoAlbum.Location = new System.Drawing.Point(315, 38);
            this.dtpDataLancamentoAlbum.Name = "dtpDataLancamentoAlbum";
            this.dtpDataLancamentoAlbum.Size = new System.Drawing.Size(109, 20);
            this.dtpDataLancamentoAlbum.TabIndex = 13;
            // 
            // dtp_DuracaoTotal
            // 
            this.dtp_DuracaoTotal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_DuracaoTotal.Location = new System.Drawing.Point(315, 127);
            this.dtp_DuracaoTotal.Name = "dtp_DuracaoTotal";
            this.dtp_DuracaoTotal.Size = new System.Drawing.Size(109, 20);
            this.dtp_DuracaoTotal.TabIndex = 14;
            // 
            // cb_TipoAlbum
            // 
            this.cb_TipoAlbum.FormattingEnabled = true;
            this.cb_TipoAlbum.Items.AddRange(new object[] {
            "EP",
            "Single",
            "Album"});
            this.cb_TipoAlbum.Location = new System.Drawing.Point(27, 223);
            this.cb_TipoAlbum.Name = "cb_TipoAlbum";
            this.cb_TipoAlbum.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoAlbum.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Id Album";
            // 
            // txtIdAlbum
            // 
            this.txtIdAlbum.Location = new System.Drawing.Point(27, 38);
            this.txtIdAlbum.Name = "txtIdAlbum";
            this.txtIdAlbum.ReadOnly = true;
            this.txtIdAlbum.Size = new System.Drawing.Size(45, 20);
            this.txtIdAlbum.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Id Artista";
            // 
            // cbIdArtistaAlbum
            // 
            this.cbIdArtistaAlbum.FormattingEnabled = true;
            this.cbIdArtistaAlbum.Location = new System.Drawing.Point(89, 38);
            this.cbIdArtistaAlbum.Name = "cbIdArtistaAlbum";
            this.cbIdArtistaAlbum.Size = new System.Drawing.Size(45, 21);
            this.cbIdArtistaAlbum.TabIndex = 32;
            // 
            // txtNomeAlbum
            // 
            this.txtNomeAlbum.Location = new System.Drawing.Point(557, 290);
            this.txtNomeAlbum.Name = "txtNomeAlbum";
            this.txtNomeAlbum.Size = new System.Drawing.Size(231, 20);
            this.txtNomeAlbum.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nome Album";
            // 
            // txtCapaUrl
            // 
            this.txtCapaUrl.Location = new System.Drawing.Point(557, 242);
            this.txtCapaUrl.Name = "txtCapaUrl";
            this.txtCapaUrl.Size = new System.Drawing.Size(231, 20);
            this.txtCapaUrl.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(554, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Url da Capa";
            // 
            // frmAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCapaUrl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNomeAlbum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbIdArtistaAlbum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdAlbum);
            this.Controls.Add(this.cb_TipoAlbum);
            this.Controls.Add(this.dtp_DuracaoTotal);
            this.Controls.Add(this.dtpDataLancamentoAlbum);
            this.Controls.Add(this.txtNumeroFaixas);
            this.Controls.Add(this.txtGravadora);
            this.Controls.Add(this.btnCadastrarAlbum);
            this.Controls.Add(this.picBox_CapaUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlbum";
            this.Text = "frmAlbum";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CapaUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBox_CapaUrl;
        private System.Windows.Forms.Button btnCadastrarAlbum;
        private System.Windows.Forms.TextBox txtGravadora;
        private System.Windows.Forms.TextBox txtNumeroFaixas;
        private System.Windows.Forms.DateTimePicker dtpDataLancamentoAlbum;
        private System.Windows.Forms.DateTimePicker dtp_DuracaoTotal;
        private System.Windows.Forms.ComboBox cb_TipoAlbum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdAlbum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIdArtistaAlbum;
        private System.Windows.Forms.TextBox txtNomeAlbum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCapaUrl;
        private System.Windows.Forms.Label label9;
    }
}