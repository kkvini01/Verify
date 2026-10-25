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
    public partial class frmMusica : Form
    {
        // Criar as instâncias com a camada de controle
        MusicaController mcontroller = new MusicaController();
        ArtistaController acontroller = new ArtistaController();
        AlbumController albcontroller = new AlbumController();

        // Para reutilizar a tela para cadastrar, alterar e visualizar
        // 0 = Cadastrar
        // 1 = Alterar
        // 2 = Visualizar
        int acao;
        Musica musicaSelecionada;

        void CarregarArtistas()
        {
            // Carregar os artistas no ComboBox
            cbIdArtistaMusica.DataSource = acontroller.GetAll();
            cbIdArtistaMusica.DisplayMember = "IdArtista";
            cbIdArtistaMusica.ValueMember = "IdArtista";
            cbIdArtistaMusica.SelectedIndex = -1;
        }

        void CarregarAlbuns()
        {
            // Carregar os álbuns no ComboBox
            albcontroller = new AlbumController();

            cbIdAlbumMusica.DataSource = albcontroller.GetAll();
            cbIdAlbumMusica.DisplayMember = "IdAlbum";
            cbIdAlbumMusica.ValueMember = "IdAlbum";
            cbIdAlbumMusica.SelectedIndex = -1;
        }

        // Verifica se os campos estão preenchidos
        private bool VerificarCampos()
        {
            if (cbIdAlbumMusica.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um álbum.");
                cbIdAlbumMusica.Focus();
                return false;
            }

            if (cbIdArtistaMusica.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um artista.");
                cbIdArtistaMusica.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTituloMusica.Text))
            {
                MessageBox.Show("Preencha o título da música.");
                txtTituloMusica.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNomeCompositor.Text))
            {
                MessageBox.Show("Preencha o compositor.");
                txtNomeCompositor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGeneroMusical.Text))
            {
                MessageBox.Show("Preencha o gênero musical.");
                txtGeneroMusical.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumReprod.Text))
            {
                MessageBox.Show("Preencha o número de reproduções.");
                txtNumReprod.Focus();
                return false;
            }

            return true;
        }

        public frmMusica(int acaoDaTela, Musica musica)
        {
            InitializeComponent();

            // Carregar os parâmetros
            acao = acaoDaTela;
            musicaSelecionada = musica;

            // Carregar os dados dos ComboBoxes
            CarregarArtistas();
            CarregarAlbuns();

            // Personalizar a tela de acordo com a ação
            CarregarTela();
        }

        void CarregarTela()
        {
            // Validar a ação necessária
            if (acao == 0)
                this.Text = "Cadastrar Música";
            else
            {
                // Mapear o objeto para a tela
                CarregarDados();

                if (acao == 1)
                    this.Text = "Alterar Música";
                else
                {
                    this.Text = "Visualizar Música";

                    // Como a ideia é só visualizar,
                    // desabilitamos os campos
                    DesabilitarCampos();
                }
            }
        }

        void CarregarDados()
        {
            txtIdMusica.Text =
                musicaSelecionada.IdMusica.ToString();

            txtTituloMusica.Text =
                musicaSelecionada.TituloMusica;

            txtDuracaoSegundos.Text =
                musicaSelecionada.DuracaoSegundos.ToString();

            dtpDataLancamentoMusica.Value =
                musicaSelecionada.DataLancamentoMusica;

            txtGeneroMusical.Text =
                musicaSelecionada.GeneroMusical;

            txtNomeCompositor.Text =
                musicaSelecionada.NomeCompositor;

            txtNumReprod.Text =
                musicaSelecionada.NumReprod.ToString();

            // Selecionar o artista relacionado
            if (musicaSelecionada.IdArtista != null)
                cbIdArtistaMusica.SelectedValue =
                    musicaSelecionada.IdArtista.IdArtista;

            // Selecionar o álbum relacionado
            if (musicaSelecionada.IdAlbum != null)
                cbIdAlbumMusica.SelectedValue =
                    musicaSelecionada.IdAlbum.IdAlbum;
        }

        void DesabilitarCampos()
        {
            // Transformar os campos em somente leitura
            txtTituloMusica.ReadOnly = true;
            txtDuracaoSegundos.Enabled = false;
            txtGeneroMusical.ReadOnly = true;
            txtNomeCompositor.ReadOnly = true;
            txtNumReprod.ReadOnly = true;

            dtpDataLancamentoMusica.Enabled = false;
            cbIdArtistaMusica.Enabled = false;
            cbIdAlbumMusica.Enabled = false;

            // Ocultar os botões Cadastrar e Limpar
            btnCadastrarMusica.Visible = false;
        }

        void Salvar()
        {
            // Instanciar o objeto Musica
            Musica musica = new Musica();

            // Instanciar os objetos relacionados
            Artista artista = new Artista();
            Album album = new Album();

            // Mapear as informações
            artista.IdArtista =
                (int)cbIdArtistaMusica.SelectedValue;

            album.IdAlbum =
                (int)cbIdAlbumMusica.SelectedValue;

            musica.IdArtista = artista;
            musica.IdAlbum = album;

            musica.TituloMusica = txtTituloMusica.Text;
            musica.DuracaoSegundos = txtDuracaoSegundos.Value.ToString("HH:mm:ss");

            musica.DataLancamentoMusica =
                dtpDataLancamentoMusica.Value;

            musica.GeneroMusical = txtGeneroMusical.Text;
            musica.NomeCompositor = txtNomeCompositor.Text;
            musica.NumReprod = int.Parse(txtNumReprod.Text);

            // Armazenar o retorno da operação
            int retorno = 0;

            if (acao == 0)
                retorno = mcontroller.Inserir(musica);
            else
            {
                // Carregar o código da música para o UPDATE
                musica.IdMusica = int.Parse(txtIdMusica.Text);

                retorno = mcontroller.Alterar(musica);
            }

            if (retorno > 0)
            {
                MessageBox.Show("Música salva com sucesso!");

                // Retornar para a tela que chamou o cadastro
                DialogResult = DialogResult.OK;
            }
            else
            {
                // Notificar o usuário
                MessageBox.Show("Falha ao salvar a música.");
            }
        }
        private void btnCadastrarMusica_Click_1(object sender, EventArgs e)
        {
            if (!VerificarCampos())
            {
                return;
            }
            else
            {
                Salvar();
            }
        }
    }
}