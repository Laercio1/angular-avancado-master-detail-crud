
namespace UIPrincipal
{
    partial class FormCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label ativoLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuario));
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonSalvarECadastrarNovo = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fotoTextBox = new System.Windows.Forms.PictureBox();
            this.buttonAddimagem = new System.Windows.Forms.Button();
            this.cpf_cnpjTextBox = new System.Windows.Forms.TextBox();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoTextBox = new System.Windows.Forms.TextBox();
            this.profissaoTextBox = new System.Windows.Forms.TextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.estadoCivilComboBox = new System.Windows.Forms.ComboBox();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nivelTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            idLabel.Location = new System.Drawing.Point(202, 49);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(65, 21);
            idLabel.TabIndex = 8;
            idLabel.Text = "Código";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeUsuarioLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nomeUsuarioLabel.Location = new System.Drawing.Point(360, 49);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(122, 21);
            nomeUsuarioLabel.TabIndex = 1;
            nomeUsuarioLabel.Text = "Nome usuário:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            senhaLabel.Location = new System.Drawing.Point(546, 379);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(61, 21);
            senhaLabel.TabIndex = 9;
            senhaLabel.Text = "Senha:";
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(33, 165);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(0, 13);
            ativoLabel.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(258, 379);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 21);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label4.Location = new System.Drawing.Point(32, 379);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 21);
            label4.TabIndex = 5;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label5.Location = new System.Drawing.Point(202, 104);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 21);
            label5.TabIndex = 19;
            label5.Text = "CPF/CNPJ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label6.Location = new System.Drawing.Point(360, 104);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 21);
            label6.TabIndex = 20;
            label6.Text = "RG:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label7.Location = new System.Drawing.Point(559, 104);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(97, 21);
            label7.TabIndex = 21;
            label7.Text = "Estado Civil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(202, 159);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(139, 21);
            label1.TabIndex = 22;
            label1.Text = "Data nascimento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label8.Location = new System.Drawing.Point(360, 159);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(46, 21);
            label8.TabIndex = 23;
            label8.Text = "Sexo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label9.Location = new System.Drawing.Point(559, 159);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(79, 21);
            label9.TabIndex = 24;
            label9.Text = "Profissão";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label10.Location = new System.Drawing.Point(202, 214);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(81, 21);
            label10.TabIndex = 27;
            label10.Text = "Endereço";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label11.Location = new System.Drawing.Point(559, 214);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(31, 21);
            label11.TabIndex = 28;
            label11.Text = "Nº";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label12.Location = new System.Drawing.Point(202, 269);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(119, 21);
            label12.TabIndex = 30;
            label12.Text = "Complemento";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label13.Location = new System.Drawing.Point(422, 269);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(55, 21);
            label13.TabIndex = 32;
            label13.Text = "Bairro";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label14.Location = new System.Drawing.Point(32, 324);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(40, 21);
            label14.TabIndex = 36;
            label14.Text = "CEP";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label15.Location = new System.Drawing.Point(258, 324);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(31, 21);
            label15.TabIndex = 37;
            label15.Text = "UF";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label16.Location = new System.Drawing.Point(481, 324);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(63, 21);
            label16.TabIndex = 38;
            label16.Text = "Cidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(32, 272);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 21);
            label2.TabIndex = 40;
            label2.Text = "Nível";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(36, 501);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Sal&var";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonSalvarECadastrarNovo
            // 
            this.buttonSalvarECadastrarNovo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSalvarECadastrarNovo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalvarECadastrarNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSalvarECadastrarNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSalvarECadastrarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarECadastrarNovo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.buttonSalvarECadastrarNovo.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvarECadastrarNovo.Image")));
            this.buttonSalvarECadastrarNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvarECadastrarNovo.Location = new System.Drawing.Point(139, 501);
            this.buttonSalvarECadastrarNovo.Name = "buttonSalvarECadastrarNovo";
            this.buttonSalvarECadastrarNovo.Size = new System.Drawing.Size(219, 40);
            this.buttonSalvarECadastrarNovo.TabIndex = 2;
            this.buttonSalvarECadastrarNovo.Text = "Salvar e cadastrar um &novo";
            this.buttonSalvarECadastrarNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarECadastrarNovo.UseVisualStyleBackColor = false;
            this.buttonSalvarECadastrarNovo.Click += new System.EventHandler(this.buttonSalvarECadastrarNovo_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSair.Location = new System.Drawing.Point(699, 501);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(85, 40);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "&Sair";
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(204, 73);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(154, 28);
            this.idTextBox.TabIndex = 9;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Model.Usuario);
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(364, 73);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(420, 28);
            this.nomeUsuarioTextBox.TabIndex = 0;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.Location = new System.Drawing.Point(550, 403);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(169, 28);
            this.senhaTextBox.TabIndex = 8;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ativoCheckBox.Location = new System.Drawing.Point(725, 403);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(68, 25);
            this.ativoCheckBox.TabIndex = 10;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox.Location = new System.Drawing.Point(204, 238);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(353, 28);
            this.enderecoTextBox.TabIndex = 2;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Telefone", true));
            this.telefoneTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTextBox.Location = new System.Drawing.Point(36, 403);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(216, 28);
            this.telefoneTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(258, 403);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(286, 28);
            this.emailTextBox.TabIndex = 6;
            // 
            // fotoTextBox
            // 
            this.fotoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.fotoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.usuarioBindingSource, "Foto", true));
            this.fotoTextBox.ImageLocation = "";
            this.fotoTextBox.Location = new System.Drawing.Point(36, 49);
            this.fotoTextBox.Name = "fotoTextBox";
            this.fotoTextBox.Size = new System.Drawing.Size(142, 176);
            this.fotoTextBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoTextBox.TabIndex = 11;
            this.fotoTextBox.TabStop = false;
            // 
            // buttonAddimagem
            // 
            this.buttonAddimagem.Location = new System.Drawing.Point(36, 231);
            this.buttonAddimagem.Name = "buttonAddimagem";
            this.buttonAddimagem.Size = new System.Drawing.Size(142, 38);
            this.buttonAddimagem.TabIndex = 12;
            this.buttonAddimagem.Text = "Selecionar Imagem";
            this.buttonAddimagem.UseVisualStyleBackColor = true;
            this.buttonAddimagem.Click += new System.EventHandler(this.buttonAddimagem_Click);
            // 
            // cpf_cnpjTextBox
            // 
            this.cpf_cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CPF_CNPJ", true));
            this.cpf_cnpjTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf_cnpjTextBox.Location = new System.Drawing.Point(204, 128);
            this.cpf_cnpjTextBox.Name = "cpf_cnpjTextBox";
            this.cpf_cnpjTextBox.Size = new System.Drawing.Size(154, 28);
            this.cpf_cnpjTextBox.TabIndex = 14;
            // 
            // rgTextBox
            // 
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "RG", true));
            this.rgTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTextBox.Location = new System.Drawing.Point(364, 128);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(193, 28);
            this.rgTextBox.TabIndex = 15;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Numero", true));
            this.numeroTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTextBox.Location = new System.Drawing.Point(563, 238);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(221, 28);
            this.numeroTextBox.TabIndex = 16;
            // 
            // dataNascimentoTextBox
            // 
            this.dataNascimentoTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimentoTextBox.Location = new System.Drawing.Point(204, 183);
            this.dataNascimentoTextBox.Name = "dataNascimentoTextBox";
            this.dataNascimentoTextBox.Size = new System.Drawing.Size(154, 28);
            this.dataNascimentoTextBox.TabIndex = 17;
            // 
            // profissaoTextBox
            // 
            this.profissaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Profissao", true));
            this.profissaoTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profissaoTextBox.Location = new System.Drawing.Point(563, 183);
            this.profissaoTextBox.Name = "profissaoTextBox";
            this.profissaoTextBox.Size = new System.Drawing.Size(221, 28);
            this.profissaoTextBox.TabIndex = 19;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Sexo", true));
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexoComboBox.Location = new System.Drawing.Point(364, 182);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(193, 29);
            this.sexoComboBox.TabIndex = 25;
            // 
            // estadoCivilComboBox
            // 
            this.estadoCivilComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "EstadoCivil", true));
            this.estadoCivilComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCivilComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCivilComboBox.FormattingEnabled = true;
            this.estadoCivilComboBox.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Separado",
            "Divorciado",
            "Viúvo"});
            this.estadoCivilComboBox.Location = new System.Drawing.Point(563, 128);
            this.estadoCivilComboBox.Name = "estadoCivilComboBox";
            this.estadoCivilComboBox.Size = new System.Drawing.Size(221, 29);
            this.estadoCivilComboBox.TabIndex = 26;
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Complemento", true));
            this.complementoTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complementoTextBox.Location = new System.Drawing.Point(204, 293);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(216, 28);
            this.complementoTextBox.TabIndex = 29;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Bairro", true));
            this.bairroTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTextBox.Location = new System.Drawing.Point(426, 293);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(358, 28);
            this.bairroTextBox.TabIndex = 31;
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CEP", true));
            this.cepTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepTextBox.Location = new System.Drawing.Point(36, 348);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(216, 28);
            this.cepTextBox.TabIndex = 33;
            // 
            // ufComboBox
            // 
            this.ufComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "UF", true));
            this.ufComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ufComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "Tocantins ",
            "Maranhão",
            "São Paulo",
            "Rio de Janeiro",
            "Pará"});
            this.ufComboBox.Location = new System.Drawing.Point(258, 348);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(221, 29);
            this.ufComboBox.TabIndex = 34;
            // 
            // cidadeComboBox
            // 
            this.cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cidade", true));
            this.cidadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidadeComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Items.AddRange(new object[] {
            "Araguaína ",
            "Palmas",
            "São Paulo",
            "Santos ",
            "Rio de Janeiro",
            "Cabo Frio",
            "Belém do Pará",
            "São Luís"});
            this.cidadeComboBox.Location = new System.Drawing.Point(485, 347);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(299, 29);
            this.cidadeComboBox.TabIndex = 35;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // nivelTextBox
            // 
            this.nivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nivel", true));
            this.nivelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelTextBox.Location = new System.Drawing.Point(36, 295);
            this.nivelTextBox.Name = "nivelTextBox";
            this.nivelTextBox.Size = new System.Drawing.Size(142, 26);
            this.nivelTextBox.TabIndex = 41;
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(818, 566);
            this.Controls.Add(this.nivelTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(label16);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(label15);
            this.Controls.Add(label4);
            this.Controls.Add(label14);
            this.Controls.Add(this.cidadeComboBox);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(label13);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(label12);
            this.Controls.Add(this.complementoTextBox);
            this.Controls.Add(label11);
            this.Controls.Add(label10);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.estadoCivilComboBox);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(label1);
            this.Controls.Add(this.profissaoTextBox);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.dataNascimentoTextBox);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.rgTextBox);
            this.Controls.Add(this.cpf_cnpjTextBox);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(this.buttonAddimagem);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.fotoTextBox);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonSalvarECadastrarNovo);
            this.Controls.Add(this.buttonSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "b";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonSalvarECadastrarNovo;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox fotoTextBox;
        private System.Windows.Forms.Button buttonAddimagem;
        private System.Windows.Forms.TextBox cpf_cnpjTextBox;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox dataNascimentoTextBox;
        private System.Windows.Forms.TextBox profissaoTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.ComboBox estadoCivilComboBox;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox nivelTextBox;
    }
}

