using System;
using System.Data;
using System.Data.SqlClient;
using Verify.Models;
using Verify.Services;

namespace Verify.Controllers
{
    // Classe de controle com as regras de negócio
    // para manipular o relacionamento entre Playlists e Músicas
    public class PlaylistMusicaController
    {
        // Instância da camada de serviço
        DataBaseService dataBase = new DataBaseService();

        // Função pública para adicionar uma música a uma playlist
        public int Inserir(PlaylistMusica playlistMusica)
        {
            // Criar o comando SQL para o INSERT
            string query =
                "INSERT INTO PLAYLIST_MUSICA " +
                "(ID_PLAYLIST, ID_MUSICA) " +
                "VALUES " +
                "(@IdPlaylist, @IdMusica)";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue(
                "@IdPlaylist", playlistMusica.IdPlaylist.IdPlaylist);

            command.Parameters.AddWithValue(
                "@IdMusica", playlistMusica.IdMusica.IdMusica);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para remover uma música de uma playlist
        public int Excluir(int idPlaylist, int idMusica)
        {
            // Criar o comando SQL para o DELETE
            string query =
                "DELETE FROM PLAYLIST_MUSICA " +
                "WHERE ID_PLAYLIST = @IdPlaylist " +
                "AND ID_MUSICA = @IdMusica";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@IdPlaylist", idPlaylist);
            command.Parameters.AddWithValue("@IdMusica", idMusica);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para consultar um relacionamento específico
        public PlaylistMusica GetById(int idPlaylist, int idMusica)
        {
            // Criar o comando SELECT
            string query =
                "SELECT * FROM PLAYLIST_MUSICA " +
                "WHERE ID_PLAYLIST = @IdPlaylist " +
                "AND ID_MUSICA = @IdMusica";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@IdPlaylist", idPlaylist);
            command.Parameters.AddWithValue("@IdMusica", idMusica);

            // Executar a consulta
            DataTable dataTable = dataBase.GetDataTable(command);

            // Validar se existem dados retornados
            if (dataTable.Rows.Count > 0)
            {
                // Instanciar o objeto PlaylistMusica
                PlaylistMusica playlistMusica = new PlaylistMusica();

                // Mapear os dados da tabela para o objeto C#
                playlistMusica.IdPlaylist = new Playlist();
                playlistMusica.IdPlaylist.IdPlaylist =
                    (int)dataTable.Rows[0]["ID_PLAYLIST"];

                playlistMusica.IdMusica = new Musica();
                playlistMusica.IdMusica.IdMusica =
                    (int)dataTable.Rows[0]["ID_MUSICA"];

                // Retornar o objeto mapeado
                return playlistMusica;
            }
            else
                return null;
        }

        // Função para consultar todos os relacionamentos
        public PMCollection GetAll()
        {
            return GetByFilters();
        }

        // Função para consultar relacionamentos com filtros
        public PMCollection GetByFilters(
            string campo = "", string filtro = "")
        {
            // Criar o comando SQL para o SELECT
            string query = "SELECT * FROM PLAYLIST_MUSICA ";

            // Verificar se possui filtro
            if (filtro != "")
                query += "WHERE " + campo + " LIKE @filtro ";

            // Adicionar ordenação
            query += " ORDER BY ID_PLAYLIST, ID_MUSICA";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            if (filtro != "")
                command.Parameters.AddWithValue(
                    "@filtro", "%" + filtro + "%");

            // Executar a consulta
            DataTable dataTable = dataBase.GetDataTable(command);

            // Instanciar a coleção de relacionamentos
            PMCollection relacionamentos = new PMCollection();

            // Percorrer todas as linhas retornadas
            foreach (DataRow row in dataTable.Rows)
            {
                // Instanciar o objeto PlaylistMusica
                PlaylistMusica playlistMusica = new PlaylistMusica();

                // Mapear o ID da playlist
                playlistMusica.IdPlaylist = new Playlist();
                playlistMusica.IdPlaylist.IdPlaylist =
                    (int)row["ID_PLAYLIST"];

                // Mapear o ID da música
                playlistMusica.IdMusica = new Musica();
                playlistMusica.IdMusica.IdMusica =
                    (int)row["ID_MUSICA"];

                // Adicionar à coleção
                relacionamentos.Add(playlistMusica);
            }

            // Retornar a coleção
            return relacionamentos;
        }

        // Função para retornar todas as músicas de uma playlist
        public PMCollection GetByPlaylist(int idPlaylist)
        {
            // Criar o comando SQL
            string query =
                "SELECT * FROM PLAYLIST_MUSICA " +
                "WHERE ID_PLAYLIST = @IdPlaylist " +
                "ORDER BY ID_MUSICA";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir o parâmetro
            command.Parameters.AddWithValue("@IdPlaylist", idPlaylist);

            // Executar a consulta
            DataTable dataTable = dataBase.GetDataTable(command);

            // Instanciar a coleção
            PMCollection relacionamentos = new PMCollection();

            // Percorrer as linhas retornadas
            foreach (DataRow row in dataTable.Rows)
            {
                // Instanciar o objeto
                PlaylistMusica playlistMusica = new PlaylistMusica();

                // Mapear a playlist
                playlistMusica.IdPlaylist = new Playlist();
                playlistMusica.IdPlaylist.IdPlaylist =
                    (int)row["ID_PLAYLIST"];

                // Mapear a música
                playlistMusica.IdMusica = new Musica();
                playlistMusica.IdMusica.IdMusica =
                    (int)row["ID_MUSICA"];

                // Adicionar à coleção
                relacionamentos.Add(playlistMusica);
            }

            // Retornar os relacionamentos
            return relacionamentos;
        }

        // Função para retornar todas as playlists de uma música
        public PMCollection GetByMusica(int idMusica)
        {
            // Criar o comando SQL
            string query =
                "SELECT * FROM PLAYLIST_MUSICA " +
                "WHERE ID_MUSICA = @IdMusica " +
                "ORDER BY ID_PLAYLIST";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir o parâmetro
            command.Parameters.AddWithValue("@IdMusica", idMusica);

            // Executar a consulta
            DataTable dataTable = dataBase.GetDataTable(command);

            // Instanciar a coleção
            PMCollection relacionamentos = new PMCollection();

            // Percorrer as linhas retornadas
            foreach (DataRow row in dataTable.Rows)
            {
                // Instanciar o objeto
                PlaylistMusica playlistMusica = new PlaylistMusica();

                // Mapear a playlist
                playlistMusica.IdPlaylist = new Playlist();
                playlistMusica.IdPlaylist.IdPlaylist =
                    (int)row["ID_PLAYLIST"];

                // Mapear a música
                playlistMusica.IdMusica = new Musica();
                playlistMusica.IdMusica.IdMusica =
                    (int)row["ID_MUSICA"];

                // Adicionar à coleção
                relacionamentos.Add(playlistMusica);
            }

            // Retornar os relacionamentos
            return relacionamentos;
        }

        // Consultar as músicas de uma playlist com seus títulos
        public MusicaCollection GetMusicasDaPlaylist(int idPlaylist)
        {
            string query =
                "SELECT M.ID_MUSICA, M.TITULO_MUSICA " +
                "FROM PLAYLIST_MUSICA PM " +
                "INNER JOIN MUSICA M " +
                "ON PM.ID_MUSICA = M.ID_MUSICA " +
                "WHERE PM.ID_PLAYLIST = @IdPlaylist " +
                "ORDER BY M.ID_MUSICA";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue(
                "@IdPlaylist", idPlaylist);

            DataTable dataTable = dataBase.GetDataTable(command);

            MusicaCollection musicas = new MusicaCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Musica musica = new Musica();

                musica.IdMusica = (int)row["ID_MUSICA"];
                musica.TituloMusica = (string)row["TITULO_MUSICA"];

                musicas.Add(musica);
            }

            return musicas;
        }

    }
}