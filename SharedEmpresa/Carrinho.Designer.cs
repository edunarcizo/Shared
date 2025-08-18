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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(507, 415);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(698, 415);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // dataGridViewCarrinho
            // 
            dataGridViewCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrinho.Location = new Point(42, 42);
            dataGridViewCarrinho.Name = "dataGridViewCarrinho";
            dataGridViewCarrinho.Size = new Size(703, 292);
            dataGridViewCarrinho.TabIndex = 2;
            dataGridViewCarrinho.CellContentClick += dataGridViewCarrinho_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(53, 352);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // cboFormaPagamento
            // 
            cboFormaPagamento.FormattingEnabled = true;
            cboFormaPagamento.Location = new Point(57, 381);
            cboFormaPagamento.Name = "cboFormaPagamento";
            cboFormaPagamento.Size = new Size(121, 23);
            cboFormaPagamento.TabIndex = 4;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(608, 415);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Carrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}