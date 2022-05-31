using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Autor
    {
        private int codigo;
        private string nomeAutor;

        public string NomeAutor
        {
            get { return nomeAutor; }
            set { nomeAutor = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
