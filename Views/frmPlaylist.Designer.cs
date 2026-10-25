namespace Verify.Views
{
    partial class frmPlaylist
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
            this.txtNomePlaylist = new System.Windows.Forms.TextBox();
            this.txtDescricaoPlaylist = new System.Windows.Forms.TextBox();
            this.btnCadastrarPlaylist = new System.Windows.Forms.Button();
            this.dtp_Atualizacao = new System.Windows.Forms.DateTimePicker();
            this.dtp_Criacao = new System.Windows.Forms.DateTimePicker();
            this.cbPrivacidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdLikes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPlaylist = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbIdUsuarioPlaylist = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Playlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Atualização";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Criação";
            // 
            // txtNomePlaylist
            // 
            this.txtNomePlaylist.Location = new System.Drawing.Point(578, 48);
            this.txtNomePlaylist.Name = "txtNomePlaylist";
            this.txtNomePlaylist.Size = new System.Drawing.Size(197, 20);
            this.txtNomePlaylist.TabIndex = 4;
            // 
            // txtDescricaoPlaylist
            // 
            this.txtDescricaoPlaylist.Location = new System.Drawing.Point(578, 121);
            this.txtDescricaoPlaylist.Multiline = true;
            this.txtDescricaoPlaylist.Name = "txtDescricaoPlaylist";
            this.txtDescricaoPlaylist.Size = new System.Drawing.Size(197, 103);
            this.txtDescricaoPlaylist.TabIndex = 5;
            // 
            // btnCadastrarPlaylist
            // 
            this.btnCadastrarPlaylist.Location = new System.Drawing.Point(10, 366);
            this.btnCadastrarPlaylist.Name = "btnCadastrarPlaylist";
            this.btnCadastrarPlaylist.Size = new System.Drawing.Size(104, 41);
            this.btnCadastrarPlaylist.TabIndex = 10;
            this.btnCadastrarPlaylist.Text = "Cadastrar";
            this.btnCadastrarPlaylist.UseVisualStyleBackColor = true;
            this.btnCadastrarPlaylist.Click += new System.EventHandler(this.btnCadastrarPlaylist_Click);
            // 
            // dtp_Atualizacao
            // 
            this.dtp_Atualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Atualizacao.Location = new System.Drawing.Point(656, 306);
            this.dtp_Atualizacao.Name = "dtp_Atualizacao";
            this.dtp_Atualizacao.Size = new System.Drawing.Size(107, 20);
            this.dtp_Atualizacao.TabIndex = 13;
            // 
            // dtp_Criacao
            // 
            this.dtp_Criacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Criacao.Location = new System.Drawing.Point(656, 396);
            this.dtp_Criacao.Name = "dtp_Criacao";
            this.dtp_Criacao.Size = new System.Drawing.Size(107, 20);
            this.dtp_Criacao.TabIndex = 14;
            // 
            // cbPrivacidade
            // 
            this.cbPrivacidade.FormattingEnabled = true;
            this.cbPrivacidade.Items.AddRange(new object[] {
            "Publico",
            "Privado"});
            this.cbPrivacidade.Location = new System.Drawing.Point(12, 95);
            this.cbPrivacidade.Name = "cbPrivacidade";
            this.cbPrivacidade.Size = new System.Drawing.Size(121, 21);
            this.cbPrivacidade.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Privacidade:";
            // 
            // txtQtdLikes
            // 
            this.txtQtdLikes.Location = new System.Drawing.Point(423, 204);
            this.txtQtdLikes.Name = "txtQtdLikes";
            this.txtQtdLikes.Size = new System.Drawing.Size(105, 20);
            this.txtQtdLikes.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quantidade de Likes:";
            // 
            // txtIdPlaylist
            // 
            this.txtIdPlaylist.Location = new System.Drawing.Point(12, 30);
            this.txtIdPlaylist.Name = "txtIdPlaylist";
            this.txtIdPlaylist.ReadOnly = true;
            this.txtIdPlaylist.Size = new System.Drawing.Size(48, 20);
            this.txtIdPlaylist.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Id Playlist";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Id Usuario";
            // 
            // cbIdUsuarioPlaylist
            // 
            this.cbIdUsuarioPlaylist.FormattingEnabled = true;
            this.cbIdUsuarioPlaylist.Location = new System.Drawing.Point(85, 29);
            this.cbIdUsuarioPlaylist.Name = "cbIdUsuarioPlaylist";
            this.cbIdUsuarioPlaylist.Size = new System.Drawing.Size(48, 21);
            this.cbIdUsuarioPlaylist.TabIndex = 25;
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbIdUsuarioPlaylist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdPlaylist);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQtdLikes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPrivacidade);
            this.Controls.Add(this.dtp_Criacao);
            this.Controls.Add(this.dtp_Atualizacao);
            this.Controls.Add(this.btnCadastrarPlaylist);
            this.Controls.Add(this.txtDescricaoPlaylist);
            this.Controls.Add(this.txtNomePlaylist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPlaylist";
            this.Text = "frmPlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomePlaylist;
        private System.Windows.Forms.TextBox txtDescricaoPlaylist;
        private System.Windows.Forms.Button btnCadastrarPlaylist;
        private System.Windows.Forms.DateTimePicker dtp_Atualizacao;
        private System.Windows.Forms.DateTimePicker dtp_Criacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtdLikes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPrivacidade;
        private System.Windows.Forms.TextBox txtIdPlaylist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbIdUsuarioPlaylist;
    }
}