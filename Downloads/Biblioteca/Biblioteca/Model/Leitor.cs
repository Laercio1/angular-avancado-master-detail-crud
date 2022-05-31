using System;

namespace Model
{
    public class Leitor
    {
        private int codigo;
        private int codigoTipoLeitor;
        private string nome;
        private string endereco;
        private string bairro;
        private int codigoCidade;
        private int codigoEstado;
        private string cep;
        private string cpf;
        private string rg;
        private string telefone;
        private string email;
        private DateTime dataCadastro;
        private DateTime dataNascimento;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int CodigoTipoLeitor
        {
            get { return codigoTipoLeitor; }
            set { codigoTipoLeitor = value; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public int CodigoEstado
        {
            get { return codigoEstado; }
            set { codigoEstado = value; }
        }
        public int CodigoCidade
        {
            get { return codigoCidade; }
            set { codigoCidade = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }







    }
}
