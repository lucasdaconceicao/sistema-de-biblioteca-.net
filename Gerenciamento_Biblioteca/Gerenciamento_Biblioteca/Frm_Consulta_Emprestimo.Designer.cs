namespace Gerenciamento_Biblioteca
{
    partial class Frm_Consulta_Emprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consulta_Emprestimo));
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_LIVRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_ALUGADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_DEVOLUCAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtBusca.Location = new System.Drawing.Point(2, 28);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(325, 20);
            this.txtBusca.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(333, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 25);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.AllowUserToAddRows = false;
            this.dgvEmprestimos.AllowUserToDeleteRows = false;
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD,
            this.NOME_CLIENTE,
            this.NOME_LIVRO,
            this.DATA_ALUGADA,
            this.DATA_DEVOLUCAO});
            this.dgvEmprestimos.Location = new System.Drawing.Point(2, 54);
            this.dgvEmprestimos.MultiSelect = false;
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.ReadOnly = true;
            this.dgvEmprestimos.ShowCellErrors = false;
            this.dgvEmprestimos.ShowCellToolTips = false;
            this.dgvEmprestimos.ShowEditingIcon = false;
            this.dgvEmprestimos.ShowRowErrors = false;
            this.dgvEmprestimos.Size = new System.Drawing.Size(771, 312);
            this.dgvEmprestimos.TabIndex = 2;
            // 
            // COD
            // 
            this.COD.FillWeight = 1000F;
            this.COD.HeaderText = "COD";
            this.COD.Name = "COD";
            this.COD.ReadOnly = true;
            this.COD.Width = 50;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.HeaderText = "NOME CLIENTE";
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.ReadOnly = true;
            this.NOME_CLIENTE.Width = 190;
            // 
            // NOME_LIVRO
            // 
            this.NOME_LIVRO.HeaderText = "NOME LIVRO";
            this.NOME_LIVRO.Name = "NOME_LIVRO";
            this.NOME_LIVRO.ReadOnly = true;
            this.NOME_LIVRO.Width = 190;
            // 
            // DATA_ALUGADA
            // 
            this.DATA_ALUGADA.HeaderText = "DATA ALUGADA";
            this.DATA_ALUGADA.Name = "DATA_ALUGADA";
            this.DATA_ALUGADA.ReadOnly = true;
            this.DATA_ALUGADA.Width = 150;
            // 
            // DATA_DEVOLUCAO
            // 
            this.DATA_DEVOLUCAO.HeaderText = "DATA DEVOLUÇÃO";
            this.DATA_DEVOLUCAO.Name = "DATA_DEVOLUCAO";
            this.DATA_DEVOLUCAO.ReadOnly = true;
            this.DATA_DEVOLUCAO.Width = 150;
            // 
            // btnRenovar
            // 
            this.btnRenovar.BackColor = System.Drawing.Color.Transparent;
            this.btnRenovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovar.Location = new System.Drawing.Point(682, 369);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(91, 33);
            this.btnRenovar.TabIndex = 86;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = false;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(596, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 33);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Voltar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "Digite  aqui um cliente";
            // 
            // Frm_Consulta_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvEmprestimos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Consulta_Emprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Emprestimos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_LIVRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ALUGADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_DEVOLUCAO;
    }
}