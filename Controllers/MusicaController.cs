using Verify.Models;
using Verify.Services;
using System.Data;
using System.Data.SqlClient;
using System;

namespace Verify.Controllers
{
    public class MusicaController
    {
            DataBaseService dataBase = new DataBaseService();

        // Função pública para inserir uma música
        public int Inserir(Musica musica)
        {
            // Criar o comando SQL que será executado
            string query =
                "INSERT INTO musica (id_artista, id_album, titulo_musica, duracao_musica, data_lancamento_musica, genero_musical, compositor, numero_reproducoes) " +
                "VALUES (@id_artista, @id_album, @titulo_musica, @duracao_musica, @data_lancamento_musica, @genero_musical, @compositor, @numero_reproducoes)";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os valores dos parâmetros
            command.Parameters.AddWithValue("@id_artista", musica.IdArtista.IdArtista);
            command.Parameters.AddWithValue("@id_album", musica.IdAlbum.IdAlbum);
            command.Parameters.AddWithValue("@titulo_musica", musica.TituloMusica);
            command.Parameters.AddWithValue("@duracao_musica", musica.DuracaoSegundos);
            command.Parameters.AddWithValue("@data_lancamento_musica", musica.DataLancamentoMusica);
            command.Parameters.AddWithValue("@genero_musical", musica.GeneroMusical);
            command.Parameters.AddWithValue("@compositor", musica.NomeCompositor);
            command.Parameters.AddWithValue("@numero_reproducoes", musica.NumReprod);

            // Executar o comando e retornar a quantidade de linhas afetadas
            return dataBase.ExecuteSql(command);
        }


