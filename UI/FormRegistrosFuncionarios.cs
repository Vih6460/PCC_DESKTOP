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
    public partial class FormRegistrosFuncionarios : Form
    {
        public FormRegistrosFuncionarios()
        {
            InitializeComponent();
        }

        private void FormRegistrosFuncionarios_Load(object sender, EventArgs e)
        {
            carrega_datagridview();
        }

        private void carrega_datagridview()
        {
            dgvDadosFuncionarios.AutoGenerateColumns = false;
            dgvDadosFuncionarios.DataSource = new Funcionario().Todos();
        }

        private void lblCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFuncionarios telaFuncionarios = new FormFuncionarios();
            telaFuncionarios.ShowDialog();
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

        private void lblCadastrarFuncionario_MouseEnter(object sender, EventArgs e)
        {
            lblCadastrarFuncionario.Font = new Font(lblCadastrarFuncionario.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblCadastrarFuncionario_MouseLeave(object sender, EventArgs e)
        {
            lblCadastrarFuncionario.Font = new Font(lblCadastrarFuncionario.Font, FontStyle.Bold | FontStyle.Regular);
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
