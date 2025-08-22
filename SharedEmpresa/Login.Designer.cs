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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Email = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnLogar = new Button();
            label12 = new Label();
            chkMostrarSenha = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(325, 230);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 280);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(392, 230);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(392, 280);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(114, 27);
            txtSenha.TabIndex = 3;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = SystemColors.ButtonHighlight;
            btnLogar.Location = new Point(402, 337);
            btnLogar.Margin = new Padding(3, 4, 3, 4);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(86, 31);
            btnLogar.TabIndex = 6;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(325, 337);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 7;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Location = new Point(512, 283);
            chkMostrarSenha.Margin = new Padding(3, 4, 3, 4);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(124, 24);
            chkMostrarSenha.TabIndex = 8;
            chkMostrarSenha.Text = "Mostrar senha";
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumBlue;
            pictureBox2.Location = new Point(-48, -15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(988, 116);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(367, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(163, 102);
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MediumBlue;
            pictureBox1.Location = new Point(-22, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 452);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.MediumBlue;
            pictureBox4.Location = new Point(858, 79);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(82, 452);
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(914, 524);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(chkMostrarSenha);
            Controls.Add(label12);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(Email);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Email;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnLogar;
        private Label label12;
        private CheckBox chkMostrarSenha;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}