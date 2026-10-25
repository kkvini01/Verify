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
    public partial class frmPlaylistSelecao : Form
    {
        //Importar as camadas de modelo e de controle
        //using NomeProjeto.Controllers;
        //using NomeProjeto.Models;

        //Criar a instanciar com a camada de controle
        PlaylistController controller = new PlaylistController();
        public frmPlaylistSelecao()
        {
            InitializeComponent();

            //Ao abrir a tela, ja ira pesquisar
            //A apresentar todos os registros cadastrados
            Pesquisar();
        }

        //Criar o nosso método de pesquisa
        void Pesquisar()
        {
            //Primeiro é preciso limpar a grade atual
            dgvRegistrosPlaylistSelecao.DataSource = null;

            //Realizar as condicionais
            //Codigo, Nome, Email ou todos se vazio
            //Trim() remove espaços vazios
            if (!string.IsNullOrEmpty(txtIdPlaylist.Text.Trim()))
            {
                //No caso do GetById retorna apenas um registro
                //Então o método retorno um objeto Usuario
                //Porém a grade esperar uma fonte de dados
                //do tipo lista
                //Neste caso temos o Usuario collection
                //Então temos que adicionar o retorno na lista de usuario
                //Vincular a lista na grade

                //Salvo o Usuario retornado na consulta
                Playlist retorno = controller.GetById(int.Parse(txtIdPlaylist.Text));
                //Instancia a lista de usuarios
                PlaylistCollection playlists = new PlaylistCollection();
                //Adicionar o retorno a lista
                playlists.Add(retorno);
                //Vinculo a lista a grade
                dgvRegistrosPlaylistSelecao.DataSource = playlists;
            }
            else
                if (!string.IsNullOrEmpty(txtNomePlaylistSelecao.Text))
                    dgvRegistrosPlaylistSelecao.DataSource =
                        controller.GetByNome(txtNomePlaylistSelecao.Text);
                else
                    if (!string.IsNullOrEmpty(txtIdUsuarioPlaylist.Text))
                        dgvRegistrosPlaylistSelecao.DataSource =
                            controller.GetByIdUsuario(int.Parse(txtIdUsuarioPlaylist.Text));
                    else
                       if (!string.IsNullOrEmpty(txtIdPlaylist.Text))
                            dgvRegistrosPlaylistSelecao.DataSource =
                                controller.GetById(int.Parse(txtIdPlaylist.Text));
                       else
                            dgvRegistrosPlaylistSelecao.DataSource = controller.GetAll();
        }

        //Função para identificar o registro selecionado 
        //na grade e recuperar essa informação
        //transformando-o em objeto novamente
        //Essa rotina sera nescessaria para as ações
        //Excluir, Alterar e Visualizar
        Playlist RecuperarPlaylistSelecionada()
        {
            //Validar se possui um registro selecionado
            if (dgvRegistrosPlaylistSelecao.SelectedRows.Count == 0)
            {
                //Notificar o usuario do sistema
                MessageBox.Show("Nenhum registro selecionado.");
                //Retorno nullo
                return null;
            }
            else
            {
                //retorno o registro selecionado
                //o convertendo de volta para objeto
                return
                    dgvRegistrosPlaylistSelecao.SelectedRows[0].
                        DataBoundItem as Playlist;
            }
        }

        //Método para realizar a exclusão do registro
        void Excluir()
        {
            //Recuperar o registro selecionado
            Playlist playlist = RecuperarPlaylistSelecionada();

            //Validar se o usuario selecionado é nullo
            if (playlist != null)
            {
                //Confirmar a exclusão com o usuario
                if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //Só excluimos com a confirmação
                    if (controller.Excluir(playlist.IdPlaylist) > 0)
                    {
                        MessageBox.Show("Registro excluito com sucesso.");
                        Pesquisar();
                    }
                    else
                        MessageBox.Show("Não foi possível excluir o registro.");
                }
            }
        }

        private void btnAdicionarPlaylistSelecao_Click(object sender, EventArgs e)
        {
            //Abrir a tela de cadastro
            frmPlaylist frm = new frmPlaylist(0, null);
            //Validar o retorno da tela de cadastro
            //Se foi OK ou Cancel
            if (frm.ShowDialog() == DialogResult.OK)
                Pesquisar(); //Atualizar a grade com o novo cadastro
        }

        private void btnVisualizarPlaylistSelecao_Click(object sender, EventArgs e)
        {
            //Abrir a tela de visualização
            frmPlaylist frm =
                new frmPlaylist(2, RecuperarPlaylistSelecionada());
            frm.ShowDialog();
        }

        private void btnAlterarPlaylistSelecao_Click(object sender, EventArgs e)
        {
            //Abrir a tela de alteração
            frmPlaylist frm =
                new frmPlaylist(1, RecuperarPlaylistSelecionada());
            //Validar o retorno da tela de alteraçao
            //Se foi OK ou Cancel
            if (frm.ShowDialog() == DialogResult.OK)
                Pesquisar(); //Atualizar a grade com o novo cadastro
        }

        private void btnExcluirPlaylistSelecao_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnPesquisarPlaylistSelecao_Click_1(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
