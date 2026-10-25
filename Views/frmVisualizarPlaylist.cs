
using System;
using System.Windows.Forms;
using Verify.Controllers;
using Verify.Models;

namespace Verify.Views
{
    public partial class frmVisualizarPlaylist : Form
    {
        PlaylistMusicaController pmController =
            new PlaylistMusicaController();

        PlaylistController playlistController =
            new PlaylistController();

        public frmVisualizarPlaylist()
        {
            InitializeComponent();

            // Impedir que o usuário altere o nome manualmente
            txtNomePlaylistVisualizar.ReadOnly = true;

            CarregarPlaylists();
        }

        // Carregar os IDs das playlists no ComboBox
        private void CarregarPlaylists()
        {
            cbIdPlaylistVisualizar.DataSource =
                playlistController.GetAll();

            cbIdPlaylistVisualizar.DisplayMember =
                "IdPlaylist";

            cbIdPlaylistVisualizar.ValueMember =
                "IdPlaylist";

            cbIdPlaylistVisualizar.SelectedIndex = -1;

            txtNomePlaylistVisualizar.Clear();
            lsbMusicas.Items.Clear();
        }

        // Selecionar uma playlist e mostrar suas músicas
        private void cbIdPlaylistVisualizar_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            Playlist playlist =
                cbIdPlaylistVisualizar.SelectedItem as Playlist;

            lsbMusicas.Items.Clear();

            if (playlist == null)
            {
                txtNomePlaylistVisualizar.Clear();
                return;
            }

            txtNomePlaylistVisualizar.Text =
                playlist.NomePlaylist;

            MusicaCollection musicas =
                pmController.GetMusicasDaPlaylist(
                    playlist.IdPlaylist);

            foreach (Musica musica in musicas)
            {
                lsbMusicas.Items.Add(
                    musica.IdMusica + " - " +
                    musica.TituloMusica);
            }
        }

        private void txtNomePlaylistVisualizar_TextChanged(
            object sender, EventArgs e)
        {
        }

        private void lsbMusicasInserida_SelectedIndexChanged(
            object sender, EventArgs e)
        {
        }
    }
}
