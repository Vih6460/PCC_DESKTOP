
namespace H_GOLD_Transportes_Ltda
{
    partial class FormRegistrosCargas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrosCargas));
            this.dgvDadosCargas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodRomaneio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRegistrosCargas = new System.Windows.Forms.Label();
            this.lblCadastrarCarga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCargas = new System.Windows.Forms.Label();
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblNotaCarregamento = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCargas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDadosCargas
            // 
            this.dgvDadosCargas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDadosCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosCargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodRomaneio,
            this.Descricao,
            this.Peso});
            this.dgvDadosCargas.Location = new System.Drawing.Point(235, 132);
            this.dgvDadosCargas.Name = "dgvDadosCargas";
            this.dgvDadosCargas.Size = new System.Drawing.Size(523, 306);
            this.dgvDadosCargas.TabIndex = 86;
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
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 180;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 84;
            this.label8.Text = "Motorista";
            // 
            // lblRegistrosCargas
            // 
            this.lblRegistrosCargas.AutoSize = true;
            this.lblRegistrosCargas.BackColor = System.Drawing.Color.DarkGray;
            this.lblRegistrosCargas.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosCargas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistrosCargas.Location = new System.Drawing.Point(576, 70);
            this.lblRegistrosCargas.Name = "lblRegistrosCargas";
            this.lblRegistrosCargas.Size = new System.Drawing.Size(129, 28);
            this.lblRegistrosCargas.TabIndex = 78;
            this.lblRegistrosCargas.Text = "Registros";
            // 
            // lblCadastrarCarga
            // 
            this.lblCadastrarCarga.AutoSize = true;
            this.lblCadastrarCarga.BackColor = System.Drawing.Color.DarkGray;
            this.lblCadastrarCarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastrarCarga.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarCarga.ForeColor = System.Drawing.Color.DimGray;
            this.lblCadastrarCarga.Location = new System.Drawing.Point(287, 70);
            this.lblCadastrarCarga.Name = "lblCadastrarCarga";
            this.lblCadastrarCarga.Size = new System.Drawing.Size(211, 28);
            this.lblCadastrarCarga.TabIndex = 76;
            this.lblCadastrarCarga.Text = "Cadastrar Carga";
            this.lblCadastrarCarga.Click += new System.EventHandler(this.lblCadastrarCarga_Click);
            this.lblCadastrarCarga.MouseEnter += new System.EventHandler(this.lblCadastrarCarga_MouseEnter);
            this.lblCadastrarCarga.MouseLeave += new System.EventHandler(this.lblCadastrarCarga_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(355, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 74;
            this.label1.Text = "Registro de Cargas";
            // 
            // lblCargas
            // 
            this.lblCargas.AutoSize = true;
            this.lblCargas.BackColor = System.Drawing.Color.Black;
            this.lblCargas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCargas.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargas.ForeColor = System.Drawing.Color.Yellow;
            this.lblCargas.Location = new System.Drawing.Point(62, 319);
            this.lblCargas.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblCargas.Name = "lblCargas";
            this.lblCargas.Size = new System.Drawing.Size(83, 24);
            this.lblCargas.TabIndex = 73;
            this.lblCargas.Text = "Cargas";
            this.lblCargas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.BackColor = System.Drawing.Color.Black;
            this.lblFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFuncionarios.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarios.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFuncionarios.Location = new System.Drawing.Point(24, 278);
            this.lblFuncionarios.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(153, 24);
            this.lblFuncionarios.TabIndex = 72;
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
            this.lblClientes.Location = new System.Drawing.Point(51, 234);
            this.lblClientes.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(100, 24);
            this.lblClientes.TabIndex = 70;
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
            this.lblNotaCarregamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotaCarregamento.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaCarregamento.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNotaCarregamento.Location = new System.Drawing.Point(24, 163);
            this.lblNotaCarregamento.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblNotaCarregamento.Name = "lblNotaCarregamento";
            this.lblNotaCarregamento.Size = new System.Drawing.Size(164, 48);
            this.lblNotaCarregamento.TabIndex = 69;
            this.lblNotaCarregamento.Text = "Notas de Carregamento";
            this.lblNotaCarregamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotaCarregamento.Click += new System.EventHandler(this.lblNotaCarregamento_Click);
            this.lblNotaCarregamento.MouseEnter += new System.EventHandler(this.lblNotaCarregamento_MouseEnter);
            this.lblNotaCarregamento.MouseLeave += new System.EventHandler(this.lblNotaCarregamento_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox4.Location = new System.Drawing.Point(524, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(5, 28);
            this.pictureBox4.TabIndex = 85;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::H_GOLD_Transportes_Ltda.Properties.Resources.logohgold1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(28, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 99);
            this.pictureBox3.TabIndex = 67;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(217, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(557, 455);
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 455);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistrosCargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.dgvDadosCargas);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRegistrosCargas);
            this.Controls.Add(this.lblCadastrarCarga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCargas);
            this.Controls.Add(this.lblFuncionarios);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblNotaCarregamento);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistrosCargas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H GOLD Log Transportes Ltda.";
            this.Load += new System.EventHandler(this.FormRegistrosCargas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCargas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDadosCargas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRegistrosCargas;
        private System.Windows.Forms.Label lblCadastrarCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCargas;
        private System.Windows.Forms.Label lblFuncionarios;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblNotaCarregamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRomaneio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
    }
}