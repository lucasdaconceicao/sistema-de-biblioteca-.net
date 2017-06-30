using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_Biblioteca
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
             //   //caminho onde sera criado a string de conexao com banco de dados
             //   string caminhoStringConexao = Application.StartupPath + "/stringConexao.txt";
             //   //string de conexao com banco de dados
             //   string stringConexao = "Server=localhost;Port=3306;Database=BIBLIOTECA;Uid=administrator;Pwd=1234;";
             //   //criar arquivo txt com a string de conexao
             //   StreamWriter sw = new StreamWriter(caminhoStringConexao);
             //   sw.WriteLine(stringConexao);
             //   sw.Dispose();
             //
             //   //caminho onde sera criado o login
             //   string caminhoLogin = Application.StartupPath + "/Login.txt";
             //   //Login
             //   string stringLogin = "admin" + "|" + "123";
             //   //criar arquivo txt com os dados do login
             //   StreamWriter login = new StreamWriter(caminhoLogin);
             //   login.WriteLine(stringLogin);
             //   login.Dispose();
             //
             //   //Chamar o login antes de iniciar a aplicação
             //   Frm_Login fLogin = new Frm_Login();
             //   fLogin.ShowDialog();
             //   //iniciar tela splash
             //   Application.Run(new Frm_Splash());
             //
             //   //Só inicia se receber True na propriedade "Logado"
             //   if (fLogin.Logado)
             //   {
                    Application.Run(new Frm_Principal());
             //   }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
