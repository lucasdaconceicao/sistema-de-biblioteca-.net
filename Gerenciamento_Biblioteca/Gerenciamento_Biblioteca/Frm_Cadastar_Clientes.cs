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
    public partial class Frm_Cadastar_Clientes : Form
    {
        public Frm_Cadastar_Clientes()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=BIBLIOTECA;Uid=lucas;Pwd=root;");
            try
            {
                Clientes cliente = new Clientes();
                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Cpf = txtCpf.Text;

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

                //abrindo a conexão com banco de dados;
                conn.Open();
                //teste se esta aberto
                if (conn.State == ConnectionState.Open)
                {
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

                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso!");
                        LimparCampos();
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

        private void cbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo letra e se nao for a tecla back
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cancela o evento no campo letra e se nao for a tecla back
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
