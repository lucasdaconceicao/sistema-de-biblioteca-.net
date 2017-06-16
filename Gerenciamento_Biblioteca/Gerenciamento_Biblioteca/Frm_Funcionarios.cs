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
    public partial class Frm_Funcionarios : Form
    {
        public Frm_Funcionarios()
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
            Frm_Cadastrar_Funcionarios objFrmCadastrar_Funcionarios = new Frm_Cadastrar_Funcionarios();
            objFrmCadastrar_Funcionarios.ShowDialog();
        }
    }
}
