using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Biblioteca
{
    class Funcionarios
    {
        private string _nome;
        private string _endereco;
        private string _cidade;
        private string _estado;
        private string _telefone;
        private string _cargo;
        private string _cpf;

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

        public string Endereco
        {
            get
            {
                return _endereco;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _endereco = value;
                }
                else
                {
                    throw new Exception("O endereco não pode ser vazio.");
                }
            }
        }

        public string Cidade
        {
            get
            {
                return _cidade;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _cidade = value;
                }
                else
                {
                    throw new Exception("A cidade não pode ser vazio.");
                }
            }
        }

        public string Estado
        {
            get
            {
                return _estado;
            }

            set
            {

                _estado = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _telefone;
            }

            set
            {
                if (!String.IsNullOrEmpty(value) && value.Length == 12)
                {
                    _telefone = value;
                }
                else
                {
                    throw new Exception("Digite corretamente o telefone.");
                }
            }
        }

        public string Cargo
        {
            get
            {
                return _cargo;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _cargo = value;
                }
                else
                {
                    throw new Exception("O cargo não pode ser vazio.");
                }
            }
        }

        public string Cpf
        {
            get
            {
                return _cpf;
            }

            set
            {
                if (!String.IsNullOrEmpty(value) && value.Length == 11)
                {
                    _cpf = value;
                }
                else
                {
                    throw new Exception("Digite corretamente o cpf.");
                }
            }
        }
    }
}
