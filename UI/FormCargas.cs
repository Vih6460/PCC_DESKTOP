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
    public partial class FormCargas : Form
    {
        public FormCargas()
        {
            InitializeComponent();
        }

        private void btnSalvarCarga_Click(object sender, EventArgs e)
        {
            Carga carga = new Carga();
            if (txtIdCarga.Text != "")
            {
                carga.Id = int.Parse(txtIdCarga.Text);
            }
            carga.CodRomaneio = txtCodigoRomaneioCarga.Text;
            carga.Descricao = txtDescricaoCarga.Text;
            carga.Peso = txtPesoCarga.Text;
            carga.Salvar();

            MessageBox.Show("Carga cadastrada com sucesso !", "H GOLD Log Transportes");
            txtCodigoRomaneioCarga.Text = "";
            txtDescricaoCarga.Text = "";
            txtPesoCarga.Text = "";
        }

        private void btnPesquisarCarga_Click(object sender, EventArgs e)
        {
            Carga carga = new Carga();
            if (!txtIdCarga.Text.Equals(""))
            {
                carga.Id = int.Parse(txtIdCarga.Text);
            }

            if (!txtCodigoRomaneioCarga.Text.Equals(""))
            {
                carga.CodRomaneio = txtCodigoRomaneioCarga.Text;
            }

            if (!txtDescricaoCarga.Text.Equals(""))
            {
                carga.Descricao = txtDescricaoCarga.Text;
            }

            if (!txtPesoCarga.Text.Equals(""))
            {
                carga.Peso = txtPesoCarga.Text;
            }

            foreach (Carga carg in carga.Busca())
            {
                txtIdCarga.Text = carg.Id.ToString();
                txtCodigoRomaneioCarga.Text = carg.CodRomaneio;
                txtDescricaoCarga.Text = carg.Descricao;
                txtPesoCarga.Text = carg.Peso;
            }
        }

        private void btnExcluirCarga_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Tem certeza que deseja excluir", "Excluir", MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                Carga carg = new Carga();
                carg.Id = int.Parse(txtIdCarga.Text);
                carg.Excluir();
                txtIdCarga.Text = "";
                txtCodigoRomaneioCarga.Text = "";
                txtDescricaoCarga.Text = "";
                txtPesoCarga.Text = "";
            }
        }

        private void lblRegistrosCargas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrosCargas telaRegistrosCargas = new FormRegistrosCargas();
            telaRegistrosCargas.ShowDialog();
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

        private void lblRegistrosCargas_MouseEnter(object sender, EventArgs e)
        {
            lblRegistrosCargas.Font = new Font(lblRegistrosCargas.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblRegistrosCargas_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrosCargas.Font = new Font(lblRegistrosCargas.Font, FontStyle.Bold | FontStyle.Regular);
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
