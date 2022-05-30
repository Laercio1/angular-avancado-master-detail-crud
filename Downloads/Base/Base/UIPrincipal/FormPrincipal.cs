using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Model;

namespace UIPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelConteiner.Controls.Count > 0)
                this.panelConteiner.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelConteiner.Controls.Add(fh);
            this.panelConteiner.Tag = fh;
            fh.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 269)
            {
                menuVertical.Width = 79;
            }
            else
                menuVertical.Width = 269;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            buttonRestaurar.Visible = false;
            buttonMaximizar.Visible = true;
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            buttonRestaurar.Visible = true;
            buttonMaximizar.Visible = false;
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            menuDropdown1.Show(buttonCadastro, buttonCadastro.Width, 0);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            menuDropdown1.IsMainMenu = true;
            menuDropdown2.IsMainMenu = true;
            menuDropdown3.IsMainMenu = true;
        }

        private void buttonAjuda_Click_1(object sender, EventArgs e)
        {
            menuDropdown2.Show(buttonAjuda, buttonAjuda.Width, 0);
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    AbrirFormEnPanel(new FormConsultaUsuario());
                    barraTitulo.Visible = false;
                    panel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormLogin frm = new FormLogin(this))
            {
                frm.ShowDialog();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_nomeUsuario.Text = "---";
            Globais.logado = false;
            Globais.nivel = 0;
            using (FormLogin frm = new FormLogin(this))
            {
                frm.ShowDialog();
            }
        }

        private void buttonServico_Click(object sender, EventArgs e)
        {
            menuDropdown3.Show(buttonServico, buttonServico.Width, 0);
        }

        private void empréstimoDeLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    //Procedimentos 
                    AbrirFormEnPanel(new FormEmprestimoLivro());
                    barraTitulo.Visible = false;
                    panel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void leitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    //Procedimentos 
                    AbrirFormEnPanel(new FormCadastroLivros());
                    barraTitulo.Visible = false;
                    panel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }
    }
}
