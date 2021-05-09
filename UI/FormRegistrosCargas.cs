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
    public partial class FormRegistrosCargas : Form
    {
        public FormRegistrosCargas()
        {
            InitializeComponent();
        }

        private void FormRegistrosCargas_Load(object sender, EventArgs e)
        {
            carrega_datagridview();
        }

        private void carrega_datagridview()
        {
            dgvDadosCargas.AutoGenerateColumns = false;
            dgvDadosCargas.DataSource = new Carga().Todos();
        }

        private void lblCadastrarCarga_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCargas telaCargas = new FormCargas();
            telaCargas.ShowDialog();
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

        private void lblFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFuncionarios telaFuncionarios = new FormFuncionarios();
            telaFuncionarios.ShowDialog();
            this.Close();
        }

        private void lblCadastrarCarga_MouseEnter(object sender, EventArgs e)
        {
            lblCadastrarCarga.Font = new Font(lblCadastrarCarga.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblCadastrarCarga_MouseLeave(object sender, EventArgs e)
        {
            lblCadastrarCarga.Font = new Font(lblCadastrarCarga.Font, FontStyle.Bold | FontStyle.Regular);
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

        private void lblFuncionarios_MouseEnter(object sender, EventArgs e)
        {
            lblFuncionarios.Font = new Font(lblFuncionarios.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblFuncionarios_MouseLeave(object sender, EventArgs e)
        {
            lblFuncionarios.Font = new Font(lblFuncionarios.Font, FontStyle.Bold | FontStyle.Regular);
        }
    }
}