        // Função pública para atualizar uma música
        public int Alterar(Musica musica)
        {
            // Criar o comando SQL para o UPDATE
            string query =
                "UPDATE musica SET " +
                "id_artista = @id_artista, " +
                "id_album = @id_album, " +
                "titulo_musica = @titulo_musica, " +
                "duracao_musica = @duracao_musica, " +
                "data_lancamento_musica = @data_lancamento_musica, " +
                "genero_musical = @genero_musical, " +
                "compositor = @compositor, " +
                "numero_reproducoes = @numero_reproducoes " +
                "WHERE id_musica = @id_musica";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@id_artista", musica.IdArtista.IdArtista);
            command.Parameters.AddWithValue("@id_album", musica.IdAlbum.IdAlbum);
            command.Parameters.AddWithValue("@titulo_musica", musica.TituloMusica);
            command.Parameters.AddWithValue("@duracao_musica", musica.DuracaoSegundos);
            command.Parameters.AddWithValue("@data_lancamento_musica", musica.DataLancamentoMusica);
            command.Parameters.AddWithValue("@genero_musical", musica.GeneroMusical);
            command.Parameters.AddWithValue("@compositor", musica.NomeCompositor);
            command.Parameters.AddWithValue("@numero_reproducoes", musica.NumReprod);
            command.Parameters.AddWithValue("@id_musica", musica.IdMusica);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para excluir uma música
        public int Excluir(int id)
        {
            // Verificar se a música está vinculada a alguma playlist
            string queryVerificar =
                "SELECT COUNT(*) FROM PLAYLIST_MUSICA " +
                "WHERE ID_MUSICA = @id_musica";

            SqlCommand commandVerificar = new SqlCommand(queryVerificar);

            commandVerificar.Parameters.AddWithValue("@id_musica", id);

            DataTable dataTable = dataBase.GetDataTable(commandVerificar);

            // Se estiver vinculada, não permitir a exclusão
            if ((int)dataTable.Rows[0][0] > 0)
            {
                return -1;
            }

            // Criar o comando SQL para excluir a música
            string query =
                "DELETE FROM musica " +
                "WHERE id_musica = @id_musica";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@id_musica", id);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }


        // Função pública para consultar uma música por ID
        public Musica GetById(int id)
        {
            // Criar o comando SELECT
            string query =
                "SELECT * FROM musica " +
                "WHERE id_musica = @id_musica";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@id_musica", id);

            // Recuperar os dados retornados
            DataTable dataTable = dataBase.GetDataTable(command);

            // Verificar se algum registro foi encontrado
            if (dataTable.Rows.Count > 0)
            {
                // Instanciar o objeto Musica
                Musica musica = new Musica();

                // Mapear os dados do SQL para o objeto
                musica.IdMusica = (int)dataTable.Rows[0]["id_musica"];
                musica.IdArtista = new Artista();
                musica.IdArtista.IdArtista = (int)dataTable.Rows[0]["id_artista"];
                musica.IdAlbum = new Album();
                musica.IdAlbum.IdAlbum = (int)dataTable.Rows[0]["id_album"];
                musica.TituloMusica = (string)dataTable.Rows[0]["titulo_musica"];
                musica.DuracaoSegundos = dataTable.Rows[0]["duracao_musica"].ToString();
                musica.DataLancamentoMusica = (DateTime)dataTable.Rows[0]["data_lancamento_musica"];
                musica.GeneroMusical = (string)dataTable.Rows[0]["genero_musical"];
                musica.NomeCompositor = (string)dataTable.Rows[0]["compositor"];
                musica.NumReprod = (int)dataTable.Rows[0]["numero_reproducoes"];

                // Retornar o objeto mapeado
                return musica;
            }
            else
            {
                // Retornar null caso não encontre a música
                return null;
            }
        }

        // Função pública para consultar músicas com filtro
        public MusicaCollection GetByFilters(
            string campo = "", string filtro = "")
        {
            // Criar o comando SELECT
            string query = "SELECT * FROM musica ";

            // Verificar se existe algum filtro
            if (filtro != "")
                query += "WHERE " + campo + " LIKE @filtro ";

            // Ordenar os resultados pelo título
            query += "ORDER BY titulo_musica";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros do filtro
            if (filtro != "")
                command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

            // Recuperar os dados retornados
            DataTable dataTable = dataBase.GetDataTable(command);

            // Instanciar a coleção de músicas
            MusicaCollection musicas = new MusicaCollection();

            // Percorrer todas as linhas retornadas
            foreach (DataRow row in dataTable.Rows)
            {
                // Instanciar o objeto Musica
                Musica musica = new Musica();

                // Mapear os dados do SQL para o objeto
                musica.IdMusica = (int)row["id_musica"];
                musica.IdArtista = new Artista();
                musica.IdArtista.IdArtista = (int)row["id_artista"];
                musica.IdAlbum = new Album();
                musica.IdAlbum.IdAlbum = (int)row["id_album"];
                musica.TituloMusica = (string)row["titulo_musica"];
                musica.DuracaoSegundos = (string)row["duracao_musica"];
                musica.DataLancamentoMusica = (DateTime)row["data_lancamento_musica"];
                musica.GeneroMusical = (string)row["genero_musical"];
                musica.NomeCompositor = (string)row["compositor"];
                musica.NumReprod = (int)row["numero_reproducoes"];

                // Adicionar a música à coleção
                musicas.Add(musica);
            }

            // Retornar a coleção
            return musicas;
        }

        // Função para retornar todas as músicas
        public MusicaCollection GetAll()
        {
            // Consultar sem aplicar filtros
            return GetByFilters();
        }

        // Função para retornar músicas pelo Id
        public MusicaCollection GetByIdMusica(int valor)
        {
            return GetByFilters("id_musica", valor.ToString());
        }

        // Função para consultar músicas pelo título
        public MusicaCollection GetByTitulo(string valor)
        {
            return GetByFilters("titulo_musica", valor);
        }
        // Função para consultar músicas pelo gênero
        public MusicaCollection GetByCompositor(string valor)
        {
            return GetByFilters("compositor", valor);
        }
        // Função para consultar músicas pelo ID artista
        public MusicaCollection GetByIdArtista(int valor)
        {
            return GetByFilters("id_artista", valor.ToString());
        }
        public MusicaCollection GetByIdAlbum(int valor)
        {
            return GetByFilters("id_album", valor.ToString());
        }
    }
}