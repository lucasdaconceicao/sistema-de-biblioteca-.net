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
    public partial class Frm_Cadastrar_Emprestimo : Form
    {
        public Frm_Cadastrar_Emprestimo()
        {
            InitializeComponent();
            btn_buscar_livro.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btn_buscar_usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
