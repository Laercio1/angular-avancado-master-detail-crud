using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardApp
{
    public partial class FormPrincipal : Form
    {
        //Fields
        private Button currentButton;
        private int borderSize = 2;
        //Constructor
        public FormPrincipal()
        {
            InitializeComponent();
            collapseMenu();
            this.Padding = new Padding(borderSize);// Border Size
            this.BackColor = Color.FromArgb(98, 102, 244);// Border color
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelDesktop.Controls.Count > 0)
                this.panelDesktop.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(fh);
            this.panelDesktop.Tag = fh;
            fh.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormDashboard());
        }

        private void collapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButonn in panelMenu.Controls.OfType<Button>())
                {
                    menuButonn.Text = "";
                    menuButonn.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButonn.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 260;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButonn in panelMenu.Controls.OfType<Button>())
                {
                    menuButonn.Text = "  " + menuButonn.Tag.ToString();
                    menuButonn.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButonn.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            collapseMenu();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
