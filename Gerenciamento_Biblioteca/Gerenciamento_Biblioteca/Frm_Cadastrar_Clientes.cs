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

    public partial class Frm_Cadastrar_Clientes : Form
    {
        private string Stringconexao;

        private int id;
        public Frm_Cadastrar_Clientes()
        {
            InitializeComponent();
            LerStringConexao();
        }

        //sobrecarga metodo construtor do formulario
        //quando vir do formualrio consultar cliente
        public Frm_Cadastrar_Clientes(int cod)
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
                    string consulta = "SELECT * FROM CLIENTES WHERE ID_CLIENTE=" + cod + "";
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
                        txtEndereco.Text = valores[2].ToString();
                        txtCidade.Text = valores[3].ToString();
                        cbxEstado.SelectedItem = valores[4].ToString();
                        txtTelefone.Text = valores[5].ToString();
                        txtCpf.Text = valores[7].ToString();

                        //converte o status do cliente para char
                        //para poder ser possivel a comparacao 
                        char status = Convert.ToChar(valores[6]);
                        if (status == 'A')
                        {
                            rbA.Checked = true;
                        }
                        else
                        {
                            rbI.Checked = true;
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
                Clientes cliente = new Clientes();
                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Cpf = txtCpf.Text;

                //teste se o estado esta selecionado
                if (cbxEstado.SelectedIndex != -1)
                {
                    cliente.Estado = cbxEstado.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Selecione um estado!");
                    return;
                }

                if (rbA.Checked || rbI.Checked)
                {
                    cliente.Status = rbA.Checked ? 'A' : 'I';
                }
                else
                {
                    MessageBox.Show("Selecione um status!");
                    return;
                }

                //abrindo a conexão com banco de dados
                conn.Open();
                //teste se esta aberto
                if (conn.State == ConnectionState.Open)
                {
                    if (String.IsNullOrEmpty(txtCod.Text))
                    {
                        //comando para insercao no banco de dados
                        MySqlCommand comando = conn.CreateCommand();
                        string consulta = "INSERT INTO CLIENTES (NOME_CLIENTE,ENDERECO_CLIENTE,CIDADE_CLIENTE,ESTADO_CLIENTE,TELEFONE_CLIENTE,STATUS_CLIENTE,CPF) VALUES (?NOME,?ENDERECO,?CIDADE,?ESTADO,?TELEFONE,?STATUS,?CPF)";
                        comando.CommandText = consulta;
                        comando.Parameters.AddWithValue("?NOME", cliente.Nome);
                        comando.Parameters.AddWithValue("?ENDERECO", cliente.Endereco);
                        comando.Parameters.AddWithValue("?CIDADE", cliente.Cidade);
                        comando.Parameters.AddWithValue("?ESTADO", cliente.Estado);
                        comando.Parameters.AddWithValue("?TELEFONE", cliente.Telefone);
                        comando.Parameters.AddWithValue("?STATUS", cliente.Status);
                        comando.Parameters.AddWithValue("?CPF", cliente.Cpf);

                        //se executo o comando com sucesso
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Cliente cadastrado com sucesso!");
                            LimparCampos();
                        }
                    }
                    else
                    {
                        //comando para update no banco de dados
                        MySqlCommand comando = conn.CreateCommand();
                        string consulta = "UPDATE CLIENTES SET NOME_CLIENTE=?NOME,ENDERECO_CLIENTE=?ENDERECO,CIDADE_CLIENTE=?CIDADE,ESTADO_CLIENTE=?ESTADO,TELEFONE_CLIENTE=?TELEFONE,STATUS_CLIENTE=?STATUS,CPF=?CPF WHERE ID_CLIENTE=" + this.id + "";
                        comando.CommandText = consulta;
                        comando.Parameters.AddWithValue("?NOME", cliente.Nome);
                        comando.Parameters.AddWithValue("?ENDERECO", cliente.Endereco);
                        comando.Parameters.AddWithValue("?CIDADE", cliente.Cidade);
                        comando.Parameters.AddWithValue("?ESTADO", cliente.Estado);
                        comando.Parameters.AddWithValue("?TELEFONE", cliente.Telefone);
                        comando.Parameters.AddWithValue("?STATUS", cliente.Status);
                        comando.Parameters.AddWithValue("?CPF", cliente.Cpf);

                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Cliente alterado com sucesso!");
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

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            cbxEstado.SelectedIndex = -1;
            txtTelefone.Clear();
            txtCpf.Clear();
            rbA.Checked = false;
            rbI.Checked = false;
        }

        //nenhuma interacao no campo
        private void cbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo, se for letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
