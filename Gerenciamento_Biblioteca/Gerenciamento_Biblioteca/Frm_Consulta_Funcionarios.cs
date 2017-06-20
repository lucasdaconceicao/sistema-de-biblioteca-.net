using MySql.Data.MySqlClient;
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
    public partial class Frm_Consulta_Funcionarios : Form
    {
        //conexao com o bd
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=BIBLIOTECA;Uid=lucas;Pwd=root;");
        public Frm_Consulta_Funcionarios()
        {
            InitializeComponent();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void recarregarGrid()
        {
            try
            {
                //verificando se o campo da busca nao esta vazio
                if (String.IsNullOrEmpty(txtNomeBusca.Text))
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
                    string consulta = "SELECT * FROM FUNCIONARIOS WHERE NOME_FUNCIONARIO LIKE'%" + txtNomeBusca.Text + "%'";
                    comando.CommandText = consulta;

                    //retornando os dados da query
                    MysqlReader = comando.ExecuteReader();

                    //verificando se existe registro
                    if (MysqlReader.HasRows == false)
                    {
                        MessageBox.Show("Nao existe registro!");
                        txtNomeBusca.Clear();
                        return;
                    }
                    //limpar linhas grid
                    dgvFuncionario.Rows.Clear();

                    //Percorrendo a consulta e adicionando os valores em cada linha
                    while (MysqlReader.Read())
                    {
                        object[] valores = new object[MysqlReader.FieldCount];
                        for (int i = 0; i < MysqlReader.FieldCount; i++)
                        {
                            valores[i] = MysqlReader.GetValue(i);
                        }
                        dgvFuncionario.Rows.Add(valores);
                    }
                }
                txtNomeBusca.Clear();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:. " + ex.Message);
            }
            finally
            {
                //fechando a conexao com o banco de dados
                conn.Close();
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            recarregarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Pegando o código da linha selecionada.
            int codigo = Convert.ToInt32(dgvFuncionario.CurrentRow.Cells[0].Value.ToString());
            Frm_Cadastrar_Funcionarios objCadastrarFuncionario = new Frm_Cadastrar_Funcionarios(codigo);
            objCadastrarFuncionario.ShowDialog();
            dgvFuncionario.Rows.Clear();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(dgvFuncionario.CurrentRow.Cells[0].Value.ToString());
                //abrindo a conexao com o bd
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "DELETE FROM FUNCIONARIOS WHERE ID_FUNCIONARIO=" + codigo + "";
                    comando.CommandText = consulta;

                    //se executo o comando com sucesso
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Funcionario excluido com sucesso!");
                        dgvFuncionario.Rows.Clear();
                        btnEditar.Enabled = false;
                        btnExcluir.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:. " + ex.Message);
            }
            finally
            {
                //fechando a conexao com o banco de dados
                conn.Close();
            }
        }
    }
}
