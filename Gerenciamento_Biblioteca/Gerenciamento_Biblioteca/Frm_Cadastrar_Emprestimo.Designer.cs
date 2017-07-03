namespace Gerenciamento_Biblioteca
{
    partial class Frm_Cadastrar_Emprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastrar_Emprestimo));
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btn_buscar_usuario = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_livros = new System.Windows.Forms.DataGridView();
            this.ID_LIVRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_LIVRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar_livro = new System.Windows.Forms.Button();
            this.txtBuscarLivro = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(4, 36);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(212, 20);
            this.txtBuscarUsuario.TabIndex = 0;
            // 
            // btn_buscar_usuario
            // 
            this.btn_buscar_usuario.Location = new System.Drawing.Point(222, 36);
            this.btn_buscar_usuario.Name = "btn_buscar_usuario";
            this.btn_buscar_usuario.Size = new System.Drawing.Size(75, 24);
            this.btn_buscar_usuario.TabIndex = 1;
            this.btn_buscar_usuario.Text = "BUSCAR";
            this.btn_buscar_usuario.UseVisualStyleBackColor = true;
            this.btn_buscar_usuario.Click += new System.EventHandler(this.btn_buscar_usuario_Click);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.TELEFONE});
            this.dgv_usuarios.Location = new System.Drawing.Point(4, 63);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.ShowCellErrors = false;
            this.dgv_usuarios.ShowCellToolTips = false;
            this.dgv_usuarios.ShowEditingIcon = false;
            this.dgv_usuarios.ShowRowErrors = false;
            this.dgv_usuarios.Size = new System.Drawing.Size(410, 301);
            this.dgv_usuarios.TabIndex = 2;
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
            this.NOME.Width = 180;
            // 
            // TELEFONE
            // 
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            this.TELEFONE.Width = 147;
            // 
            // dgv_livros
            // 
            this.dgv_livros.AllowUserToAddRows = false;
            this.dgv_livros.AllowUserToDeleteRows = false;
            this.dgv_livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_livros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_LIVRO,
            this.NOME_LIVRO,
            this.ANO,
            this.ISBN});
            this.dgv_livros.Location = new System.Drawing.Point(436, 63);
            this.dgv_livros.MultiSelect = false;
            this.dgv_livros.Name = "dgv_livros";
            this.dgv_livros.ReadOnly = true;
            this.dgv_livros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_livros.ShowCellErrors = false;
            this.dgv_livros.ShowCellToolTips = false;
            this.dgv_livros.ShowEditingIcon = false;
            this.dgv_livros.ShowRowErrors = false;
            this.dgv_livros.Size = new System.Drawing.Size(418, 301);
            this.dgv_livros.TabIndex = 3;
            // 
            // ID_LIVRO
            // 
            this.ID_LIVRO.HeaderText = "ID";
            this.ID_LIVRO.Name = "ID_LIVRO";
            this.ID_LIVRO.ReadOnly = true;
            this.ID_LIVRO.Width = 40;
            // 
            // NOME_LIVRO
            // 
            this.NOME_LIVRO.HeaderText = "NOME";
            this.NOME_LIVRO.Name = "NOME_LIVRO";
            this.NOME_LIVRO.ReadOnly = true;
            this.NOME_LIVRO.Width = 180;
            // 
            // ANO
            // 
            this.ANO.HeaderText = "ANO";
            this.ANO.Name = "ANO";
            this.ANO.ReadOnly = true;
            this.ANO.Width = 70;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Digite o livro:";
            // 
            // btn_buscar_livro
            // 
            this.btn_buscar_livro.Location = new System.Drawing.Point(660, 36);
            this.btn_buscar_livro.Name = "btn_buscar_livro";
            this.btn_buscar_livro.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_livro.TabIndex = 6;
            this.btn_buscar_livro.Text = "BUSCAR";
            this.btn_buscar_livro.UseVisualStyleBackColor = true;
            this.btn_buscar_livro.Click += new System.EventHandler(this.btn_buscar_livro_Click);
            // 
            // txtBuscarLivro
            // 
            this.txtBuscarLivro.Location = new System.Drawing.Point(436, 36);
            this.txtBuscarLivro.Name = "txtBuscarLivro";
            this.txtBuscarLivro.Size = new System.Drawing.Size(218, 20);
            this.txtBuscarLivro.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(762, 370);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 33);
            this.btnSalvar.TabIndex = 77;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(676, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 33);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "VOLTAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Frm_Cadastrar_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 409);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar_livro);
            this.Controls.Add(this.txtBuscarLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_livros);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.btn_buscar_usuario);
            this.Controls.Add(this.txtBuscarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Cadastrar_Emprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestimo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Button btn_buscar_usuario;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.DataGridView dgv_livros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LIVRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_LIVRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar_livro;
        private System.Windows.Forms.TextBox txtBuscarLivro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}