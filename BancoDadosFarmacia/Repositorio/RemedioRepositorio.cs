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
        string cadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65974\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Remedio> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = cadeiaConexao;
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
                remedio.id = Convert.ToInt32(linha["id"]);
                remedio.nome = linha["nome"].ToString();
                remedio.e_generico = linha["e_generico"].ToString();
                remedio.categoria = linha["categoria"].ToString();
                remedio.e_solido = linha["e_solido"].ToString();
                remedio.contra_indicacoes = linha["contra_indicacoes"].ToString();
                remedio.bula = linha["bula"].ToString();
                remedio.faixa = linha["faixa"].ToString();
                remedio.precisa_receita = linha["precisa_receita"].ToString();
            }
            conexao.Close();
            return remedios;
        }


        public Remedio ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = cadeiaConexao;
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
                remedio.id = Convert.ToInt32(linha["id"]);
                remedio.nome = linha["nome"].ToString();
                remedio.e_generico = linha["e_generico"].ToString();
                remedio.categoria = linha["categoria"].ToString();
                remedio.e_solido = linha["e_solido"].ToString();
                remedio.contra_indicacoes = linha["contra_indicacoes"].ToString();
                remedio.bula = linha["bula"].ToString();
                remedio.faixa = linha["faixa"].ToString();
                remedio.precisa_receita = linha["precisa_receita"].ToString();
                return remedio;
            }
            return null;

        }
        public void Inserir(Remedio remedio)
        {

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = cadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO remedios (id, nome, categoria, e_generico
contra_indicacoes , bula , faixa , precisa_receita)
VALUES (@NOME , @CATEGORIA , @E_GENERICO , @CONTRA_INDICACOES , @BULA , @FAIXA , @PRECISA_RECEITA)";

            comando.Parameters.AddWithValue("@NOME", remedio.nome);
            comando.Parameters.AddWithValue("@CATEGORIA", remedio.categoria);
            comando.Parameters.AddWithValue("@E_GENERICO", remedio.e_generico);
            comando.Parameters.AddWithValue("@CONTRA_INDICACOES", remedio.contra_indicacoes);
            comando.Parameters.AddWithValue("@BULA", remedio.bula);
            comando.Parameters.AddWithValue("@FAIXA", remedio.faixa);
            comando.Parameters.AddWithValue("@PRECISA_RECEITA", remedio.precisa_receita);

            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = cadeiaConexao;
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
            conexao.ConnectionString = cadeiaConexao;
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
precisa_receita = @PRECISA_RECEITA 
WHERE id = @ID";

            comando.Parameters.AddWithValue("NOME", remedio.nome);
            comando.Parameters.AddWithValue("categoria", remedio.categoria);
            comando.Parameters.AddWithValue("e_generico", remedio.e_generico);
            comando.Parameters.AddWithValue("contra_indicacoes", remedio.contra_indicacoes);
            comando.Parameters.AddWithValue("bula", remedio.bula);
            comando.Parameters.AddWithValue("faixa", remedio.faixa);
            comando.Parameters.AddWithValue("precisa_receita", remedio.precisa_receita);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}

