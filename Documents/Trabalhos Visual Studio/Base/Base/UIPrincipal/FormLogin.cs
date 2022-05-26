using System.Data;
using DAL;
using System.Windows.Forms;
using Model;

namespace UIPrincipal
{
    public partial class FormLogin : Form
    {
        FormPrincipal formPrincipal;
        DataTable dt = new DataTable();
        public FormLogin(FormPrincipal f)
        {
            InitializeComponent();
            formPrincipal = f;
        }

        private void buttonLogar_Click(object sender, System.EventArgs e)
        {
            string nomeUsuario = nomeUsuarioTextBox.Text;
            string senha = senhaTextBox.Text;

            if (nomeUsuario == "" || senha == "")
            {
                MessageBox.Show("Usuario e ou senha inválidos");
                nomeUsuarioTextBox.Focus();
                return;
            }

            string sql = "SELECT * FROM Usuario WHERE nomeUsuario='"+nomeUsuario+"' AND Senha='"+senha+"'";
            dt = Banco.Consulta(sql);
            if(dt.Rows.Count == 1)
            {
                formPrincipal.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("nomeUsuario");
                Globais.logado = true;
                this.Close();
            }
            else
            {

                MessageBox.Show("Usuário não encontrado!");
            }
        }

        private void buttonCancelar_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
