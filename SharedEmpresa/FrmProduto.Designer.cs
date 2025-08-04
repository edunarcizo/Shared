namespace SharedEmpresa
{
    partial class FrmProduto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            label4 = new Label();
            txtQuantidade = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 57);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 92);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(115, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(115, 57);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(115, 92);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 127);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(115, 127);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 7;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtQuantidade);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private TextBox txtValor;
        private Label label4;
        private TextBox txtQuantidade;
    }
}