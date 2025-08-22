namespace SharedEmpresa
{
    partial class Carrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrinho));
            btnVoltar = new Button();
            btnFinalizar = new Button();
            dataGridViewCarrinho = new DataGridView();
            lblTotal = new Label();
            cboFormaPagamento = new ComboBox();
            btnExcluir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(579, 553);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(86, 31);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(798, 553);
            btnFinalizar.Margin = new Padding(3, 4, 3, 4);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(86, 31);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // dataGridViewCarrinho
            // 
            dataGridViewCarrinho.BackgroundColor = SystemColors.Control;
            dataGridViewCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrinho.Location = new Point(12, 163);
            dataGridViewCarrinho.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCarrinho.Name = "dataGridViewCarrinho";
            dataGridViewCarrinho.RowHeadersWidth = 51;
            dataGridViewCarrinho.Size = new Size(890, 333);
            dataGridViewCarrinho.TabIndex = 2;
            dataGridViewCarrinho.CellContentClick += dataGridViewCarrinho_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(26, 514);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // cboFormaPagamento
            // 
            cboFormaPagamento.FormattingEnabled = true;
            cboFormaPagamento.Location = new Point(30, 553);
            cboFormaPagamento.Margin = new Padding(3, 4, 3, 4);
            cboFormaPagamento.Name = "cboFormaPagamento";
            cboFormaPagamento.Size = new Size(138, 28);
            cboFormaPagamento.TabIndex = 4;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(695, 553);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 31);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumBlue;
            pictureBox2.Location = new Point(-17, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(988, 116);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(377, -5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(183, 116);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // Carrinho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnExcluir);
            Controls.Add(cboFormaPagamento);
            Controls.Add(lblTotal);
            Controls.Add(dataGridViewCarrinho);
            Controls.Add(btnFinalizar);
            Controls.Add(btnVoltar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Carrinho";
            Text = "Carrinho";
            Load += Carrinho_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnFinalizar;
        private DataGridView dataGridViewCarrinho;
        private Label lblTotal;
        private ComboBox cboFormaPagamento;
        private Button btnExcluir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}