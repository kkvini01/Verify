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
    public partial class frmPlaylist : Form
    {

        //Importar as camadas de modelo e de controle
        //using Verify.Controllers;
        //using Verify.Models;

        //Criar a instanciar com a camada de controle
        PlaylistController pcontroller = new PlaylistController();

        //Para reutilizar a tela para as rotinas de 
        //Alterar e Visualizar
        //Precisamos adicionar 2 parametros na chamada tela
        //um parametro para definir o tipo ação
        //0 = Cadastrar
        //1 = Alterar
        //2 = Visualizar
        //Receber no segundo parametro o objeto do cadastro
        //a ser carregado
        //Definir as variaveis para salvar as informações
        //do parametro
        int acao;
        Playlist playlistSelecionada;
        PlaylistMusicaController pmcontroller = new PlaylistMusicaController();

        UsuarioController ucontroller = new UsuarioController();
        void CarregarUsuarios()
        {
            cbIdUsuarioPlaylist.DataSource = ucontroller.GetAll();
            cbIdUsuarioPlaylist.DisplayMember = "IdUsuario";
            cbIdUsuarioPlaylist.ValueMember = "IdUsuario";
            cbIdUsuarioPlaylist.SelectedIndex = -1;
        }


        public frmPlaylist(int acaoDaTela, Playlist playlist)
        {
            InitializeComponent();

            //Carregar os parametros
            acao = acaoDaTela;
            playlistSelecionada = playlist;

            //Personalizar a tela de acordo com a acao
            CarregarUsuarios();
            CarregarTela();

        }

        void CarregarTela()
        {
            //Validar a ação nescessaria
            if (acao == 0)
                this.Text = "Cadastrar Playlist";
            else
            {
                //Mapeamento do objeto para tela
                CarregarDados();

                if (acao == 1)
                    this.Text = "Alterar Playlist";
                else
                {
                    this.Text = "Visualizar Playlist";
                    //Como a ideia é só visulizar
                    //Desabilitamos os campos
                    DesabilitarCampos();
                }
            }
        }

        void CarregarDados()
        {
            txtIdPlaylist.Text = playlistSelecionada.IdPlaylist.ToString();
            if (playlistSelecionada.IdUsuario != null)
                cbIdUsuarioPlaylist.SelectedValue = playlistSelecionada.IdUsuario.IdUsuario;
            txtNomePlaylist.Text = playlistSelecionada.NomePlaylist;
            txtDescricaoPlaylist.Text = playlistSelecionada.DescPlaylist;
            dtp_Criacao.Text = playlistSelecionada.CriacaoPlaylist.ToString();
            dtp_Atualizacao.Text = playlistSelecionada.AtualizacaoPlaylist.ToString();
            cbPrivacidade.Text = playlistSelecionada.Privacidade;
            txtQtdLikes.Text = playlistSelecionada.QtdLikes.ToString();
        }

        // Verifica se os campos estão preenchidos
        private bool VerificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomePlaylist.Text))
            {
                MessageBox.Show("Preencha o nome da playlist.");
                txtNomePlaylist.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescricaoPlaylist.Text))
            {
                MessageBox.Show("Preencha a descrição da playlist.");
                txtDescricaoPlaylist.Focus();
                return false;
            }

            if (cbPrivacidade.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a privacidade da playlist.");
                cbPrivacidade.Focus();
                return false;
            }

            if (cbIdUsuarioPlaylist.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um usuário.");
                cbIdUsuarioPlaylist.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQtdLikes.Text))
            {
                MessageBox.Show("Preencha a quantidade de likes.");
                txtQtdLikes.Focus();
                return false;
            }

            return true;
        }

        void DesabilitarCampos()
        {
            // Mudar pros nossos bgl
            //Transformar os campos de texto em somente leitura
            cbIdUsuarioPlaylist.Enabled = false;
            txtNomePlaylist.ReadOnly = true;
            txtDescricaoPlaylist.ReadOnly = true;
            dtp_Criacao.Enabled = false;
            dtp_Atualizacao.Enabled = false;
            cbPrivacidade.Enabled = false;
            txtQtdLikes.ReadOnly = true;

            //Ocultar os campos Cadastrar e Limpar
            btnCadastrarPlaylist.Visible = false;
        }

        void Salvar()
        {
            //Instanciar o objeto Playlist
            Playlist playlist = new Playlist();
            Usuario usuario = new Usuario();

            //Mapear as informações
            playlist.IdUsuario = usuario;
            usuario.IdUsuario = (int)cbIdUsuarioPlaylist.SelectedValue;
            playlist.NomePlaylist = txtNomePlaylist.Text;
            playlist.DescPlaylist = txtDescricaoPlaylist.Text;
            playlist.CriacaoPlaylist = dtp_Criacao.Value;
            playlist.AtualizacaoPlaylist = dtp_Atualizacao.Value;
            playlist.Privacidade = cbPrivacidade.Text;
            playlist.QtdLikes = int.Parse(txtQtdLikes.Text);

            //Executar a rotina de cadastro
            //na camada de controle
            //Ou seja, vamos chamar o método Inserir
            //e passar o objeto via parametro
            //E validar o retorno
            //0 = Falha na execução
            //1 = Cadastro realizado com sucesso

            //Vamos adicionar a opção de alterar
            //Então faremos ou o Inserir ou o Alterar
            //para isso vamos precisar armazenar o retorno
            int retorno = 0;

            if (acao == 0)
                retorno = pcontroller.Inserir(playlist);
            else
            {
                //Carregar o Codigo da playlist no objeto
                //Nescessario para aplicar o WHERE no UPDATE
                playlist.IdPlaylist = int.Parse(txtIdPlaylist.Text);

                retorno = pcontroller.Alterar(playlist);
            }

            if (retorno > 0)
            {
                MessageBox.Show("Playlist salva com sucesso!");

                //Retorna para a tela anterior (tela que chamou o cadastro)
                //Que deu tudo certo
                //Assim a tela que chamar o cadastro
                //Pode validar se deu tudo certo
                DialogResult = DialogResult.OK;
            }
            else
            {
                // Caso o retorno for 0 de falha
                // Notificar o usuario
                MessageBox.Show("Falha ao salvar a playlist.");

                // Aqui não definimos o retorno da tela
                // Pois o usuário pode tentar novamente
            }
        }

        private void btnCadastrarPlaylist_Click(object sender, EventArgs e)
        {

            if (!VerificarCampos())
            {
                return;
            }
            else
                if(dtp_Criacao.Value > dtp_Atualizacao.Value)
                {
                    MessageBox.Show("A data de criação não pode ser posterior à data de atualização.");
                }
                else
                    Salvar();
        }
    }
}
