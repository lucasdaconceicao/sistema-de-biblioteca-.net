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
        private string _ano;
        private string _genero;
        private string _editora;
        private string _paginas;
        private char _status;
        private string _isbn;

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
                else
                {
                    throw new Exception("O nome não pode ser vazio.");
                }
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
                if (!String.IsNullOrEmpty(value))
                {
                    _autor = value;
                }
                else
                {
                    throw new Exception("O autor não pode ser vazio.");
                }
            }
        }

        public string Ano
        {
            get
            {
                return _ano;
            }

            set
            {
                if (!String.IsNullOrEmpty(value) && value.Length == 4)
                {
                    _ano = value;
                }
                else
                {
                    throw new Exception("Digite corretamente o ano.");
                }
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
                if (!String.IsNullOrEmpty(value))
                {
                    _genero = value;
                }
                else
                {
                    throw new Exception("O genero não pode ser vazio.");
                }
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
                if (!String.IsNullOrEmpty(value))
                {
                    _editora = value;
                }
                else
                {
                    throw new Exception("A editora não pode ser vazio.");
                }
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
                if (!String.IsNullOrEmpty(value))
                {
                    _paginas = value;
                }
                else
                {
                    throw new Exception("As paginas não pode ser vazio.");
                }
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

        public string Isbn
        {
            get
            {
                return _isbn;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _isbn = value;
                }
                else
                {
                    throw new Exception("O isbn não pode ser vazio.");
                }
            }
        }
    }
}
