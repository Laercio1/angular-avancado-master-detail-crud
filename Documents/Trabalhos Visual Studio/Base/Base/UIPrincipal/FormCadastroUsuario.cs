using BLL;
using Model;
using System;
using System.Windows.Forms;
using System.IO;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        private bool inserindoNovo;

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";

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

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SalvarDados())
                {
                    usuarioBindingSource.EndEdit();
                    if (inserindoNovo)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    else
                        MessageBox.Show("Cadastro atualizado com sucesso!");
                    Close();
                    nomeUsuarioTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);

            }
        }
        private bool SalvarDados()
        {
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.CPF_CNPJ = cpf_cnpjTextBox.Text;
            usuario.RG = rgTextBox.Text;
            usuario.EstadoCivil = estadoCivilComboBox.SelectedItem.ToString();
            // usuario.DataNascimento = dataNascimentoTextBox.Text;
            usuario.Sexo = sexoComboBox.SelectedItem.ToString();
            usuario.Profissao = profissaoTextBox.Text;
            usuario.Numero = numeroTextBox.Text;
            usuario.Complemento = complementoTextBox.Text;
            usuario.Bairro = bairroTextBox.Text;
            usuario.CEP = cepTextBox.Text;
            usuario.UF = ufComboBox.SelectedItem.ToString();
            usuario.Cidade = cidadeComboBox.SelectedItem.ToString();
            usuario.Endereco = enderecoTextBox.Text;
            usuario.Telefone = telefoneTextBox.Text;
            usuario.Email = emailTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;
            usuario.Foto = destinoCompleto;

            //Validação do objeto usuario
            if (usuario != null)
            {
                var validador = new UsuarioValidacao();
                var resultados = validador.Validate(usuario);

                if (!resultados.IsValid)
                {
                    foreach (var erro in resultados.Errors)
                    {
                        MessageBox.Show(erro.ErrorMessage);
                        return false;
                    }
                }
            }

            Inserir();

            return true;
        }
        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.CPF_CNPJ = cpf_cnpjTextBox.Text;
            usuario.RG = rgTextBox.Text;
            usuario.EstadoCivil = estadoCivilComboBox.SelectedItem.ToString();
            // usuario.DataNascimento = dataNascimentoTextBox.Text;
            usuario.Sexo = sexoComboBox.SelectedItem.ToString();
            usuario.Profissao = profissaoTextBox.Text;
            usuario.Numero = numeroTextBox.Text;
            usuario.Complemento = complementoTextBox.Text;
            usuario.Bairro = bairroTextBox.Text;
            usuario.CEP = cepTextBox.Text;
            usuario.UF = ufComboBox.SelectedItem.ToString();
            usuario.Cidade = cidadeComboBox.SelectedItem.ToString();
            usuario.Endereco = enderecoTextBox.Text;
            usuario.Telefone = telefoneTextBox.Text;
            usuario.Email = emailTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;
            usuario.Foto = destinoCompleto;
            
            if (destinoCompleto == "")
            {
                if (MessageBox.Show("Sem foto selecionada, deseja continuar?", "Erro", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    fotoTextBox.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar foto, deseja continuar:", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            if (inserindoNovo)
                usuarioBLL.Inserir(usuario);
            else
                usuarioBLL.Alterar(usuario);

        }

        private void FormCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void buttonSalvarECadastrarNovo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            Inserir();
            MessageBox.Show("Cadastro realizado com sucesso!");
            usuarioBindingSource.DataSource = typeof(Usuario);
            usuarioBindingSource.AddNew();
            nomeUsuarioTextBox.Focus();
        }

        private void buttonAddimagem_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Globais.caminhoFotos;
            destinoCompleto = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substituir", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
            {
                fotoTextBox.ImageLocation = destinoCompleto;
            }
            else
            {
                MessageBox.Show("Arquivo não copiado");
            }
        }
    }
}
