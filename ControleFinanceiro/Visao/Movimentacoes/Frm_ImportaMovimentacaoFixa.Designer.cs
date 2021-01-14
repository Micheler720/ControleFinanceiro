namespace ControleFinanceiro.Visao.Movimentacoes
{
    partial class Frm_ImportaMovimentacaoFixa
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
            this.Grp_DadosImportacao = new System.Windows.Forms.GroupBox();
            this.Btn_Importar = new System.Windows.Forms.Button();
            this.Lbl_Mes = new System.Windows.Forms.Label();
            this.Dat_Mes = new System.Windows.Forms.DateTimePicker();
            this.DatView_Lancamentos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grp_DadosImportacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatView_Lancamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_DadosImportacao
            // 
            this.Grp_DadosImportacao.Controls.Add(this.Btn_Importar);
            this.Grp_DadosImportacao.Controls.Add(this.Lbl_Mes);
            this.Grp_DadosImportacao.Controls.Add(this.Dat_Mes);
            this.Grp_DadosImportacao.Location = new System.Drawing.Point(12, 267);
            this.Grp_DadosImportacao.Name = "Grp_DadosImportacao";
            this.Grp_DadosImportacao.Size = new System.Drawing.Size(776, 73);
            this.Grp_DadosImportacao.TabIndex = 0;
            this.Grp_DadosImportacao.TabStop = false;
            this.Grp_DadosImportacao.Text = "groupBox1";
            // 
            // Btn_Importar
            // 
            this.Btn_Importar.Location = new System.Drawing.Point(695, 37);
            this.Btn_Importar.Name = "Btn_Importar";
            this.Btn_Importar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Importar.TabIndex = 4;
            this.Btn_Importar.Text = "button1";
            this.Btn_Importar.UseVisualStyleBackColor = true;
            this.Btn_Importar.Click += new System.EventHandler(this.Btn_Importar_Click);
            // 
            // Lbl_Mes
            // 
            this.Lbl_Mes.AutoSize = true;
            this.Lbl_Mes.Location = new System.Drawing.Point(6, 20);
            this.Lbl_Mes.Name = "Lbl_Mes";
            this.Lbl_Mes.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Mes.TabIndex = 1;
            this.Lbl_Mes.Text = "label1";
            // 
            // Dat_Mes
            // 
            this.Dat_Mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dat_Mes.Location = new System.Drawing.Point(9, 36);
            this.Dat_Mes.Name = "Dat_Mes";
            this.Dat_Mes.Size = new System.Drawing.Size(98, 20);
            this.Dat_Mes.TabIndex = 0;
            // 
            // DatView_Lancamentos
            // 
            this.DatView_Lancamentos.AllowUserToAddRows = false;
            this.DatView_Lancamentos.AllowUserToDeleteRows = false;
            this.DatView_Lancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatView_Lancamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DatView_Lancamentos.Location = new System.Drawing.Point(12, 42);
            this.DatView_Lancamentos.Name = "DatView_Lancamentos";
            this.DatView_Lancamentos.RowHeadersVisible = false;
            this.DatView_Lancamentos.Size = new System.Drawing.Size(776, 199);
            this.DatView_Lancamentos.TabIndex = 1;
            this.DatView_Lancamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatView_Lancamentos_CellClick);
            this.DatView_Lancamentos.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DatView_Lancamentos_ColumnWidthChanged);
            this.DatView_Lancamentos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DatView_Lancamentos_Scroll);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Frm_ImportaMovimentacaoFixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.DatView_Lancamentos);
            this.Controls.Add(this.Grp_DadosImportacao);
            this.Name = "Frm_ImportaMovimentacaoFixa";
            this.Text = "Frm_ImportaMovimentacaoFixa";
            this.Grp_DadosImportacao.ResumeLayout(false);
            this.Grp_DadosImportacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatView_Lancamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_DadosImportacao;
        private System.Windows.Forms.DateTimePicker Dat_Mes;
        private System.Windows.Forms.Label Lbl_Mes;
        private System.Windows.Forms.DataGridView DatView_Lancamentos;
        private System.Windows.Forms.Button Btn_Importar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}