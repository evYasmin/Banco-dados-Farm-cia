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
    public class RemedioRepositorio
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65974\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Remedio> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM remedios";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Remedio> remedios = new List<Remedio>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(linha["id"]);
                remedio.Nome = linha["nome"].ToString();
                remedio.Generico = Convert.ToBoolean(linha["e_generico"]);
                remedio.Categoria = linha["categoria"].ToString();
                remedio.ContraIndicacoes = linha["contra_indicacoes"].ToString();
                remedio.Bula = linha["bula"].ToString();
                remedio.Faixa = linha["faixa"].ToString();
                remedio.PrecisaReceita = Convert.ToBoolean(linha["precisa_receita"]);
                remedio.Solido = Convert.ToBoolean(linha["e_solido"]);
                remedios.Add(remedio);
            }
            conexao.Close();
            return remedios;
        }


        public Remedio ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM remedios WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            conexao.Close();

            if (dataTable.Rows.Count == 1)
            {
                DataRow linha = dataTable.Rows[0];
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(linha["Id"]);
                remedio.Nome = linha["Nome"].ToString();
                remedio.Generico = Convert.ToBoolean(linha["e_generico"]);
                remedio.Categoria = linha["Categoria"].ToString();
                remedio.Solido = Convert.ToBoolean(linha["e_solido"]);
                remedio.Bula = linha["Bula"].ToString();
                remedio.Faixa = linha["Faixa"].ToString();
                remedio.PrecisaReceita = Convert.ToBoolean(linha["precisa_receita"]);
                return remedio;
            }
            return null;

        }
        public void Inserir(Remedio remedio)
        {

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO REMEDIOS (nome, categoria, e_generico, contra_indicacoes , bula , faixa , precisa_receita, e_solido)
VALUES (@NOME , @CATEGORIA , @E_GENERICO , @CONTRA_INDICACOES , @BULA , @FAIXA , @PRECISA_RECEITA , @E_SOLIDO)";

            comando.Parameters.AddWithValue("@NOME", remedio.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.Categoria);
            comando.Parameters.AddWithValue("@E_GENERICO", remedio.Generico);
            comando.Parameters.AddWithValue("@CONTRA_INDICACOES", remedio.ContraIndicacoes);
            comando.Parameters.AddWithValue("@BULA", remedio.Bula);
            comando.Parameters.AddWithValue("@FAIXA", remedio.Faixa);
            comando.Parameters.AddWithValue("@PRECISA_RECEITA", remedio.PrecisaReceita);
            comando.Parameters.AddWithValue("@E_SOLIDO", remedio.Solido);

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
            comando.CommandText = @"DELETE FROM remedios WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Atualizar(Remedio remedio)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE remedios SET 
nome = @NOME , 
categoria = @CATEGORIA , 
e_generico = @E_GENERICO , 
contra_indicacoes = @CONTRA_INDICACOES , 
bula = @BULA , 
faixa = @FAIXA ,
precisa_receita = @PRECISA_RECEITA ,
e_solido = @E_SOLIDO 
WHERE id = @ID";

            comando.Parameters.AddWithValue("nome", remedio.Nome);
            comando.Parameters.AddWithValue("categoria", remedio.Categoria);
            comando.Parameters.AddWithValue("e_generico", remedio.Generico);
            comando.Parameters.AddWithValue("contra_indicacoes", remedio.ContraIndicacoes);
            comando.Parameters.AddWithValue("bula", remedio.Bula);
            comando.Parameters.AddWithValue("faixa", remedio.Faixa);
            comando.Parameters.AddWithValue("precisa_receita", remedio.PrecisaReceita);
            comando.Parameters.AddWithValue("e_solido", remedio.Solido);
            comando.Parameters.AddWithValue("id", remedio.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}

