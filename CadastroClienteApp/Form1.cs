using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClienteApp
{
    public partial class Cadastro : Form
    {
        List<Clientes> clientes;
        public Cadastro()
        {
            InitializeComponent();

            clientes = new List<Clientes>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes(txtNome.Text, txtSobrenome.Text, txtTelefone.Text);

            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                txtNome.Focus();
                return;
            }

            if (txtSobrenome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                txtSobrenome.Focus();
                return;
            }

            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha todos os campos!");
                txtTelefone.Focus();
                return;
            }

            MessageBox.Show(cliente.mensagem);

            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //int indice = lista.SelectedIndex;
            //clientes.RemoveAt(indice);
            //Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtTelefone.Text = "";
            txtNome.Focus();
        }

        private void Listar()
        {
            lista.Items.Clear();
            
            foreach (Clientes client in clientes)
            {
                lista.Items.Add();
                //lista.Items.Add(c.Sobrenome);
                //lista.Items.Add(c.Telefone);
            }
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = lista.SelectedIndex;
            Clientes client = clientes[indice];

            client.;
            //txtSobrenome.Text = client.ToString();
            //txtTelefone.Text = client.ToString();
        }
    }
}
