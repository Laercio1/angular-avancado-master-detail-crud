using System;

namespace Model
{
    public class HistoricoLeitor
    {
        private int codigo;
        private int codigoLivro;
        private int codigoLeitor;
        private int codigoUsuario;
        private DateTime dataLocacao;
        private DateTime dataDevolucao;
        private int exemplar;
        private DateTime dataRenovacao;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public DateTime DataRenovacao
        {
            get { return dataRenovacao; }
            set { dataRenovacao = value; }
        }

        public int Exemplar
        {
            get { return exemplar; }
            set { exemplar = value; }
        }

        public DateTime DataDevolucao
        {
            get { return dataDevolucao; }
            set { dataDevolucao = value; }
        }

        public DateTime DataLocacao
        {
            get { return dataLocacao; }
            set { dataLocacao = value; }
        }

        public int CodigoUsuario
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }

        public int CodigoLeitor
        {
            get { return codigoLeitor; }
            set { codigoLeitor = value; }
        }

        public int CodigoLivro
        {
            get { return codigoLivro; }
            set { codigoLivro = value; }
        }

    }
}
