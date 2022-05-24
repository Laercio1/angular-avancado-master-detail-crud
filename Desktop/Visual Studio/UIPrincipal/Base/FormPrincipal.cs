using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Base
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            buttonRestaurar.Visible = true;
            buttonMaximizar.Visible = false;
        }

        private void buttonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            buttonRestaurar.Visible = false;
            buttonMaximizar.Visible = true;
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 269)
            {
                menuVertical.Width = 0;
            }
            else
                menuVertical.Width = 269;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void customizeDesing()
        {
            panelSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormConsultaUsuario());
        }
    }
}
