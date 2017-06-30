using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_Biblioteca
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            //botao sair
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsbtnClientes_Click(object sender, EventArgs e)
        {
            //iniciar formulario clientes
            Frm_Clientes objFrm_Cliente = new Frm_Clientes();
            objFrm_Cliente.ShowDialog();
        }

        private void tsbtnFuncionarios_Click(object sender, EventArgs e)
        {
            //iniciar formulario funcionarios
            Frm_Funcionarios objFrm_Funcionarios = new Frm_Funcionarios();
            objFrm_Funcionarios.ShowDialog();
        }

        private void tsbtnLivros_Click(object sender, EventArgs e)
        {
            //iniciar formulario livros
            Frm_Livros objFrm_Livros = new Frm_Livros();
            objFrm_Livros.ShowDialog();
        }

        private void Frm_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            //sair da aplicacao com a tecla ESC
            if (e.KeyValue==(char)Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //iniciar formulario emprestimos
            Frm_Emprestimo objEmprestimo = new Frm_Emprestimo();
            objEmprestimo.ShowDialog();
        }
    }
}
