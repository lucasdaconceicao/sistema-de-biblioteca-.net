﻿namespace Gerenciamento_Biblioteca
{
    partial class Frm_Consulta_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consulta_Clientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeBusca = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.ENDERECO,
            this.CIDADE,
            this.ESTADO,
            this.TELEFONE,
            this.STATUS,
            this.CPF});
            this.dgvClientes.Location = new System.Drawing.Point(1, 80);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(722, 310);
            this.dgvClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Digite o nome do cliente aqui";
            // 
            // txtNomeBusca
            // 
            this.txtNomeBusca.Location = new System.Drawing.Point(46, 36);
            this.txtNomeBusca.Name = "txtNomeBusca";
            this.txtNomeBusca.Size = new System.Drawing.Size(276, 20);
            this.txtNomeBusca.TabIndex = 80;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(328, 30);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(80, 30);
            this.btnBusca.TabIndex = 79;
            this.btnBusca.Text = "BUSCAR";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCadastrar.Location = new System.Drawing.Point(621, 416);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 33);
            this.btnCadastrar.TabIndex = 83;
            this.btnCadastrar.Text = "EDITAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Cyan;
            this.btnCancelar.Location = new System.Drawing.Point(534, 416);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 33);
            this.btnCancelar.TabIndex = 82;
            this.btnCancelar.Text = "VOLTAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 200;
            // 
            // ENDERECO
            // 
            this.ENDERECO.HeaderText = "ENDERECO";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.ReadOnly = true;
            this.ENDERECO.Width = 170;
            // 
            // CIDADE
            // 
            this.CIDADE.HeaderText = "CIDADE";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.ReadOnly = true;
            this.CIDADE.Width = 140;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 130;
            // 
            // TELEFONE
            // 
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            this.TELEFONE.Width = 130;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 60;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 140;
            // 
            // Frm_Consulta_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 461);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeBusca);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Consulta_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Consulta_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeBusca;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
    }
}