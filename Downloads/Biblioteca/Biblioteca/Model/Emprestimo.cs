using System;

namespace Model
{
    public class Emprestimo
    {
        private int codigo;
        private int codigoLivro;
        private int codigoLeitor;
        private int codigoUsuario;
        private DateTime dataHoraEmprestimo;
        private DateTime dataHoraDevolucao;
        private int exemplar;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public int Exemplar
        {
            get { return exemplar; }
            set { exemplar = value; }
        }
        public DateTime DataHoraDevolucao
        {
            get { return dataHoraDevolucao; }
            set { dataHoraDevolucao = value; }
        }

        public DateTime DataHoraEmprestimo
        {
            get { return dataHoraEmprestimo; }
            set { dataHoraEmprestimo = value; }
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
