using Verify.Models;
using Verify.Services;
using System.Data;
using System.Data.SqlClient;
using System;

namespace Verify.Controllers
{
    public class AlbumController
    {
        DataBaseService dataBase = new DataBaseService();

        // Função pública para inserir um álbum
        public int Inserir(Album album)
        {
            // Criar o comando SQL que será executado
            string query =
                "INSERT INTO album (id_artista, nome_album, data_lancamento_album, gravadora, capa_url, duracao_total, tipo_album, numero_faixas) " +
                "VALUES (@id_artista, @nome_album, @data_lancamento_album, @gravadora, @capa_url, @duracao_total, @tipo_album, @numero_faixas)";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os valores dos parâmetros
            command.Parameters.AddWithValue("@id_artista", album.IdArtista.IdArtista);
            command.Parameters.AddWithValue("@nome_album", album.NomeAlbum);
            command.Parameters.AddWithValue("@data_lancamento_album", album.DataLancamentoAlbum);
            command.Parameters.AddWithValue("@gravadora", album.Gravadora);
            command.Parameters.AddWithValue("@capa_url", album.CapaUrl);
            command.Parameters.AddWithValue("@duracao_total", album.DuracaoTotalAlbum);
            command.Parameters.AddWithValue("@tipo_album", album.TipoAlbum);
            command.Parameters.AddWithValue("@numero_faixas", album.NumeroFaixas);

            // Executar o comando e retornar a quantidade de linhas afetadas
            return dataBase.ExecuteSql(command);
        }

        // Função pública para atualizar um álbum
        public int Alterar(Album album)
        {
            // Criar o comando SQL para o UPDATE
            string query =
                "UPDATE album SET " +
                "id_artista = @id_artista, " +
                "nome_album = @nome_album, " +
                "data_lancamento_album = @data_lancamento_album, " +
                "gravadora = @gravadora, " +
                "capa_url = @capa_url, " +
                "duracao_total = @duracao_total, " +
                "tipo_album = @tipo_album, " +
                "numero_faixas = @numero_faixas " +
                "WHERE id_album = @id_album";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@id_artista", album.IdArtista.IdArtista);
            command.Parameters.AddWithValue("@nome_album", album.NomeAlbum);
            command.Parameters.AddWithValue("@data_lancamento_album", album.DataLancamentoAlbum);
            command.Parameters.AddWithValue("@gravadora", album.Gravadora);
            command.Parameters.AddWithValue("@capa_url", album.CapaUrl);
            command.Parameters.AddWithValue("@duracao_total", album.DuracaoTotalAlbum);
            command.Parameters.AddWithValue("@tipo_album", album.TipoAlbum);
            command.Parameters.AddWithValue("@numero_faixas", album.NumeroFaixas);
            command.Parameters.AddWithValue("@id_album", album.IdAlbum);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para excluir um álbum
        public int Excluir(int id)
        {
            // Criar o comando SQL para o DELETE
            string query =
                "DELETE FROM album " +
                "WHERE id_album = @id_album";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@id_album", id);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para consultar um álbum por ID
        public Album GetById(int id)
        {
            // Criar o comando SELECT
            string query =
                "SELECT * FROM album " +
                "WHERE id_album = @id_album";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@id_album", id);

            // Recuperar os dados retornados
            DataTable dataTable = dataBase.GetDataTable(command);

            // Verificar se algum registro foi encontrado
            if (dataTable.Rows.Count > 0)
            {
                // Instanciar o objeto Album
                Album album = new Album();

                // Mapear os dados do SQL para o objeto
                album.IdAlbum = (int)dataTable.Rows[0]["id_album"];
                album.NomeAlbum = (string)dataTable.Rows[0]["nome_album"];
                album.IdArtista = new Artista();
                album.IdArtista.IdArtista = (int)dataTable.Rows[0]["id_artista"];
                album.DataLancamentoAlbum = (DateTime)dataTable.Rows[0]["data_lancamento_album"];
                album.Gravadora = (string)dataTable.Rows[0]["gravadora"];
                album.CapaUrl = (string)dataTable.Rows[0]["capa_url"];
                album.DuracaoTotalAlbum = (string)dataTable.Rows[0]["duracao_total"];
                album.TipoAlbum = (string)dataTable.Rows[0]["tipo_album"];
                album.NumeroFaixas = (int)dataTable.Rows[0]["numero_faixas"];

                // Retornar o objeto mapeado
                return album;
            }
            else
            {
                // Retornar null caso não encontre o álbum
                return null;
            }
        }
  
        // Função pública para consultar álbuns com filtro
        public AlbumCollection GetByFilters(
            string campo = "", string filtro = "")
        {
            // Criar o comando SELECT
            string query = "SELECT * FROM album ";

            // Verificar se existe algum filtro
            if (filtro != "")
                query += "WHERE " + campo + " LIKE @filtro ";

            // Ordenar os resultados pelo ID
            query += "ORDER BY id_album";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros do filtro
            if (filtro != "")
                command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

            // Recuperar os dados retornados
            DataTable dataTable = dataBase.GetDataTable(command);

            // Instanciar a coleção de álbuns
            AlbumCollection albums = new AlbumCollection();

            // Percorrer todas as linhas retornadas
            foreach (DataRow row in dataTable.Rows)
            {
                // Instanciar o objeto Album
                Album album = new Album();

                // Mapear os dados do SQL para o objeto
                album.IdAlbum = (int)row["id_album"];
                album.NomeAlbum = (string)dataTable.Rows[0]["nome_album"];
                album.IdArtista = new Artista();
                album.IdArtista.IdArtista = (int)row["id_artista"];
                album.DataLancamentoAlbum = (DateTime)row["data_lancamento_album"];
                album.Gravadora = (string)row["gravadora"];
                album.CapaUrl = (string)row["capa_url"];
                album.DuracaoTotalAlbum = (string)row["duracao_total"];
                album.TipoAlbum = (string)row["tipo_album"];
                album.NumeroFaixas = (int)row["numero_faixas"];

                // Adicionar o álbum à coleção
                albums.Add(album);
            }

            // Retornar a coleção de álbuns
            return albums;
        }

        // Função para retornar todos os álbuns
        public AlbumCollection GetAll()
        {
            // Consultar sem aplicar filtros
            return GetByFilters();
        }

        // Função para retornar o Id album
        public AlbumCollection GetByIdAlbum(int valor)
        {
            return GetByFilters("id_album", valor.ToString());
        }

        // Função para retornar o Id artista
        public AlbumCollection GetByIdArtistaAlbum(int valor)
        {
            return GetByFilters("id_artista", valor.ToString());
        }

        // Função para retornar o nome do album boomshakala
        public AlbumCollection GetByNomeAlbum(string valor)
        {
            return GetByFilters("nome_album", valor);
        }

        // Função para consultar álbuns por tipo
        public AlbumCollection GetByTipoAlbum(string valor)
        {
            return GetByFilters("tipo_album", valor);
        }
    }
}
