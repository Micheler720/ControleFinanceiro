namespace ControleFinanceiro.Visao.Cadastros
{
    partial class Frm_DespesaFixasCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DespesaFixasCadastro));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Msk_Valor = new System.Windows.Forms.MaskedTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            // 
            // Lbl_NomeDespesa
            // 
            this.Lbl_NomeDespesa.AutoSize = true;
            this.Lbl_NomeDespesa.Location = new System.Drawing.Point(6, 86);
            this.Lbl_NomeDespesa.Name = "Lbl_NomeDespesa";
            this.Lbl_NomeDespesa.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeDespesa.TabIndex = 1;
            this.Lbl_NomeDespesa.Text = "label1";
            // 
            // Txt_NomeDespesa
            // 
            this.Txt_NomeDespesa.Location = new System.Drawing.Point(9, 102);
            this.Txt_NomeDespesa.Name = "Txt_NomeDespesa";
            this.Txt_NomeDespesa.Size = new System.Drawing.Size(276, 20);
            this.Txt_NomeDespesa.TabIndex = 2;
            this.Txt_NomeDespesa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NomeDespesa_KeyUp);
            // 
            // Btn_Gravar
            // 
            this.Btn_Gravar.Location = new System.Drawing.Point(219, 177);
            this.Btn_Gravar.Name = "Btn_Gravar";
            this.Btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Gravar.TabIndex = 12;
            this.Btn_Gravar.Text = "button2";
            this.Btn_Gravar.UseVisualStyleBackColor = true;
            this.Btn_Gravar.Click += new System.EventHandler(this.Btn_Gravar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(381, 177);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Excluir.TabIndex = 11;
            this.Btn_Excluir.Text = "button4";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(300, 177);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 10;
            this.Btn_Novo.Text = "button3";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(138, 177);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Editar.TabIndex = 9;
            this.Btn_Editar.Text = "button2";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(6, 25);
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
            this.Txt_Codigo.TabIndex = 14;
            // 
            // Grp_DadosDespesaFixa
            // 
            this.Grp_DadosDespesaFixa.Controls.Add(this.Msk_Valor);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Lbl_Valor);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Lbl_Codigo);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Txt_Codigo);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Txt_NomeDespesa);
            this.Grp_DadosDespesaFixa.Controls.Add(this.Lbl_NomeDespesa);
            this.Grp_DadosDespesaFixa.Location = new System.Drawing.Point(9, 28);
            this.Grp_DadosDespesaFixa.Name = "Grp_DadosDespesaFixa";
            this.Grp_DadosDespesaFixa.Size = new System.Drawing.Size(447, 143);
            this.Grp_DadosDespesaFixa.TabIndex = 15;
            this.Grp_DadosDespesaFixa.TabStop = false;
            this.Grp_DadosDespesaFixa.Text = "groupBox1";
            this.Grp_DadosDespesaFixa.Enter += new System.EventHandler(this.Grp_DadosDespesaFixa_Enter);
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Location = new System.Drawing.Point(297, 86);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Valor.TabIndex = 16;
            this.Lbl_Valor.Text = "label2";
            // 
            // Msk_Valor
            // 
            this.Msk_Valor.Location = new System.Drawing.Point(300, 101);
            this.Msk_Valor.Name = "Msk_Valor";
            this.Msk_Valor.Size = new System.Drawing.Size(100, 20);
            this.Msk_Valor.TabIndex = 17;
            this.Msk_Valor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Msk_Valor_KeyUp);
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
            // Frm_DespesaFixasCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grp_DadosDespesaFixa);
            this.Controls.Add(this.Btn_Gravar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_DespesaFixasCadastro";
            this.Size = new System.Drawing.Size(477, 234);
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
    }
}
