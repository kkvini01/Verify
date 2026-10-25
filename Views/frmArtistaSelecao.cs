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
    public partial class frmArtistaSelecao : Form
    {
        // Criar a instância com a camada de controle
        ArtistaController controller = new ArtistaController();

        public frmArtistaSelecao()
        {
            InitializeComponent();

            // Ao abrir a tela, apresentar todos os registros
            Pesquisar();
        }

        // Método para realizar a pesquisa
        void Pesquisar()
        {
            // Limpar a grade atual
            dgvRegistrosArtistaSelecao.DataSource = null;

            // Pesquisar por código
            if (!string.IsNullOrEmpty(txtIdArtistaSelecao.Text.Trim()))
            {
                // Consultar o artista pelo ID
                Artista retorno =
                    controller.GetById(
                        int.Parse(txtIdArtistaSelecao.Text));

                // Instanciar a coleção de artistas
                ArtistaCollection artistas = new ArtistaCollection();

                // Adicionar o retorno caso tenha sido encontrado
                if (retorno != null)
                    artistas.Add(retorno);

                // Vincular a coleção à grade
                dgvRegistrosArtistaSelecao.DataSource = artistas;
            }
            // Pesquisar pelo nome artístico
            else if (!string.IsNullOrEmpty(
                txtNomeArtisticoSelecao.Text.Trim()))
            {
                dgvRegistrosArtistaSelecao.DataSource =
                    controller.GetByName(
                        txtNomeArtisticoSelecao.Text.Trim());
            }
            // Pesquisar pelo nome real
            else if (!string.IsNullOrEmpty(
                txtNomeRealSelecao.Text.Trim()))
            {
                dgvRegistrosArtistaSelecao.DataSource =
                    controller.GetByRealName(
                        txtNomeRealSelecao.Text.Trim());
            }
            // Pesquisar pelo gênero musical principal
            else if (!string.IsNullOrEmpty(
                txtGeneroPrincipalSelecao.Text.Trim()))
            {
                dgvRegistrosArtistaSelecao.DataSource =
                    controller.GetByGenre(
                        txtGeneroPrincipalSelecao.Text.Trim());
            }
            // Caso nenhum filtro seja informado, retornar todos
            else
            {
                dgvRegistrosArtistaSelecao.DataSource =
                    controller.GetAll();
            }
        }

        // Recuperar o artista selecionado na grade
        Artista RecuperarArtistaSelecionado()
        {
            // Validar se existe um registro selecionado
            if (dgvRegistrosArtistaSelecao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");

                return null;
            }
            else
            {
                // Converter o registro selecionado novamente em objeto
                return dgvRegistrosArtistaSelecao
                    .SelectedRows[0].DataBoundItem as Artista;
            }
        }

        // Método para excluir um artista
        void Excluir()
        {
            // Recuperar o registro selecionado
            Artista artista = RecuperarArtistaSelecionado();

            // Validar se o artista foi selecionado
            if (artista != null)
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
                    if (controller.Excluir(artista.IdArtista) > 0)
                    {
                        MessageBox.Show(
                            "Registro excluído com sucesso.");

                        Pesquisar();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Não foi possível excluir o registro, ele está sendo utilizado.");
                    }
                }
            }
        }

        private void btnPesquisarArtistaSelecao_Click(
            object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnVisualizarArtistaSelecao_Click_1(object sender, EventArgs e)
        {
            // Recuperar o artista selecionado
            Artista artista = RecuperarArtistaSelecionado();

            if (artista != null)
            {
                // Abrir a tela de alteração
                frmArtista frm = new frmArtista(2, artista);

                // Atualizar a grade se a alteração for concluída
                if (frm.ShowDialog() == DialogResult.OK)
                    Pesquisar();
            }
        }

        private void btnAdicionarArtistaSelecao_Click_1(object sender, EventArgs e)
        {
            // Abrir a tela de cadastro
            frmArtista frm = new frmArtista(0, null);

            // Atualizar a grade se o cadastro for concluído
            if (frm.ShowDialog() == DialogResult.OK)
                Pesquisar();
        }

        private void btnAlterarArtistaSelecao_Click_1(object sender, EventArgs e)
        {
            // Recuperar o artista selecionado
            Artista artista = RecuperarArtistaSelecionado();

            if (artista != null)
            {
                // Abrir a tela de alteração
                frmArtista frm = new frmArtista(1, artista);

                // Atualizar a grade se a alteração for concluída
                if (frm.ShowDialog() == DialogResult.OK)
                    Pesquisar();
            }
        }

        private void btnExcluirArtistaSelecao_Click_1(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnPesquisarArtistaSelecao_Click_1(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}