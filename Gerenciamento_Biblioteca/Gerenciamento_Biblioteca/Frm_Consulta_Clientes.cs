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
    public partial class Frm_Consulta_Clientes : Form
    {
        public Frm_Consulta_Clientes()
        {
            InitializeComponent();
        }

        private void recarregarGrid()
        {
            //conexao com o bd
            MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=BIBLIOTECA;Uid=lucas;Pwd=root;");
            try
            {
                //verificando se o campo da busca nao esta vazio
                if (String.IsNullOrEmpty(txtNomeBusca.Text))
                {
                    MessageBox.Show("O campo para busca nao pode ser vazio!");
                    return;
                }
                //Limpa os dados da grid
                dgvClientes.Rows.Clear();

                //abrindo a conexao com o bd
                conn.Open();

                //Criando um objeto Reader;
                MySqlDataReader MysqlReader = null;

                if (conn.State == ConnectionState.Open)
                {
                    //consulta no bd
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "SELECT * FROM CLIENTES WHERE NOME_CLIENTE LIKE'%" + txtNomeBusca.Text + "%'";
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

                    //Percorrendo a consulta e adicionando os valores em cada linha
                    while (MysqlReader.Read())
                    {
                        object[] valores = new object[MysqlReader.FieldCount];
                        for (int i = 0; i < MysqlReader.FieldCount; i++)
                        {
                            valores[i] = MysqlReader.GetValue(i);
                        }
                        dgvClientes.Rows.Add(valores);
                    }
                }
                txtNomeBusca.Clear();
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
    }
}
