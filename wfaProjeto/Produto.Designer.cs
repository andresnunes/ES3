namespace wfaProjeto
{
    partial class Produto
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
            this.grpEstoque = new System.Windows.Forms.GroupBox();
            this.txtLocalEstoque = new System.Windows.Forms.TextBox();
            this.lblCapMaxEst = new System.Windows.Forms.Label();
            this.txtCapMinEst = new System.Windows.Forms.TextBox();
            this.txtCapMaxEst = new System.Windows.Forms.TextBox();
            this.lblCapacidadeEstoque = new System.Windows.Forms.Label();
            this.lblCapMinEst = new System.Windows.Forms.Label();
            this.lblLocalEstoque = new System.Windows.Forms.Label();
            this.btnDeletarProduto = new System.Windows.Forms.Button();
            this.btnAtualizarProduto = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLargura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.lblDimensoes = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnVoltaSel = new System.Windows.Forms.Button();
            this.grpEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEstoque
            // 
            this.grpEstoque.Controls.Add(this.txtLocalEstoque);
            this.grpEstoque.Controls.Add(this.lblCapMaxEst);
            this.grpEstoque.Controls.Add(this.txtCapMinEst);
            this.grpEstoque.Controls.Add(this.txtCapMaxEst);
            this.grpEstoque.Controls.Add(this.lblCapacidadeEstoque);
            this.grpEstoque.Controls.Add(this.lblCapMinEst);
            this.grpEstoque.Controls.Add(this.lblLocalEstoque);
            this.grpEstoque.Location = new System.Drawing.Point(23, 281);
            this.grpEstoque.Name = "grpEstoque";
            this.grpEstoque.Size = new System.Drawing.Size(326, 123);
            this.grpEstoque.TabIndex = 69;
            this.grpEstoque.TabStop = false;
            this.grpEstoque.Text = "Estoque";
            // 
            // txtLocalEstoque
            // 
            this.txtLocalEstoque.Location = new System.Drawing.Point(47, 33);
            this.txtLocalEstoque.Name = "txtLocalEstoque";
            this.txtLocalEstoque.Size = new System.Drawing.Size(244, 20);
            this.txtLocalEstoque.TabIndex = 35;
            // 
            // lblCapMaxEst
            // 
            this.lblCapMaxEst.AutoSize = true;
            this.lblCapMaxEst.Location = new System.Drawing.Point(171, 94);
            this.lblCapMaxEst.Name = "lblCapMaxEst";
            this.lblCapMaxEst.Size = new System.Drawing.Size(43, 13);
            this.lblCapMaxEst.TabIndex = 48;
            this.lblCapMaxEst.Text = "Máxima";
            // 
            // txtCapMinEst
            // 
            this.txtCapMinEst.Location = new System.Drawing.Point(88, 87);
            this.txtCapMinEst.Name = "txtCapMinEst";
            this.txtCapMinEst.Size = new System.Drawing.Size(67, 20);
            this.txtCapMinEst.TabIndex = 39;
            // 
            // txtCapMaxEst
            // 
            this.txtCapMaxEst.Location = new System.Drawing.Point(215, 87);
            this.txtCapMaxEst.Name = "txtCapMaxEst";
            this.txtCapMaxEst.Size = new System.Drawing.Size(67, 20);
            this.txtCapMaxEst.TabIndex = 47;
            // 
            // lblCapacidadeEstoque
            // 
            this.lblCapacidadeEstoque.AutoSize = true;
            this.lblCapacidadeEstoque.Location = new System.Drawing.Point(44, 71);
            this.lblCapacidadeEstoque.Name = "lblCapacidadeEstoque";
            this.lblCapacidadeEstoque.Size = new System.Drawing.Size(67, 13);
            this.lblCapacidadeEstoque.TabIndex = 40;
            this.lblCapacidadeEstoque.Text = "Capacidade ";
            // 
            // lblCapMinEst
            // 
            this.lblCapMinEst.AutoSize = true;
            this.lblCapMinEst.Location = new System.Drawing.Point(44, 94);
            this.lblCapMinEst.Name = "lblCapMinEst";
            this.lblCapMinEst.Size = new System.Drawing.Size(42, 13);
            this.lblCapMinEst.TabIndex = 46;
            this.lblCapMinEst.Text = "Miníma";
            // 
            // lblLocalEstoque
            // 
            this.lblLocalEstoque.AutoSize = true;
            this.lblLocalEstoque.Location = new System.Drawing.Point(44, 17);
            this.lblLocalEstoque.Name = "lblLocalEstoque";
            this.lblLocalEstoque.Size = new System.Drawing.Size(33, 13);
            this.lblLocalEstoque.TabIndex = 45;
            this.lblLocalEstoque.Text = "Local";
            // 
            // btnDeletarProduto
            // 
            this.btnDeletarProduto.Location = new System.Drawing.Point(714, 272);
            this.btnDeletarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletarProduto.Name = "btnDeletarProduto";
            this.btnDeletarProduto.Size = new System.Drawing.Size(64, 45);
            this.btnDeletarProduto.TabIndex = 68;
            this.btnDeletarProduto.Text = "Deletar";
            this.btnDeletarProduto.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarProduto
            // 
            this.btnAtualizarProduto.Location = new System.Drawing.Point(612, 271);
            this.btnAtualizarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizarProduto.Name = "btnAtualizarProduto";
            this.btnAtualizarProduto.Size = new System.Drawing.Size(69, 46);
            this.btnAtualizarProduto.TabIndex = 67;
            this.btnAtualizarProduto.Text = "Atualizar";
            this.btnAtualizarProduto.UseVisualStyleBackColor = true;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(392, 271);
            this.btnNovoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(76, 46);
            this.btnNovoProduto.TabIndex = 66;
            this.btnNovoProduto.Text = "Novo";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(501, 272);
            this.btnSalvarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(74, 46);
            this.btnSalvarProduto.TabIndex = 65;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(392, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(386, 168);
            this.dataGridView1.TabIndex = 64;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(136, 193);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(21, 13);
            this.lblAltura.TabIndex = 63;
            this.lblAltura.Text = "cm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 62;
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(255, 193);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(21, 13);
            this.lblLargura.TabIndex = 61;
            this.lblLargura.Text = "cm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "X";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(125, 253);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(22, 13);
            this.lblKg.TabIndex = 59;
            this.lblKg.Text = "KG";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(60, 229);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 58;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(63, 245);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(56, 20);
            this.txtPeso.TabIndex = 57;
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(182, 186);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(67, 20);
            this.txtLargura.TabIndex = 56;
            // 
            // lblDimensoes
            // 
            this.lblDimensoes.AutoSize = true;
            this.lblDimensoes.Location = new System.Drawing.Point(60, 170);
            this.lblDimensoes.Name = "lblDimensoes";
            this.lblDimensoes.Size = new System.Drawing.Size(59, 13);
            this.lblDimensoes.TabIndex = 55;
            this.lblDimensoes.Text = "Dimensões";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(63, 186);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(67, 20);
            this.txtAltura.TabIndex = 54;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(60, 96);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoProduto.TabIndex = 53;
            this.lblCodigoProduto.Text = "Código";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(63, 112);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(244, 20);
            this.txtCodigoProduto.TabIndex = 52;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(60, 32);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProduto.TabIndex = 51;
            this.lblNomeProduto.Text = "Nome";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(63, 48);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(244, 20);
            this.txtNomeProduto.TabIndex = 50;
            // 
            // btnVoltaSel
            // 
            this.btnVoltaSel.Location = new System.Drawing.Point(673, 352);
            this.btnVoltaSel.Name = "btnVoltaSel";
            this.btnVoltaSel.Size = new System.Drawing.Size(105, 36);
            this.btnVoltaSel.TabIndex = 70;
            this.btnVoltaSel.Text = "Voltar a Seleção";
            this.btnVoltaSel.UseVisualStyleBackColor = true;
            this.btnVoltaSel.Click += new System.EventHandler(this.btnVoltaSel_Click);
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltaSel);
            this.Controls.Add(this.grpEstoque);
            this.Controls.Add(this.btnDeletarProduto);
            this.Controls.Add(this.btnAtualizarProduto);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLargura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.lblDimensoes);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblCodigoProduto);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.grpEstoque.ResumeLayout(false);
            this.grpEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEstoque;
        private System.Windows.Forms.TextBox txtLocalEstoque;
        private System.Windows.Forms.Label lblCapMaxEst;
        private System.Windows.Forms.TextBox txtCapMinEst;
        private System.Windows.Forms.TextBox txtCapMaxEst;
        private System.Windows.Forms.Label lblCapacidadeEstoque;
        private System.Windows.Forms.Label lblCapMinEst;
        private System.Windows.Forms.Label lblLocalEstoque;
        private System.Windows.Forms.Button btnDeletarProduto;
        private System.Windows.Forms.Button btnAtualizarProduto;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Label lblDimensoes;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnVoltaSel;
    }
}