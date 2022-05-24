using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Base
{
    public partial class FormConsultaUsuario : Form
    {
        public FormConsultaUsuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario(usuarioBindingSource.Current))
            {
                frm.ShowDialog();
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            UsuarioBLL usuarioBLL = new UsuarioBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Id"]);
            usuarioBLL.Excluir(id);
            usuarioBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonEncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormConsultaUsuario_Load(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
            
        }
    }
}
