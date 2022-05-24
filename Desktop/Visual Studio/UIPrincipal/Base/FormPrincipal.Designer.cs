
namespace Base
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelConteiner = new Base.GradientPainel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gradientPainel3 = new Base.GradientPainel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.barraTitulo = new Base.GradientPainel();
            this.buttonMenu = new System.Windows.Forms.PictureBox();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonRestaurar = new System.Windows.Forms.Button();
            this.buttonMaximizar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.menuVertical = new Base.GradientPainel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.buttonGrupoUsuario = new System.Windows.Forms.Button();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelConteiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradientPainel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConteiner
            // 
            this.panelConteiner.ColorBottom = System.Drawing.Color.Empty;
            this.panelConteiner.ColorTop = System.Drawing.Color.Empty;
            this.panelConteiner.Controls.Add(this.pictureBox2);
            this.panelConteiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteiner.Location = new System.Drawing.Point(269, 50);
            this.panelConteiner.Name = "panelConteiner";
            this.panelConteiner.Size = new System.Drawing.Size(1031, 550);
            this.panelConteiner.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(189, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(676, 390);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // gradientPainel3
            // 
            this.gradientPainel3.ColorBottom = System.Drawing.Color.SkyBlue;
            this.gradientPainel3.ColorTop = System.Drawing.Color.SkyBlue;
            this.gradientPainel3.Controls.Add(this.statusStrip1);
            this.gradientPainel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPainel3.Location = new System.Drawing.Point(269, 600);
            this.gradientPainel3.Name = "gradientPainel3";
            this.gradientPainel3.Size = new System.Drawing.Size(1031, 50);
            this.gradientPainel3.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, -1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 51);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 46);
            this.toolStripStatusLabel1.Text = "Usuário: Teste";
            // 
            // barraTitulo
            // 
            this.barraTitulo.ColorBottom = System.Drawing.Color.SteelBlue;
            this.barraTitulo.ColorTop = System.Drawing.Color.SteelBlue;
            this.barraTitulo.Controls.Add(this.buttonMenu);
            this.barraTitulo.Controls.Add(this.buttonMinimizar);
            this.barraTitulo.Controls.Add(this.buttonRestaurar);
            this.barraTitulo.Controls.Add(this.buttonMaximizar);
            this.barraTitulo.Controls.Add(this.buttonSair);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(269, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1031, 50);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.Location = new System.Drawing.Point(3, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(40, 40);
            this.buttonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMenu.TabIndex = 5;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.buttonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.Image")));
            this.buttonMinimizar.Location = new System.Drawing.Point(926, 3);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(40, 40);
            this.buttonMinimizar.TabIndex = 3;
            this.buttonMinimizar.UseVisualStyleBackColor = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestaurar.FlatAppearance.BorderSize = 0;
            this.buttonRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestaurar.Image")));
            this.buttonRestaurar.Location = new System.Drawing.Point(957, 3);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(40, 40);
            this.buttonRestaurar.TabIndex = 2;
            this.buttonRestaurar.UseVisualStyleBackColor = false;
            this.buttonRestaurar.Click += new System.EventHandler(this.buttonRestaurar_Click);
            // 
            // buttonMaximizar
            // 
            this.buttonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximizar.FlatAppearance.BorderSize = 0;
            this.buttonMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximizar.Image")));
            this.buttonMaximizar.Location = new System.Drawing.Point(957, 3);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Size = new System.Drawing.Size(40, 40);
            this.buttonMaximizar.TabIndex = 1;
            this.buttonMaximizar.UseVisualStyleBackColor = false;
            this.buttonMaximizar.Click += new System.EventHandler(this.buttonMaximizar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.BackColor = System.Drawing.Color.Transparent;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.Location = new System.Drawing.Point(988, 3);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(40, 40);
            this.buttonSair.TabIndex = 0;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.AutoScroll = true;
            this.menuVertical.BackColor = System.Drawing.Color.Transparent;
            this.menuVertical.ColorBottom = System.Drawing.Color.SkyBlue;
            this.menuVertical.ColorTop = System.Drawing.Color.SteelBlue;
            this.menuVertical.Controls.Add(this.panelSubMenu);
            this.menuVertical.Controls.Add(this.buttonCadastro);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(269, 650);
            this.menuVertical.TabIndex = 0;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.buttonGrupoUsuario);
            this.panelSubMenu.Controls.Add(this.buttonUsuario);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 128);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(269, 99);
            this.panelSubMenu.TabIndex = 5;
            // 
            // buttonGrupoUsuario
            // 
            this.buttonGrupoUsuario.FlatAppearance.BorderSize = 0;
            this.buttonGrupoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonGrupoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonGrupoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrupoUsuario.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.buttonGrupoUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGrupoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGrupoUsuario.Location = new System.Drawing.Point(3, 50);
            this.buttonGrupoUsuario.Name = "buttonGrupoUsuario";
            this.buttonGrupoUsuario.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.buttonGrupoUsuario.Size = new System.Drawing.Size(263, 40);
            this.buttonGrupoUsuario.TabIndex = 8;
            this.buttonGrupoUsuario.Text = "  Grupo de Usuários";
            this.buttonGrupoUsuario.UseVisualStyleBackColor = true;
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.FlatAppearance.BorderSize = 0;
            this.buttonUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuario.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.buttonUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsuario.Location = new System.Drawing.Point(3, 3);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonUsuario.Size = new System.Drawing.Size(263, 40);
            this.buttonUsuario.TabIndex = 7;
            this.buttonUsuario.Text = "Usuários";
            this.buttonUsuario.UseVisualStyleBackColor = true;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCadastro.FlatAppearance.BorderSize = 0;
            this.buttonCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastro.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.buttonCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastro.Location = new System.Drawing.Point(0, 88);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCadastro.Size = new System.Drawing.Size(269, 40);
            this.buttonCadastro.TabIndex = 5;
            this.buttonCadastro.Text = "Cadastro";
            this.buttonCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastro.UseVisualStyleBackColor = true;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonCadastro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelConteiner);
            this.Controls.Add(this.gradientPainel3);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelConteiner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradientPainel3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPainel menuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GradientPainel barraTitulo;
        private GradientPainel gradientPainel3;
        private GradientPainel panelConteiner;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.Button buttonRestaurar;
        private System.Windows.Forms.Button buttonMaximizar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.PictureBox buttonMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button buttonGrupoUsuario;
        private System.Windows.Forms.Button buttonUsuario;
    }
}

