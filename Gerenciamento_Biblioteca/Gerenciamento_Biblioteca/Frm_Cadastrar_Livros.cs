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
    public partial class Frm_Cadastrar_Livros : Form
    {
        private string Stringconexao;

        private int id;
        public Frm_Cadastrar_Livros()
        {
            InitializeComponent();
            LerStringConexao();
        }

        //sobrecarga metodo construtor
        //quando vir do formulario consulta livros
        public Frm_Cadastrar_Livros(int cod)
        {
            InitializeComponent();
            LerStringConexao();
            this.id = cod;
            buscaDados(this.id);

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

        //exibir os dados na tela para alterar
        private void buscaDados(int cod)
        {
            //conexao com o banco de dados
            MySqlConnection conn = new MySqlConnection(this.Stringconexao);
            try
            {
                //abrindo a conexao com o banco de dados
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    //consulta no banco de dados
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "SELECT * FROM LIVROS WHERE ID_LIVRO=" + cod + "";
                    comando.CommandText = consulta;
                    //retornando os dados da query
                    MySqlDataReader MysqlReader = comando.ExecuteReader();
                    
                    //Percorrendo a consulta 
                    //adicionando cada valor da consulta no seu campo no formulario
                    //de acordo com sua posicao no vetor
                    while (MysqlReader.Read())
                    {
                        object[] valores = new object[MysqlReader.FieldCount];
                        for (int i = 0; i < MysqlReader.FieldCount; i++)
                        {
                            //cada dado da consulta em uma posicao do vetor
                            valores[i] = MysqlReader.GetValue(i);
                        }
                        txtCod.Text = valores[0].ToString();
                        txtNome.Text = valores[1].ToString();
                        txtAutor.Text = valores[2].ToString();
                        txtAno.Text = valores[3].ToString();
                        txtGenero.Text = valores[4].ToString();
                        txtEditora.Text = valores[5].ToString();
                        txtPaginas.Text = valores[6].ToString();
                        txtIsbn.Text = valores[8].ToString();
                       
                        //converte o status para char 
                        //para poder ser comparado
                        char status = Convert.ToChar(valores[7]);
                        if (status == 'I')
                        {
                            rbI.Checked = true;
                        }
                        else
                        {
                            rbD.Checked = true;
                        }
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
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //conexao com o banco de dados
            MySqlConnection conn = new MySqlConnection(this.Stringconexao);
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
                    if (String.IsNullOrEmpty(txtCod.Text))
                    {
                        //comando para insercao no bd
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

                        //se executo o comando com sucesso
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Livro cadastrado com sucesso!");
                            LimparCampos();
                        }
                    }
                    else
                    {
                        //comando para update no bancco de dados
                        MySqlCommand comando = conn.CreateCommand();
                        string consulta = "UPDATE LIVROS SET NOME_LIVRO=?NOME,AUTOR_LIVRO=?AUTOR,ANO_LIVRO=?ANO,GENERO_LIVRO=?GENERO,EDITORA_LIVRO=?EDITORA,PAGINAS_LIVRO=?PAGINAS,STATUS_LIVRO=?STATUS,ISBN_LIVRO=?ISBN WHERE ID_LIVRO=" + this.id + "";
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
                            MessageBox.Show("Livro alterado com sucesso!");
                            this.Dispose();
                        }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //limpar os campos no formulario
        private void LimparCampos()
        {
            txtNome.Clear();
            txtAno.Clear();
            txtAutor.Clear();
            txtGenero.Clear();
            txtPaginas.Clear();
            txtEditora.Clear();
            txtIsbn.Clear();
            rbD.Checked = false;
            rbI.Checked = false;
        }
    }
}
