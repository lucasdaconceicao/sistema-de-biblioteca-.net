using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Biblioteca
{
    class Emprestimo
    {
        int _codigo_usuarios;
        int _codigo_livros;
        DateTime _dataAgora = DateTime.Today;
        DateTime _dataEmprestimo;

        public int Codigo_usuarios
        {
            get
            {
                return _codigo_usuarios;
            }

            set
            {
                _codigo_usuarios = value;
            }
        }

        public int Codigo_livros
        {
            get
            {
                return _codigo_livros;
            }

            set
            {
                _codigo_livros = value;
            }
        }

        public DateTime DataAgora
        {
            get
            {
                return _dataAgora;
            }

            set
            {
                _dataAgora = value;
            }
        }

        public DateTime DataEmprestimo
        {
            get
            {
                return _dataEmprestimo;
            }

            set
            {
                _dataEmprestimo = _dataAgora.AddDays(5);
            }
        }
    }
}
