
namespace H_GOLD_Transportes_Ltda
{
    partial class FormRegistrosNotasCarregamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDadosNotas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodRomaneio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recebedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRegistrosNC = new System.Windows.Forms.Label();
            this.lblEmitirNC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCargas = new System.Windows.Forms.Label();
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblNotaCarregamento = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDadosNotas
            // 
            this.dgvDadosNotas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDadosNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodRomaneio,
            this.Recebedor,
            this.Fornecedor,
            this.NomeMotorista,
            this.Carro,
            this.Placa});
            this.dgvDadosNotas.Location = new System.Drawing.Point(230, 134);
            this.dgvDadosNotas.Name = "dgvDadosNotas";
            this.dgvDadosNotas.Size = new System.Drawing.Size(527, 304);
            this.dgvDadosNotas.TabIndex = 60;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // CodRomaneio
            // 
            this.CodRomaneio.DataPropertyName = "CodRomaneio";
            this.CodRomaneio.HeaderText = "CodRomaneio";
            this.CodRomaneio.Name = "CodRomaneio";
            // 
            // Recebedor
            // 
            this.Recebedor.DataPropertyName = "Recebedor";
            this.Recebedor.HeaderText = "Recebedor";
            this.Recebedor.Name = "Recebedor";
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // NomeMotorista
            // 
            this.NomeMotorista.DataPropertyName = "NomeMotorista";
            this.NomeMotorista.HeaderText = "NomeMotorista";
            this.NomeMotorista.Name = "NomeMotorista";
            // 
            // Carro
            // 
            this.Carro.DataPropertyName = "Carro";
            this.Carro.HeaderText = "Carro";
            this.Carro.Name = "Carro";
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox4.Location = new System.Drawing.Point(488, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(5, 28);
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "Motorista";
            // 
            // lblRegistrosNC
            // 
            this.lblRegistrosNC.AutoSize = true;
            this.lblRegistrosNC.BackColor = System.Drawing.Color.DarkGray;
            this.lblRegistrosNC.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosNC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistrosNC.Location = new System.Drawing.Point(540, 71);
            this.lblRegistrosNC.Name = "lblRegistrosNC";
            this.lblRegistrosNC.Size = new System.Drawing.Size(129, 28);
            this.lblRegistrosNC.TabIndex = 49;
            this.lblRegistrosNC.Text = "Registros";
            // 
            // lblEmitirNC
            // 
            this.lblEmitirNC.AutoSize = true;
            this.lblEmitirNC.BackColor = System.Drawing.Color.DarkGray;
            this.lblEmitirNC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmitirNC.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmitirNC.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmitirNC.Location = new System.Drawing.Point(317, 71);
            this.lblEmitirNC.Name = "lblEmitirNC";
            this.lblEmitirNC.Size = new System.Drawing.Size(137, 28);
            this.lblEmitirNC.TabIndex = 47;
            this.lblEmitirNC.Text = "Emitir NC";
            this.lblEmitirNC.Click += new System.EventHandler(this.lblEmitirNC_Click);
            this.lblEmitirNC.MouseEnter += new System.EventHandler(this.lblEmitirNC_MouseEnter);
            this.lblEmitirNC.MouseLeave += new System.EventHandler(this.lblEmitirNC_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(236, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Registros de Nota de Carregamento";
            // 
            // lblCargas
            // 
            this.lblCargas.AutoSize = true;
            this.lblCargas.BackColor = System.Drawing.Color.Black;
            this.lblCargas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCargas.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargas.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCargas.Location = new System.Drawing.Point(63, 324);
            this.lblCargas.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblCargas.Name = "lblCargas";
            this.lblCargas.Size = new System.Drawing.Size(83, 24);
            this.lblCargas.TabIndex = 43;
            this.lblCargas.Text = "Cargas";
            this.lblCargas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCargas.Click += new System.EventHandler(this.lblCargas_Click);
            this.lblCargas.MouseEnter += new System.EventHandler(this.lblCargas_MouseEnter);
            this.lblCargas.MouseLeave += new System.EventHandler(this.lblCargas_MouseLeave);
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.BackColor = System.Drawing.Color.Black;
            this.lblFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFuncionarios.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarios.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFuncionarios.Location = new System.Drawing.Point(27, 283);
            this.lblFuncionarios.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(153, 24);
            this.lblFuncionarios.TabIndex = 40;
            this.lblFuncionarios.Text = "Funcionários";
            this.lblFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFuncionarios.Click += new System.EventHandler(this.lblFuncionarios_Click);
            this.lblFuncionarios.MouseEnter += new System.EventHandler(this.lblFuncionarios_MouseEnter);
            this.lblFuncionarios.MouseLeave += new System.EventHandler(this.lblFuncionarios_MouseLeave);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.Black;
            this.lblClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientes.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.DarkGray;
            this.lblClientes.Location = new System.Drawing.Point(54, 238);
            this.lblClientes.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(100, 24);
            this.lblClientes.TabIndex = 38;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            this.lblClientes.MouseEnter += new System.EventHandler(this.lblClientes_MouseEnter);
            this.lblClientes.MouseLeave += new System.EventHandler(this.lblClientes_MouseLeave);
            // 
            // lblNotaCarregamento
            // 
            this.lblNotaCarregamento.AutoSize = true;
            this.lblNotaCarregamento.BackColor = System.Drawing.Color.Black;
            this.lblNotaCarregamento.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNotaCarregamento.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaCarregamento.ForeColor = System.Drawing.Color.Yellow;
            this.lblNotaCarregamento.Location = new System.Drawing.Point(24, 165);
            this.lblNotaCarregamento.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblNotaCarregamento.Name = "lblNotaCarregamento";
            this.lblNotaCarregamento.Size = new System.Drawing.Size(164, 48);
            this.lblNotaCarregamento.TabIndex = 37;
            this.lblNotaCarregamento.Text = "Notas de Carregamento";
            this.lblNotaCarregamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::H_GOLD_Transportes_Ltda.Properties.Resources.logohgold1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(22, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 99);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(218, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(552, 455);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 455);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistrosNotasCarregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.dgvDadosNotas);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRegistrosNC);
            this.Controls.Add(this.lblEmitirNC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCargas);
            this.Controls.Add(this.lblFuncionarios);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblNotaCarregamento);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRegistrosNotasCarregamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H GOLD Log Transportes Ltda.";
            this.Load += new System.EventHandler(this.FormRegistrosNotasCrregamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDadosNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRomaneio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recebedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRegistrosNC;
        private System.Windows.Forms.Label lblEmitirNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCargas;
        private System.Windows.Forms.Label lblFuncionarios;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblNotaCarregamento;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}