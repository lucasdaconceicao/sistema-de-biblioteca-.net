﻿using MySql.Data.MySqlClient;
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
    public partial class Frm_Consulta_Livros : Form
    {
        public Frm_Consulta_Livros()
        {
            InitializeComponent();
        }

        private void recarregaGrid()
        {
            //Limpa os dados da grid
            dgv_Livros.Rows.Clear();

            //conexao com o bd
            MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=BIBLIOTECA;Uid=lucas;Pwd=root;");

            //Criando um objeto Reader;
            MySqlDataReader MyqlReader = null;
            
            string consulta = "SELECT * FROM LIVROS";


        }

        private void btnbusca_Click(object sender, EventArgs e)
        {

        }
    }
}