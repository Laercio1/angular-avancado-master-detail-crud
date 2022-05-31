using System;

namespace Model
{




    public class Usuario
    {
        private int codigo;
        private string nome;
        private string endereco;
        private string bairro;
        private string codigoCidade;
        private string codigoEstado;
        private int cep;
        private int cpf;
        private int rg;
        private string telefone;
        private string email;
        private DateTime dataNascimento;
        private string senha;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
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
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string CodigoCidade
        {
            get { return codigoCidade; }
            set { codigoCidade = value; }
        }
        public string CodigoEstado
        {
            get { return codigoEstado; }
            set { codigoEstado = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

    }
}
