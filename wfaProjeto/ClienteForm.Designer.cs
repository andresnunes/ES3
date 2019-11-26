namespace wfaProjeto
{
    partial class Cliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rdbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNúmero = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnAtualizarCliente = new System.Windows.Forms.Button();
            this.btnDeletarCliente = new System.Windows.Forms.Button();
            this.btnVoltaSel = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPessoaJuridica);
            this.groupBox1.Controls.Add(this.rdbPessoaFisica);
            this.groupBox1.Location = new System.Drawing.Point(9, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de cliente:";
            // 
            // rdbPessoaJuridica
            // 
            this.rdbPessoaJuridica.AutoSize = true;
            this.rdbPessoaJuridica.Location = new System.Drawing.Point(11, 99);
            this.rdbPessoaJuridica.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPessoaJuridica.Name = "rdbPessoaJuridica";
            this.rdbPessoaJuridica.Size = new System.Drawing.Size(98, 17);
            this.rdbPessoaJuridica.TabIndex = 2;
            this.rdbPessoaJuridica.TabStop = true;
            this.rdbPessoaJuridica.Text = "Pessoa jurídica";
            this.rdbPessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // rdbPessoaFisica
            // 
            this.rdbPessoaFisica.AutoSize = true;
            this.rdbPessoaFisica.Location = new System.Drawing.Point(11, 51);
            this.rdbPessoaFisica.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPessoaFisica.Name = "rdbPessoaFisica";
            this.rdbPessoaFisica.Size = new System.Drawing.Size(89, 17);
            this.rdbPessoaFisica.TabIndex = 1;
            this.rdbPessoaFisica.TabStop = true;
            this.rdbPessoaFisica.Text = "Pessoa física";
            this.rdbPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(190, 17);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCliente.TabIndex = 1;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(190, 70);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(342, 70);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(77, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone (fixo):";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(28, 207);
            this.lblCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 4;
            this.lblCep.Text = "CEP:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(193, 131);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(193, 42);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(378, 20);
            this.txtNomeCliente.TabIndex = 6;
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(193, 95);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(2);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(86, 20);
            this.mskCpf.TabIndex = 7;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(344, 95);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.mskTelefone.Mask = "(00) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(86, 20);
            this.mskTelefone.TabIndex = 8;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(482, 70);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(92, 13);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Telefone (celular):";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(484, 95);
            this.mskCelular.Margin = new System.Windows.Forms.Padding(2);
            this.mskCelular.Mask = "(00) 90000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(86, 20);
            this.mskCelular.TabIndex = 10;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(193, 159);
            this.txtEmailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(378, 20);
            this.txtEmailCliente.TabIndex = 11;
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(27, 249);
            this.lblEndereço.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(56, 13);
            this.lblEndereço.TabIndex = 13;
            this.lblEndereço.Text = "Endereço:";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(28, 356);
            this.lblMunicipio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(57, 13);
            this.lblMunicipio.TabIndex = 14;
            this.lblMunicipio.Text = "Município:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(28, 296);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 15;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNúmero
            // 
            this.lblNúmero.AutoSize = true;
            this.lblNúmero.Location = new System.Drawing.Point(482, 249);
            this.lblNúmero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNúmero.Name = "lblNúmero";
            this.lblNúmero.Size = new System.Drawing.Size(47, 13);
            this.lblNúmero.TabIndex = 16;
            this.lblNúmero.Text = "Número:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(124, 296);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 17;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(486, 356);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado:";
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(29, 223);
            this.mskCep.Margin = new System.Windows.Forms.Padding(2);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(86, 20);
            this.mskCep.TabIndex = 19;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(29, 265);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(434, 20);
            this.txtEndereco.TabIndex = 20;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(484, 265);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(86, 20);
            this.txtNumero.TabIndex = 21;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(127, 316);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(444, 20);
            this.txtBairro.TabIndex = 22;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(30, 316);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(85, 20);
            this.txtComplemento.TabIndex = 23;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(29, 371);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(434, 20);
            this.txtMunicipio.TabIndex = 24;
            // 
            // dtgCliente
            // 
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(610, 17);
            this.dtgCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.RowHeadersWidth = 51;
            this.dtgCliente.RowTemplate.Height = 24;
            this.dtgCliente.Size = new System.Drawing.Size(386, 220);
            this.dtgCliente.TabIndex = 26;
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Location = new System.Drawing.Point(719, 266);
            this.btnSalvarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(74, 46);
            this.btnSalvarCliente.TabIndex = 27;
            this.btnSalvarCliente.Text = "Salvar";
            this.btnSalvarCliente.UseVisualStyleBackColor = true;
            this.btnSalvarCliente.Click += new System.EventHandler(this.btnSalvarCliente_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(610, 265);
            this.btnNovoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(76, 46);
            this.btnNovoCliente.TabIndex = 28;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnAtualizarCliente
            // 
            this.btnAtualizarCliente.Location = new System.Drawing.Point(830, 265);
            this.btnAtualizarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizarCliente.Name = "btnAtualizarCliente";
            this.btnAtualizarCliente.Size = new System.Drawing.Size(69, 46);
            this.btnAtualizarCliente.TabIndex = 29;
            this.btnAtualizarCliente.Text = "Atualizar";
            this.btnAtualizarCliente.UseVisualStyleBackColor = true;
            this.btnAtualizarCliente.Click += new System.EventHandler(this.btnAtualizarCliente_Click);
            // 
            // btnDeletarCliente
            // 
            this.btnDeletarCliente.Location = new System.Drawing.Point(932, 266);
            this.btnDeletarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new System.Drawing.Size(64, 45);
            this.btnDeletarCliente.TabIndex = 30;
            this.btnDeletarCliente.Text = "Deletar";
            this.btnDeletarCliente.UseVisualStyleBackColor = true;
            // 
            // btnVoltaSel
            // 
            this.btnVoltaSel.Location = new System.Drawing.Point(878, 356);
            this.btnVoltaSel.Name = "btnVoltaSel";
            this.btnVoltaSel.Size = new System.Drawing.Size(105, 36);
            this.btnVoltaSel.TabIndex = 31;
            this.btnVoltaSel.Text = "Voltar a Seleção";
            this.btnVoltaSel.UseVisualStyleBackColor = true;
            this.btnVoltaSel.Click += new System.EventHandler(this.btnVoltaSel_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(130, 223);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(444, 20);
            this.txtCidade.TabIndex = 33;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(127, 203);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 32;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(484, 372);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(90, 20);
            this.txtEstado.TabIndex = 34;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 413);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.btnVoltaSel);
            this.Controls.Add(this.btnDeletarCliente);
            this.Controls.Add(this.btnAtualizarCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.btnSalvarCliente);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblNúmero);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPessoaJuridica;
        private System.Windows.Forms.RadioButton rdbPessoaFisica;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNúmero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnAtualizarCliente;
        private System.Windows.Forms.Button btnDeletarCliente;
        private System.Windows.Forms.Button btnVoltaSel;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEstado;
    }
}