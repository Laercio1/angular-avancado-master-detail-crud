using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Livro
    {
        private int codigo;
        private int tombo;
        private int codigoSituacao;
        private string titulo;
        private int codigoAutor;
        private int codigoCategoria;
        private int codigoEditora;
        private int ano;
        private DateTime dataCadastro;
        private int classificacao;
        private int exemplar;
        private int isbn;
        private int issn;
        private string material;
        private string volume;
        private string localPublicacao;
        private string assunto;
        private string areaConhecimento;
        public string AreaConhecimento
        {
            get { return areaConhecimento; }
            set { areaConhecimento = value; }
        }
        public string Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }
        public string LocalPublicacao
        {
            get { return localPublicacao; }
            set { localPublicacao = value; }
        }
        public string Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public string MyProperty
        {
            get { return material; }
            set { material = value; }
        }
        public int Issn
        {
            get { return issn; }
            set { issn = value; }
        }
        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public int Classificacao
        {
            get { return classificacao; }
            set { classificacao = value; }
        }
        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public int CodigoEditora
        {
            get { return codigoEditora; }
            set { codigoEditora = value; }
        }
        public int CodigoCategoria
        {
            get { return codigoCategoria; }
            set { codigoCategoria = value; }
        }
        public int CodigoAutor
        {
            get { return codigoAutor; }
            set { codigoAutor = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int CodigoSituacao
        {
            get { return codigoSituacao; }
            set { codigoSituacao = value; }
        }
        public int Tombo
        {
            get { return tombo; }
            set { tombo = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Exemplar
        {
            get
            {
                return exemplar;
            }
            set
            {
                exemplar = value;
            }
        }
        public string Material
        {
            get
            {
                return material;
            }
            set
            {
                material = value;
            }
        }

    }
}
