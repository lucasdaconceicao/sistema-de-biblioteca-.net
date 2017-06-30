using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_Biblioteca
{
    public partial class Frm_Login : Form
    {
        //Os valores da propriedade serão passados para o Program.cs
        public bool Logado { get; set; }
        private string usuario;
        private string senha;

        public Frm_Login()
        {
            InitializeComponent();

            //Forçar o PictureBox como pai dos controles para a transparência funcionar
            this.lblUsuario.Parent = this.pbBackground;
            this.tbUsuario.Parent = this.pbBackground;
            this.lblSenha.Parent = this.pbBackground;
            this.tbSenha.Parent = this.pbBackground;
            this.lblDadosInvalidos.Parent = this.pbBackground;
            this.btnSair.Parent = this.pbBackground;
            this.btnLogin.Parent = this.pbBackground;
            this.pbCadeado.Parent = this.pbBackground;
            LerLogin();
        }
        
        private void LerLogin()
        {
            //caminho dos dados do login
            string caminhoLogin = Application.StartupPath + "/Login.txt";
            StreamReader reader = new StreamReader(caminhoLogin);
            //Lendo o arquivo de texto com os dados de login
            string linha = reader.ReadLine();
            //adicionando os dados retornados em um vetor
            string[] conteudo = linha.Split('|');
            this.usuario = conteudo[0];
            this.senha = conteudo[1];
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            //Vincular Enter ao btnLogin
            this.AcceptButton = this.btnLogin;
            //Vincular ESC ao btnSair
            this.CancelButton = this.btnSair;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //Dados digitado
            string usuarioDigitado = tbUsuario.Text;
            string senhaDigitada = tbSenha.Text;
            
            if ((usuarioDigitado == this.usuario) && (senhaDigitada == this.senha))
            {
                Logado = true;
                this.Dispose();
            }
            else
            {
                Logado = false; ;
                lblDadosInvalidos.Visible = true;
            }
            this.Cursor = Cursors.Default;
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            lblDadosInvalidos.Visible = false;
        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            lblDadosInvalidos.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
