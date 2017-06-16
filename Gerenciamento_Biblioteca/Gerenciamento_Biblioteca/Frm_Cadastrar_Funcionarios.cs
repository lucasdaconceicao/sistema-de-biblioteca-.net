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
    public partial class Frm_Cadastrar_Funcionarios : Form
    {
        public Frm_Cadastrar_Funcionarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=BIBLIOTECA;Uid=lucas;Pwd=root;");
            try
            {
                Funcionarios funcionario = new Funcionarios();
                funcionario.Nome = txtNome.Text;
                funcionario.Endereco = txtEndereco.Text;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Cidade = txtCidade.Text;
                funcionario.Cargo = txtCargo.Text;
                funcionario.Estado = cbxEstado.SelectedText;

                //abrindo a conexão com banco de dados;
                conn.Open();
                //teste se esta aberto
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "INSERT INTO LIVROS (NOME_LIVRO,AUTOR_LIVRO,ANO_LIVRO,GENERO_LIVRO,EDITORA_LIVRO,PAGINAS_LIVRO,STATUS_LIVRO,ISBN_LIVRO) VALUES (?NOME,?AUTOR,?ANO,?GENERO,?EDITORA,?PAGINAS,?STATUS,?ISBN)";
                    comando.CommandText = consulta;
                    comando.Parameters.AddWithValue("?NOME", livro.Nome);
                    comando.Parameters.AddWithValue("?AUTOR", livro.Autor);
                    comando.Parameters.AddWithValue("?ANO", livro.Ano);
                    comando.Parameters.AddWithValue("?GENERO", livro.Genero);
                    comando.Parameters.AddWithValue("?EDITORA", livro.Editora);
                    comando.Parameters.AddWithValue("?PAGINAS", livro.Paginas);
                    comando.Parameters.AddWithValue("?STATUS", livro.Status);
                    comando.Parameters.AddWithValue("?ISBN", livro.Isbn);

                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Livro cadastrado com sucesso!");
                        LimparCampos();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }



        }

        private void cbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
