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
            int index = -1;

            foreach (Clientes c in clientes)
            {
                if (c.Nome == txtNome.Text)
                {
                    index = clientes.IndexOf(c);
                }
            }

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

            if (txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                txtTelefone.Focus();
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            lista.Items.Clear();
            
            foreach (Clientes c in clientes)
            {
                lista.Items.Add(c.Nome);
                lista.Items.Add(c.Sobrenome);
                lista.Items.Add(c.Telefone);
            }
        }
    }
}
