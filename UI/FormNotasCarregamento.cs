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

//iTextSharp
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf; 

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

            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);

            string now = DateTime.Now.ToString();
            now = now.Replace(" ", "");
            now = now.Replace("/", "");
            now = now.Replace(":", "");
            string caminho = @"C:\Users\Marcos Vinicius\Documents\Unifaat\PCC\NotasCarregamento\Motorista=" + nota.NomeMotorista + "_" + now + ".pdf";
            _ = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            string simg = "https://raw.githubusercontent.com/Vih6460/PCC-Unifaat/master/PCC/src/img/logohgold.jpg";
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(simg);
            img.ScaleAbsolute(256, 192);
            img.Alignment = Element.ALIGN_CENTER;
            doc.Add(img);

            Paragraph titulo1 = new Paragraph();
            titulo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 30);
            titulo1.Alignment = Element.ALIGN_CENTER;
            titulo1.Add("\n\nH GOLD Log Transportes Ltda.\n\n");
            doc.Add(titulo1);

            Paragraph dadosHGold = new Paragraph();
            dadosHGold.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 15);
            dadosHGold.Add("CNPJ: 14.238.200/0001-91\nEndereço: Rua Tuiuti, 258 - Tatuapé\nCidade: São Paulo - SP\nCEP: 03081-003\nTelefone: (11) 2093-5177\nEmail: contato@hgold.com\n\n\n");
            doc.Add(dadosHGold);

            Paragraph titulo2 = new Paragraph();
            titulo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 25);
            titulo2.Alignment = Element.ALIGN_CENTER;
            titulo2.Add("Nota de Carregamento\n\n\n");
            doc.Add(titulo2);

            Paragraph pdadosCarga = new Paragraph();
            pdadosCarga.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20);
            pdadosCarga.Add("Dados da Carga\n\n");
            doc.Add(pdadosCarga);

            Paragraph dadosCarga = new Paragraph();
            dadosCarga.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 15);
            dadosCarga.Add("Código Romaneio: " + nota.CodRomaneio + "\nCliente Recebedor: " + nota.Recebedor + "\nCliente Fornecedor: " + nota.Fornecedor + "\n\n\n");
            doc.Add(dadosCarga);

            Paragraph pdadosMotorista = new Paragraph();
            pdadosMotorista.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20);
            pdadosMotorista.Add("Dados do Motorista\n\n");
            doc.Add(pdadosMotorista);

            Paragraph dadosMotorista = new Paragraph();
            dadosMotorista.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 15);
            dadosMotorista.Add("Nome: " + nota.NomeMotorista + "\nCarro: " + nota.Carro + "\nPlaca: " + nota.Placa + "\n\n");
            doc.Add(dadosMotorista);

            doc.Close();

            var open = MessageBox.Show("Deseja abrir agora a Nota de Carregamento ?", "NC EMITIDA COM SUCESSO !", MessageBoxButtons.YesNo);
            if (open == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(caminho);
                txtIdNota.Text = "";
                txtCodigoRomaneioNota.Text = "";
                txtRecebedorNota.Text = "";
                txtFornecedorNota.Text = "";
                txtNomeNota.Text = "";
                txtCarroNota.Text = "";
                txtPlacaNota.Text = "";
            }
            else
            {
                txtIdNota.Text = "";
                txtCodigoRomaneioNota.Text = "";
                txtRecebedorNota.Text = "";
                txtFornecedorNota.Text = "";
                txtNomeNota.Text = "";
                txtCarroNota.Text = "";
                txtPlacaNota.Text = "";
            }


                
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
            lblRegistrosNC.Font = new System.Drawing.Font(lblRegistrosNC.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblRegistrosNC_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrosNC.Font = new System.Drawing.Font(lblRegistrosNC.Font, FontStyle.Bold | FontStyle.Regular);
        }

        private void lblClientes_MouseEnter(object sender, EventArgs e)
        {
            lblClientes.Font = new System.Drawing.Font(lblClientes.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblClientes_MouseLeave(object sender, EventArgs e)
        {
            lblClientes.Font = new System.Drawing.Font(lblClientes.Font, FontStyle.Bold | FontStyle.Regular);
        }

        private void lblFuncionarios_MouseEnter(object sender, EventArgs e)
        {
            lblFuncionarios.Font = new System.Drawing.Font(lblFuncionarios.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblFuncionarios_MouseLeave(object sender, EventArgs e)
        {
            lblFuncionarios.Font = new System.Drawing.Font(lblFuncionarios.Font, FontStyle.Bold | FontStyle.Regular);
        }

        private void lblCargas_MouseEnter(object sender, EventArgs e)
        {
            lblCargas.Font = new System.Drawing.Font(lblCargas.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblCargas_MouseLeave(object sender, EventArgs e)
        {
            lblCargas.Font = new System.Drawing.Font(lblCargas.Font, FontStyle.Bold | FontStyle.Regular);
        }
    }
}
