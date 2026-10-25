namespace Verify.Views
{
    partial class frmArtista
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
            this.gbrBiografia = new System.Windows.Forms.GroupBox();
            this.txtBiografia = new System.Windows.Forms.TextBox();
            this.btnCadastrarArtista = new System.Windows.Forms.Button();
            this.txtNomeReal = new System.Windows.Forms.TextBox();
            this.txtNomeArtistico = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicioCarreira = new System.Windows.Forms.DateTimePicker();
            this.txtGeneroMusicalPrincipal = new System.Windows.Forms.TextBox();
            this.gbrGeneroMusica = new System.Windows.Forms.GroupBox();
            this.txtIdArtista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbrBiografia.SuspendLayout();
            this.gbrGeneroMusica.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Real";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Artistico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Começo de carreira";
            // 
            // gbrBiografia
            // 
            this.gbrBiografia.Controls.Add(this.txtBiografia);
            this.gbrBiografia.Location = new System.Drawing.Point(26, 255);
            this.gbrBiografia.Name = "gbrBiografia";
            this.gbrBiografia.Size = new System.Drawing.Size(352, 151);
            this.gbrBiografia.TabIndex = 5;
            this.gbrBiografia.TabStop = false;
            this.gbrBiografia.Text = "Biografia do Artista";
            // 
            // txtBiografia
            // 
            this.txtBiografia.Location = new System.Drawing.Point(6, 19);
            this.txtBiografia.Multiline = true;
            this.txtBiografia.Name = "txtBiografia";
            this.txtBiografia.Size = new System.Drawing.Size(340, 126);
            this.txtBiografia.TabIndex = 6;
            // 
            // btnCadastrarArtista
            // 
            this.btnCadastrarArtista.Location = new System.Drawing.Point(644, 383);
            this.btnCadastrarArtista.Name = "btnCadastrarArtista";
            this.btnCadastrarArtista.Size = new System.Drawing.Size(122, 23);
            this.btnCadastrarArtista.TabIndex = 6;
            this.btnCadastrarArtista.Text = "Cadastrar";
            this.btnCadastrarArtista.UseVisualStyleBackColor = true;
            this.btnCadastrarArtista.Click += new System.EventHandler(this.btnCadastrarArtista_Click_1);
            // 
            // txtNomeReal
            // 
            this.txtNomeReal.Location = new System.Drawing.Point(26, 91);
            this.txtNomeReal.Name = "txtNomeReal";
            this.txtNomeReal.Size = new System.Drawing.Size(180, 20);
            this.txtNomeReal.TabIndex = 8;
            // 
            // txtNomeArtistico
            // 
            this.txtNomeArtistico.Location = new System.Drawing.Point(26, 141);
            this.txtNomeArtistico.Name = "txtNomeArtistico";
            this.txtNomeArtistico.Size = new System.Drawing.Size(180, 20);
            this.txtNomeArtistico.TabIndex = 10;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(346, 42);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(109, 20);
            this.dtpDataNascimento.TabIndex = 14;
            // 
            // dtpDataInicioCarreira
            // 
            this.dtpDataInicioCarreira.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicioCarreira.Location = new System.Drawing.Point(346, 141);
            this.dtpDataInicioCarreira.Name = "dtpDataInicioCarreira";
            this.dtpDataInicioCarreira.Size = new System.Drawing.Size(109, 20);
            this.dtpDataInicioCarreira.TabIndex = 15;
            // 
            // txtGeneroMusicalPrincipal
            // 
            this.txtGeneroMusicalPrincipal.Location = new System.Drawing.Point(6, 17);
            this.txtGeneroMusicalPrincipal.Multiline = true;
            this.txtGeneroMusicalPrincipal.Name = "txtGeneroMusicalPrincipal";
            this.txtGeneroMusicalPrincipal.Size = new System.Drawing.Size(188, 20);
            this.txtGeneroMusicalPrincipal.TabIndex = 7;
            // 
            // gbrGeneroMusica
            // 
            this.gbrGeneroMusica.Controls.Add(this.txtGeneroMusicalPrincipal);
            this.gbrGeneroMusica.Location = new System.Drawing.Point(572, 25);
            this.gbrGeneroMusica.Name = "gbrGeneroMusica";
            this.gbrGeneroMusica.Size = new System.Drawing.Size(200, 46);
            this.gbrGeneroMusica.TabIndex = 4;
            this.gbrGeneroMusica.TabStop = false;
            this.gbrGeneroMusica.Text = "Generos Musicas";
            // 
            // txtIdArtista
            // 
            this.txtIdArtista.Location = new System.Drawing.Point(26, 26);
            this.txtIdArtista.Name = "txtIdArtista";
            this.txtIdArtista.ReadOnly = true;
            this.txtIdArtista.Size = new System.Drawing.Size(45, 20);
            this.txtIdArtista.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Id Artista";
            // 
            // frmArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdArtista);
            this.Controls.Add(this.dtpDataInicioCarreira);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.txtNomeArtistico);
            this.Controls.Add(this.txtNomeReal);
            this.Controls.Add(this.btnCadastrarArtista);
            this.Controls.Add(this.gbrBiografia);
            this.Controls.Add(this.gbrGeneroMusica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmArtista";
            this.Text = "frmArtista";
            this.gbrBiografia.ResumeLayout(false);
            this.gbrBiografia.PerformLayout();
            this.gbrGeneroMusica.ResumeLayout(false);
            this.gbrGeneroMusica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbrBiografia;
        private System.Windows.Forms.Button btnCadastrarArtista;
        private System.Windows.Forms.TextBox txtNomeReal;
        private System.Windows.Forms.TextBox txtNomeArtistico;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataInicioCarreira;
        private System.Windows.Forms.TextBox txtBiografia;
        private System.Windows.Forms.TextBox txtGeneroMusicalPrincipal;
        private System.Windows.Forms.GroupBox gbrGeneroMusica;
        private System.Windows.Forms.TextBox txtIdArtista;
        private System.Windows.Forms.Label label5;
    }
}