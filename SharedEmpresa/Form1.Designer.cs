namespace SharedEmpresa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            dataGridView1 = new DataGridView();
            cboCargo = new ComboBox();
            label6 = new Label();
            chkAtivo = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 132);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 176);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 220);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 265);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 309);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Cargo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(119, 132);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(114, 27);
            txtCodigo.TabIndex = 5;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(119, 176);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 27);
            txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(119, 220);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(119, 265);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(114, 27);
            txtSenha.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(311, 132);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(86, 31);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(311, 176);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(311, 220);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 31);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(311, 265);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(86, 31);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 385);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(890, 200);
            dataGridView1.TabIndex = 13;
            // 
            // cboCargo
            // 
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(119, 309);
            cboCargo.Margin = new Padding(3, 4, 3, 4);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(138, 28);
            cboCargo.TabIndex = 14;
            cboCargo.SelectedIndexChanged += cboCargo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 361);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 15;
            label6.Text = "Ativo";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(119, 361);
            chkAtivo.Margin = new Padding(3, 4, 3, 4);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(66, 24);
            chkAtivo.TabIndex = 16;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            chkAtivo.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumBlue;
            pictureBox2.Location = new Point(-10, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(988, 116);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(364, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(183, 116);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(chkAtivo);
            Controls.Add(label6);
            Controls.Add(cboCargo);
            Controls.Add(dataGridView1);
            Controls.Add(btnPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private DataGridView dataGridView1;
        private ComboBox cboCargo;
        private Label label6;
        private CheckBox chkAtivo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
