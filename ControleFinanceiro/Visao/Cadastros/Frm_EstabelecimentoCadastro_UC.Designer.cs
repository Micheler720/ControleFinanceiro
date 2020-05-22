namespace ControleFinanceiro.Visao.Cadastros
{
    partial class Frm_EstabelecimentoCadastro_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EstabelecimentoCadastro_UC));
            this.Lbl_NomeEstabelecimento = new System.Windows.Forms.Label();
            this.Lbl_TipoEstabelecimento = new System.Windows.Forms.Label();
            this.Txt_NomeEstabelecimento = new System.Windows.Forms.TextBox();
            this.Cbo_TipoEstabelecimento = new System.Windows.Forms.ComboBox();
            this.Grp_DadosEstabelecimento = new System.Windows.Forms.GroupBox();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Grp_EnderecoEstabelecimento = new System.Windows.Forms.GroupBox();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Msk_Numero = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Endereco = new System.Windows.Forms.Label();
            this.Txt_Endereco = new System.Windows.Forms.TextBox();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Msk_CEP = new System.Windows.Forms.MaskedTextBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Gravar = new System.Windows.Forms.Button();
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Lbl_Legenda = new System.Windows.Forms.Label();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Grp_DadosEstabelecimento.SuspendLayout();
            this.Grp_EnderecoEstabelecimento.SuspendLayout();
            this.Tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_NomeEstabelecimento
            // 
            this.Lbl_NomeEstabelecimento.AutoSize = true;
            this.Lbl_NomeEstabelecimento.Location = new System.Drawing.Point(6, 67);
            this.Lbl_NomeEstabelecimento.Name = "Lbl_NomeEstabelecimento";
            this.Lbl_NomeEstabelecimento.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeEstabelecimento.TabIndex = 0;
            this.Lbl_NomeEstabelecimento.Text = "label1";
            // 
            // Lbl_TipoEstabelecimento
            // 
            this.Lbl_TipoEstabelecimento.AutoSize = true;
            this.Lbl_TipoEstabelecimento.Location = new System.Drawing.Point(92, 16);
            this.Lbl_TipoEstabelecimento.Name = "Lbl_TipoEstabelecimento";
            this.Lbl_TipoEstabelecimento.Size = new System.Drawing.Size(35, 13);
            this.Lbl_TipoEstabelecimento.TabIndex = 1;
            this.Lbl_TipoEstabelecimento.Text = "label2";
            // 
            // Txt_NomeEstabelecimento
            // 
            this.Txt_NomeEstabelecimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeEstabelecimento.Location = new System.Drawing.Point(6, 83);
            this.Txt_NomeEstabelecimento.Name = "Txt_NomeEstabelecimento";
            this.Txt_NomeEstabelecimento.Size = new System.Drawing.Size(476, 20);
            this.Txt_NomeEstabelecimento.TabIndex = 3;
            this.Txt_NomeEstabelecimento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NomeEstabelecimento_KeyUp);
            // 
            // Cbo_TipoEstabelecimento
            // 
            this.Cbo_TipoEstabelecimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbo_TipoEstabelecimento.FormattingEnabled = true;
            this.Cbo_TipoEstabelecimento.Location = new System.Drawing.Point(92, 34);
            this.Cbo_TipoEstabelecimento.Name = "Cbo_TipoEstabelecimento";
            this.Cbo_TipoEstabelecimento.Size = new System.Drawing.Size(239, 21);
            this.Cbo_TipoEstabelecimento.TabIndex = 2;
            // 
            // Grp_DadosEstabelecimento
            // 
            this.Grp_DadosEstabelecimento.Controls.Add(this.Lbl_TipoEstabelecimento);
            this.Grp_DadosEstabelecimento.Controls.Add(this.Cbo_TipoEstabelecimento);
            this.Grp_DadosEstabelecimento.Controls.Add(this.Lbl_Codigo);
            this.Grp_DadosEstabelecimento.Controls.Add(this.Lbl_NomeEstabelecimento);
            this.Grp_DadosEstabelecimento.Controls.Add(this.Txt_NomeEstabelecimento);
            this.Grp_DadosEstabelecimento.Controls.Add(this.Txt_Codigo);
            this.Grp_DadosEstabelecimento.Location = new System.Drawing.Point(19, 61);
            this.Grp_DadosEstabelecimento.Name = "Grp_DadosEstabelecimento";
            this.Grp_DadosEstabelecimento.Size = new System.Drawing.Size(495, 120);
            this.Grp_DadosEstabelecimento.TabIndex = 4;
            this.Grp_DadosEstabelecimento.TabStop = false;
            this.Grp_DadosEstabelecimento.Text = "groupBox1";
            this.Grp_DadosEstabelecimento.Enter += new System.EventHandler(this.Grp_DadosEstabelecimento_Enter);
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(6, 16);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Codigo.TabIndex = 10;
            this.Lbl_Codigo.Text = "label2";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(7, 34);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(70, 20);
            this.Txt_Codigo.TabIndex = 1;
            // 
            // Grp_EnderecoEstabelecimento
            // 
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Lbl_Cidade);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Txt_Cidade);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Txt_Complemento);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Lbl_Complemento);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Msk_Numero);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Lbl_Numero);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Txt_Bairro);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Lbl_Bairro);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Lbl_Endereco);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Txt_Endereco);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Lbl_CEP);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Msk_CEP);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Cbo_Estado);
            this.Grp_EnderecoEstabelecimento.Controls.Add(this.Lbl_Estado);
            this.Grp_EnderecoEstabelecimento.Location = new System.Drawing.Point(19, 187);
            this.Grp_EnderecoEstabelecimento.Name = "Grp_EnderecoEstabelecimento";
            this.Grp_EnderecoEstabelecimento.Size = new System.Drawing.Size(495, 157);
            this.Grp_EnderecoEstabelecimento.TabIndex = 5;
            this.Grp_EnderecoEstabelecimento.TabStop = false;
            this.Grp_EnderecoEstabelecimento.Text = "groupBox1";
            this.Grp_EnderecoEstabelecimento.Enter += new System.EventHandler(this.Grp_EnderecoEstabelecimento_Enter);
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Location = new System.Drawing.Point(185, 15);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Cidade.TabIndex = 20;
            this.Lbl_Cidade.Text = "label1";
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(188, 31);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(294, 20);
            this.Txt_Cidade.TabIndex = 6;
            this.Txt_Cidade.TextChanged += new System.EventHandler(this.Txt_Cidade_TextChanged);
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Complemento.Location = new System.Drawing.Point(304, 117);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(178, 20);
            this.Txt_Complemento.TabIndex = 10;
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Location = new System.Drawing.Point(301, 101);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Complemento.TabIndex = 17;
            this.Lbl_Complemento.Text = "label2";
            // 
            // Msk_Numero
            // 
            this.Msk_Numero.Location = new System.Drawing.Point(234, 117);
            this.Msk_Numero.Name = "Msk_Numero";
            this.Msk_Numero.Size = new System.Drawing.Size(66, 20);
            this.Msk_Numero.TabIndex = 9;
            this.Msk_Numero.TextChanged += new System.EventHandler(this.Msk_Numero_TextChanged);
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.AutoSize = true;
            this.Lbl_Numero.Location = new System.Drawing.Point(233, 101);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Numero.TabIndex = 15;
            this.Lbl_Numero.Text = "label2";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(6, 117);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(222, 20);
            this.Txt_Bairro.TabIndex = 8;
            this.Txt_Bairro.TextChanged += new System.EventHandler(this.Txt_Bairro_TextChanged);
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(4, 101);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Bairro.TabIndex = 13;
            this.Lbl_Bairro.Text = "label2";
            // 
            // Lbl_Endereco
            // 
            this.Lbl_Endereco.AutoSize = true;
            this.Lbl_Endereco.Location = new System.Drawing.Point(4, 61);
            this.Lbl_Endereco.Name = "Lbl_Endereco";
            this.Lbl_Endereco.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Endereco.TabIndex = 12;
            this.Lbl_Endereco.Text = "label2";
            // 
            // Txt_Endereco
            // 
            this.Txt_Endereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Endereco.Location = new System.Drawing.Point(6, 78);
            this.Txt_Endereco.Name = "Txt_Endereco";
            this.Txt_Endereco.Size = new System.Drawing.Size(476, 20);
            this.Txt_Endereco.TabIndex = 7;
            this.Txt_Endereco.TextChanged += new System.EventHandler(this.Txt_Endereco_TextChanged);
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Location = new System.Drawing.Point(6, 16);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(35, 13);
            this.Lbl_CEP.TabIndex = 10;
            this.Lbl_CEP.Text = "label2";
            // 
            // Msk_CEP
            // 
            this.Msk_CEP.Location = new System.Drawing.Point(6, 32);
            this.Msk_CEP.Mask = "00000-000";
            this.Msk_CEP.Name = "Msk_CEP";
            this.Msk_CEP.Size = new System.Drawing.Size(100, 20);
            this.Msk_CEP.TabIndex = 4;
            this.Msk_CEP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Msk_CEP_KeyUp);
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(112, 31);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(70, 21);
            this.Cbo_Estado.TabIndex = 5;
            this.Cbo_Estado.SelectedIndexChanged += new System.EventHandler(this.Cbo_Estado_SelectedIndexChanged);
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(112, 16);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Estado.TabIndex = 7;
            this.Lbl_Estado.Text = "label2";
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(354, 372);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 6;
            this.Btn_Novo.Text = "button1";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(435, 372);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Excluir.TabIndex = 8;
            this.Btn_Excluir.Text = "button3";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(192, 372);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Editar.TabIndex = 9;
            this.Btn_Editar.Text = "button1";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Gravar
            // 
            this.Btn_Gravar.Location = new System.Drawing.Point(273, 372);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Gravar.TabIndex = 11;
            this.Btn_Gravar.Text = "button1";
            this.Btn_Gravar.UseVisualStyleBackColor = true;
            this.Btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.abrirToolStripButton,
            this.toolStripSeparator,
            this.ajudaToolStripButton});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(523, 25);
            this.Tls_Principal.TabIndex = 11;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ControleFinanceiro.Properties.Resources.LimparBarra;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(149, 25);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(209, 23);
            this.LblTitulo.TabIndex = 12;
            this.LblTitulo.Text = "Cadastro Estabelecimento";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // Lbl_Legenda
            // 
            this.Lbl_Legenda.AutoSize = true;
            this.Lbl_Legenda.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Legenda.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Legenda.Location = new System.Drawing.Point(18, 354);
            this.Lbl_Legenda.Name = "Lbl_Legenda";
            this.Lbl_Legenda.Size = new System.Drawing.Size(48, 17);
            this.Lbl_Legenda.TabIndex = 13;
            this.Lbl_Legenda.Text = "label2";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ajudaToolStripButton.Text = "&Ajuda";
            // 
            // Frm_EstabelecimentoCadastro_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_Legenda);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.Tls_Principal);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.Grp_EnderecoEstabelecimento);
            this.Controls.Add(this.Grp_DadosEstabelecimento);
            this.Name = "Frm_EstabelecimentoCadastro_UC";
            this.Size = new System.Drawing.Size(523, 401);
            this.Load += new System.EventHandler(this.Frm_EstabelecimentoCadastro_UC_Load);
            this.Grp_DadosEstabelecimento.ResumeLayout(false);
            this.Grp_DadosEstabelecimento.PerformLayout();
            this.Grp_EnderecoEstabelecimento.ResumeLayout(false);
            this.Grp_EnderecoEstabelecimento.PerformLayout();
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_NomeEstabelecimento;
        private System.Windows.Forms.Label Lbl_TipoEstabelecimento;
        private System.Windows.Forms.TextBox Txt_NomeEstabelecimento;
        private System.Windows.Forms.ComboBox Cbo_TipoEstabelecimento;
        private System.Windows.Forms.GroupBox Grp_DadosEstabelecimento;
        private System.Windows.Forms.GroupBox Grp_EnderecoEstabelecimento;
        private System.Windows.Forms.MaskedTextBox Msk_CEP;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.MaskedTextBox Msk_Numero;
        private System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Endereco;
        private System.Windows.Forms.TextBox Txt_Endereco;
        private System.Windows.Forms.Label Lbl_CEP;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Button Btn_Gravar;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label Lbl_Legenda;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton;
    }
}
