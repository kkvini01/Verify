using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verify.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlaylistSelecao frm = new frmPlaylistSelecao();
            frm.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioSelecao frm = new frmUsuarioSelecao();
            frm.ShowDialog();
        }

        private void artistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtistaSelecao frm = new frmArtistaSelecao();
            frm.ShowDialog();

        }

        private void musicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusicaSelecao frm = new frmMusicaSelecao();
            frm.ShowDialog();

        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlbumSelecao frm = new frmAlbumSelecao();
            frm.ShowDialog();

        }

        private void inserirMúsicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInserirMusicas frm = new frmInserirMusicas();
            frm.ShowDialog();
        }

        private void visualizarPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizarPlaylist frm = new frmVisualizarPlaylist();
            frm.ShowDialog();
        }
    }
}
