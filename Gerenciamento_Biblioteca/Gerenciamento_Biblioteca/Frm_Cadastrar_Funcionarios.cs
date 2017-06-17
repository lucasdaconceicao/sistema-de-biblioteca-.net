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
            //conexao com o bd
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
                if (cbxEstado.SelectedIndex!=-1)
                {
                    funcionario.Estado = cbxEstado.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Selecione um estado!");
                    return;
                }

                //abrindo a conexão com banco de dados;
                conn.Open();
                //teste se esta aberto
                if (conn.State == ConnectionState.Open)
                {
                    //comando para insercao no bd
                    MySqlCommand comando = conn.CreateCommand();
                    string consulta = "INSERT INTO FUNCIONARIOS (NOME_FUNCIONARIO,ENDERECO_FUNCIONARIO,CIDADE_FUNCIONARIO,ESTADO_FUNCIONARIO,TELEFONE_FUNCIONARIO,CARGO_FUNCIONARIO,CPF) VALUES (?NOME,?ENDERECO,?CIDADE,?ESTADO,?TELEFONE,?CARGO,?CPF)";
                    comando.CommandText = consulta;
                    comando.Parameters.AddWithValue("?NOME", funcionario.Nome);
                    comando.Parameters.AddWithValue("?ENDERECO", funcionario.Endereco);
                    comando.Parameters.AddWithValue("?CIDADE", funcionario.Cidade);
                    comando.Parameters.AddWithValue("?ESTADO", funcionario.Estado);
                    comando.Parameters.AddWithValue("?TELEFONE", funcionario.Telefone);
                    comando.Parameters.AddWithValue("?CARGO", funcionario.Cargo);
                    comando.Parameters.AddWithValue("?CPF", funcionario.Cpf);

                    //se executo a query com sucesso
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Funcionario cadastrado com sucesso!");
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
            txtTelefone.Clear();
            txtCpf.Clear();
            txtCidade.Clear();
            txtCargo.Clear();
            cbxEstado.SelectedIndex = -1;
        }

        //sem iteracao no campo
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
