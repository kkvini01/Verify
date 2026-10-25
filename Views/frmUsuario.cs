using System;
using System.Windows.Forms;
using Verify.Controllers;
using Verify.Models;

namespace Verify.Views
{
    public partial class frmUsuario : Form
    {
        // Importar as camadas de modelo e de controle
        // using Verify.Controllers;
        // using Verify.Models;

        // Criar e instanciar com a camada de controle
        UsuarioController ucontroller = new UsuarioController();

        // Para reutilizar a tela para as rotinas de Alterar e Visualizar
        // Precisamos adicionar 2 parâmetros na chamada tela
        // um parâmetro para definir o tipo ação
        // 0 = Cadastrar
        // 1 = Alterar
        // 2 = Visualizar
        // Receber no segundo parâmetro o objeto do cadastro a ser carregado
        // Definir as variáveis para salvar as informações do parâmetro
        int acao;
        Usuario usuarioSelecionado;

        public frmUsuario(int acaoDaTela, Usuario usuario)
        {
            InitializeComponent();

            // Carregar os parâmetros
            acao = acaoDaTela;
            usuarioSelecionado = usuario;

            // Personalizar a tela de acordo com a ação
            CarregarTela();
        }

        void CarregarTela()
        {
            // Validar a ação necessária
            if (acao == 0)
                this.Text = "Cadastrar Usuário";
            else
            {
                // Mapeamento do objeto para tela
                CarregarDados();

                if (acao == 1)
                    this.Text = "Alterar Usuário";
                else
                {
                    this.Text = "Visualizar Usuário";
                    // Como a ideia é só visualizar
                    // Desabilitamos os campos
                    DesabilitarCampos();
                }
            }
        }

        void CarregarDados()
        {
            txtIdUsuario.Text = usuarioSelecionado.IdUsuario.ToString();
            txtNomeCompletoUser.Text = usuarioSelecionado.NomeCompleto;
            txtNomeUsuario.Text = usuarioSelecionado.NomeUsuario;
            txtEmailUsuario.Text = usuarioSelecionado.EmailUsuario;
            txtSenhaUsuario.Text = usuarioSelecionado.SenhaUsuario;
            dtp_DataNascimentoUser.Text = usuarioSelecionado.DataNascUsuario.ToString();
            cb_TipoPlano.Text = usuarioSelecionado.TipoPlano;
        }

        void DesabilitarCampos()
        {
            // Transformar os campos de texto em somente leitura
            txtNomeCompletoUser.ReadOnly = true;
            txtNomeUsuario.ReadOnly = true;
            txtEmailUsuario.ReadOnly = true;
            txtSenhaUsuario.ReadOnly = true;
            dtp_DataNascimentoUser.Enabled = false;
            cb_TipoPlano.Enabled = false;

            // Ocultar os botões de Cadastrar e Limpar
            btnCadastroUsuario.Visible = false;
        }

        // Verifica se os campos estão preenchidos
        private bool VerificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomeCompletoUser.Text))
            {
                MessageBox.Show("Preencha o nome completo.");
                txtNomeCompletoUser.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text))
            {
                MessageBox.Show("Preencha o nome de usuário.");
                txtNomeUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmailUsuario.Text))
            {
                MessageBox.Show("Preencha o e-mail.");
                txtEmailUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSenhaUsuario.Text))
            {
                MessageBox.Show("Preencha a senha.");
                txtSenhaUsuario.Focus();
                return false;
            }

            if (cb_TipoPlano.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de plano.");
                cb_TipoPlano.Focus();
                return false;
            }

            return true;
        }

        void Salvar()
        {
            // Instanciar o objeto Usuario
            Usuario usuario = new Usuario();

            // Mapear as informações
            usuario.NomeCompleto = txtNomeCompletoUser.Text;
            usuario.NomeUsuario = txtNomeUsuario.Text;
            usuario.EmailUsuario = txtEmailUsuario.Text;
            usuario.SenhaUsuario = txtSenhaUsuario.Text;
            usuario.DataNascUsuario = DateTime.Parse(dtp_DataNascimentoUser.Text);
            usuario.TipoPlano = cb_TipoPlano.Text;

            int retorno = 0;

            if (acao == 0)
                retorno = ucontroller.Inserir(usuario);
            else
            {
                usuario.IdUsuario = int.Parse(txtIdUsuario.Text);
                retorno = ucontroller.Alterar(usuario);
            }

            if (retorno > 0)
            {
                MessageBox.Show("Usuário salvo com sucesso!");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Falha ao salvar o usuário.");
            }
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos())
            {
                return;
            }
            else
                Salvar();
        }
    }
}