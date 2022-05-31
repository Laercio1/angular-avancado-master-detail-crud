using System;

namespace Model
{
    public class Reserva
    {
        private int codigo;
        private int codigoLivro;
        private int codigoLeitor;
        private int codigoUsuario;
        private DateTime dataHoraReserva;

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
        public DateTime DataHoraReserva
        {
            get { return dataHoraReserva; }
            set { dataHoraReserva = value; }
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
