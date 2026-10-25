namespace Verify.Views
{
    partial class frmUsuarioSelecao
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
            this.btnAdicionarUsuarioSelecao = new System.Windows.Forms.Button();
            this.btnAlterarUsuarioSelecao = new System.Windows.Forms.Button();
            this.btnExcluirUsuarioSelecao = new System.Windows.Forms.Button();
            this.btnVisualizarUsuarioSelecao = new System.Windows.Forms.Button();
            this.lblRegistrosUsuarioSelecao = new System.Windows.Forms.Label();
            this.dgvRegistrosUsuarioSelecao = new System.Windows.Forms.DataGridView();
            this.btnPesquisarUsuarioSelecao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeUsuarioSelecao = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailUsuarioSelecao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TipoPlanoSelecao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosUsuarioSelecao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarUsuarioSelecao
            // 
            this.btnAdicionarUsuarioSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarUsuarioSelecao.Location = new System.Drawing.Point(336, 289);
            this.btnAdicionarUsuarioSelecao.Name = "btnAdicionarUsuarioSelecao";
            this.btnAdicionarUsuarioSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarUsuarioSelecao.TabIndex = 26;
            this.btnAdicionarUsuarioSelecao.Text = "Adicionar";
            this.btnAdicionarUsuarioSelecao.UseVisualStyleBackColor = true;
            this.btnAdicionarUsuarioSelecao.Click += new System.EventHandler(this.btnAdicionarUsuarioSelecao_Click);
            // 
            // btnAlterarUsuarioSelecao
            // 
            this.btnAlterarUsuarioSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarUsuarioSelecao.Location = new System.Drawing.Point(417, 289);
            this.btnAlterarUsuarioSelecao.Name = "btnAlterarUsuarioSelecao";
            this.btnAlterarUsuarioSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarUsuarioSelecao.TabIndex = 25;
            this.btnAlterarUsuarioSelecao.Text = "Alterar";
            this.btnAlterarUsuarioSelecao.UseVisualStyleBackColor = true;
            this.btnAlterarUsuarioSelecao.Click += new System.EventHandler(this.btnAlterarUsuarioSelecao_Click);
            // 
            // btnExcluirUsuarioSelecao
            // 
            this.btnExcluirUsuarioSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirUsuarioSelecao.Location = new System.Drawing.Point(498, 289);
            this.btnExcluirUsuarioSelecao.Name = "btnExcluirUsuarioSelecao";
            this.btnExcluirUsuarioSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirUsuarioSelecao.TabIndex = 24;
            this.btnExcluirUsuarioSelecao.Text = "Excluir";
            this.btnExcluirUsuarioSelecao.UseVisualStyleBackColor = true;
            this.btnExcluirUsuarioSelecao.Click += new System.EventHandler(this.btnExcluirUsuarioSelecao_Click);
            // 
            // btnVisualizarUsuarioSelecao
            // 
            this.btnVisualizarUsuarioSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizarUsuarioSelecao.Location = new System.Drawing.Point(579, 289);
            this.btnVisualizarUsuarioSelecao.Name = "btnVisualizarUsuarioSelecao";
            this.btnVisualizarUsuarioSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarUsuarioSelecao.TabIndex = 23;
            this.btnVisualizarUsuarioSelecao.Text = "Visualizar";
            this.btnVisualizarUsuarioSelecao.UseVisualStyleBackColor = true;
            this.btnVisualizarUsuarioSelecao.Click += new System.EventHandler(this.btnVisualizarUsuarioSelecao_Click_1);
            // 
            // lblRegistrosUsuarioSelecao
            // 
            this.lblRegistrosUsuarioSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistrosUsuarioSelecao.AutoSize = true;
            this.lblRegistrosUsuarioSelecao.Location = new System.Drawing.Point(20, 259);
            this.lblRegistrosUsuarioSelecao.Name = "lblRegistrosUsuarioSelecao";
            this.lblRegistrosUsuarioSelecao.Size = new System.Drawing.Size(57, 13);
            this.lblRegistrosUsuarioSelecao.TabIndex = 22;
            this.lblRegistrosUsuarioSelecao.Text = "Registros: ";
            // 
            // dgvRegistrosUsuarioSelecao
            // 
            this.dgvRegistrosUsuarioSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistrosUsuarioSelecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrosUsuarioSelecao.Location = new System.Drawing.Point(20, 75);
            this.dgvRegistrosUsuarioSelecao.MultiSelect = false;
            this.dgvRegistrosUsuarioSelecao.Name = "dgvRegistrosUsuarioSelecao";
            this.dgvRegistrosUsuarioSelecao.ReadOnly = true;
            this.dgvRegistrosUsuarioSelecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistrosUsuarioSelecao.Size = new System.Drawing.Size(634, 181);
            this.dgvRegistrosUsuarioSelecao.TabIndex = 21;
            // 
            // btnPesquisarUsuarioSelecao
            // 
            this.btnPesquisarUsuarioSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarUsuarioSelecao.Location = new System.Drawing.Point(579, 37);
            this.btnPesquisarUsuarioSelecao.Name = "btnPesquisarUsuarioSelecao";
            this.btnPesquisarUsuarioSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarUsuarioSelecao.TabIndex = 20;
            this.btnPesquisarUsuarioSelecao.Text = "Pesquisar";
            this.btnPesquisarUsuarioSelecao.UseVisualStyleBackColor = true;
            this.btnPesquisarUsuarioSelecao.Click += new System.EventHandler(this.btnPesquisarUsuarioSelecao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nome Usuario:";
            // 
            // txtNomeUsuarioSelecao
            // 
            this.txtNomeUsuarioSelecao.Location = new System.Drawing.Point(86, 40);
            this.txtNomeUsuarioSelecao.Name = "txtNomeUsuarioSelecao";
            this.txtNomeUsuarioSelecao.Size = new System.Drawing.Size(163, 20);
            this.txtNomeUsuarioSelecao.TabIndex = 36;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(23, 40);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(57, 20);
            this.txtIdUsuario.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id Usuário:";
            // 
            // txtEmailUsuarioSelecao
            // 
            this.txtEmailUsuarioSelecao.Location = new System.Drawing.Point(255, 40);
            this.txtEmailUsuarioSelecao.Name = "txtEmailUsuarioSelecao";
            this.txtEmailUsuarioSelecao.Size = new System.Drawing.Size(205, 20);
            this.txtEmailUsuarioSelecao.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Email:";
            // 
            // cb_TipoPlanoSelecao
            // 
            this.cb_TipoPlanoSelecao.FormattingEnabled = true;
            this.cb_TipoPlanoSelecao.Items.AddRange(new object[] {
            "Gratuito",
            "Individual",
            "Universitario",
            "Duo",
            "Familia"});
            this.cb_TipoPlanoSelecao.Location = new System.Drawing.Point(466, 39);
            this.cb_TipoPlanoSelecao.Name = "cb_TipoPlanoSelecao";
            this.cb_TipoPlanoSelecao.Size = new System.Drawing.Size(107, 21);
            this.cb_TipoPlanoSelecao.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tipo Plano:";
            // 
            // frmUsuarioSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 335);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_TipoPlanoSelecao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailUsuarioSelecao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeUsuarioSelecao);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionarUsuarioSelecao);
            this.Controls.Add(this.btnAlterarUsuarioSelecao);
            this.Controls.Add(this.btnExcluirUsuarioSelecao);
            this.Controls.Add(this.btnVisualizarUsuarioSelecao);
            this.Controls.Add(this.lblRegistrosUsuarioSelecao);
            this.Controls.Add(this.dgvRegistrosUsuarioSelecao);
            this.Controls.Add(this.btnPesquisarUsuarioSelecao);
            this.Name = "frmUsuarioSelecao";
            this.Text = "frmUsuarioSelecao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosUsuarioSelecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarUsuarioSelecao;
        private System.Windows.Forms.Button btnAlterarUsuarioSelecao;
        private System.Windows.Forms.Button btnExcluirUsuarioSelecao;
        private System.Windows.Forms.Button btnVisualizarUsuarioSelecao;
        private System.Windows.Forms.Label lblRegistrosUsuarioSelecao;
        private System.Windows.Forms.DataGridView dgvRegistrosUsuarioSelecao;
        private System.Windows.Forms.Button btnPesquisarUsuarioSelecao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeUsuarioSelecao;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailUsuarioSelecao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_TipoPlanoSelecao;
        private System.Windows.Forms.Label label4;
    }
}