namespace SharedEmpresa
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            Email = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            btnLogar = new Button();
            label12 = new Label();
            chkMostrarSenha = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Email.AutoSize = true;
            Email.BackColor = SystemColors.ControlLightLight;
            Email.Location = new Point(278, 153);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(278, 208);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSenha.Location = new Point(343, 205);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnLogar
            // 
            btnLogar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogar.BackColor = SystemColors.ButtonHighlight;
            btnLogar.Location = new Point(368, 285);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 6;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(284, 253);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 7;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.BackColor = SystemColors.ControlLightLight;
            chkMostrarSenha.Location = new Point(449, 207);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(101, 19);
            chkMostrarSenha.TabIndex = 8;
            chkMostrarSenha.Text = "Mostrar senha";
            chkMostrarSenha.UseVisualStyleBackColor = false;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(343, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TelaLogin1;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(chkMostrarSenha);
            Controls.Add(label12);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(Email);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Email;
        private Label label2;
        private TextBox txtSenha;
        private Button btnLogar;
        private Label label12;
        private CheckBox chkMostrarSenha;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtEmail;
    }
}