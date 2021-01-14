namespace ControleFinanceiro.Visao.Filtros
{
    partial class Frm_BuscaLancamento
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fin_ReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Abrir = new System.Windows.Forms.Button();
            this.Dat_Inicial = new System.Windows.Forms.DateTimePicker();
            this.Grp_TipoData = new System.Windows.Forms.GroupBox();
            this.Rdb_Lancamento = new System.Windows.Forms.RadioButton();
            this.Rdb_Inclusao = new System.Windows.Forms.RadioButton();
            this.Dat_Final = new System.Windows.Forms.DateTimePicker();
            this.Lbl_DataInicial = new System.Windows.Forms.Label();
            this.Lbl_DataFinal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.finPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fin_ReceberDataGridView)).BeginInit();
            this.Grp_TipoData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fin_ReceberDataGridView
            // 
            this.fin_ReceberDataGridView.AllowUserToAddRows = false;
            this.fin_ReceberDataGridView.AllowUserToDeleteRows = false;
            this.fin_ReceberDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fin_ReceberDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fin_ReceberDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fin_ReceberDataGridView.CausesValidation = false;
            this.fin_ReceberDataGridView.Location = new System.Drawing.Point(12, 86);
            this.fin_ReceberDataGridView.MultiSelect = false;
            this.fin_ReceberDataGridView.Name = "fin_ReceberDataGridView";
            this.fin_ReceberDataGridView.ReadOnly = true;
            this.fin_ReceberDataGridView.RowHeadersVisible = false;
            this.fin_ReceberDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fin_ReceberDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fin_ReceberDataGridView.Size = new System.Drawing.Size(586, 185);
            this.fin_ReceberDataGridView.TabIndex = 2;
            this.fin_ReceberDataGridView.TabStop = false;
            this.fin_ReceberDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fin_ReceberDataGridView_CellContentClick);
            this.fin_ReceberDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fin_ReceberDataGridView_MouseDoubleClick);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Sair.Location = new System.Drawing.Point(523, 277);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sair.TabIndex = 3;
            this.Btn_Sair.Text = "button1";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Abrir
            // 
            this.Btn_Abrir.Location = new System.Drawing.Point(442, 277);
            this.Btn_Abrir.Name = "Btn_Abrir";
            this.Btn_Abrir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Abrir.TabIndex = 4;
            this.Btn_Abrir.Text = "button2";
            this.Btn_Abrir.UseVisualStyleBackColor = true;
            this.Btn_Abrir.Click += new System.EventHandler(this.Btn_Abrir_Click);
            // 
            // Dat_Inicial
            // 
            this.Dat_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Inicial.Location = new System.Drawing.Point(21, 36);
            this.Dat_Inicial.Name = "Dat_Inicial";
            this.Dat_Inicial.Size = new System.Drawing.Size(89, 20);
            this.Dat_Inicial.TabIndex = 5;
            // 
            // Grp_TipoData
            // 
            this.Grp_TipoData.Controls.Add(this.Rdb_Lancamento);
            this.Grp_TipoData.Controls.Add(this.Rdb_Inclusao);
            this.Grp_TipoData.Location = new System.Drawing.Point(250, 16);
            this.Grp_TipoData.Name = "Grp_TipoData";
            this.Grp_TipoData.Size = new System.Drawing.Size(198, 43);
            this.Grp_TipoData.TabIndex = 6;
            this.Grp_TipoData.TabStop = false;
            this.Grp_TipoData.Text = "groupBox1";
            // 
            // Rdb_Lancamento
            // 
            this.Rdb_Lancamento.AutoSize = true;
            this.Rdb_Lancamento.Location = new System.Drawing.Point(107, 17);
            this.Rdb_Lancamento.Name = "Rdb_Lancamento";
            this.Rdb_Lancamento.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Lancamento.TabIndex = 7;
            this.Rdb_Lancamento.TabStop = true;
            this.Rdb_Lancamento.Text = "radioButton1";
            this.Rdb_Lancamento.UseVisualStyleBackColor = true;
            // 
            // Rdb_Inclusao
            // 
            this.Rdb_Inclusao.AutoSize = true;
            this.Rdb_Inclusao.Location = new System.Drawing.Point(6, 17);
            this.Rdb_Inclusao.Name = "Rdb_Inclusao";
            this.Rdb_Inclusao.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Inclusao.TabIndex = 8;
            this.Rdb_Inclusao.TabStop = true;
            this.Rdb_Inclusao.Text = "radioButton2";
            this.Rdb_Inclusao.UseVisualStyleBackColor = true;
            // 
            // Dat_Final
            // 
            this.Dat_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Final.Location = new System.Drawing.Point(133, 36);
            this.Dat_Final.Name = "Dat_Final";
            this.Dat_Final.Size = new System.Drawing.Size(89, 20);
            this.Dat_Final.TabIndex = 7;
            // 
            // Lbl_DataInicial
            // 
            this.Lbl_DataInicial.AutoSize = true;
            this.Lbl_DataInicial.Location = new System.Drawing.Point(18, 20);
            this.Lbl_DataInicial.Name = "Lbl_DataInicial";
            this.Lbl_DataInicial.Size = new System.Drawing.Size(35, 13);
            this.Lbl_DataInicial.TabIndex = 8;
            this.Lbl_DataInicial.Text = "label1";
            // 
            // Lbl_DataFinal
            // 
            this.Lbl_DataFinal.AutoSize = true;
            this.Lbl_DataFinal.Location = new System.Drawing.Point(133, 20);
            this.Lbl_DataFinal.Name = "Lbl_DataFinal";
            this.Lbl_DataFinal.Size = new System.Drawing.Size(35, 13);
            this.Lbl_DataFinal.TabIndex = 9;
            this.Lbl_DataFinal.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Controls.Add(this.Lbl_DataFinal);
            this.groupBox1.Controls.Add(this.Dat_Inicial);
            this.groupBox1.Controls.Add(this.Lbl_DataInicial);
            this.groupBox1.Controls.Add(this.Grp_TipoData);
            this.groupBox1.Controls.Add(this.Dat_Final);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.Location = new System.Drawing.Point(501, 30);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 10;
            this.Btn_Buscar.Text = "button1";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // finPagarBindingSource
            // 
            this.finPagarBindingSource.DataSource = typeof(ControleFinanceiro.Modelo.Entidades.Fin_Pagar);
            // 
            // Frm_BuscaLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Sair;
            this.ClientSize = new System.Drawing.Size(609, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Abrir);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.fin_ReceberDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BuscaLancamento";
            this.Text = "Frm_BuscaLancamento";
            ((System.ComponentModel.ISupportInitialize)(this.fin_ReceberDataGridView)).EndInit();
            this.Grp_TipoData.ResumeLayout(false);
            this.Grp_TipoData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finPagarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView fin_ReceberDataGridView;
        private System.Windows.Forms.BindingSource finPagarBindingSource;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Abrir;
        private System.Windows.Forms.DateTimePicker Dat_Inicial;
        private System.Windows.Forms.GroupBox Grp_TipoData;
        private System.Windows.Forms.RadioButton Rdb_Lancamento;
        private System.Windows.Forms.RadioButton Rdb_Inclusao;
        private System.Windows.Forms.DateTimePicker Dat_Final;
        private System.Windows.Forms.Label Lbl_DataInicial;
        private System.Windows.Forms.Label Lbl_DataFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}