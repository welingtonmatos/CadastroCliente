using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroClienteApp
{
    public partial class Cadastro : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        string strSQL;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=WELINGTON-PC;Database=bdClientes;User Id=sa;Password=welington;");

                strSQL = "INSERT INTO clientes (id, nome, ddd, telefone) VALUES (@id, @nome, @ddd, @telefone)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@id", txtId.Text);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@ddd", txtDdd.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=WELINGTON-PC;Database=bdClientes;User Id=sa;Password=welington;");

                strSQL = "UPDATE clientes SET nome = @nome, ddd = @ddd, telefone = @telefone WHERE id = @id";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@id", txtId.Text);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@ddd", txtDdd.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=WELINGTON-PC;Database=bdClientes;User Id=sa;Password=welington;");

                strSQL = "SELECT * FROM clientes";

                DataSet data = new DataSet();

                adapter = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                adapter.Fill(data);

                lista.DataSource = data.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=WELINGTON-PC;Database=bdClientes;User Id=sa;Password=welington;");

                strSQL = "SELECT * FROM clientes WHERE id = @id";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@id", txtId.Text);

                conexao.Open();
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    txtNome.Text = (string)reader["nome"];
                    txtDdd.Text = (string)reader["ddd"];
                    txtTelefone.Text = (string)reader["telefone"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtDdd.Text = "";
            txtTelefone.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=WELINGTON-PC;Database=bdClientes;User Id=sa;Password=welington;");

                strSQL = "DELETE clientes WHERE id = @id";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@id", txtId.Text);
                
                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro exluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
