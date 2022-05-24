using BLL;
using Model;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Base
{
    public partial class FormCadastroUsuario : Form
    {
        private bool inserindoNovo;
        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormCadastroUsuario(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;
            inserindoNovo = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();
                Inserir();
                if (inserindoNovo)
                    MessageBox.Show("Cadastro realizado com sucesso!");
                else
                    MessageBox.Show("Cadastro atualizado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);

            }
        }
        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.Endereco = enderecoTextBox.Text;
            usuario.Telefone = telefoneTextBox.Text;
            usuario.Email = emailTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;

            if (inserindoNovo)
                usuarioBLL.Inserir(usuario);
            else
                usuarioBLL.Alterar(usuario);
        }
        private void buttonSalvarecadastrarnovo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            Inserir();
            MessageBox.Show("Cadastro realizado com sucesso!");
            usuarioBindingSource.DataSource = typeof(Usuario);
            usuarioBindingSource.AddNew();
            nomeUsuarioTextBox.Focus();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
