using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Biblioteca
{
    class Livros
    {
        private string _nome;
        private string _autor;
        private int _ano;
        private string _genero;
        private string _editora;
        private string _paginas;
        private char _status;

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string Autor
        {
            get
            {
                return _autor;
            }

            set
            {
                _autor = value;
            }
        }

        public int Ano
        {
            get
            {
                return _ano;
            }

            set
            {
                _ano = value;
            }
        }

        public string Genero
        {
            get
            {
                return _genero;
            }

            set
            {
                _genero = value;
            }
        }

        public string Editora
        {
            get
            {
                return _editora;
            }

            set
            {
                _editora = value;
            }
        }

        public string Paginas
        {
            get
            {
                return _paginas;
            }

            set
            {
                _paginas = value;
            }
        }

        public char Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }
    }
}
