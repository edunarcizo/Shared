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
            btnVoltar = new Button();
            btnFinalizar = new Button();
            dataGridViewCarrinho = new DataGridView();
            lblTotal = new Label();
            cboFormaPagamento = new ComboBox();
            btnExcluir = new Button();
            txtIdExcluir = new TextBox();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(522, 412);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(713, 412);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // dataGridViewCarrinho
            // 
            dataGridViewCarrinho.BackgroundColor = SystemColors.Control;
            dataGridViewCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrinho.Location = new Point(12, 58);
            dataGridViewCarrinho.Name = "dataGridViewCarrinho";
            dataGridViewCarrinho.RowHeadersWidth = 51;
            dataGridViewCarrinho.Size = new Size(779, 250);
            dataGridViewCarrinho.TabIndex = 2;
            dataGridViewCarrinho.CellContentClick += dataGridViewCarrinho_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Location = new Point(21, 321);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // cboFormaPagamento
            // 
            cboFormaPagamento.FormattingEnabled = true;
            cboFormaPagamento.Location = new Point(219, 368);
            cboFormaPagamento.Name = "cboFormaPagamento";
            cboFormaPagamento.Size = new Size(121, 23);
            cboFormaPagamento.TabIndex = 4;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(623, 412);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtIdExcluir
            // 
            txtIdExcluir.Location = new Point(228, 413);
            txtIdExcluir.Name = "txtIdExcluir";
            txtIdExcluir.Size = new Size(100, 23);
            txtIdExcluir.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(21, 416);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 24;
            label1.Text = "Digite o id do produto a ser excluído:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(21, 371);
            label3.Name = "label3";
            label3.Size = new Size(181, 15);
            label3.TabIndex = 26;
            label3.Text = "Selecione a forma de pagamento";
            // 
            // Carrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Coringa;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtIdExcluir);
            Controls.Add(btnExcluir);
            Controls.Add(cboFormaPagamento);
            Controls.Add(lblTotal);
            Controls.Add(dataGridViewCarrinho);
            Controls.Add(btnFinalizar);
            Controls.Add(btnVoltar);
            Name = "Carrinho";
            Text = "Carrinho";
            Load += Carrinho_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).EndInit();
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
        private TextBox txtIdExcluir;
        private Label label1;
        private Label label3;
    }
}