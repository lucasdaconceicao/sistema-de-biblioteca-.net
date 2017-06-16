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
    public partial class Frm_Livros : Form
    {
        public Frm_Livros()
        {
            InitializeComponent();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsbtnCadastrar_Click(object sender, EventArgs e)
        {
            Frm_Cadastar_Livros objCadastrar_Livros = new Frm_Cadastar_Livros();
            objCadastrar_Livros.ShowDialog();
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsbtnConsultar_Click(object sender, EventArgs e)
        {
            Frm_Consulta_Livros objConsulta_livros = new Frm_Consulta_Livros();
            objConsulta_livros.ShowDialog();
        }
    }
}
