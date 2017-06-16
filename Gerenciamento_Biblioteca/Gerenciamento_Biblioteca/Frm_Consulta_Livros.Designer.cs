﻿namespace Gerenciamento_Biblioteca
{
    partial class Frm_Consulta_Livros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consulta_Livros));
            this.dgv_Livros = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome_Busca = new System.Windows.Forms.TextBox();
            this.btnbusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Livros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Livros
            // 
            this.dgv_Livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Livros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.AUTOR,
            this.ANO,
            this.GENERO,
            this.EDITORA,
            this.PAG,
            this.STATUS,
            this.ISBN});
            this.dgv_Livros.Location = new System.Drawing.Point(2, 61);
            this.dgv_Livros.Name = "dgv_Livros";
            this.dgv_Livros.Size = new System.Drawing.Size(622, 328);
            this.dgv_Livros.TabIndex = 0;
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
            this.NOME.Width = 150;
            // 
            // AUTOR
            // 
            this.AUTOR.HeaderText = "AUTOR";
            this.AUTOR.Name = "AUTOR";
            this.AUTOR.ReadOnly = true;
            this.AUTOR.Width = 200;
            // 
            // ANO
            // 
            this.ANO.HeaderText = "ANO";
            this.ANO.Name = "ANO";
            this.ANO.ReadOnly = true;
            this.ANO.Width = 45;
            // 
            // GENERO
            // 
            this.GENERO.HeaderText = "GENERO";
            this.GENERO.Name = "GENERO";
            this.GENERO.ReadOnly = true;
            this.GENERO.Width = 95;
            // 
            // EDITORA
            // 
            this.EDITORA.HeaderText = "EDITORA";
            this.EDITORA.Name = "EDITORA";
            this.EDITORA.ReadOnly = true;
            this.EDITORA.Width = 95;
            // 
            // PAG
            // 
            this.PAG.HeaderText = "PAG";
            this.PAG.Name = "PAG";
            this.PAG.ReadOnly = true;
            this.PAG.Width = 50;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 60;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 60;
            // 
            // txtNome_Busca
            // 
            this.txtNome_Busca.Location = new System.Drawing.Point(43, 35);
            this.txtNome_Busca.MaxLength = 100;
            this.txtNome_Busca.Name = "txtNome_Busca";
            this.txtNome_Busca.Size = new System.Drawing.Size(297, 20);
            this.txtNome_Busca.TabIndex = 1;
            // 
            // btnbusca
            // 
            this.btnbusca.Location = new System.Drawing.Point(375, 29);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(84, 26);
            this.btnbusca.TabIndex = 2;
            this.btnbusca.Text = "BUSCA";
            this.btnbusca.UseVisualStyleBackColor = true;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o nome do livro aqui";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCadastrar.Location = new System.Drawing.Point(510, 416);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 33);
            this.btnCadastrar.TabIndex = 75;
            this.btnCadastrar.Text = "EDITAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Cyan;
            this.btnCancelar.Location = new System.Drawing.Point(423, 416);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 33);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "VOLTAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Frm_Consulta_Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbusca);
            this.Controls.Add(this.txtNome_Busca);
            this.Controls.Add(this.dgv_Livros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Consulta_Livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Livros";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Livros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Livros;
        private System.Windows.Forms.TextBox txtNome_Busca;
        private System.Windows.Forms.Button btnbusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDITORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
    }
}