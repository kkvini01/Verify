namespace Verify.Views
{
    partial class frmVisualizarPlaylist
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
            this.cbIdPlaylistVisualizar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomePlaylistVisualizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbMusicas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbIdPlaylistVisualizar
            // 
            this.cbIdPlaylistVisualizar.FormattingEnabled = true;
            this.cbIdPlaylistVisualizar.Location = new System.Drawing.Point(19, 39);
            this.cbIdPlaylistVisualizar.Name = "cbIdPlaylistVisualizar";
            this.cbIdPlaylistVisualizar.Size = new System.Drawing.Size(48, 21);
            this.cbIdPlaylistVisualizar.TabIndex = 47;
            this.cbIdPlaylistVisualizar.SelectedIndexChanged += new System.EventHandler(this.cbIdPlaylistVisualizar_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Id Playlist";
            // 
            // txtNomePlaylistVisualizar
            // 
            this.txtNomePlaylistVisualizar.Location = new System.Drawing.Point(84, 40);
            this.txtNomePlaylistVisualizar.Name = "txtNomePlaylistVisualizar";
            this.txtNomePlaylistVisualizar.ReadOnly = true;
            this.txtNomePlaylistVisualizar.Size = new System.Drawing.Size(205, 20);
            this.txtNomePlaylistVisualizar.TabIndex = 45;
            this.txtNomePlaylistVisualizar.TextChanged += new System.EventHandler(this.txtNomePlaylistVisualizar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nome Playlist";
            // 
            // lsbMusicas
            // 
            this.lsbMusicas.FormattingEnabled = true;
            this.lsbMusicas.Location = new System.Drawing.Point(19, 88);
            this.lsbMusicas.Name = "lsbMusicas";
            this.lsbMusicas.Size = new System.Drawing.Size(270, 316);
            this.lsbMusicas.TabIndex = 48;
            this.lsbMusicas.SelectedIndexChanged += new System.EventHandler(this.lsbMusicasInserida_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Músicas:";
            // 
            // frmVisualizarPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbMusicas);
            this.Controls.Add(this.cbIdPlaylistVisualizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomePlaylistVisualizar);
            this.Controls.Add(this.label1);
            this.Name = "frmVisualizarPlaylist";
            this.Text = "frmVisualizarPlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIdPlaylistVisualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomePlaylistVisualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbMusicas;
        private System.Windows.Forms.Label label2;
    }
}