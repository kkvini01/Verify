
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Verify.Controllers;
using Verify.Models;

namespace Verify.Views
{
    public partial class frmInserirMusicas : Form
    {
        PlaylistController playlistController =
            new PlaylistController();

        MusicaController musicaController =
            new MusicaController();

        PlaylistMusicaController pmController =
            new PlaylistMusicaController();

        // Guardar as músicas antes de cadastrar
        List<PlaylistMusica> musicasPendentes =
            new List<PlaylistMusica>();

        public frmInserirMusicas()
        {
            InitializeComponent();

            txtNomePlaylistInserir.ReadOnly = true;
            txtNomeMusicaInserir.ReadOnly = true;

            CarregarPlaylists();
            CarregarMusicas();
        }

        // Carregar IDs das playlists
        private void CarregarPlaylists()
        {
            cbIdPlaylistInserir.DataSource =
                playlistController.GetAll();

            cbIdPlaylistInserir.DisplayMember = "IdPlaylist";
            cbIdPlaylistInserir.ValueMember = "IdPlaylist";
            cbIdPlaylistInserir.SelectedIndex = -1;

            txtNomePlaylistInserir.Clear();
        }

        // Carregar IDs das músicas
        private void CarregarMusicas()
        {
            cbIdMusicasInserir.DataSource =
                musicaController.GetAll();

            cbIdMusicasInserir.DisplayMember = "IdMusica";
            cbIdMusicasInserir.ValueMember = "IdMusica";
            cbIdMusicasInserir.SelectedIndex = -1;

            txtNomeMusicaInserir.Clear();
        }

        // Mostrar nome da playlist selecionada
        private void cbIdPlaylistInserir_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            Playlist playlist =
                cbIdPlaylistInserir.SelectedItem as Playlist;

            if (playlist != null)
                txtNomePlaylistInserir.Text =
                    playlist.NomePlaylist;
            else
                txtNomePlaylistInserir.Clear();
        }

        // Mostrar nome da música selecionada
        private void cbIdMusicasInserir_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            Musica musica =
                cbIdMusicasInserir.SelectedItem as Musica;

            if (musica != null)
                txtNomeMusicaInserir.Text =
                    musica.TituloMusica;
            else
                txtNomeMusicaInserir.Clear();
        }

        // Adicionar música à lista temporária
        private void btnInserirMusica_Click(
            object sender, EventArgs e)
        {
            Playlist playlist =
                cbIdPlaylistInserir.SelectedItem as Playlist;

            Musica musica =
                cbIdMusicasInserir.SelectedItem as Musica;

            if (playlist == null)
            {
                MessageBox.Show("Selecione uma playlist.");
                return;
            }

            if (musica == null)
            {
                MessageBox.Show("Selecione uma música.");
                return;
            }

            // Manter todas as músicas na mesma playlist
            if (musicasPendentes.Count > 0 &&
                musicasPendentes[0].IdPlaylist.IdPlaylist
                != playlist.IdPlaylist)
            {
                MessageBox.Show(
                    "Finalize o cadastro desta playlist antes " +
                    "de selecionar outra.");

                return;
            }

            // Verificar se já foi adicionada à lista
            foreach (PlaylistMusica item in musicasPendentes)
            {
                if (item.IdMusica.IdMusica == musica.IdMusica)
                {
                    MessageBox.Show(
                        "Essa música já está na lista.");
                    return;
                }
            }

            PlaylistMusica relacao = new PlaylistMusica();

            relacao.IdPlaylist = playlist;
            relacao.IdMusica = musica;

            musicasPendentes.Add(relacao);

            lsbMusicasInseridas.Items.Add(
                musica.IdMusica + " - " + musica.TituloMusica);
        }

        // Gravar as músicas no banco
        private void btnCadastrarMusicaInserir_Click(
            object sender, EventArgs e)
        {
            if (musicasPendentes.Count == 0)
            {
                MessageBox.Show(
                    "Adicione pelo menos uma música antes de cadastrar.");

                return;
            }

            try
            {
                int cadastradas = 0;
                int existentes = 0;

                foreach (PlaylistMusica relacao in musicasPendentes)
                {
                    PlaylistMusica existente =
                        pmController.GetById(
                            relacao.IdPlaylist.IdPlaylist,
                            relacao.IdMusica.IdMusica);

                    if (existente == null)
                    {
                        pmController.Inserir(relacao);
                        cadastradas++;
                    }
                    else
                    {
                        existentes++;
                    }
                }

                MessageBox.Show(
                    "Cadastro finalizado!\n" +
                    "Músicas inseridas: " + cadastradas + "\n" +
                    "Já existentes na playlist: " + existentes);

                musicasPendentes.Clear();
                lsbMusicasInseridas.Items.Clear();

                cbIdMusicasInserir.SelectedIndex = -1;
                txtNomeMusicaInserir.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao cadastrar músicas: " + ex.Message);
            }
        }

        private void txtNomePlaylistInserir_TextChanged(
            object sender, EventArgs e)
        {
        }

        private void txtNomeMusicaInserir_TextChanged(
            object sender, EventArgs e)
        {
        }

        private void lsbMusicasInseridas_SelectedIndexChanged(
            object sender, EventArgs e)
        {
        }
    }
}
