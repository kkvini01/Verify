using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verify.Controllers;
using Verify.Models;

namespace Verify.Views
{
    public partial class frmMusicaSelecao : Form
    {
        // Criar a instância com a camada de controle
        MusicaController controller = new MusicaController();

        public frmMusicaSelecao()
        {
            InitializeComponent();

            // Ao abrir a tela, apresentar todos os registros
            Pesquisar();
        }

        // Método para realizar a pesquisa
        void Pesquisar()
        {
            // Limpar a grade atual
            dgvRegistrosMusicaSelecao.DataSource = null;

            // Pesquisar por código
            if (!string.IsNullOrEmpty(
                txtIdMusicaSelecao.Text.Trim()))
            {
                // Consultar a música pelo ID
                Musica retorno = controller.GetById(int.Parse(txtIdMusicaSelecao.Text));
                // Instanciar a coleção de músicas
                MusicaCollection musicas = new MusicaCollection();

                // Adicionar o retorno caso tenha sido encontrado
                if (retorno != null)
                    musicas.Add(retorno);

                // Vincular a coleção à grade
                dgvRegistrosMusicaSelecao.DataSource = musicas;
            }
            // Pesquisar pelo título
            else if (!string.IsNullOrEmpty(
                txtTituloMusicaSelecao.Text.Trim()))
            {
                dgvRegistrosMusicaSelecao.DataSource =
                    controller.GetByTitulo(
                        txtTituloMusicaSelecao.Text.Trim());
            }
            else if (!string.IsNullOrEmpty(
                txtIdArtistaMusica.Text.Trim()))
            {
                dgvRegistrosMusicaSelecao.DataSource =
                    controller.GetByIdMusica(
                        int.Parse(txtIdMusicaSelecao.Text.Trim()));
            }
            // Pesquisar pelo ID do artista
            else if (!string.IsNullOrEmpty(
                txtIdArtistaMusica.Text.Trim()))
            {
                dgvRegistrosMusicaSelecao.DataSource =
                    controller.GetByIdArtista(
                        int.Parse(txtIdArtistaMusica.Text.Trim()));
            }
            // Pesquisar pelo compositor
            else if (!string.IsNullOrEmpty(
                txtCompositorMusicaSelecao.Text.Trim()))
            {
                dgvRegistrosMusicaSelecao.DataSource =
                    controller.GetByCompositor(
                        txtCompositorMusicaSelecao.Text.Trim());
            }
            // Caso nenhum filtro seja informado, retornar todas
            else
            {
                dgvRegistrosMusicaSelecao.DataSource =
                    controller.GetAll();
            }
        }

        // Recuperar a música selecionada na grade
        Musica RecuperarMusicaSelecionada()
        {
            // Validar se existe um registro selecionado
            if (dgvRegistrosMusicaSelecao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");

                return null;
            }
            else
            {
                // Converter o registro selecionado novamente em objeto
                return dgvRegistrosMusicaSelecao
                    .SelectedRows[0].DataBoundItem as Musica;
            }
        }

        // Método para excluir uma música
        void Excluir()
        {
            // Recuperar o registro selecionado
            Musica musica = RecuperarMusicaSelecionada();

            // Validar se a música foi selecionada
            if (musica != null)
            {
                // Confirmar a exclusão
                if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Excluir somente após a confirmação
                    if (controller.Excluir(musica.IdMusica) > 0)
                    {
                        MessageBox.Show(
                            "Registro excluído com sucesso.");

                        Pesquisar();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Não foi possível excluir o registro.");
                    }
                }
            }
        }

        private void btnVisualizarMusicaSelecao_Click_1(object sender, EventArgs e)
        {
            // Recuperar a música selecionada
            Musica musica = RecuperarMusicaSelecionada();

            if (musica != null)
            {
                // Abrir a tela de visualização
                frmMusica frm = new frmMusica(2, musica);

                frm.ShowDialog();
            }
        }

        private void btnAdicionarMusicaSelecao_Click_1(object sender, EventArgs e)
        {
            // Abrir a tela de cadastro
            frmMusica frm = new frmMusica(0, null);

            // Atualizar a grade se o cadastro for concluído
            if (frm.ShowDialog() == DialogResult.OK)
                Pesquisar();
        }

        private void btnAlterarMusicaSelecao_Click_1(object sender, EventArgs e)
        {
            // Recuperar a música selecionada
            Musica musica = RecuperarMusicaSelecionada();

            if (musica != null)
            {
                // Abrir a tela de alteração
                frmMusica frm = new frmMusica(1, musica);

                // Atualizar a grade se a alteração for concluída
                if (frm.ShowDialog() == DialogResult.OK)
                    Pesquisar();
            }
        }

        private void btnExcluirMusicaSelecao_Click_1(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnPesquisarMusicaSelecao_Click_1(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}