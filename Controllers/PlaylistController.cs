using Verify.Models;
using Verify.Services;
using System.Data;
using System.Data.SqlClient;
using System;

namespace Verify.Controllers
{
    public class PlaylistController
    {
        DataBaseService dataBase = new DataBaseService();

        // Função pública para inserir uma playlist
        public int Inserir(Playlist playlist)
        {
            // Criar o comando SQL que será executado
            string query =
                "INSERT INTO playlist (id_usuario, nome_playlist, descricao, dat_criacao, dat_atualizacao, publica, qtd_likes) " +
                "VALUES (@id_usuario, @nome_playlist, @descricao, @dat_criacao, @dat_atualizacao, @publica, @qtd_likes)";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Converter a privacidade para inteiro
            int publica = 0;

            if (playlist.Privacidade == "Público")
                publica = 1;

            // Definir os valores dos parâmetros
            command.Parameters.AddWithValue("@id_usuario", playlist.IdUsuario.IdUsuario);
            command.Parameters.AddWithValue("@nome_playlist", playlist.NomePlaylist);
            command.Parameters.AddWithValue("@descricao", playlist.DescPlaylist);
            command.Parameters.AddWithValue("@dat_criacao", playlist.CriacaoPlaylist);
            command.Parameters.AddWithValue("@dat_atualizacao", playlist.AtualizacaoPlaylist);
            command.Parameters.AddWithValue("@publica", publica);
            command.Parameters.AddWithValue("@qtd_likes", playlist.QtdLikes);

            // Executar o comando e retornar a quantidade de linhas afetadas
            return dataBase.ExecuteSql(command);
        }

