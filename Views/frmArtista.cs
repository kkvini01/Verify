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
    public partial class frmArtista : Form
    {
        // Criar a instância com a camada de controle
        ArtistaController acontroller = new ArtistaController();

        // Para reutilizar a tela para cadastrar, alterar e visualizar
        // 0 = Cadastrar
        // 1 = Alterar
        // 2 = Visualizar
        int acao;
        Artista artistaSelecionado;

        public frmArtista(int acaoDaTela, Artista artista)
        {
            InitializeComponent();

            // Carregar os parâmetros
            acao = acaoDaTela;
            artistaSelecionado = artista;

            // Personalizar a tela de acordo com a ação
            CarregarTela();
        }

        void CarregarTela()
        {
            // Validar a ação necessária
            if (acao == 0)
                this.Text = "Cadastrar Artista";
            else
            {
                // Mapear o objeto para a tela
                CarregarDados();

                if (acao == 1)
                    this.Text = "Alterar Artista";
                else
                {
                    this.Text = "Visualizar Artista";

                    // Como a ideia é só visualizar,
                    // desabilitamos os campos
                    DesabilitarCampos();
                }
            }
        }

        void CarregarDados()
        {
            txtIdArtista.Text = artistaSelecionado.IdArtista.ToString();
            txtNomeArtistico.Text = artistaSelecionado.NomeArtistico;
            txtNomeReal.Text = artistaSelecionado.NomeReal;
            txtBiografia.Text = artistaSelecionado.Biografia;
            txtGeneroMusicalPrincipal.Text =
                artistaSelecionado.GeneroMusicalPrincipal;
            dtpDataNascimento.Value = artistaSelecionado.DataNascimento;
            dtpDataInicioCarreira.Value =
                artistaSelecionado.DataInicioCarreira;
        }

        // Verifica se os campos estão preenchidos
        private bool VerificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomeReal.Text))
            {
                MessageBox.Show("Preencha o nome real.");
                txtNomeReal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNomeArtistico.Text))
            {
                MessageBox.Show("Preencha o nome artístico.");
                txtNomeArtistico.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBiografia.Text))
            {
                MessageBox.Show("Preencha a biografia.");
                txtBiografia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGeneroMusicalPrincipal.Text))
            {
                MessageBox.Show("Preencha o gênero musical principal.");
                txtGeneroMusicalPrincipal.Focus();
                return false;
            }

            return true;
        }

        void DesabilitarCampos()
        {
            // Transformar os campos em somente leitura
            txtNomeArtistico.ReadOnly = true;
            txtNomeReal.ReadOnly = true;
            txtBiografia.ReadOnly = true;
            txtGeneroMusicalPrincipal.ReadOnly = true;

            dtpDataNascimento.Enabled = false;
            dtpDataInicioCarreira.Enabled = false;

            // Ocultar os botões Cadastrar e Limpar
            btnCadastrarArtista.Visible = false;
        }

        void Salvar()
        {
            // Instanciar o objeto Artista
            Artista artista = new Artista();

            // Mapear as informações
            artista.NomeArtistico = txtNomeArtistico.Text;
            artista.NomeReal = txtNomeReal.Text;
            artista.Biografia = txtBiografia.Text;
            artista.GeneroMusicalPrincipal =
                txtGeneroMusicalPrincipal.Text;
            artista.DataNascimento = dtpDataNascimento.Value;
            artista.DataInicioCarreira = dtpDataInicioCarreira.Value;

            // Armazenar o retorno da operação
            int retorno = 0;

            if (acao == 0)
                retorno = acontroller.Inserir(artista);
            else
            {
                // Carregar o código do artista para o UPDATE
                artista.IdArtista = int.Parse(txtIdArtista.Text);

                retorno = acontroller.Alterar(artista);
            }

            if (retorno > 0)
            {
                MessageBox.Show("Artista salvo com sucesso!");

                // Retornar para a tela que chamou o cadastro
                DialogResult = DialogResult.OK;
            }
            else
            {
                // Notificar o usuário
                MessageBox.Show("Falha ao salvar o artista.");
            }
        }
        private void btnCadastrarArtista_Click_1(object sender, EventArgs e)
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