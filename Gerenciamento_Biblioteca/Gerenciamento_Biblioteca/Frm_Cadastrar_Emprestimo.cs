using MySql.Data.MySqlClient;
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
    public partial class Frm_Cadastrar_Emprestimo : Form
    {
        private string Stringconexao;

        public Frm_Cadastrar_Emprestimo()
        {
            InitializeComponent();
            LerStringConexao();
            //btnSalvar.Enabled = false;
        }

        private void LerStringConexao()
        {
            //caminho dos dados da string de conexao
            string caminhoStringConexao = Application.StartupPath + "/stringConexao.txt";
            StreamReader reader = new StreamReader(caminhoStringConexao);
            //Lendo o arquivo de texto com os dados de login
            string linha = reader.ReadLine();
            this.Stringconexao = linha;

        }

        private void getCli()
        {
            MySqlConnection conn = new MySqlConnection(this.Stringconexao);

            try
            {
                //verificando se o campo da busca nao esta vazio
                if (String.IsNullOrEmpty(txtBuscarUsuario.Text))
                {
                    MessageBox.Show("O campo para busca nao pode ser vazio!");
                    return;
                }

                //abrindo a conexao com o bd
                conn.Open();

                //Criando um objeto Reader;
                MySqlDataReader MysqlReader = null;

                if (conn.State == ConnectionState.Open)
                {
                    //consulta no bd
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "SELECT * FROM CLIENTES WHERE NOME_CLIENTE LIKE'%" + txtBuscarUsuario.Text + "%'";
                    comando.CommandText = consulta;

                    //retornando os dados da query
                    MysqlReader = comando.ExecuteReader();

                    //verificando se existe registro
                    if (MysqlReader.HasRows == false)
                    {
                        MessageBox.Show("Nao existe registro!");
                        txtBuscarUsuario.Clear();
                        return;
                    }

                    //Limpa os dados da grid
                    dgv_usuarios.Rows.Clear();

                    //Percorrendo a consulta e adicionando os valores em cada linha
                    while (MysqlReader.Read())
                    {
                        object[] valores = new object[MysqlReader.FieldCount];
                        for (int i = 0; i < MysqlReader.FieldCount; i++)
                        {
                            valores[i] = MysqlReader.GetValue(i);
                        }
                        dgv_usuarios.Rows.Add(valores);
                    }
                }
                txtBuscarUsuario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:. " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void getBook()
        {
            MySqlConnection conn = new MySqlConnection(this.Stringconexao);

            try
            {
                //verificando se o campo da busca nao esta vazio
                if (String.IsNullOrEmpty(txtBuscarLivro.Text))
                {
                    MessageBox.Show("O campo para busca nao pode ser vazio!");
                    return;
                }

                //abrindo a conexao com o bd
                conn.Open();

                //Criando um objeto Reader;
                MySqlDataReader MysqlReader = null;

                if (conn.State == ConnectionState.Open)
                {
                    //consulta no bd
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "SELECT * FROM LIVROS WHERE NOME_LIVRO LIKE'%" + txtBuscarLivro.Text + "%'";
                    comando.CommandText = consulta;

                    //retornando os dados da query
                    MysqlReader = comando.ExecuteReader();

                    //verificando se existe registro
                    if (MysqlReader.HasRows == false)
                    {
                        MessageBox.Show("Nao existe registro!");
                        txtBuscarUsuario.Clear();
                        return;
                    }

                    //Limpa os dados da grid
                    dgv_livros.Rows.Clear();

                    //Percorrendo a consulta e adicionando os valores em cada linha
                    while (MysqlReader.Read())
                    {
                        object[] valores = new object[MysqlReader.FieldCount];
                        for (int i = 0; i < MysqlReader.FieldCount; i++)
                        {
                            valores[i] = MysqlReader.GetValue(i);
                        }
                        dgv_livros.Rows.Add(valores);
                    }
                }
                txtBuscarUsuario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:. " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_buscar_usuario_Click(object sender, EventArgs e)
        {
            getCli();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_livro_Click(object sender, EventArgs e)
        {
            getBook();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool insertOk = true;
            try
            {
                int userCod = Convert.ToInt32(dgv_usuarios.CurrentRow.Cells[0].Value.ToString());
                int bookCod = Convert.ToInt32(dgv_livros.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                insertOk = false;
            }

            if (insertOk)
            {
                MySqlConnection conn = new MySqlConnection(this.Stringconexao);

                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {

                        int userCod = Convert.ToInt32(dgv_usuarios.CurrentRow.Cells[0].Value.ToString());
                        int bookCod = Convert.ToInt32(dgv_livros.CurrentRow.Cells[0].Value.ToString());

                        MySqlCommand comando = conn.CreateCommand();
                        string insert = "INSERT INTO LOCACAO (ID_CLIENTE, ID_LIVRO, DATA_LOCACAO, DATA_DEVOLUCAO) " +
                                        "VALUES (" + userCod + ", " + bookCod + ", NOW(), NOW() + INTERVAL 4 DAY)";

                        comando.CommandText = insert;

                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Locacao realzada com sucesso!");
                            dgv_livros.Rows.Clear();
                            dgv_usuarios.Rows.Clear();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:. " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione um livro e um cliente!");
            }
        }
    }
}
