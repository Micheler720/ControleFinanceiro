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
            this.Txt_Parcela = new System.Windows.Forms.TextBox();
            this.Lbl_Parcela = new System.Windows.Forms.Label();
            this.Grp_Similar = new System.Windows.Forms.GroupBox();
            this.Btn_Gerar = new System.Windows.Forms.Button();
            this.Pan_Similiar = new System.Windows.Forms.Panel();
            this.Lbl_Parcelas = new System.Windows.Forms.Label();
            this.Msk_Parcelas = new System.Windows.Forms.MaskedTextBox();
            this.Rdb_Varios = new System.Windows.Forms.RadioButton();
            this.Rdb_Unico = new System.Windows.Forms.RadioButton();
            this.Lbl_DataPagamento = new System.Windows.Forms.Label();
            this.Dat_Pagamento = new System.Windows.Forms.DateTimePicker();
            this.Lbl_DataInclusao = new System.Windows.Forms.Label();
            this.Dat_Inclusão = new System.Windows.Forms.DateTimePicker();
            this.Txt_Documento = new System.Windows.Forms.TextBox();
            this.Lbl_Documento = new System.Windows.Forms.Label();
            this.Lbl_Data = new System.Windows.Forms.Label();
            this.Dat_DataLancamento = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Observacao = new System.Windows.Forms.Label();
            this.Txt_Observacao = new System.Windows.Forms.TextBox();
            this.Msk_CodigoEstabelecimento = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Valor = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Btn_BuscaEstabelecimento = new System.Windows.Forms.Button();
            this.Txt_NomeEstabelecimento = new System.Windows.Forms.TextBox();
            this.Lbl_Estabelecimento = new System.Windows.Forms.Label();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Legenda = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Similar = new System.Windows.Forms.Button();
            this.Btn_CancelarSimilar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.Grp_DadosMovimentacoes.SuspendLayout();
            this.Grp_Similar.SuspendLayout();
            this.Pan_Similiar.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
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
            // Btn_Gravar
            // 
            this.Btn_Gravar.Location = new System.Drawing.Point(235, 335);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Size = new System.Drawing.Size(72, 25);
            this.Btn_Gravar.TabIndex = 8;
            this.Btn_Gravar.Text = "button2";
            this.Btn_Gravar.UseVisualStyleBackColor = true;
            this.Btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(391, 335);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(72, 25);
            this.Btn_Excluir.TabIndex = 15;
            this.Btn_Excluir.Text = "button4";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(313, 335);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(72, 25);
            this.Btn_Novo.TabIndex = 14;
            this.Btn_Novo.Text = "button3";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(157, 335);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(72, 25);
            this.Btn_Editar.TabIndex = 13;
            this.Btn_Editar.Text = "button2";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Grp_DadosMovimentacoes
            // 
            this.Grp_DadosMovimentacoes.Controls.Add(this.Txt_Parcela);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Lbl_Parcela);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Grp_Similar);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Lbl_DataPagamento);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Dat_Pagamento);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Lbl_DataInclusao);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Dat_Inclusão);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Txt_Documento);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Lbl_Documento);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Lbl_Data);
            this.Grp_DadosMovimentacoes.Controls.Add(this.Dat_DataLancamento);
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
            this.Grp_DadosMovimentacoes.Location = new System.Drawing.Point(14, 50);
            this.Grp_DadosMovimentacoes.Name = "Grp_DadosMovimentacoes";
            this.Grp_DadosMovimentacoes.Size = new System.Drawing.Size(527, 256);
            this.Grp_DadosMovimentacoes.TabIndex = 7;
            this.Grp_DadosMovimentacoes.TabStop = false;
            this.Grp_DadosMovimentacoes.Text = "groupBox1";
            // 
            // Txt_Parcela
            // 
            this.Txt_Parcela.Location = new System.Drawing.Point(174, 40);
            this.Txt_Parcela.Name = "Txt_Parcela";
            this.Txt_Parcela.Size = new System.Drawing.Size(51, 20);
            this.Txt_Parcela.TabIndex = 20;
            // 
            // Lbl_Parcela
            // 
            this.Lbl_Parcela.AutoSize = true;
            this.Lbl_Parcela.Location = new System.Drawing.Point(175, 20);
            this.Lbl_Parcela.Name = "Lbl_Parcela";
            this.Lbl_Parcela.Size = new System.Drawing.Size(39, 14);
            this.Lbl_Parcela.TabIndex = 19;
            this.Lbl_Parcela.Text = "label1";
            // 
            // Grp_Similar
            // 
            this.Grp_Similar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grp_Similar.Controls.Add(this.Btn_CancelarSimilar);
            this.Grp_Similar.Controls.Add(this.Btn_Gerar);
            this.Grp_Similar.Controls.Add(this.Pan_Similiar);
            this.Grp_Similar.Location = new System.Drawing.Point(87, 64);
            this.Grp_Similar.Name = "Grp_Similar";
            this.Grp_Similar.Size = new System.Drawing.Size(307, 115);
            this.Grp_Similar.TabIndex = 2;
            this.Grp_Similar.TabStop = false;
            this.Grp_Similar.Text = "groupBox1";
            // 
            // Btn_Gerar
            // 
            this.Btn_Gerar.Location = new System.Drawing.Point(226, 80);
            this.Btn_Gerar.Name = "Btn_Gerar";
            this.Btn_Gerar.Size = new System.Drawing.Size(72, 25);
            this.Btn_Gerar.TabIndex = 21;
            this.Btn_Gerar.Text = "button2";
            this.Btn_Gerar.UseVisualStyleBackColor = true;
            this.Btn_Gerar.Click += new System.EventHandler(this.Btn_Gerar_Click);
            // 
            // Pan_Similiar
            // 
            this.Pan_Similiar.Controls.Add(this.Lbl_Parcelas);
            this.Pan_Similiar.Controls.Add(this.Msk_Parcelas);
            this.Pan_Similiar.Controls.Add(this.Rdb_Varios);
            this.Pan_Similiar.Controls.Add(this.Rdb_Unico);
            this.Pan_Similiar.Location = new System.Drawing.Point(9, 19);
            this.Pan_Similiar.Name = "Pan_Similiar";
            this.Pan_Similiar.Size = new System.Drawing.Size(289, 55);
            this.Pan_Similiar.TabIndex = 19;
            // 
            // Lbl_Parcelas
            // 
            this.Lbl_Parcelas.AutoSize = true;
            this.Lbl_Parcelas.Location = new System.Drawing.Point(206, 4);
            this.Lbl_Parcelas.Name = "Lbl_Parcelas";
            this.Lbl_Parcelas.Size = new System.Drawing.Size(39, 14);
            this.Lbl_Parcelas.TabIndex = 3;
            this.Lbl_Parcelas.Text = "label1";
            // 
            // Msk_Parcelas
            // 
            this.Msk_Parcelas.Location = new System.Drawing.Point(206, 20);
            this.Msk_Parcelas.Name = "Msk_Parcelas";
            this.Msk_Parcelas.Size = new System.Drawing.Size(72, 20);
            this.Msk_Parcelas.TabIndex = 2;
            // 
            // Rdb_Varios
            // 
            this.Rdb_Varios.AutoSize = true;
            this.Rdb_Varios.Location = new System.Drawing.Point(94, 21);
            this.Rdb_Varios.Name = "Rdb_Varios";
            this.Rdb_Varios.Size = new System.Drawing.Size(95, 18);
            this.Rdb_Varios.TabIndex = 1;
            this.Rdb_Varios.TabStop = true;
            this.Rdb_Varios.Text = "radioButton2";
            this.Rdb_Varios.UseVisualStyleBackColor = true;
            this.Rdb_Varios.CheckedChanged += new System.EventHandler(this.Rdb_Varios_CheckedChanged);
            // 
            // Rdb_Unico
            // 
            this.Rdb_Unico.AutoSize = true;
            this.Rdb_Unico.Location = new System.Drawing.Point(7, 21);
            this.Rdb_Unico.Name = "Rdb_Unico";
            this.Rdb_Unico.Size = new System.Drawing.Size(95, 18);
            this.Rdb_Unico.TabIndex = 0;
            this.Rdb_Unico.TabStop = true;
            this.Rdb_Unico.Text = "radioButton1";
            this.Rdb_Unico.UseVisualStyleBackColor = true;
            this.Rdb_Unico.CheckedChanged += new System.EventHandler(this.Rdb_Unico_CheckedChanged);
            // 
            // Lbl_DataPagamento
            // 
            this.Lbl_DataPagamento.AutoSize = true;
            this.Lbl_DataPagamento.Location = new System.Drawing.Point(427, 23);
            this.Lbl_DataPagamento.Name = "Lbl_DataPagamento";
            this.Lbl_DataPagamento.Size = new System.Drawing.Size(39, 14);
            this.Lbl_DataPagamento.TabIndex = 18;
            this.Lbl_DataPagamento.Text = "label1";
            // 
            // Dat_Pagamento
            // 
            this.Dat_Pagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Pagamento.Location = new System.Drawing.Point(430, 40);
            this.Dat_Pagamento.Name = "Dat_Pagamento";
            this.Dat_Pagamento.Size = new System.Drawing.Size(92, 20);
            this.Dat_Pagamento.TabIndex = 17;
            // 
            // Lbl_DataInclusao
            // 
            this.Lbl_DataInclusao.AutoSize = true;
            this.Lbl_DataInclusao.Location = new System.Drawing.Point(228, 20);
            this.Lbl_DataInclusao.Name = "Lbl_DataInclusao";
            this.Lbl_DataInclusao.Size = new System.Drawing.Size(39, 14);
            this.Lbl_DataInclusao.TabIndex = 16;
            this.Lbl_DataInclusao.Text = "label1";
            // 
            // Dat_Inclusão
            // 
            this.Dat_Inclusão.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Inclusão.Location = new System.Drawing.Point(231, 40);
            this.Dat_Inclusão.Name = "Dat_Inclusão";
            this.Dat_Inclusão.Size = new System.Drawing.Size(92, 20);
            this.Dat_Inclusão.TabIndex = 15;
            // 
            // Txt_Documento
            // 
            this.Txt_Documento.Location = new System.Drawing.Point(86, 40);
            this.Txt_Documento.Name = "Txt_Documento";
            this.Txt_Documento.Size = new System.Drawing.Size(82, 20);
            this.Txt_Documento.TabIndex = 1;
            this.Txt_Documento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Documento_KeyUp);
            // 
            // Lbl_Documento
            // 
            this.Lbl_Documento.AutoSize = true;
            this.Lbl_Documento.Location = new System.Drawing.Point(84, 20);
            this.Lbl_Documento.Name = "Lbl_Documento";
            this.Lbl_Documento.Size = new System.Drawing.Size(39, 14);
            this.Lbl_Documento.TabIndex = 14;
            this.Lbl_Documento.Text = "label1";
            // 
            // Lbl_Data
            // 
            this.Lbl_Data.AutoSize = true;
            this.Lbl_Data.Location = new System.Drawing.Point(329, 20);
            this.Lbl_Data.Name = "Lbl_Data";
            this.Lbl_Data.Size = new System.Drawing.Size(39, 14);
            this.Lbl_Data.TabIndex = 13;
            this.Lbl_Data.Text = "label1";
            // 
            // Dat_DataLancamento
            // 
            this.Dat_DataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_DataLancamento.Location = new System.Drawing.Point(332, 40);
            this.Dat_DataLancamento.Name = "Dat_DataLancamento";
            this.Dat_DataLancamento.Size = new System.Drawing.Size(92, 20);
            this.Dat_DataLancamento.TabIndex = 2;
            this.Dat_DataLancamento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Lbl_Observacao
            // 
            this.Lbl_Observacao.AutoSize = true;
            this.Lbl_Observacao.Location = new System.Drawing.Point(9, 154);
            this.Lbl_Observacao.Name = "Lbl_Observacao";
            this.Lbl_Observacao.Size = new System.Drawing.Size(39, 14);
            this.Lbl_Observacao.TabIndex = 11;
            this.Lbl_Observacao.Text = "label2";
            // 
            // Txt_Observacao
            // 
            this.Txt_Observacao.Location = new System.Drawing.Point(10, 171);
            this.Txt_Observacao.Multiline = true;
            this.Txt_Observacao.Name = "Txt_Observacao";
            this.Txt_Observacao.Size = new System.Drawing.Size(509, 76);
            this.Txt_Observacao.TabIndex = 7;
            // 
            // Msk_CodigoEstabelecimento
            // 
            this.Msk_CodigoEstabelecimento.Location = new System.Drawing.Point(55, 81);
            this.Msk_CodigoEstabelecimento.Name = "Msk_CodigoEstabelecimento";
            this.Msk_CodigoEstabelecimento.Size = new System.Drawing.Size(68, 20);
            this.Msk_CodigoEstabelecimento.TabIndex = 4;
            this.Msk_CodigoEstabelecimento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Msk_CodigoEstabelecimento_KeyUp);
            // 
            // Msk_Valor
            // 
            this.Msk_Valor.Location = new System.Drawing.Point(10, 127);
            this.Msk_Valor.Name = "Msk_Valor";
            this.Msk_Valor.Size = new System.Drawing.Size(116, 20);
            this.Msk_Valor.TabIndex = 6;
            this.Msk_Valor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Msk_Valor_KeyUp);
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Location = new System.Drawing.Point(9, 109);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(39, 14);
            this.Lbl_Valor.TabIndex = 7;
            this.Lbl_Valor.Text = "label2";
            // 
            // Btn_BuscaEstabelecimento
            // 
            this.Btn_BuscaEstabelecimento.Location = new System.Drawing.Point(7, 79);
            this.Btn_BuscaEstabelecimento.Name = "Btn_BuscaEstabelecimento";
            this.Btn_BuscaEstabelecimento.Size = new System.Drawing.Size(43, 23);
            this.Btn_BuscaEstabelecimento.TabIndex = 3;
            this.Btn_BuscaEstabelecimento.Text = "button1";
            this.Btn_BuscaEstabelecimento.UseVisualStyleBackColor = true;
            this.Btn_BuscaEstabelecimento.Click += new System.EventHandler(this.Btn_BuscaEstabelecimento_Click);
            // 
            // Txt_NomeEstabelecimento
            // 
            this.Txt_NomeEstabelecimento.Location = new System.Drawing.Point(131, 81);
            this.Txt_NomeEstabelecimento.Name = "Txt_NomeEstabelecimento";
            this.Txt_NomeEstabelecimento.Size = new System.Drawing.Size(389, 20);
            this.Txt_NomeEstabelecimento.TabIndex = 5;
            // 
            // Lbl_Estabelecimento
            // 
            this.Lbl_Estabelecimento.AutoSize = true;
            this.Lbl_Estabelecimento.Location = new System.Drawing.Point(7, 64);
            this.Lbl_Estabelecimento.Name = "Lbl_Estabelecimento";
            this.Lbl_Estabelecimento.Size = new System.Drawing.Size(39, 14);
            this.Lbl_Estabelecimento.TabIndex = 2;
            this.Lbl_Estabelecimento.Text = "label1";
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(7, 20);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(39, 14);
            this.Lbl_Codigo.TabIndex = 1;
            this.Lbl_Codigo.Text = "label1";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(7, 40);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(73, 20);
            this.Txt_Codigo.TabIndex = 0;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Titulo.Location = new System.Drawing.Point(191, 25);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(164, 18);
            this.Lbl_Titulo.TabIndex = 18;
            this.Lbl_Titulo.Text = "Lançamentos de Entradas";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Legenda
            // 
            this.Lbl_Legenda.AutoSize = true;
            this.Lbl_Legenda.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Legenda.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Legenda.Location = new System.Drawing.Point(16, 316);
            this.Lbl_Legenda.Name = "Lbl_Legenda";
            this.Lbl_Legenda.Size = new System.Drawing.Size(48, 17);
            this.Lbl_Legenda.TabIndex = 16;
            this.Lbl_Legenda.Text = "label1";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(469, 335);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(72, 25);
            this.Btn_Cancelar.TabIndex = 19;
            this.Btn_Cancelar.Text = "button4";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Similar
            // 
            this.Btn_Similar.Location = new System.Drawing.Point(79, 335);
            this.Btn_Similar.Name = "Btn_Similar";
            this.Btn_Similar.Size = new System.Drawing.Size(72, 25);
            this.Btn_Similar.TabIndex = 20;
            this.Btn_Similar.Text = "button2";
            this.Btn_Similar.UseVisualStyleBackColor = true;
            this.Btn_Similar.Click += new System.EventHandler(this.Btn_Similar_Click);
            // 
            // Btn_CancelarSimilar
            // 
            this.Btn_CancelarSimilar.Location = new System.Drawing.Point(148, 79);
            this.Btn_CancelarSimilar.Name = "Btn_CancelarSimilar";
            this.Btn_CancelarSimilar.Size = new System.Drawing.Size(72, 25);
            this.Btn_CancelarSimilar.TabIndex = 22;
            this.Btn_CancelarSimilar.Text = "button2";
            this.Btn_CancelarSimilar.UseVisualStyleBackColor = true;
            this.Btn_CancelarSimilar.Click += new System.EventHandler(this.Btn_CancelarSimilar_Click);
            // 
            // Frm_Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Similar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Lbl_Legenda);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Grp_DadosMovimentacoes);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Entradas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(554, 375);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Grp_DadosMovimentacoes.ResumeLayout(false);
            this.Grp_DadosMovimentacoes.PerformLayout();
            this.Grp_Similar.ResumeLayout(false);
            this.Pan_Similiar.ResumeLayout(false);
            this.Pan_Similiar.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker Dat_DataLancamento;
        private System.Windows.Forms.Label Lbl_Data;
        private System.Windows.Forms.TextBox Txt_Documento;
        private System.Windows.Forms.Label Lbl_Documento;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Legenda;
        private System.Windows.Forms.Label Lbl_DataInclusao;
        private System.Windows.Forms.DateTimePicker Dat_Inclusão;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lbl_DataPagamento;
        private System.Windows.Forms.DateTimePicker Dat_Pagamento;
        private System.Windows.Forms.Button Btn_Similar;
        private System.Windows.Forms.GroupBox Grp_Similar;
        private System.Windows.Forms.Panel Pan_Similiar;
        private System.Windows.Forms.Label Lbl_Parcelas;
        private System.Windows.Forms.MaskedTextBox Msk_Parcelas;
        private System.Windows.Forms.RadioButton Rdb_Varios;
        private System.Windows.Forms.RadioButton Rdb_Unico;
        private System.Windows.Forms.TextBox Txt_Parcela;
        private System.Windows.Forms.Label Lbl_Parcela;
        private System.Windows.Forms.Button Btn_Gerar;
        private System.Windows.Forms.Button Btn_CancelarSimilar;
    }
}
