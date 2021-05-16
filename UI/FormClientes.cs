using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace H_GOLD_Transportes_Ltda
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (txtIdCliente.Text != "")
            {
                cliente.Id = int.Parse(txtIdCliente.Text);
            }
            cliente.NomeCliente = txtNomeCliente.Text;
            cliente.Endereco = txtEnderecoCliente.Text;
            cliente.Cep = txtCepCliente.Text;
            cliente.Tel = txtTelefoneCliente.Text;
            cliente.Cnpj = txtCnpjCliente.Text;
            cliente.Salvar();

            MessageBox.Show("Cliente cadastrado com sucesso !", "H GOLD Log Transportes");
            txtNomeCliente.Text = "";
            txtEnderecoCliente.Text = "";
            txtCepCliente.Text = "";
            txtTelefoneCliente.Text = "";
            txtCnpjCliente.Text = "";
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (!txtIdCliente.Text.Equals(""))
            {
                cliente.Id = int.Parse(txtIdCliente.Text);
            }

            if (!txtNomeCliente.Text.Equals(""))
            {
                cliente.NomeCliente = txtNomeCliente.Text;
            }

            if (!txtEnderecoCliente.Text.Equals(""))
            {
                cliente.Endereco = txtEnderecoCliente.Text;
            }

            if (!txtCepCliente.Text.Equals(""))
            {
                cliente.Cep = txtCepCliente.Text;
            }

            if (!txtTelefoneCliente.Text.Equals(""))
            {
                cliente.Tel = txtTelefoneCliente.Text;
            }

            if (!txtCnpjCliente.Text.Equals(""))
            {
                cliente.Cnpj = txtCnpjCliente.Text;
            }

            foreach (Cliente cli in cliente.Busca())
            {
                txtIdCliente.Text = cli.Id.ToString();
                txtNomeCliente.Text = cli.NomeCliente;
                txtEnderecoCliente.Text = cli.Endereco;
                txtCepCliente.Text = cli.Cep;
                txtTelefoneCliente.Text = cli.Tel;
                txtCnpjCliente.Text = cli.Cnpj;
            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Tem certeza que deseja excluir", "Excluir", MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                Cliente cli = new Cliente();
                cli.Id = int.Parse(txtIdCliente.Text);
                cli.Excluir();
                txtIdCliente.Text = "";
                txtNomeCliente.Text = "";
                txtEnderecoCliente.Text = "";
                txtCepCliente.Text = "";
                txtTelefoneCliente.Text = "";
                txtCnpjCliente.Text = "";
            }
        }

        private void lblRegistrosClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrosClientes telaRegistrosClientes = new FormRegistrosClientes();
            telaRegistrosClientes.ShowDialog();
            this.Close();
        }

        private void lblNotaCarregamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNotasCarregamento telaNotas = new FormNotasCarregamento();
            telaNotas.ShowDialog();
            this.Close();
        }

        private void lblFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFuncionarios telaFuncionarios = new FormFuncionarios();
            telaFuncionarios.ShowDialog();
            this.Close();
        }

        private void lblCargas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCargas telaCargas = new FormCargas();
            telaCargas.ShowDialog();
            this.Close();
        }

        private void lblRegistrosClientes_MouseEnter(object sender, EventArgs e)
        {
            lblRegistrosClientes.Font = new Font(lblRegistrosClientes.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblRegistrosClientes_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrosClientes.Font = new Font(lblRegistrosClientes.Font, FontStyle.Bold | FontStyle.Regular);
        }

        private void lblNotaCarregamento_MouseEnter(object sender, EventArgs e)
        {
            lblNotaCarregamento.Font = new Font(lblNotaCarregamento.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblNotaCarregamento_MouseLeave(object sender, EventArgs e)
        {
            lblNotaCarregamento.Font = new Font(lblNotaCarregamento.Font, FontStyle.Bold | FontStyle.Regular);
        }

        private void lblFuncionarios_MouseEnter(object sender, EventArgs e)
        {
            lblFuncionarios.Font = new Font(lblFuncionarios.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblFuncionarios_MouseLeave(object sender, EventArgs e)
        {
            lblFuncionarios.Font = new Font(lblFuncionarios.Font, FontStyle.Bold | FontStyle.Regular);
        }

        private void lblCargas_MouseEnter(object sender, EventArgs e)
        {
            lblCargas.Font = new Font(lblCargas.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblCargas_MouseLeave(object sender, EventArgs e)
        {
            lblCargas.Font = new Font(lblCargas.Font, FontStyle.Bold | FontStyle.Regular);
        }
    }
}
