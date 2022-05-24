namespace Model
{
    public class Usuario
    {
        private string nomeUsuario;
        private int id;
        private bool ativo;
        private string senha;
        private string endereco;
        private string telefone;
        private string email;

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
