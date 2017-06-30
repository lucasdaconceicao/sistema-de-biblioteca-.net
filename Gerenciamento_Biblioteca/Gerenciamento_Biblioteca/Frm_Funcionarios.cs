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
            //botao sair
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsbtnCadastrar_Click(object sender, EventArgs e)
        {
            //iniciar formulario de cadastrar funcionario
            Frm_Cadastrar_Funcionarios objFrmCadastrar_Funcionarios = new Frm_Cadastrar_Funcionarios();
            objFrmCadastrar_Funcionarios.ShowDialog();
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsbtnConsultar_Click(object sender, EventArgs e)
        {
            //iniciar formulario de consulta funcionario
            Frm_Consulta_Funcionarios objConsulta_funcionario = new Frm_Consulta_Funcionarios();
            objConsulta_funcionario.ShowDialog();
        }
    }
}
