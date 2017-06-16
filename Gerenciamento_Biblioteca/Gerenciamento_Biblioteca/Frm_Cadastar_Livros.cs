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
    public partial class Frm_Cadastar_Livros : Form
    {
        public Frm_Cadastar_Livros()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=BIBLIOTECA;Uid=lucas;Pwd=root;");

            try
            {
                Livros livro = new Livros();
                livro.Nome = txtNome.Text;
                livro.Ano = txtAno.Text;
                livro.Autor = txtAutor.Text;
                livro.Genero = txtGenero.Text;
                livro.Paginas = txtPaginas.Text;
                livro.Editora = txtEditora.Text;
                livro.Isbn = txtIsbn.Text;

                if (rbD.Checked || rbI.Checked)
                {
                    livro.Status = rbD.Checked ? 'D' : 'I';
                }
                else
                {
                    MessageBox.Show("Selecione um status");
                    return;
                }

                //abrindo a conexão com banco de dados;
                conn.Open();
                //teste se esta aberto
                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "INSERT INTO LIVROS (NOME_LIVRO,AUTOR_LIVRO,ANO_LIVRO,GENERO_LIVRO,EDITORA_LIVRO,PAGINAS_LIVRO,STATUS_LIVRO,ISBN_LIVRO) VALUES (?NOME,?ENDERECO,?TELEFONE,?EMAIL,?OBSERVACAO)";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
