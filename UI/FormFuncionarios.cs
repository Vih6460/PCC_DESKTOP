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
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            if (txtIdFuncionario.Text != "")
            {
                funcionario.Id = int.Parse(txtIdFuncionario.Text);
            }
            funcionario.NomeMotorista = txtNomeMotoristaFuncionario.Text;
            funcionario.Carro = txtCarroFuncionario.Text;
            funcionario.Placa = txtPlacaFuncionario.Text;
            funcionario.Cnh = txtCnhFuncionario.Text;
            funcionario.Cpf = txtCpfFuncionario.Text;
            funcionario.Whatsapp = txtWhatsappFuncionario.Text;
            funcionario.Salvar();

            MessageBox.Show("Funcionário cadastrado com sucesso !", "H GOLD Log Transportes");
            txtNomeMotoristaFuncionario.Text = "";
            txtCarroFuncionario.Text = "";
            txtPlacaFuncionario.Text = "";
            txtCnhFuncionario.Text = "";
            txtCpfFuncionario.Text = "";
            txtWhatsappFuncionario.Text = "";
        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            if (!txtIdFuncionario.Text.Equals(""))
            {
                funcionario.Id = int.Parse(txtIdFuncionario.Text);
            }

            if (!txtNomeMotoristaFuncionario.Text.Equals(""))
            {
                funcionario.NomeMotorista = txtNomeMotoristaFuncionario.Text;
            }

            if (!txtCarroFuncionario.Text.Equals(""))
            {
                funcionario.Carro = txtCarroFuncionario.Text;
            }

            if (!txtPlacaFuncionario.Text.Equals(""))
            {
                funcionario.Placa = txtPlacaFuncionario.Text;
            }

            if (!txtCnhFuncionario.Text.Equals(""))
            {
                funcionario.Cnh = txtCnhFuncionario.Text;
            }

            if (!txtCpfFuncionario.Text.Equals(""))
            {
                funcionario.Cpf = txtCpfFuncionario.Text;
            }

            if (!txtWhatsappFuncionario.Text.Equals(""))
            {
                funcionario.Whatsapp = txtWhatsappFuncionario.Text;
            }

            foreach (Funcionario fun in funcionario.Busca())
            {
                txtIdFuncionario.Text = fun.Id.ToString();
                txtNomeMotoristaFuncionario.Text = fun.NomeMotorista;
                txtCarroFuncionario.Text = fun.Carro;
                txtPlacaFuncionario.Text = fun.Placa;
                txtCnhFuncionario.Text = fun.Cnh;
                txtCpfFuncionario.Text = fun.Cpf;
                txtWhatsappFuncionario.Text = fun.Whatsapp;
            }
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Tem certeza que deseja excluir", "Excluir", MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                Funcionario fun = new Funcionario();
                fun.Id = int.Parse(txtIdFuncionario.Text);
                fun.Excluir();
                txtIdFuncionario.Text = "";
                txtNomeMotoristaFuncionario.Text = "";
                txtCarroFuncionario.Text = "";
                txtPlacaFuncionario.Text = "";
                txtCnhFuncionario.Text = "";
                txtCpfFuncionario.Text = "";
                txtWhatsappFuncionario.Text = "";
            }
        }

        private void lblRegistrosFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrosFuncionarios telaRegistrosFuncionarios = new FormRegistrosFuncionarios();
            telaRegistrosFuncionarios.ShowDialog();
            this.Close();
        }

        private void lblNotaCarregamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNotasCarregamento telaNotas = new FormNotasCarregamento();
            telaNotas.ShowDialog();
            this.Close();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClientes telaClientes = new FormClientes();
            telaClientes.ShowDialog();
            this.Close();
        }

        private void lblCargas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCargas telaCargas = new FormCargas();
            telaCargas.ShowDialog();
            this.Close();
        }

        private void lblRegistrosFuncionarios_MouseEnter(object sender, EventArgs e)
        {
            lblRegistrosFuncionarios.Font = new Font(lblRegistrosFuncionarios.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblRegistrosFuncionarios_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrosFuncionarios.Font = new Font(lblRegistrosFuncionarios.Font, FontStyle.Bold | FontStyle.Regular);
        }

        private void lblNotaCarregamento_MouseEnter(object sender, EventArgs e)
        {
            lblNotaCarregamento.Font = new Font(lblNotaCarregamento.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblNotaCarregamento_MouseLeave(object sender, EventArgs e)
        {
            lblNotaCarregamento.Font = new Font(lblNotaCarregamento.Font, FontStyle.Bold | FontStyle.Regular);

        }

        private void lblClientes_MouseEnter(object sender, EventArgs e)
        {
            lblClientes.Font = new Font(lblClientes.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblClientes_MouseLeave(object sender, EventArgs e)
        {
            lblClientes.Font = new Font(lblClientes.Font, FontStyle.Bold | FontStyle.Regular);
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
