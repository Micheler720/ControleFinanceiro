namespace ControleFinanceiro.Visao.Movimentacoes
{
    partial class Frm_Entradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Entradas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Btn_Gravar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Grp_DadosMovimentacoes = new System.Windows.Forms.GroupBox();
            this.Msk_Valor = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Btn_BuscaEstabelecimento = new System.Windows.Forms.Button();
            this.Txt_NomeEstabelecimento = new System.Windows.Forms.TextBox();
            this.Lbl_Estabelecimento = new System.Windows.Forms.Label();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Msk_CodigoEstabelecimento = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Observacao = new System.Windows.Forms.TextBox();
            this.Lbl_Observacao = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.Grp_DadosMovimentacoes.SuspendLayout();
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
            // Btn_Gravar
            // 
            this.Btn_Gravar.Location = new System.Drawing.Point(227, 272);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Gravar.TabIndex = 16;
            this.Btn_Gravar.Text = "button2";
            this.Btn_Gravar.UseVisualStyleBackColor = true;
            this.Btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(389, 272);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Excluir.TabIndex = 15;
            this.Btn_Excluir.Text = "button4";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(308, 272);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 14;
            this.Btn_Novo.Text = "button3";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(146, 272);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Editar.TabIndex = 13;
            this.Btn_Editar.Text = "button2";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Grp_DadosMovimentacoes
            // 
            this.Grp_DadosMovimentacoes.Controls.Add(this.Lbl_Observacao);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Txt_Observacao);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Msk_CodigoEstabelecimento);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Msk_Valor);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Lbl_Valor);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Btn_BuscaEstabelecimento);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Txt_NomeEstabelecimento);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Lbl_Estabelecimento);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Lbl_Codigo);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Txt_Codigo);
            this.Grp_DadosMovimentacoes.Location = new System.Drawing.Point(12, 28);
            this.Grp_DadosMovimentacoes.Name = "Grp_DadosMovimentacoes";
            this.Grp_DadosMovimentacoes.Size = new System.Drawing.Size(452, 238);
            this.Grp_DadosMovimentacoes.TabIndex = 17;
            this.Grp_DadosMovimentacoes.TabStop = false;
            this.Grp_DadosMovimentacoes.Text = "groupBox1";
            // 
            // Msk_Valor
            // 
            this.Msk_Valor.Location = new System.Drawing.Point(9, 118);
            this.Msk_Valor.Name = "Msk_Valor";
            this.Msk_Valor.Size = new System.Drawing.Size(100, 20);
            this.Msk_Valor.TabIndex = 8;
            this.Msk_Valor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Msk_Valor_KeyUp);
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Location = new System.Drawing.Point(8, 101);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Valor.TabIndex = 7;
            this.Lbl_Valor.Text = "label2";
            // 
            // Btn_BuscaEstabelecimento
            // 
            this.Btn_BuscaEstabelecimento.Location = new System.Drawing.Point(6, 76);
            this.Btn_BuscaEstabelecimento.Name = "Btn_BuscaEstabelecimento";
            this.Btn_BuscaEstabelecimento.Size = new System.Drawing.Size(37, 21);
            this.Btn_BuscaEstabelecimento.TabIndex = 5;
            this.Btn_BuscaEstabelecimento.Text = "button1";
            this.Btn_BuscaEstabelecimento.UseVisualStyleBackColor = true;
            // 
            // Txt_NomeEstabelecimento
            // 
            this.Txt_NomeEstabelecimento.Location = new System.Drawing.Point(112, 75);
            this.Txt_NomeEstabelecimento.Name = "Txt_NomeEstabelecimento";
            this.Txt_NomeEstabelecimento.Size = new System.Drawing.Size(334, 20);
            this.Txt_NomeEstabelecimento.TabIndex = 3;
            // 
            // Lbl_Estabelecimento
            // 
            this.Lbl_Estabelecimento.AutoSize = true;
            this.Lbl_Estabelecimento.Location = new System.Drawing.Point(6, 59);
            this.Lbl_Estabelecimento.Name = "Lbl_Estabelecimento";
            this.Lbl_Estabelecimento.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Estabelecimento.TabIndex = 2;
            this.Lbl_Estabelecimento.Text = "label1";
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(6, 19);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Codigo.TabIndex = 1;
            this.Lbl_Codigo.Text = "label1";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(6, 37);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Codigo.TabIndex = 0;
            // 
            // Msk_CodigoEstabelecimento
            // 
            this.Msk_CodigoEstabelecimento.Location = new System.Drawing.Point(47, 75);
            this.Msk_CodigoEstabelecimento.Name = "Msk_CodigoEstabelecimento";
            this.Msk_CodigoEstabelecimento.Size = new System.Drawing.Size(59, 20);
            this.Msk_CodigoEstabelecimento.TabIndex = 9;
            // 
            // Txt_Observacao
            // 
            this.Txt_Observacao.Location = new System.Drawing.Point(9, 159);
            this.Txt_Observacao.Multiline = true;
            this.Txt_Observacao.Name = "Txt_Observacao";
            this.Txt_Observacao.Size = new System.Drawing.Size(437, 71);
            this.Txt_Observacao.TabIndex = 10;
            // 
            // Lbl_Observacao
            // 
            this.Lbl_Observacao.AutoSize = true;
            this.Lbl_Observacao.Location = new System.Drawing.Point(8, 143);
            this.Lbl_Observacao.Name = "Lbl_Observacao";
            this.Lbl_Observacao.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Observacao.TabIndex = 11;
            this.Lbl_Observacao.Text = "label2";
            // 
            // Frm_Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grp_DadosMovimentacoes);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_Entradas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(477, 310);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Grp_DadosMovimentacoes.ResumeLayout(false);
            this.Grp_DadosMovimentacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button Btn_Gravar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.GroupBox Grp_DadosMovimentacoes;
        private System.Windows.Forms.MaskedTextBox Msk_Valor;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Button Btn_BuscaEstabelecimento;
        private System.Windows.Forms.TextBox Txt_NomeEstabelecimento;
        private System.Windows.Forms.Label Lbl_Estabelecimento;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.MaskedTextBox Msk_CodigoEstabelecimento;
        private System.Windows.Forms.Label Lbl_Observacao;
        private System.Windows.Forms.TextBox Txt_Observacao;
    }
}
