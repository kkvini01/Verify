using System;
using System.Windows.Forms;
using Verify.Controllers;
using Verify.Models;

namespace Verify.Views
{
    public partial class frmUsuarioSelecao : Form
    {
        //Importar as camadas de modelo e de controle
        //using Verify.Controllers;
        //using Verify.Models;

        //Criar e instanciar com a camada de controle
        UsuarioController controller = new UsuarioController();
        public frmUsuarioSelecao()
        {
            InitializeComponent();

            //Ao abrir a tela, já irá pesquisar
            //E apresentar todos os registros cadastrados
            Pesquisar();
        }

        //Criar o nosso método de pesquisa
        void Pesquisar()
        {
            //Primeiro é preciso limpar a grade atual
            dgvRegistrosUsuarioSelecao.DataSource = null;

            //Realizar as condicionais
            //Código, Nome, Email ou todos se vazio
            //Trim() remove espaços vazios
            if (!string.IsNullOrEmpty(txtIdUsuario.Text.Trim()))
            {
                //No caso do GetById retorna apenas um registro
                //Então o método retorna um objeto Usuario
                //Porém a grade espera uma fonte de dados do tipo lista
                //Neste caso temos o UsuarioCollection
                //Então temos que adicionar o retorno na lista de usuário
                //Vincular a lista na grade

                Usuario retorno = controller.GetById(int.Parse(txtIdUsuario.Text));
                UsuarioCollection usuarios = new UsuarioCollection();
                usuarios.Add(retorno);
                dgvRegistrosUsuarioSelecao.DataSource = usuarios;
            }
            else 
                if (!string.IsNullOrEmpty(txtNomeUsuarioSelecao.Text))
                    dgvRegistrosUsuarioSelecao.DataSource =
                        controller.GetByNomeUsuario(txtNomeUsuarioSelecao.Text);

                else 
                    if (!string.IsNullOrEmpty(txtEmailUsuarioSelecao.Text))
                        dgvRegistrosUsuarioSelecao.DataSource =
                            controller.GetByEmail(txtEmailUsuarioSelecao.Text);

                    else 
                        if (!string.IsNullOrEmpty(txtIdUsuario.Text))
                            dgvRegistrosUsuarioSelecao.DataSource =
                                controller.GetByIdUsuario(int.Parse(txtIdUsuario.Text));

                        else 
                            if (!string.IsNullOrEmpty(cb_TipoPlanoSelecao.Text))
                                dgvRegistrosUsuarioSelecao.DataSource =
                                    controller.GetByTipoPlano(cb_TipoPlanoSelecao.Text);

                            else
                                dgvRegistrosUsuarioSelecao.DataSource = controller.GetAll();
        }

        //Função para identificar o registro selecionado 
        //na grade e recuperar essa informação
        //transformando-o em objeto novamente
        //Essa rotina será necessária para as ações
        //Excluir, Alterar e Visualizar
        Usuario RecuperarUsuarioSelecionado()
        {
            //Validar se possui um registro selecionado
            if (dgvRegistrosUsuarioSelecao.SelectedRows.Count == 0)
            {
                //Notificar o usuário do sistema
                MessageBox.Show("Nenhum registro selecionado.");
                //Retorno nulo
                return null;
            }
            else
            {
                //retorno o registro selecionado
                //o convertendo de volta para objeto
                return
                    dgvRegistrosUsuarioSelecao.SelectedRows[0].
                        DataBoundItem as Usuario;
            }
        }

        //Método para realizar a exclusão do registro
        void Excluir()
        {
            //Recuperar o registro selecionado
            Usuario usuario = RecuperarUsuarioSelecionado();

            //Validar se o usuário selecionado é nulo
            if (usuario != null)
            {
                //Confirmar a exclusão com o usuário
                if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //Só excluímos com a confirmação
                    if (controller.Excluir(usuario.IdUsuario) > 0)
                    {
                        MessageBox.Show("Registro excluído com sucesso.");
                        Pesquisar();
                    }
                    else
                        MessageBox.Show("Não foi possível excluir o registro, ele está sendo utilizado.");
                }
            }
        }

        private void btnVisualizarUsuarioSelecao_Click_1(object sender, EventArgs e)
        {
            frmUsuario frm =
                new frmUsuario(2, RecuperarUsuarioSelecionado());
            frm.ShowDialog();
        }

        private void btnAlterarUsuarioSelecao_Click(object sender, EventArgs e)
        {
            //Abrir a tela de alteração
            frmUsuario frm =
                new frmUsuario(1, RecuperarUsuarioSelecionado());
            //Validar o retorno da tela de alteração
            //Se foi OK ou Cancel
            if (frm.ShowDialog() == DialogResult.OK)
                Pesquisar(); //Atualizar a grade com o novo cadastro
        }
        private void btnAdicionarUsuarioSelecao_Click(object sender, EventArgs e)
        {
            //Abrir a tela de cadastro
            frmUsuario frm = new frmUsuario(0, null);
            //Validar o retorno da tela de cadastro
            //Se foi OK ou Cancel
            if (frm.ShowDialog() == DialogResult.OK)
                Pesquisar(); //Atualizar a grade com o novo cadastro
        }

        private void btnPesquisarUsuarioSelecao_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnExcluirUsuarioSelecao_Click(object sender, EventArgs e)
        {
            Excluir();
        }

    }
}