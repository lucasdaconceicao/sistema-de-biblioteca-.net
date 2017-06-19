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
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
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

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsbtnCadastrar_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Clientes objFrmCadastrarCliente = new Frm_Cadastrar_Clientes();
            objFrmCadastrarCliente.ShowDialog();
        }

        private void tsbtnConsultar_Click(object sender, EventArgs e)
        {
            Frm_Consulta_Clientes objConsulta_Clientes = new Frm_Consulta_Clientes();
            objConsulta_Clientes.ShowDialog();
        }
    }
}
