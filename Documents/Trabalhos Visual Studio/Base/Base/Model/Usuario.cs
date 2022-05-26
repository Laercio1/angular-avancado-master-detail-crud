using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel;

namespace Model
{
    public class Usuario
    {
        private int id;
        private string nomeUsuario;
        private string cpf_cnpj;
        private string rg;
        private string estadoCivil;
        private DateTime dataNascimento;
        private string sexo;
        private string profissao;
        private string numero;
        private string complemento;
        private string bairro;
        private string cep;
        private string uf;
        private string cidade;
        private string foto;
        private string endereco;
        private string telefone;
        private string email;
        private string senha;
        private bool ativo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        public string CPF_CNPJ
        {
            get { return cpf_cnpj; }
            set { cpf_cnpj = value; }
        }
        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }
        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public string UF
        {
            get { return uf; }
            set { uf = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }


    }
}
