using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ComestiveisRepositorio
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65974\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Comestivel> Obtertodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM comestiveis";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Comestivel> comestiveis = new List<Comestivel>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Comestivel comestivel = new Comestivel();
                comestivel.id = Convert.ToInt32(linha["id"]);
                comestivel.nome = linha["nome"].ToString();
                comestivel.valor = Convert.ToDecimal(linha["valor"]);
                comestivel.dataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
                comestivel.quantidade = Convert.ToInt32(linha["quantidade"]);
                comestivel.marca = linha["marca"].ToString();
                comestiveis.Add(comestivel);
                conexao.Close();
            }
            return comestiveis;
        }

        public Comestivel ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM comestiveis WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            conexao.Close();
            if (dataTable.Rows.Count == 1)
            {
                DataRow linha = dataTable.Rows[0];
                Comestivel comestivel = new Comestivel();
                comestivel.id = Convert.ToInt32(linha["id"]);
                comestivel.nome = linha["nome"].ToString();
                comestivel.valor = Convert.ToDecimal(linha["valor"]);
                comestivel.dataVencimento = Convert.ToDateTime(linha["data_Vencimento"]);
                comestivel.quantidade = Convert.ToInt32(linha["quantidade"]);
                comestivel.marca = linha["marca"].ToString();
                return comestivel;
            }
            return null;
        }

        public void Inserir(Comestivel comestivel)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO comestiveis (nome,valor,data_vencimento,quantidade,marca) 
VALUES (@NOME , @VALOR , @DATA_VENCIMENTO , @QUANTIDADE , @MARCA)";
            comando.Parameters.AddWithValue("@NOME", comestivel.nome);
            comando.Parameters.AddWithValue("@VALOR", comestivel.valor);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", comestivel.dataVencimento);
            comando.Parameters.AddWithValue("@QUANTIDADE", comestivel.quantidade);
            comando.Parameters.AddWithValue("@MARCA", comestivel.marca);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM comestiveis WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Atualizar(Comestivel comestivel)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE comestiveis SET 
nome = @NOME , 
valor = @VALOR , 
data_vencimento = @DATA_VENCIMENTO , 
quantidade = @QUANTIDADE , 
marca = @MARCA
WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", comestivel.nome);
            comando.Parameters.AddWithValue("@VALOR", comestivel.valor);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", comestivel.dataVencimento);
            comando.Parameters.AddWithValue("@QUANTIDADE", comestivel.quantidade);
            comando.Parameters.AddWithValue("@MARCA", comestivel.marca);
            comando.Parameters.AddWithValue("@ID", comestivel.id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }


}
