using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClienteApp
{
    class Clientes
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public Clientes(string nome, string sobrenome, string telefone)
        {
            cmd.CommandText = "insert into bdClientes (nome, sobrenome, telefone) values (@nome, @sobrenome, @telefone)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            try
            {
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro de conexão com o banco de dados!";
            }
        }
    }
}
