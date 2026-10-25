using Verify.Models;
using Verify.Services;
using System.Data;
using System.Data.SqlClient;
using System;

namespace Verify.Controllers
{
    public class UsuarioController
    {
        DataBaseService dataBase = new DataBaseService();

        // Função pública para inserir um usuário
        public int Inserir(Usuario usuario)
        {
            // Criar o comando SQL que será executado
            string query =
                "INSERT INTO usuario (nome_completo, nome_usuario, email, senha, data_nascimento, tipo_plano) " +
                "VALUES (@nome_completo, @nome_usuario, @email, @senha, @data_nascimento, @tipo_plano)";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os valores dos parâmetros
            command.Parameters.AddWithValue("@nome_completo", usuario.NomeCompleto);
            command.Parameters.AddWithValue("@nome_usuario", usuario.NomeUsuario);
            command.Parameters.AddWithValue("@email", usuario.EmailUsuario);
            command.Parameters.AddWithValue("@senha", usuario.SenhaUsuario);
            command.Parameters.AddWithValue("@data_nascimento", usuario.DataNascUsuario);
            command.Parameters.AddWithValue("@tipo_plano", usuario.TipoPlano);

            // Executar o comando e retornar a quantidade de linhas afetadas
            return dataBase.ExecuteSql(command);
        }

        // Função pública para atualizar um usuário
        public int Alterar(Usuario usuario)
        {
            // Criar o comando SQL para o UPDATE
            string query =
                "UPDATE usuario SET " +
                "nome_completo = @nome_completo, " +
                "nome_usuario = @nome_usuario, " +
                "email = @email, " +
                "senha = @senha, " +
                "data_nascimento = @data_nascimento, " +
                "tipo_plano = @tipo_plano " +
                "WHERE id_usuario = @id_usuario";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@nome_completo", usuario.NomeCompleto);
            command.Parameters.AddWithValue("@nome_usuario", usuario.NomeUsuario);
            command.Parameters.AddWithValue("@email", usuario.EmailUsuario);
            command.Parameters.AddWithValue("@senha", usuario.SenhaUsuario);
            command.Parameters.AddWithValue("@data_nascimento", usuario.DataNascUsuario);
            command.Parameters.AddWithValue("@tipo_plano", usuario.TipoPlano);
            command.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para excluir um usuário
        public int Excluir(int id)
        {
            // Criar o comando SQL para o DELETE
            string query =
                "DELETE FROM usuario " +
                "WHERE id_usuario = @id_usuario";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@id_usuario", id);

            // Executar o comando
            return dataBase.ExecuteSql(command);
        }

        // Função pública para consultar um usuário por ID
        public Usuario GetById(int id)
        {
            // Criar o comando SELECT
            string query =
                "SELECT * FROM usuario " +
                "WHERE id_usuario = @id_usuario";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros
            command.Parameters.AddWithValue("@id_usuario", id);

            // Recuperar os dados retornados
            DataTable dataTable = dataBase.GetDataTable(command);

            // Verificar se algum registro foi encontrado
            if (dataTable.Rows.Count > 0)
            {
                // Instanciar o objeto Usuario
                Usuario usuario = new Usuario();

                // Mapear os dados do SQL para o objeto
                usuario.IdUsuario = (int)dataTable.Rows[0]["id_usuario"];
                usuario.NomeCompleto = (string)dataTable.Rows[0]["nome_completo"];
                usuario.NomeUsuario = (string)dataTable.Rows[0]["nome_usuario"];
                usuario.EmailUsuario = (string)dataTable.Rows[0]["email"];
                usuario.SenhaUsuario = (string)dataTable.Rows[0]["senha"];
                usuario.DataNascUsuario = (DateTime)dataTable.Rows[0]["data_nascimento"];
                usuario.TipoPlano = (string)dataTable.Rows[0]["tipo_plano"];

                // Retornar o objeto mapeado
                return usuario;
            }
            else
            {
                // Retornar null caso não encontre o usuário
                return null;
            }
        }

        // Função pública para consultar usuários com filtro
        public UsuarioCollection GetByFilters(
            string campo = "", string filtro = "")
        {
            // Criar o comando SELECT
            string query = "SELECT * FROM usuario ";

            // Verificar se existe algum filtro
            if (filtro != "")
                query += "WHERE " + campo + " LIKE @filtro ";

            // Ordenar os resultados pelo ID
            query += "ORDER BY id_usuario";

            // Instanciar o comando
            SqlCommand command = new SqlCommand(query);

            // Definir os parâmetros do filtro
            if (filtro != "")
                command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

            // Recuperar os dados retornados
            DataTable dataTable = dataBase.GetDataTable(command);

            // Instanciar a coleção de usuários
            UsuarioCollection usuarios = new UsuarioCollection();

            // Percorrer todas as linhas retornadas
            foreach (DataRow row in dataTable.Rows)
            {
                // Instanciar o objeto Usuario
                Usuario usuario = new Usuario();

                // Mapear os dados do SQL para o objeto
                usuario.IdUsuario = (int)row["id_usuario"];
                usuario.NomeCompleto = (string)row["nome_completo"];
                usuario.NomeUsuario = (string)row["nome_usuario"];
                usuario.EmailUsuario = (string)row["email"];
                usuario.SenhaUsuario = (string)row["senha"];
                usuario.DataNascUsuario = (DateTime)row["data_nascimento"];
                usuario.TipoPlano = (string)row["tipo_plano"];

                // Adicionar o usuário à coleção
                usuarios.Add(usuario);
            }

            // Retornar a coleção de usuários
            return usuarios;
        }

        // Função para retornar todos os usuários
        public UsuarioCollection GetAll()
        {
            // Consultar sem aplicar filtros
            return GetByFilters();
        }

        // Função para consultar usuários pelo nome completo
        public UsuarioCollection GetByNomeUsuario(string valor)
        {
            return GetByFilters("nome_usuario", valor);
        }
        public UsuarioCollection GetByIdUsuario(int id)
        {
            return GetByFilters("id_usuario", id.ToString());
        }
        public UsuarioCollection GetByEmail(string email)
        {
            return GetByFilters("email", email);
        }

        // Função para consultar usuários pelo tipo de plano
        public UsuarioCollection GetByTipoPlano(string valor)
        {
            return GetByFilters("tipo_plano", valor);
        }
    }
}