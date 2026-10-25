using System;
using System.Data;
using System.Data.SqlClient;
using Verify.Models;
using Verify.Services;

namespace Verify.Controllers
{
    // Classe de controle com as regras de negócio
    // para manipular o cadastro de Artistas
    public class ArtistaController
    {
        // Instância da camada de serviço
        DataBaseService dataBase = new DataBaseService();

        // Função pública para inserir um novo artista
        public int Inserir(Artista artista)
        {
            // Criar o comando SQL
            string query =
                "INSERT INTO ARTISTA " +
                "(NOME_ARTISTICO, NOME_REAL, BIOGRAFIA, GENERO_PRINCIPAL, DATA_NASCIMENTO, DATA_INICIO_CARREIRA) " +
                "VALUES " +
                "(@NomeArtistico, @NomeReal, @Biografia, @GeneroMusicalPrincipal, @DataNascimento, @DataInicioCarreira)";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@NomeArtistico", artista.NomeArtistico);
            command.Parameters.AddWithValue("@NomeReal", artista.NomeReal);
            command.Parameters.AddWithValue("@Biografia", artista.Biografia);
            command.Parameters.AddWithValue("@GeneroMusicalPrincipal", artista.GeneroMusicalPrincipal);
            command.Parameters.AddWithValue("@DataNascimento", artista.DataNascimento);
            command.Parameters.AddWithValue("@DataInicioCarreira", artista.DataInicioCarreira);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para atualizar um artista
        public int Alterar(Artista artista)
        {
            // Criar o comando SQL para o UPDATE
            string query =
                "UPDATE ARTISTA SET " +
                "NOME_ARTISTICO = @NomeArtistico, " +
                "NOME_REAL = @NomeReal, " +
                "BIOGRAFIA = @Biografia, " +
                "GENERO_PRINCIPAL = @GeneroMusicalPrincipal, " +
                "DATA_NASCIMENTO = @DataNascimento, " +
                "DATA_INICIO_CARREIRA = @DataInicioCarreira " +
                "WHERE ID_ARTISTA = @IdArtista";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@NomeArtistico", artista.NomeArtistico);
            command.Parameters.AddWithValue("@NomeReal", artista.NomeReal);
            command.Parameters.AddWithValue("@Biografia", artista.Biografia);
            command.Parameters.AddWithValue("@GeneroMusicalPrincipal", artista.GeneroMusicalPrincipal);
            command.Parameters.AddWithValue("@DataNascimento", artista.DataNascimento);
            command.Parameters.AddWithValue("@DataInicioCarreira", artista.DataInicioCarreira);
            command.Parameters.AddWithValue("@IdArtista", artista.IdArtista);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para excluir um artista
        public int Excluir(int id)
        {
            // Criar o comando SQL para o DELETE
            string query =
                "DELETE FROM ARTISTA " +
                "WHERE ID_ARTISTA = @IdArtista";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir o parâmetro
            command.Parameters.AddWithValue("@IdArtista", id);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para consultar um artista por ID
        public Artista GetById(int id)
        {
            // Criar o comando SELECT
            string query =
                "SELECT * FROM ARTISTA " +
                "WHERE ID_ARTISTA = @IdArtista";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir o parâmetro
            command.Parameters.AddWithValue("@IdArtista", id);

            // Executar a consulta
            DataTable dataTable = dataBase.GetDataTable(command);

            // Validar se existem dados retornados
            if (dataTable.Rows.Count > 0)
            {
                // Instanciar o objeto Artista
                Artista artista = new Artista();

                // Mapear os dados da tabela para o objeto C#
                artista.IdArtista = (int)dataTable.Rows[0]["ID_ARTISTA"];
                artista.NomeArtistico = (string)dataTable.Rows[0]["NOME_ARTISTICO"];
                artista.NomeReal = (string)dataTable.Rows[0]["NOME_REAL"];
                artista.Biografia = (string)dataTable.Rows[0]["BIOGRAFIA"];
                artista.GeneroMusicalPrincipal = (string)dataTable.Rows[0]["GENERO_PRINCIPAL"];
                artista.DataNascimento = (DateTime)dataTable.Rows[0]["DATA_NASCIMENTO"];
                artista.DataInicioCarreira = (DateTime)dataTable.Rows[0]["DATA_INICIO_CARREIRA"];

                // Retornar o objeto mapeado
                return artista;
            }
            else
                return null;
        }

        // Função pública para consultar artistas com filtros
        public ArtistaCollection GetByFilters(
            string campo = "", string filtro = "")
        {
            // Criar o comando SQL para o SELECT
            string query = "SELECT * FROM ARTISTA ";

            // Validar o campo recebido para evitar SQL Injection
            if (filtro != "")
            {
                switch (campo)
                {
                    case "NOME_ARTISTICO":
                    case "NOME_REAL":
                    case "BIOGRAFIA":
                    case "GENERO_PRINCIPAL":
                        query += "WHERE " + campo + " LIKE @Filtro ";
                        break;

                    default:
                        campo = "";
                        filtro = "";
                        break;
                }
            }

            // Ordenar os resultados
            query += "ORDER BY NOME_ARTISTICO";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir o parâmetro caso exista filtro
            if (filtro != "")
                command.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

            // Executar a consulta
            DataTable dataTable = dataBase.GetDataTable(command);

            // Instanciar a coleção de artistas
            ArtistaCollection artistas = new ArtistaCollection();

            // Percorrer cada linha retornada
            foreach (DataRow row in dataTable.Rows)
            {
                // Instanciar o objeto Artista
                Artista artista = new Artista();

                // Converter os dados da tabela para o objeto C#
                artista.IdArtista = (int)row["ID_ARTISTA"];
                artista.NomeArtistico = (string)row["NOME_ARTISTICO"];
                artista.NomeReal = (string)row["NOME_REAL"];
                artista.Biografia = (string)row["BIOGRAFIA"];
                artista.GeneroMusicalPrincipal = (string)row["GENERO_PRINCIPAL"];
                artista.DataNascimento = (DateTime)row["DATA_NASCIMENTO"];
                artista.DataInicioCarreira = (DateTime)row["DATA_INICIO_CARREIRA"];

                // Adicionar o objeto à coleção
                artistas.Add(artista);
            }

            // Retornar a coleção
            return artistas;
        }

        // Função para retornar todos os artistas
        public ArtistaCollection GetAll()
        {
            // Consultar sem aplicar filtros
            return GetByFilters();
        }

        public ArtistaCollection GetByIdArtista(int id)
        {
            return GetByFilters("ID_ARTISTA", id.ToString());
        }
        // Função para filtrar artistas pelo nome artístico
        public ArtistaCollection GetByName(string value)
        {
            return GetByFilters("NOME_ARTISTICO", value);
        }

        // Função para filtrar artistas pelo nome real
        public ArtistaCollection GetByRealName(string value)
        {
            return GetByFilters("NOME_REAL", value);
        }

        // Função para filtrar artistas pelo gênero musical principal
        public ArtistaCollection GetByGenre(string value)
        {
            return GetByFilters("GENERO_PRINCIPAL", value);
        }
    }
}