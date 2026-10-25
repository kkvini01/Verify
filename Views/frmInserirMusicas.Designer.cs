namespace Verify.Views
{
    partial class frmInserirMusicas
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
            this.label7 = new System.Windows.Forms.Label();
            this.label3434 = new System.Windows.Forms.Label();
            this.cbIdMusicasInserir = new System.Windows.Forms.ComboBox();
            this.btnCadastrarMusicaInserir = new System.Windows.Forms.Button();
            this.txtNomePlaylistInserir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIdPlaylistInserir = new System.Windows.Forms.ComboBox();
            this.txtNomeMusicaInserir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbMusicasInseridas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserirMusica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Id Playlist";
            // 
            // label3434
            // 
            this.label3434.AutoSize = true;
            this.label3434.Location = new System.Drawing.Point(20, 92);
            this.label3434.Name = "label3434";
            this.label3434.Size = new System.Drawing.Size(53, 13);
            this.label3434.TabIndex = 36;
            this.label3434.Text = "Id Música";
            // 
            // cbIdMusicasInserir
            // 
            this.cbIdMusicasInserir.FormattingEnabled = true;
            this.cbIdMusicasInserir.Items.AddRange(new object[] {
            "Publico",
            "Privado"});
            this.cbIdMusicasInserir.Location = new System.Drawing.Point(20, 108);
            this.cbIdMusicasInserir.Name = "cbIdMusicasInserir";
            this.cbIdMusicasInserir.Size = new System.Drawing.Size(49, 21);
            this.cbIdMusicasInserir.TabIndex = 35;
            this.cbIdMusicasInserir.SelectedIndexChanged += new System.EventHandler(this.cbIdMusicasInserir_SelectedIndexChanged);
            // 
            // btnCadastrarMusicaInserir
            // 
            this.btnCadastrarMusicaInserir.Location = new System.Drawing.Point(18, 379);
            this.btnCadastrarMusicaInserir.Name = "btnCadastrarMusicaInserir";
            this.btnCadastrarMusicaInserir.Size = new System.Drawing.Size(104, 41);
            this.btnCadastrarMusicaInserir.TabIndex = 32;
            this.btnCadastrarMusicaInserir.Text = "Cadastrar";
            this.btnCadastrarMusicaInserir.UseVisualStyleBackColor = true;
            this.btnCadastrarMusicaInserir.Click += new System.EventHandler(this.btnCadastrarMusicaInserir_Click);
            // 
            // txtNomePlaylistInserir
            // 
            this.txtNomePlaylistInserir.Location = new System.Drawing.Point(83, 43);
            this.txtNomePlaylistInserir.Name = "txtNomePlaylistInserir";
            this.txtNomePlaylistInserir.ReadOnly = true;
            this.txtNomePlaylistInserir.Size = new System.Drawing.Size(205, 20);
            this.txtNomePlaylistInserir.TabIndex = 30;
            this.txtNomePlaylistInserir.TextChanged += new System.EventHandler(this.txtNomePlaylistInserir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome Playlist";
            // 
            // cbIdPlaylistInserir
            // 
            this.cbIdPlaylistInserir.FormattingEnabled = true;
            this.cbIdPlaylistInserir.Location = new System.Drawing.Point(18, 42);
            this.cbIdPlaylistInserir.Name = "cbIdPlaylistInserir";
            this.cbIdPlaylistInserir.Size = new System.Drawing.Size(48, 21);
            this.cbIdPlaylistInserir.TabIndex = 43;
            this.cbIdPlaylistInserir.SelectedIndexChanged += new System.EventHandler(this.cbIdPlaylistInserir_SelectedIndexChanged);
            // 
            // txtNomeMusicaInserir
            // 
            this.txtNomeMusicaInserir.Location = new System.Drawing.Point(83, 108);
            this.txtNomeMusicaInserir.Name = "txtNomeMusicaInserir";
            this.txtNomeMusicaInserir.ReadOnly = true;
            this.txtNomeMusicaInserir.Size = new System.Drawing.Size(205, 20);
            this.txtNomeMusicaInserir.TabIndex = 45;
            this.txtNomeMusicaInserir.TextChanged += new System.EventHandler(this.txtNomeMusicaInserir_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nome Música";
            // 
            // lsbMusicasInseridas
            // 
            this.lsbMusicasInseridas.FormattingEnabled = true;
            this.lsbMusicasInseridas.Location = new System.Drawing.Point(20, 172);
            this.lsbMusicasInseridas.Name = "lsbMusicasInseridas";
            this.lsbMusicasInseridas.Size = new System.Drawing.Size(268, 160);
            this.lsbMusicasInseridas.TabIndex = 46;
            this.lsbMusicasInseridas.SelectedIndexChanged += new System.EventHandler(this.lsbMusicasInseridas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Músicas Inseridas";
            // 
            // btnInserirMusica
            // 
            this.btnInserirMusica.Location = new System.Drawing.Point(305, 64);
            this.btnInserirMusica.Name = "btnInserirMusica";
            this.btnInserirMusica.Size = new System.Drawing.Size(104, 41);
            this.btnInserirMusica.TabIndex = 48;
            this.btnInserirMusica.Text = "Inserir";
            this.btnInserirMusica.UseVisualStyleBackColor = true;
            this.btnInserirMusica.Click += new System.EventHandler(this.btnInserirMusica_Click);
            // 
            // frmInserirMusicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInserirMusica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbMusicasInseridas);
            this.Controls.Add(this.txtNomeMusicaInserir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbIdPlaylistInserir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3434);
            this.Controls.Add(this.cbIdMusicasInserir);
            this.Controls.Add(this.btnCadastrarMusicaInserir);
            this.Controls.Add(this.txtNomePlaylistInserir);
            this.Controls.Add(this.label1);
            this.Name = "frmInserirMusicas";
            this.Text = "frmInserirMusicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3434;
        private System.Windows.Forms.ComboBox cbIdMusicasInserir;
        private System.Windows.Forms.Button btnCadastrarMusicaInserir;
        private System.Windows.Forms.TextBox txtNomePlaylistInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIdPlaylistInserir;
        private System.Windows.Forms.TextBox txtNomeMusicaInserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbMusicasInseridas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserirMusica;
    }
}