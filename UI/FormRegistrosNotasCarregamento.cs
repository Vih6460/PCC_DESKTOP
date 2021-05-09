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
    public partial class FormRegistrosNotasCarregamento : Form
    {
        public FormRegistrosNotasCarregamento()
        {
            InitializeComponent();
        }

        private void FormRegistrosNotasCrregamentos_Load(object sender, EventArgs e)
        {
            carrega_datagridview();
        }

        private void carrega_datagridview()
        {
            dgvDadosNotas.AutoGenerateColumns = false;
            dgvDadosNotas.DataSource = new Nota().Todos();
        }

        private void lblEmitirNC_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNotasCarregamento telaClientes = new FormNotasCarregamento();
            telaClientes.ShowDialog();
            this.Close();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClientes telaclientes = new FormClientes();
            telaclientes.ShowDialog();
            this.Close();
        }

        private void lblFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFuncionarios telafuncionarios = new FormFuncionarios();
            telafuncionarios.ShowDialog();
            this.Close();
        }

        private void lblCargas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCargas telaCargas = new FormCargas();
            telaCargas.ShowDialog();
            this.Close();
        }

        private void lblEmitirNC_MouseEnter(object sender, EventArgs e)
        {
            lblEmitirNC.Font = new Font(lblEmitirNC.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblEmitirNC_MouseLeave(object sender, EventArgs e)
        {
            lblEmitirNC.Font = new Font(lblEmitirNC.Font, FontStyle.Bold | FontStyle.Regular);
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
