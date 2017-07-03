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
    public partial class Frm_Consulta_Emprestimo : Form
    {
        private string Stringconexao;

        public Frm_Consulta_Emprestimo()
        {
            InitializeComponent();
            LerStringConexao();
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

        private void getEmprestimos()
        {
            MySqlConnection conn = new MySqlConnection(this.Stringconexao);
            try
            {
                //verificando se o campo da busca nao esta vazio
                if (String.IsNullOrEmpty(txtBusca.Text))
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
                    string consulta = "SELECT " +
                        "LOCACAO.ID_LOCACAO, CLIENTES.NOME_CLIENTE, LIVROS.NOME_LIVRO, LOCACAO.DATA_LOCACAO, LOCACAO.DATA_DEVOLUCAO " +
                        "FROM LOCACAO INNER " +
                        "JOIN CLIENTES " +
                        "ON CLIENTES.ID_CLIENTE = LOCACAO.ID_CLIENTE " +
                        "INNER JOIN LIVROS ON LIVROS.ID_LIVRO = LOCACAO.ID_LIVRO " +
                        "WHERE CLIENTES.NOME_CLIENTE LIKE'%" + txtBusca.Text + "%'";
                    comando.CommandText = consulta;

                    //retornando os dados da query
                    MysqlReader = comando.ExecuteReader();

                    //verificando se existe registro
                    if (MysqlReader.HasRows == false)
                    {
                        MessageBox.Show("Nao existe registro!");
                        txtBusca.Clear();
                        return;
                    }

                    //Limpa os dados da grid
                    dgvEmprestimos.Rows.Clear();

                    //Percorrendo a consulta e adicionando os valores em cada linha
                    while (MysqlReader.Read())
                    {
                        object[] valores = new object[MysqlReader.FieldCount];
                        for (int i = 0; i < MysqlReader.FieldCount; i++)
                        {
                            valores[i] = MysqlReader.GetValue(i);
                        }
                        dgvEmprestimos.Rows.Add(valores);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            getEmprestimos();
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(this.Stringconexao);
            bool insertOk = true;
            try
            {
                int locCod = Convert.ToInt32(dgvEmprestimos.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                insertOk = false;
            }

            if (insertOk)
            {
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        int locCod = Convert.ToInt32(dgvEmprestimos.CurrentRow.Cells[0].Value.ToString());

                        MySqlCommand comando = conn.CreateCommand();
                        string update = "UPDATE LOCACAO " +
                            "SET DATA_DEVOLUCAO = DATA_DEVOLUCAO + INTERVAL 4 DAY WHERE ID_LOCACAO = " + locCod + ";";

                        comando.CommandText = update;

                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Renovacao realzada com sucesso!");
                            dgvEmprestimos.Rows.Clear();
                            getEmprestimos();
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
                MessageBox.Show("Selecione uma locacao!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
