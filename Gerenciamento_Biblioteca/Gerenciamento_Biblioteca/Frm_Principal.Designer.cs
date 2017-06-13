namespace Gerenciamento_Biblioteca
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnClientes = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFuncionarios = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLivros = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnClientes,
            this.tsbtnFuncionarios,
            this.tsbtnLivros});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 3, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(570, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnClientes
            // 
            this.tsbtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClientes.Image")));
            this.tsbtnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClientes.Name = "tsbtnClientes";
            this.tsbtnClientes.Size = new System.Drawing.Size(101, 52);
            this.tsbtnClientes.Text = "Clientes";
            // 
            // tsbtnFuncionarios
            // 
            this.tsbtnFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFuncionarios.Image")));
            this.tsbtnFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFuncionarios.Name = "tsbtnFuncionarios";
            this.tsbtnFuncionarios.Size = new System.Drawing.Size(127, 52);
            this.tsbtnFuncionarios.Text = "Funcionarios";
            // 
            // tsbtnLivros
            // 
            this.tsbtnLivros.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLivros.Image")));
            this.tsbtnLivros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnLivros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLivros.Name = "tsbtnLivros";
            this.tsbtnLivros.Size = new System.Drawing.Size(90, 52);
            this.tsbtnLivros.Text = "Livros";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair});
            this.toolStrip2.Location = new System.Drawing.Point(0, 351);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(570, 55);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
            this.tsbtnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tsbtnSair.Size = new System.Drawing.Size(83, 52);
            this.tsbtnSair.Text = "Sair";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 406);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Biblioteca ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnClientes;
        private System.Windows.Forms.ToolStripButton tsbtnFuncionarios;
        private System.Windows.Forms.ToolStripButton tsbtnLivros;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
    }
}

