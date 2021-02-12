using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClienteApp
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=WELINGTON-PC;Initial Catalog=bdClientes;Integrated Security=True";

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            else if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

            return;
        }
    }
}
