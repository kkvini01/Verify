namespace Verify.Views
{
    partial class frmPlaylistSelecao
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
            this.btnAdicionarPlaylistSelecao = new System.Windows.Forms.Button();
            this.btnAlterarPlaylistSelecao = new System.Windows.Forms.Button();
            this.btnExcluirPlaylistSelecao = new System.Windows.Forms.Button();
            this.btnVisualizarPlaylistSelecao = new System.Windows.Forms.Button();
            this.lblRegistrosPlaylistSelecao = new System.Windows.Forms.Label();
            this.dgvRegistrosPlaylistSelecao = new System.Windows.Forms.DataGridView();
            this.btnPesquisarPlaylistSelecao = new System.Windows.Forms.Button();
            this.txtIdPlaylist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePlaylistSelecao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdUsuarioPlaylist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosPlaylistSelecao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarPlaylistSelecao
            // 
            this.btnAdicionarPlaylistSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarPlaylistSelecao.Location = new System.Drawing.Point(333, 283);
            this.btnAdicionarPlaylistSelecao.Name = "btnAdicionarPlaylistSelecao";
            this.btnAdicionarPlaylistSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarPlaylistSelecao.TabIndex = 39;
            this.btnAdicionarPlaylistSelecao.Text = "Adicionar";
            this.btnAdicionarPlaylistSelecao.UseVisualStyleBackColor = true;
            this.btnAdicionarPlaylistSelecao.Click += new System.EventHandler(this.btnAdicionarPlaylistSelecao_Click);
            // 
            // btnAlterarPlaylistSelecao
            // 
            this.btnAlterarPlaylistSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarPlaylistSelecao.Location = new System.Drawing.Point(414, 283);
            this.btnAlterarPlaylistSelecao.Name = "btnAlterarPlaylistSelecao";
            this.btnAlterarPlaylistSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPlaylistSelecao.TabIndex = 38;
            this.btnAlterarPlaylistSelecao.Text = "Alterar";
            this.btnAlterarPlaylistSelecao.UseVisualStyleBackColor = true;
            this.btnAlterarPlaylistSelecao.Click += new System.EventHandler(this.btnAlterarPlaylistSelecao_Click);
            // 
            // btnExcluirPlaylistSelecao
            // 
            this.btnExcluirPlaylistSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirPlaylistSelecao.Location = new System.Drawing.Point(495, 283);
            this.btnExcluirPlaylistSelecao.Name = "btnExcluirPlaylistSelecao";
            this.btnExcluirPlaylistSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPlaylistSelecao.TabIndex = 37;
            this.btnExcluirPlaylistSelecao.Text = "Excluir";
            this.btnExcluirPlaylistSelecao.UseVisualStyleBackColor = true;
            this.btnExcluirPlaylistSelecao.Click += new System.EventHandler(this.btnExcluirPlaylistSelecao_Click);
            // 
            // btnVisualizarPlaylistSelecao
            // 
            this.btnVisualizarPlaylistSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizarPlaylistSelecao.Location = new System.Drawing.Point(576, 283);
            this.btnVisualizarPlaylistSelecao.Name = "btnVisualizarPlaylistSelecao";
            this.btnVisualizarPlaylistSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarPlaylistSelecao.TabIndex = 36;
            this.btnVisualizarPlaylistSelecao.Text = "Visualizar";
            this.btnVisualizarPlaylistSelecao.UseVisualStyleBackColor = true;
            this.btnVisualizarPlaylistSelecao.Click += new System.EventHandler(this.btnVisualizarPlaylistSelecao_Click);
            // 
            // lblRegistrosPlaylistSelecao
            // 
            this.lblRegistrosPlaylistSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistrosPlaylistSelecao.AutoSize = true;
            this.lblRegistrosPlaylistSelecao.Location = new System.Drawing.Point(17, 253);
            this.lblRegistrosPlaylistSelecao.Name = "lblRegistrosPlaylistSelecao";
            this.lblRegistrosPlaylistSelecao.Size = new System.Drawing.Size(57, 13);
            this.lblRegistrosPlaylistSelecao.TabIndex = 35;
            this.lblRegistrosPlaylistSelecao.Text = "Registros: ";
            // 
            // dgvRegistrosPlaylistSelecao
            // 
            this.dgvRegistrosPlaylistSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistrosPlaylistSelecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrosPlaylistSelecao.Location = new System.Drawing.Point(17, 69);
            this.dgvRegistrosPlaylistSelecao.MultiSelect = false;
            this.dgvRegistrosPlaylistSelecao.Name = "dgvRegistrosPlaylistSelecao";
            this.dgvRegistrosPlaylistSelecao.ReadOnly = true;
            this.dgvRegistrosPlaylistSelecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistrosPlaylistSelecao.Size = new System.Drawing.Size(634, 181);
            this.dgvRegistrosPlaylistSelecao.TabIndex = 34;
            // 
            // btnPesquisarPlaylistSelecao
            // 
            this.btnPesquisarPlaylistSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarPlaylistSelecao.Location = new System.Drawing.Point(576, 31);
            this.btnPesquisarPlaylistSelecao.Name = "btnPesquisarPlaylistSelecao";
            this.btnPesquisarPlaylistSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPlaylistSelecao.TabIndex = 33;
            this.btnPesquisarPlaylistSelecao.Text = "Pesquisar";
            this.btnPesquisarPlaylistSelecao.UseVisualStyleBackColor = true;
            this.btnPesquisarPlaylistSelecao.Click += new System.EventHandler(this.btnPesquisarPlaylistSelecao_Click_1);
            // 
            // txtIdPlaylist
            // 
            this.txtIdPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdPlaylist.Location = new System.Drawing.Point(80, 33);
            this.txtIdPlaylist.Name = "txtIdPlaylist";
            this.txtIdPlaylist.Size = new System.Drawing.Size(57, 20);
            this.txtIdPlaylist.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nome Playlist:";
            // 
            // txtNomePlaylistSelecao
            // 
            this.txtNomePlaylistSelecao.Location = new System.Drawing.Point(143, 34);
            this.txtNomePlaylistSelecao.Name = "txtNomePlaylistSelecao";
            this.txtNomePlaylistSelecao.Size = new System.Drawing.Size(163, 20);
            this.txtNomePlaylistSelecao.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Id Playlist:";
            // 
            // txtIdUsuarioPlaylist
            // 
            this.txtIdUsuarioPlaylist.Location = new System.Drawing.Point(17, 33);
            this.txtIdUsuarioPlaylist.Name = "txtIdUsuarioPlaylist";
            this.txtIdUsuarioPlaylist.Size = new System.Drawing.Size(57, 20);
            this.txtIdUsuarioPlaylist.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id Usuário:";
            // 
            // frmPlaylistSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 322);
            this.Controls.Add(this.btnAdicionarPlaylistSelecao);
            this.Controls.Add(this.btnAlterarPlaylistSelecao);
            this.Controls.Add(this.btnExcluirPlaylistSelecao);
            this.Controls.Add(this.btnVisualizarPlaylistSelecao);
            this.Controls.Add(this.lblRegistrosPlaylistSelecao);
            this.Controls.Add(this.dgvRegistrosPlaylistSelecao);
            this.Controls.Add(this.btnPesquisarPlaylistSelecao);
            this.Controls.Add(this.txtIdPlaylist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomePlaylistSelecao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdUsuarioPlaylist);
            this.Controls.Add(this.label1);
            this.Name = "frmPlaylistSelecao";
            this.Text = "frmPlaylistSelecao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosPlaylistSelecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarPlaylistSelecao;
        private System.Windows.Forms.Button btnAlterarPlaylistSelecao;
        private System.Windows.Forms.Button btnExcluirPlaylistSelecao;
        private System.Windows.Forms.Button btnVisualizarPlaylistSelecao;
        private System.Windows.Forms.Label lblRegistrosPlaylistSelecao;
        private System.Windows.Forms.DataGridView dgvRegistrosPlaylistSelecao;
        private System.Windows.Forms.Button btnPesquisarPlaylistSelecao;
        private System.Windows.Forms.TextBox txtIdPlaylist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomePlaylistSelecao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdUsuarioPlaylist;
        private System.Windows.Forms.Label label1;
    }
}