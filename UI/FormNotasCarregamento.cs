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
    public partial class FormNotasCarregamento : Form
    {
        public FormNotasCarregamento()
        {
            InitializeComponent();
        }

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            if (txtIdNota.Text != "")
            {
                nota.Id = int.Parse(txtIdNota.Text);
            }
            nota.CodRomaneio = txtCodigoRomaneioNota.Text;
            nota.Fornecedor = txtFornecedorNota.Text;
            nota.Recebedor = txtRecebedorNota.Text;
            nota.NomeMotorista = txtNomeNota.Text;
            nota.Carro = txtCarroNota.Text;
            nota.Placa = txtPlacaNota.Text;
            nota.Salvar();
        }


        private void btnPesquisarNota_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            if (!txtIdNota.Text.Equals(""))
            {
                nota.Id = int.Parse(txtIdNota.Text);
            }

            if (!txtCodigoRomaneioNota.Text.Equals(""))
            {
                nota.CodRomaneio = txtCodigoRomaneioNota.Text;
            }

            if (!txtRecebedorNota.Text.Equals(""))
            {
                nota.Recebedor = txtRecebedorNota.Text;
            }

            if (!txtFornecedorNota.Text.Equals(""))
            {
                nota.Fornecedor = txtFornecedorNota.Text;
            }

            if (!txtNomeNota.Text.Equals(""))
            {
                nota.NomeMotorista = txtNomeNota.Text;
            }

            if (!txtCarroNota.Text.Equals(""))
            {
                nota.Carro = txtCarroNota.Text;
            }

            if (!txtPlacaNota.Text.Equals(""))
            {
                nota.Placa = txtPlacaNota.Text;
            }

            foreach (Nota not in nota.Busca())
            {
                txtIdNota.Text = not.Id.ToString();
                txtCodigoRomaneioNota.Text = not.CodRomaneio;
                txtRecebedorNota.Text = not.Recebedor;
                txtFornecedorNota.Text = not.Fornecedor;
                txtNomeNota.Text = not.NomeMotorista;
                txtCarroNota.Text = not.Carro;
                txtPlacaNota.Text = not.Placa;
            }
        }

        private void btnExcluirNota_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Tem certeza que deseja excluir", "Excluir", MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                Nota not = new Nota();
                not.Id = int.Parse(txtIdNota.Text);
                not.Excluir();
                txtIdNota.Text = "";
                txtCodigoRomaneioNota.Text = "";
                txtRecebedorNota.Text = "";
                txtFornecedorNota.Text = "";
                txtNomeNota.Text = "";
                txtCarroNota.Text = "";
                txtPlacaNota.Text = "";
            }
        }

        private void lblCargas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCargas telaCargas = new FormCargas();
            telaCargas.ShowDialog();
            this.Close();
        }

        private void lblFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFuncionarios telafuncionarios = new FormFuncionarios();
            telafuncionarios.ShowDialog();
            this.Close();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClientes telaclientes = new FormClientes();
            telaclientes.ShowDialog();
            this.Close();
        }
        private void lblRegistrosNC_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrosNotasCarregamento telaRegistrosClientes = new FormRegistrosNotasCarregamento();
            telaRegistrosClientes.ShowDialog();
            this.Close();
        }

        private void lblRegistrosNC_MouseEnter(object sender, EventArgs e)
        {
            lblRegistrosNC.Font = new Font(lblRegistrosNC.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblRegistrosNC_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrosNC.Font = new Font(lblRegistrosNC.Font, FontStyle.Bold | FontStyle.Regular);
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