        // Função pública para atualizar uma playlist
        public int Alterar(Playlist playlist)
        {
            // Criar o comando SQL para o UPDATE
            string query =
                "UPDATE playlist SET " +
                "id_usuario = @id_usuario, " +
                "nome_playlist = @nome_playlist, " +
                "descricao = @descricao, " +
                "dat_criacao = @dat_criacao, " +
                "dat_atualizacao = @dat_atualizacao, " +
                "publica = @publica, " +
                "qtd_likes = @qtd_likes " +
                "WHERE id_playlist = @id_playlist";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Converter a privacidade para inteiro
            int publica = 0;

            if (playlist.Privacidade == "Público")
                publica = 1;

            // Definir os parâmetros
            command.Parameters.AddWithValue("@id_usuario", playlist.IdUsuario.IdUsuario);
            command.Parameters.AddWithValue("@nome_playlist", playlist.NomePlaylist);
            command.Parameters.AddWithValue("@descricao", playlist.DescPlaylist);
            command.Parameters.AddWithValue("@dat_criacao", playlist.CriacaoPlaylist);
            command.Parameters.AddWithValue("@dat_atualizacao", playlist.AtualizacaoPlaylist);
            command.Parameters.AddWithValue("@publica", publica);
            command.Parameters.AddWithValue("@qtd_likes", playlist.QtdLikes);
            command.Parameters.AddWithValue("@id_playlist", playlist.IdPlaylist);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para excluir uma playlist

        public int Excluir(int id)
        {
            // Verificar se a playlist possui músicas vinculadas
            string queryVerificar =
                "SELECT COUNT(*) FROM PLAYLIST_MUSICA " +
                "WHERE ID_PLAYLIST = @id_playlist";

            SqlCommand commandVerificar = new SqlCommand(queryVerificar);

            commandVerificar.Parameters.AddWithValue("@id_playlist", id);

            DataTable dataTable = dataBase.GetDataTable(commandVerificar);

            // Se possuir músicas, não permitir a exclusão
            if ((int)dataTable.Rows[0][0] > 0)
            {
                return -1;
            }

            // Criar o comando SQL para excluir a playlist
            string query =
                "DELETE FROM playlist " +
                "WHERE id_playlist = @id_playlist";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@id_playlist", id);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }


        // Função pública para consultar uma playlist por ID
        public Playlist GetById(int id)
        {
            // Criar o comando SELECT
            string query =
                "SELECT * FROM playlist " +
                "WHERE id_playlist = @id_playlist";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@id_playlist", id);

            // Recuperar os dados retornados
            DataTable dataTable = dataBase.GetDataTable(command);

            // Verificar se algum registro foi encontrado
            if (dataTable.Rows.Count > 0)
            {
                // Instanciar o objeto Playlist
                Playlist playlist = new Playlist();

                // Mapear os dados do SQL para o objeto
                playlist.IdPlaylist = (int)dataTable.Rows[0]["id_playlist"];

                playlist.IdUsuario = new Usuario();
                playlist.IdUsuario.IdUsuario = (int)dataTable.Rows[0]["id_usuario"];

                playlist.NomePlaylist = (string)dataTable.Rows[0]["nome_playlist"];
                playlist.DescPlaylist = (string)dataTable.Rows[0]["descricao"];
                playlist.CriacaoPlaylist = (DateTime)dataTable.Rows[0]["dat_criacao"];
                playlist.AtualizacaoPlaylist = (DateTime)dataTable.Rows[0]["dat_atualizacao"];

                // Converter o inteiro do SQL para texto
                if ((int)dataTable.Rows[0]["publica"] == 1)
                    playlist.Privacidade = "Público";
                else
                    playlist.Privacidade = "Privado";

                playlist.QtdLikes = (int)dataTable.Rows[0]["qtd_likes"];

                // Retornar o objeto mapeado
                return playlist;
            }
            else
            {
                // Retornar null caso não encontre a playlist
                return null;
            }
        }

        // Função pública para consultar playlists com filtro
        public PlaylistCollection GetByFilters(
            string campo = "", string filtro = "")
        {
            // Criar o comando SELECT
            string query = "SELECT * FROM playlist ";

            // Verificar se existe algum filtro
            if (filtro != "")
                query += "WHERE " + campo + " LIKE @filtro ";

            // Ordenar os resultados pelo ID
            query += "ORDER BY id_playlist";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros do filtro
            if (filtro != "")
                command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

            // Recuperar os dados retornados
            DataTable dataTable = dataBase.GetDataTable(command);

            // Instanciar a coleção de playlists
            PlaylistCollection playlists = new PlaylistCollection();

            // Percorrer todas as linhas retornadas
            foreach (DataRow row in dataTable.Rows)
            {
                // Instanciar o objeto Playlist
                Playlist playlist = new Playlist();

                // Mapear os dados do SQL para o objeto
                playlist.IdPlaylist = (int)row["id_playlist"];

                playlist.IdUsuario = new Usuario();
                playlist.IdUsuario.IdUsuario = (int)row["id_usuario"];

                playlist.NomePlaylist = (string)row["nome_playlist"];
                playlist.DescPlaylist = (string)row["descricao"];
                playlist.CriacaoPlaylist = (DateTime)row["dat_criacao"];
                playlist.AtualizacaoPlaylist = (DateTime)row["dat_atualizacao"];

                // Converter o inteiro do SQL para texto
                if ((int)row["publica"] == 1)
                    playlist.Privacidade = "Público";
                else
                    playlist.Privacidade = "Privado";

                playlist.QtdLikes = (int)row["qtd_likes"];

                // Adicionar a playlist à coleção
                playlists.Add(playlist);
            }

            // Retornar a coleção de playlists
            return playlists;
        }

        // Função para retornar todas as playlists
        public PlaylistCollection GetAll()
        {
            // Consultar sem aplicar filtros
            return GetByFilters();
        }

        // Função para consultar playlists pelo nome
        public PlaylistCollection GetByNome(string valor)
        {
            return GetByFilters("nome_playlist", valor);
        }
        public PlaylistCollection GetByIdUsuario(int idUsuario)
        {
            return GetByFilters("id_usuario", idUsuario.ToString());
        }
        public PlaylistCollection GetByIdPlaylist(int idPlaylist)
        {
            return GetByFilters("id_playlist", idPlaylist.ToString());
        }
    }
}