
using System;
using System.Windows.Forms;
using Verify.Controllers;
using Verify.Models;

namespace Verify.Views
{
    public partial class frmAlbumSelecao : Form
    {
        // Instanciar a camada de controle
        AlbumController controller = new AlbumController();

        public frmAlbumSelecao()
        {
            InitializeComponent();

            // Ao abrir a tela, pesquisar todos os álbuns
            Pesquisar();
            OcultarColunas();
        }

        // Método para realizar a pesquisa
        void Pesquisar()
        {
            // Limpar a grade atual
            dgvRegistrosAlbumSelecao.DataSource = null;

            // Pesquisar pelo código do álbum
            if (!string.IsNullOrEmpty(txtIdAlbumSelecao.Text.Trim()))
            {
                AlbumCollection retorno = controller.GetByIdAlbum(
                    int.Parse(txtIdAlbumSelecao.Text)
                );

                dgvRegistrosAlbumSelecao.DataSource = retorno;
            }
            // Pesquisar pelo nome do álbum
            else if (!string.IsNullOrEmpty(txtNomeAlbumSelecao.Text.Trim()))
            {
                dgvRegistrosAlbumSelecao.DataSource =
                    controller.GetByNomeAlbum(txtNomeAlbumSelecao.Text);
            }
            // Pesquisar pelo ID do artista
            else if (!string.IsNullOrEmpty(txtIdArtistaAlbum.Text.Trim()))
            {   
                AlbumCollection retorno = controller.GetByIdArtistaAlbum(
                    int.Parse(txtIdArtistaAlbum.Text)
                );

                dgvRegistrosAlbumSelecao.DataSource = retorno;
            }
            // Pesquisar pelo tipo do álbum
            else if (!string.IsNullOrEmpty(txtTipoAlbumSelecao.Text.Trim()))
            {
                dgvRegistrosAlbumSelecao.DataSource =
                    controller.GetByTipoAlbum(txtTipoAlbumSelecao.Text);
            }
            // Caso nenhum filtro seja informado, buscar todos
            else
            {
                dgvRegistrosAlbumSelecao.DataSource = controller.GetAll();
            }

            // Configurar a grade
            dgvRegistrosAlbumSelecao.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvRegistrosAlbumSelecao.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvRegistrosAlbumSelecao.MultiSelect = false;
            dgvRegistrosAlbumSelecao.ReadOnly = true;
        }
        void OcultarColunas()
        {
            dgvRegistrosAlbumSelecao.Columns["IdArtista"].Visible = false;
        }

        // Recuperar o álbum selecionado
        Album RecuperarAlbumSelecionado()
        {
            if (dgvRegistrosAlbumSelecao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return null;
            }
            else
            {
                return dgvRegistrosAlbumSelecao.SelectedRows[0].DataBoundItem as Album;
            }
        }

        // Método para excluir o álbum
        void Excluir()
        {
            // Recuperar o álbum selecionado
            Album album = RecuperarAlbumSelecionado();

            if (album != null)
            {
                // Confirmar a exclusão
                if (MessageBox.Show(
                    "Deseja realmente excluir o álbum?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (controller.Excluir(album.IdAlbum) > 0)
                    {
                        MessageBox.Show("Álbum excluído com sucesso!");
                        Pesquisar();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o álbum.");
                    }
                }
            }
        }
        private void btnVisualizarAlbumSelecao_Click_1(object sender, EventArgs e)
        {
            // Recuperar o álbum selecionado
            Album album = RecuperarAlbumSelecionado();

            if (album != null)
            {
                // Abrir a tela de visualização
                frmAlbum frm = new frmAlbum(2, album);
                frm.ShowDialog();
            }
        }

        private void btnAdicionarAlbumSelecao_Click_1(object sender, EventArgs e)
        {
            // Abrir a tela de cadastro
            frmAlbum frm = new frmAlbum(0, null);

            // Atualizar a grade após o cadastro
            if (frm.ShowDialog() == DialogResult.OK)
                Pesquisar();
        }

        private void btnAlterarAlbumSelecao_Click_1(object sender, EventArgs e)
        {
            // Recuperar o álbum selecionado
            Album album = RecuperarAlbumSelecionado();

            if (album != null)
            {
                // Abrir a tela de alteração
                frmAlbum frm = new frmAlbum(1, album);

                // Atualizar a grade após a alteração
                if (frm.ShowDialog() == DialogResult.OK)
                    Pesquisar();
            }
        }

        private void btnExcluirAlbumSelecao_Click_1(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnPesquisarAlbumSelecao_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
