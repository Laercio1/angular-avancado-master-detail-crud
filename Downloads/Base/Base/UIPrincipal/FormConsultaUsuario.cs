using BLL;
using DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Model;
using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormConsultaUsuario : Form
    {
        public FormConsultaUsuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormConsultaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonSair_Click_1(null, null);
            }
        }

        private void FormConsultaUsuario_Load(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
        }

        private void buttonNovo_Click_1(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
            btnBuscar_Click(null, null);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario(usuarioBindingSource.Current))
            {
                frm.ShowDialog();
            }
            btnBuscar_Click(null, null);
        }

        private void buttonExcluir_Click_1(object sender, EventArgs e)
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

        private void buttonImprimir_Click_1(object sender, EventArgs e)
        {
            var vqueryDVG = @"
                   SELECT 
                        Id as 'Id',
                        NomeUsuario as 'NomeUsuario',
                        Endereco as 'Endereco',
                        Telefone as 'Telefone'
                    FROM
                        Usuario";

            string nomeArquivo = Globais.caminho + @"\usuarios.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            //Imagem

            /*            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logocfb.png");
                        logo.ScaleToFit(140f, 120f);
                        //logo.Alignment = Element.ALIGN_LEFT;
                        logo.SetAbsolutePosition(100f, 700f); //X, -Y*/

            //doc.Open();
            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relátorio de Usuário\n\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_LEFT;
            paragrafo2.Add("Usuários\n\n");

            PdfPTable tabela = new PdfPTable(4); //Colunas
            tabela.DefaultCell.FixedHeight = 20;

            tabela.AddCell("ID Usuario");
            tabela.AddCell("Nome Usuário");
            tabela.AddCell("Endereco");
            tabela.AddCell("Telefone");

            DataTable dtUsuarios = Banco.dql(vqueryDVG);
            for (int i = 0; i < dtUsuarios.Rows.Count; i++)
            {
                tabela.AddCell(dtUsuarios.Rows[i].Field<int>("Id").ToString());
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("NomeUsuario"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Endereco"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Telefone"));
            }

            doc.Open();
            //doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(paragrafo2);
            doc.Add(tabela);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o relatório?", "Relátorio", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\usuarios.pdf");
            }
        }

        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
