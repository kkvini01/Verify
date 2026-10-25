using System;
using System.Windows.Forms;
using Verify.Controllers;
using Verify.Models;

namespace Verify.Views
{
    public partial class frmAlbum : Form
    {
        // Instancia os controllers utilizados nesta tela
        AlbumController albcontroller = new AlbumController();
        ArtistaController acontroller = new ArtistaController();

        // Variáveis utilizadas para controlar a ação da tela
        int acao;
        Album albumSelecionado;

        // Carrega os artistas no ComboBox
        private void CarregarArtistas()
        {
            cbIdArtistaAlbum.DataSource = acontroller.GetAll();
            cbIdArtistaAlbum.DisplayMember = "IdArtista";
            cbIdArtistaAlbum.ValueMember = "IdArtista";
            cbIdArtistaAlbum.SelectedIndex = -1;
        }

        // Verifica se os campos estão preenchidos
        private bool VerificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomeAlbum.Text))
            {
                MessageBox.Show("Preencha o nome do álbum.");
                txtNomeAlbum.Focus();
                return false;
            }

            if (cbIdArtistaAlbum.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um artista.");
                cbIdArtistaAlbum.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGravadora.Text))
            {
                MessageBox.Show("Preencha a gravadora.");
                txtGravadora.Focus();
                return false;
            }

            if (cb_TipoAlbum.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo do álbum.");
                cb_TipoAlbum.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroFaixas.Text))
            {
                MessageBox.Show("Preencha o número de faixas.");
                txtNumeroFaixas.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtCapaUrl.Text))
            {
                MessageBox.Show("Preencha a URL da capa do álbum.");
                txtCapaUrl.Focus();
                return false;
            }

            return true;
        }

        // Construtor da tela
        public frmAlbum(int acaoDaTela, Album album)
        {
            InitializeComponent();

            acao = acaoDaTela;
            albumSelecionado = album;

            CarregarArtistas();
            CarregarTela();
        }

        // Define o comportamento inicial da tela
        private void CarregarTela()
        {
            if (acao == 0)
            {
                this.Text = "Cadastrar Álbum";
                btnCadastrarAlbum.Text = "Cadastrar";
            }
            else
            {
                CarregarDados();

                if (acao == 1)
                {
                    this.Text = "Alterar Álbum";
                    btnCadastrarAlbum.Text = "Alterar";
                }
                else if (acao == 2)
                {
                    this.Text = "Visualizar Álbum";

                    btnCadastrarAlbum.Visible = false;
                }

                DesabilitarCampos();
            }
        }

        // Carrega os dados do álbum selecionado nos campos
        private void CarregarDados()
        {
            if (albumSelecionado == null)
            {
                return;
            }

            txtIdAlbum.Text = albumSelecionado.IdAlbum.ToString();

            if (albumSelecionado.IdArtista != null)
            {
                cbIdArtistaAlbum.SelectedValue =
                    albumSelecionado.IdArtista.IdArtista;
            }

            dtpDataLancamentoAlbum.Value =
                albumSelecionado.DataLancamentoAlbum;
            txtNomeAlbum.Text = albumSelecionado.NomeAlbum;
            txtGravadora.Text = albumSelecionado.Gravadora;
            txtCapaUrl.Text = albumSelecionado.CapaUrl;
            picBox_CapaUrl.ImageLocation = albumSelecionado.CapaUrl;
            picBox_CapaUrl.SizeMode = PictureBoxSizeMode.Zoom;
            dtp_DuracaoTotal.Text = albumSelecionado.DuracaoTotalAlbum.ToString();
            cb_TipoAlbum.Text = albumSelecionado.TipoAlbum;
            txtNumeroFaixas.Text = albumSelecionado.NumeroFaixas.ToString();
        }

        // Desabilita os campos conforme a ação selecionada
        private void DesabilitarCampos()
        {
            txtIdAlbum.Enabled = false;

            if (acao == 2)
            {
                cbIdArtistaAlbum.Enabled = false;
                dtpDataLancamentoAlbum.Enabled = false;
                txtGravadora.Enabled = false;
                picBox_CapaUrl.Enabled = false;
                dtp_DuracaoTotal.Enabled = false;
                cb_TipoAlbum.Enabled = false;
                txtNumeroFaixas.Enabled = false;
                txtCapaUrl.Enabled = false;
                txtNomeAlbum.Enabled = false;
            }
        }

        // Cadastra ou altera os dados do álbum

        void Salvar()
        {
            // Instanciar o objeto Album
            Album album = new Album();
            Artista artista = new Artista();

            // Mapear as informações
            album.IdArtista = artista;
            album.NomeAlbum = txtNomeAlbum.Text;
            artista.IdArtista = (int)cbIdArtistaAlbum.SelectedValue;
            album.DataLancamentoAlbum = dtpDataLancamentoAlbum.Value;
            album.Gravadora = txtGravadora.Text;
            album.CapaUrl = txtCapaUrl.Text;
            album.DuracaoTotalAlbum = dtp_DuracaoTotal.Value.ToString("HH:mm:ss");
            album.TipoAlbum = cb_TipoAlbum.Text;
            album.NumeroFaixas = int.Parse(txtNumeroFaixas.Text);

            // Executar a rotina de cadastro
            // Vamos armazenar o retorno
            int retorno = 0;

            // Verificar se é cadastro ou alteração
            if (acao == 0)
                retorno = albcontroller.Inserir(album);
            else
            {
                // Carregar o código do álbum no objeto
                album.IdAlbum = int.Parse(txtIdAlbum.Text);

                retorno = albcontroller.Alterar(album);
            }

            // Verificar o resultado
            if (retorno > 0)
            {
                MessageBox.Show("Álbum salvo com sucesso!");

                // Retornar para a tela anterior
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Falha ao salvar o álbum.");
            }
        }


        // Botão Cadastrar/Alterar
        private void btnCadastrarAlbum_Click_1(object sender, EventArgs e)
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