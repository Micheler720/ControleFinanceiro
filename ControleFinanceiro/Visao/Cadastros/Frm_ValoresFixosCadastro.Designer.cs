namespace ControleFinanceiro.Visao.Cadastros
{
    partial class Frm_ValoresFixosCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValoresFixosCadastro));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Lbl_NomeDespesa = new System.Windows.Forms.Label();
            this.Txt_NomeDespesa = new System.Windows.Forms.TextBox();
            this.Btn_Gravar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Grp_DadosDespesaFixa = new System.Windows.Forms.GroupBox();
            this.Cbo_DiaPagamento = new System.Windows.Forms.ComboBox();
            this.Lbl_DataPagamento = new System.Windows.Forms.Label();
            this.Lbl_Observacao = new System.Windows.Forms.Label();
            this.Txt_Observacao = new System.Windows.Forms.TextBox();
            this.Ckb_AtivoInativo = new System.Windows.Forms.CheckBox();
            this.Lbl_TipoMovimentacao = new System.Windows.Forms.Label();
            this.Cbo_TipoMovimentacao = new System.Windows.Forms.ComboBox();
            this.Btn_BuscaEstabelecimento = new System.Windows.Forms.Button();
            this.Txt_CodigoEstabelecimento = new System.Windows.Forms.TextBox();
            this.Txt_NomeEstabelecimento = new System.Windows.Forms.TextBox();
            this.Lbl_Estabelecimento = new System.Windows.Forms.Label();
            this.Msk_Valor = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.Grp_DadosDespesaFixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.abrirToolStripButton,
            this.ajudaToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(477, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ControleFinanceiro.Properties.Resources.LimparBarra;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            this.abrirToolStripButton.Click += new System.EventHandler(this.abrirToolStripButton_Click);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ajudaToolStripButton.Text = "&Ajuda";
            this.ajudaToolStripButton.Click += new System.EventHandler(this.ajudaToolStripButton_Click);
            // 
            // Lbl_NomeDespesa
            // 
            this.Lbl_NomeDespesa.AutoSize = true;
            this.Lbl_NomeDespesa.Location = new System.Drawing.Point(6, 124);
            this.Lbl_NomeDespesa.Name = "Lbl_NomeDespesa";
            this.Lbl_NomeDespesa.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeDespesa.TabIndex = 1;
            this.Lbl_NomeDespesa.Text = "label1";
            // 
            // Txt_NomeDespesa
            // 
            this.Txt_NomeDespesa.Location = new System.Drawing.Point(9, 140);
            this.Txt_NomeDespesa.Name = "Txt_NomeDespesa";
            this.Txt_NomeDespesa.Size = new System.Drawing.Size(256, 20);
            this.Txt_NomeDespesa.TabIndex = 6;
            this.Txt_NomeDespesa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NomeDespesa_KeyUp);
            // 
            // Btn_Gravar
            // 
            this.Btn_Gravar.Location = new System.Drawing.Point(147, 324);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Gravar.TabIndex = 10;
            this.Btn_Gravar.Text = "button2";
            this.Btn_Gravar.UseVisualStyleBackColor = true;
            this.Btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(309, 324);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Excluir.TabIndex = 11;
            this.Btn_Excluir.Text = "button4";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(228, 324);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 10;
            this.Btn_Novo.Text = "button3";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(66, 324);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Editar.TabIndex = 9;
            this.Btn_Editar.Text = "button2";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(9, 30);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Codigo.TabIndex = 13;
            this.Lbl_Codigo.Text = "label1";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(9, 50);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Codigo.TabIndex = 1;
            // 
            // Grp_DadosDespesaFixa
            // 
            this.Grp_DadosDespesaFixa.Controls.Add(this.Cbo_DiaPagamento);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Lbl_DataPagamento);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Lbl_Observacao);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Txt_Observacao);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Ckb_AtivoInativo);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Lbl_TipoMovimentacao);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Cbo_TipoMovimentacao);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Btn_BuscaEstabelecimento);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Txt_CodigoEstabelecimento);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Txt_NomeEstabelecimento);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Lbl_Estabelecimento);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Msk_Valor);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Lbl_Valor);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Lbl_Codigo);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Txt_Codigo);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Txt_NomeDespesa);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Lbl_NomeDespesa);
            this.Grp_DadosDespesaFixa.Location = new System.Drawing.Point(18, 28);
            this.Grp_DadosDespesaFixa.Name = "Grp_DadosDespesaFixa";
            this.Grp_DadosDespesaFixa.Size = new System.Drawing.Size(447, 284);
            this.Grp_DadosDespesaFixa.TabIndex = 15;
            this.Grp_DadosDespesaFixa.TabStop = false;
            this.Grp_DadosDespesaFixa.Text = "groupBox1";
            this.Grp_DadosDespesaFixa.Enter += new System.EventHandler(this.Grp_DadosDespesaFixa_Enter);
            // 
            // Cbo_DiaPagamento
            // 
            this.Cbo_DiaPagamento.FormattingEnabled = true;
            this.Cbo_DiaPagamento.Location = new System.Drawing.Point(271, 139);
            this.Cbo_DiaPagamento.Name = "Cbo_DiaPagamento";
            this.Cbo_DiaPagamento.Size = new System.Drawing.Size(55, 21);
            this.Cbo_DiaPagamento.TabIndex = 29;
            // 
            // Lbl_DataPagamento
            // 
            this.Lbl_DataPagamento.AutoSize = true;
            this.Lbl_DataPagamento.Location = new System.Drawing.Point(269, 124);
            this.Lbl_DataPagamento.Name = "Lbl_DataPagamento";
            this.Lbl_DataPagamento.Size = new System.Drawing.Size(35, 13);
            this.Lbl_DataPagamento.TabIndex = 28;
            this.Lbl_DataPagamento.Text = "label2";
            // 
            // Lbl_Observacao
            // 
            this.Lbl_Observacao.AutoSize = true;
            this.Lbl_Observacao.Location = new System.Drawing.Point(9, 171);
            this.Lbl_Observacao.Name = "Lbl_Observacao";
            this.Lbl_Observacao.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Observacao.TabIndex = 26;
            this.Lbl_Observacao.Text = "label1";
            // 
            // Txt_Observacao
            // 
            this.Txt_Observacao.Location = new System.Drawing.Point(9, 187);
            this.Txt_Observacao.Multiline = true;
            this.Txt_Observacao.Name = "Txt_Observacao";
            this.Txt_Observacao.Size = new System.Drawing.Size(432, 76);
            this.Txt_Observacao.TabIndex = 9;
            // 
            // Ckb_AtivoInativo
            // 
            this.Ckb_AtivoInativo.AutoSize = true;
            this.Ckb_AtivoInativo.Location = new System.Drawing.Point(272, 53);
            this.Ckb_AtivoInativo.Name = "Ckb_AtivoInativo";
            this.Ckb_AtivoInativo.Size = new System.Drawing.Size(80, 17);
            this.Ckb_AtivoInativo.TabIndex = 3;
            this.Ckb_AtivoInativo.Text = "checkBox1";
            this.Ckb_AtivoInativo.UseVisualStyleBackColor = true;
            // 
            // Lbl_TipoMovimentacao
            // 
            this.Lbl_TipoMovimentacao.AutoSize = true;
            this.Lbl_TipoMovimentacao.Location = new System.Drawing.Point(130, 30);
            this.Lbl_TipoMovimentacao.Name = "Lbl_TipoMovimentacao";
            this.Lbl_TipoMovimentacao.Size = new System.Drawing.Size(35, 13);
            this.Lbl_TipoMovimentacao.TabIndex = 23;
            this.Lbl_TipoMovimentacao.Text = "label1";
            // 
            // Cbo_TipoMovimentacao
            // 
            this.Cbo_TipoMovimentacao.FormattingEnabled = true;
            this.Cbo_TipoMovimentacao.ItemHeight = 13;
            this.Cbo_TipoMovimentacao.Location = new System.Drawing.Point(129, 49);
            this.Cbo_TipoMovimentacao.Name = "Cbo_TipoMovimentacao";
            this.Cbo_TipoMovimentacao.Size = new System.Drawing.Size(121, 21);
            this.Cbo_TipoMovimentacao.TabIndex = 22;
            // 
            // Btn_BuscaEstabelecimento
            // 
            this.Btn_BuscaEstabelecimento.Location = new System.Drawing.Point(6, 91);
            this.Btn_BuscaEstabelecimento.Name = "Btn_BuscaEstabelecimento";
            this.Btn_BuscaEstabelecimento.Size = new System.Drawing.Size(37, 21);
            this.Btn_BuscaEstabelecimento.TabIndex = 4;
            this.Btn_BuscaEstabelecimento.Text = "button1";
            this.Btn_BuscaEstabelecimento.UseVisualStyleBackColor = true;
            this.Btn_BuscaEstabelecimento.Click += new System.EventHandler(this.Btn_BuscaEstabelecimento_Click);
            // 
            // Txt_CodigoEstabelecimento
            // 
            this.Txt_CodigoEstabelecimento.Location = new System.Drawing.Point(44, 91);
            this.Txt_CodigoEstabelecimento.Name = "Txt_CodigoEstabelecimento";
            this.Txt_CodigoEstabelecimento.Size = new System.Drawing.Size(62, 20);
            this.Txt_CodigoEstabelecimento.TabIndex = 5;
            this.Txt_CodigoEstabelecimento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_CodigoEstabelecimento_KeyUp);
            // 
            // Txt_NomeEstabelecimento
            // 
            this.Txt_NomeEstabelecimento.Location = new System.Drawing.Point(112, 91);
            this.Txt_NomeEstabelecimento.Name = "Txt_NomeEstabelecimento";
            this.Txt_NomeEstabelecimento.Size = new System.Drawing.Size(329, 20);
            this.Txt_NomeEstabelecimento.TabIndex = 19;
            // 
            // Lbl_Estabelecimento
            // 
            this.Lbl_Estabelecimento.AutoSize = true;
            this.Lbl_Estabelecimento.Location = new System.Drawing.Point(6, 73);
            this.Lbl_Estabelecimento.Name = "Lbl_Estabelecimento";
            this.Lbl_Estabelecimento.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Estabelecimento.TabIndex = 18;
            this.Lbl_Estabelecimento.Text = "label1";
            // 
            // Msk_Valor
            // 
            this.Msk_Valor.Location = new System.Drawing.Point(333, 140);
            this.Msk_Valor.Name = "Msk_Valor";
            this.Msk_Valor.Size = new System.Drawing.Size(108, 20);
            this.Msk_Valor.TabIndex = 8;
            this.Msk_Valor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Msk_Valor_MaskInputRejected);
            this.Msk_Valor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Msk_Valor_KeyUp);
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Location = new System.Drawing.Point(334, 124);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Valor.TabIndex = 16;
            this.Lbl_Valor.Text = "label2";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(390, 324);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 16;
            this.Btn_Cancelar.Text = "button4";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Frm_ValoresFixosCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Grp_DadosDespesaFixa);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_ValoresFixosCadastro";
            this.Size = new System.Drawing.Size(477, 357);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Grp_DadosDespesaFixa.ResumeLayout(false);
            this.Grp_DadosDespesaFixa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton;
        private System.Windows.Forms.Label Lbl_NomeDespesa;
        private System.Windows.Forms.TextBox Txt_NomeDespesa;
        private System.Windows.Forms.Button Btn_Gravar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.GroupBox Grp_DadosDespesaFixa;
        private System.Windows.Forms.MaskedTextBox Msk_Valor;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button Btn_BuscaEstabelecimento;
        private System.Windows.Forms.TextBox Txt_CodigoEstabelecimento;
        private System.Windows.Forms.TextBox Txt_NomeEstabelecimento;
        private System.Windows.Forms.Label Lbl_Estabelecimento;
        private System.Windows.Forms.Label Lbl_TipoMovimentacao;
        private System.Windows.Forms.ComboBox Cbo_TipoMovimentacao;
        private System.Windows.Forms.CheckBox Ckb_AtivoInativo;
        private System.Windows.Forms.Label Lbl_Observacao;
        private System.Windows.Forms.TextBox Txt_Observacao;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lbl_DataPagamento;
        private System.Windows.Forms.ComboBox Cbo_DiaPagamento;
    }
}
