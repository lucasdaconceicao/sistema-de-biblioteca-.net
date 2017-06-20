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
    public partial class Frm_Emprestimo : Form
    {
        public Frm_Emprestimo()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Emprestimo objCadastrarEmprestimo = new Frm_Cadastrar_Emprestimo();
            objCadastrarEmprestimo.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_Consulta_Emprestimo objConsultaEmprestimo = new Frm_Consulta_Emprestimo();
            objConsultaEmprestimo.ShowDialog();
        }
    }
}
