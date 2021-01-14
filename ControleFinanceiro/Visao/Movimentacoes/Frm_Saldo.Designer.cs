namespace ControleFinanceiro.Visao.Movimentacoes
{
    partial class Frm_Saldo
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
            this.Grp_MovimentacoesFinanceiras = new System.Windows.Forms.GroupBox();
            this.DatView_Pagar = new System.Windows.Forms.DataGridView();
            this.Btn_ImportarFixos = new System.Windows.Forms.Button();
            this.Grp_Totalizador = new System.Windows.Forms.GroupBox();
            this.Lbl_Saldo = new System.Windows.Forms.Label();
            this.Lbl_TotalReceita = new System.Windows.Forms.Label();
            this.Lbl_TotalDespesas = new System.Windows.Forms.Label();
            this.Lbl_Receitas = new System.Windows.Forms.Label();
            this.Lbl_Despesas = new System.Windows.Forms.Label();
            this.DatView_Receber = new System.Windows.Forms.DataGridView();
            this.Dat_Inicial = new System.Windows.Forms.DateTimePicker();
            this.Grp_FiltroRelatorio = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_DtInicial = new System.Windows.Forms.Label();
            this.Lbl_DtFinal = new System.Windows.Forms.Label();
            this.Dat_Final = new System.Windows.Forms.DateTimePicker();
            this.Grp_MovimentacoesFinanceiras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatView_Pagar)).BeginInit();
            this.Grp_Totalizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatView_Receber)).BeginInit();
            this.Grp_FiltroRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_MovimentacoesFinanceiras
            // 
            this.Grp_MovimentacoesFinanceiras.Controls.Add(this.DatView_Pagar);
            this.Grp_MovimentacoesFinanceiras.Controls.Add(this.Btn_ImportarFixos);
            this.Grp_MovimentacoesFinanceiras.Controls.Add(this.Grp_Totalizador);
            this.Grp_MovimentacoesFinanceiras.Controls.Add(this.Lbl_Receitas);
            this.Grp_MovimentacoesFinanceiras.Controls.Add(this.Lbl_Despesas);
            this.Grp_MovimentacoesFinanceiras.Controls.Add(this.DatView_Receber);
            this.Grp_MovimentacoesFinanceiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_MovimentacoesFinanceiras.Location = new System.Drawing.Point(18, 139);
            this.Grp_MovimentacoesFinanceiras.Name = "Grp_MovimentacoesFinanceiras";
            this.Grp_MovimentacoesFinanceiras.Size = new System.Drawing.Size(1061, 463);
            this.Grp_MovimentacoesFinanceiras.TabIndex = 3;
            this.Grp_MovimentacoesFinanceiras.TabStop = false;
            this.Grp_MovimentacoesFinanceiras.Text = "groupBox1";
            // 
            // DatView_Pagar
            // 
            this.DatView_Pagar.AllowUserToAddRows = false;
            this.DatView_Pagar.AllowUserToDeleteRows = false;
            this.DatView_Pagar.AllowUserToOrderColumns = true;
            this.DatView_Pagar.AllowUserToResizeRows = false;
            this.DatView_Pagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DatView_Pagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatView_Pagar.Location = new System.Drawing.Point(23, 75);
            this.DatView_Pagar.MultiSelect = false;
            this.DatView_Pagar.Name = "DatView_Pagar";
            this.DatView_Pagar.ReadOnly = true;
            this.DatView_Pagar.RowHeadersVisible = false;
            this.DatView_Pagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatView_Pagar.Size = new System.Drawing.Size(500, 242);
            this.DatView_Pagar.TabIndex = 9;
            // 
            // Btn_ImportarFixos
            // 
            this.Btn_ImportarFixos.Location = new System.Drawing.Point(973, 19);
            this.Btn_ImportarFixos.Name = "Btn_ImportarFixos";
            this.Btn_ImportarFixos.Size = new System.Drawing.Size(75, 23);
            this.Btn_ImportarFixos.TabIndex = 8;
            this.Btn_ImportarFixos.Text = "button1";
            this.Btn_ImportarFixos.UseVisualStyleBackColor = true;
            this.Btn_ImportarFixos.Click += new System.EventHandler(this.Btn_ImportarFixos_Click);
            // 
            // Grp_Totalizador
            // 
            this.Grp_Totalizador.Controls.Add(this.Lbl_Saldo);
            this.Grp_Totalizador.Controls.Add(this.Lbl_TotalReceita);
            this.Grp_Totalizador.Controls.Add(this.Lbl_TotalDespesas);
            this.Grp_Totalizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Totalizador.Location = new System.Drawing.Point(9, 342);
            this.Grp_Totalizador.Name = "Grp_Totalizador";
            this.Grp_Totalizador.Size = new System.Drawing.Size(1039, 100);
            this.Grp_Totalizador.TabIndex = 7;
            this.Grp_Totalizador.TabStop = false;
            this.Grp_Totalizador.Text = "groupBox1";
            // 
            // Lbl_Saldo
            // 
            this.Lbl_Saldo.AutoSize = true;
            this.Lbl_Saldo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Saldo.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_Saldo.Location = new System.Drawing.Point(14, 64);
            this.Lbl_Saldo.Name = "Lbl_Saldo";
            this.Lbl_Saldo.Size = new System.Drawing.Size(64, 23);
            this.Lbl_Saldo.TabIndex = 12;
            this.Lbl_Saldo.Text = "label1";
            this.Lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_TotalReceita
            // 
            this.Lbl_TotalReceita.AutoSize = true;
            this.Lbl_TotalReceita.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TotalReceita.ForeColor = System.Drawing.Color.Green;
            this.Lbl_TotalReceita.Location = new System.Drawing.Point(536, 27);
            this.Lbl_TotalReceita.Name = "Lbl_TotalReceita";
            this.Lbl_TotalReceita.Size = new System.Drawing.Size(48, 17);
            this.Lbl_TotalReceita.TabIndex = 10;
            this.Lbl_TotalReceita.Text = "label2";
            // 
            // Lbl_TotalDespesas
            // 
            this.Lbl_TotalDespesas.AutoSize = true;
            this.Lbl_TotalDespesas.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TotalDespesas.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_TotalDespesas.Location = new System.Drawing.Point(15, 27);
            this.Lbl_TotalDespesas.Name = "Lbl_TotalDespesas";
            this.Lbl_TotalDespesas.Size = new System.Drawing.Size(48, 17);
            this.Lbl_TotalDespesas.TabIndex = 0;
            this.Lbl_TotalDespesas.Text = "label1";
            // 
            // Lbl_Receitas
            // 
            this.Lbl_Receitas.AutoSize = true;
            this.Lbl_Receitas.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Receitas.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Receitas.Location = new System.Drawing.Point(545, 49);
            this.Lbl_Receitas.Name = "Lbl_Receitas";
            this.Lbl_Receitas.Size = new System.Drawing.Size(43, 15);
            this.Lbl_Receitas.TabIndex = 6;
            this.Lbl_Receitas.Text = "label2";
            // 
            // Lbl_Despesas
            // 
            this.Lbl_Despesas.AutoSize = true;
            this.Lbl_Despesas.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Despesas.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_Despesas.Location = new System.Drawing.Point(24, 49);
            this.Lbl_Despesas.Name = "Lbl_Despesas";
            this.Lbl_Despesas.Size = new System.Drawing.Size(43, 15);
            this.Lbl_Despesas.TabIndex = 5;
            this.Lbl_Despesas.Text = "label1";
            // 
            // DatView_Receber
            // 
            this.DatView_Receber.AllowUserToAddRows = false;
            this.DatView_Receber.AllowUserToDeleteRows = false;
            this.DatView_Receber.AllowUserToOrderColumns = true;
            this.DatView_Receber.AllowUserToResizeRows = false;
            this.DatView_Receber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DatView_Receber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatView_Receber.Location = new System.Drawing.Point(548, 75);
            this.DatView_Receber.MultiSelect = false;
            this.DatView_Receber.Name = "DatView_Receber";
            this.DatView_Receber.ReadOnly = true;
            this.DatView_Receber.RowHeadersVisible = false;
            this.DatView_Receber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatView_Receber.Size = new System.Drawing.Size(500, 242);
            this.DatView_Receber.TabIndex = 4;
            // 
            // Dat_Inicial
            // 
            this.Dat_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Inicial.Location = new System.Drawing.Point(9, 43);
            this.Dat_Inicial.Name = "Dat_Inicial";
            this.Dat_Inicial.Size = new System.Drawing.Size(93, 20);
            this.Dat_Inicial.TabIndex = 4;
            // 
            // Grp_FiltroRelatorio
            // 
            this.Grp_FiltroRelatorio.Controls.Add(this.Btn_Buscar);
            this.Grp_FiltroRelatorio.Controls.Add(this.Lbl_DtInicial);
            this.Grp_FiltroRelatorio.Controls.Add(this.Lbl_DtFinal);
            this.Grp_FiltroRelatorio.Controls.Add(this.Dat_Final);
            this.Grp_FiltroRelatorio.Controls.Add(this.Dat_Inicial);
            this.Grp_FiltroRelatorio.Location = new System.Drawing.Point(18, 18);
            this.Grp_FiltroRelatorio.Name = "Grp_FiltroRelatorio";
            this.Grp_FiltroRelatorio.Size = new System.Drawing.Size(421, 100);
            this.Grp_FiltroRelatorio.TabIndex = 5;
            this.Grp_FiltroRelatorio.TabStop = false;
            this.Grp_FiltroRelatorio.Text = "groupBox2";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(245, 41);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 10;
            this.Btn_Buscar.Text = "button1";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Lbl_DtInicial
            // 
            this.Lbl_DtInicial.AutoSize = true;
            this.Lbl_DtInicial.Location = new System.Drawing.Point(8, 26);
            this.Lbl_DtInicial.Name = "Lbl_DtInicial";
            this.Lbl_DtInicial.Size = new System.Drawing.Size(35, 13);
            this.Lbl_DtInicial.TabIndex = 9;
            this.Lbl_DtInicial.Text = "label7";
            // 
            // Lbl_DtFinal
            // 
            this.Lbl_DtFinal.AutoSize = true;
            this.Lbl_DtFinal.Location = new System.Drawing.Point(121, 27);
            this.Lbl_DtFinal.Name = "Lbl_DtFinal";
            this.Lbl_DtFinal.Size = new System.Drawing.Size(35, 13);
            this.Lbl_DtFinal.TabIndex = 8;
            this.Lbl_DtFinal.Text = "label6";
            // 
            // Dat_Final
            // 
            this.Dat_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Final.Location = new System.Drawing.Point(120, 43);
            this.Dat_Final.Name = "Dat_Final";
            this.Dat_Final.Size = new System.Drawing.Size(93, 20);
            this.Dat_Final.TabIndex = 5;
            // 
            // Frm_Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.Grp_FiltroRelatorio);
            this.Controls.Add(this.Grp_MovimentacoesFinanceiras);
            this.Name = "Frm_Saldo";
            this.Size = new System.Drawing.Size(1104, 663);
            this.Load += new System.EventHandler(this.Frm_Saldo_Load);
            this.Grp_MovimentacoesFinanceiras.ResumeLayout(false);
            this.Grp_MovimentacoesFinanceiras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatView_Pagar)).EndInit();
            this.Grp_Totalizador.ResumeLayout(false);
            this.Grp_Totalizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatView_Receber)).EndInit();
            this.Grp_FiltroRelatorio.ResumeLayout(false);
            this.Grp_FiltroRelatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Grp_MovimentacoesFinanceiras;
        private System.Windows.Forms.DataGridView DatView_Receber;
        private System.Windows.Forms.DataGridView DatView_Pagar;
        private System.Windows.Forms.Button Btn_ImportarFixos;
        private System.Windows.Forms.GroupBox Grp_Totalizador;
        private System.Windows.Forms.Label Lbl_TotalDespesas;
        private System.Windows.Forms.Label Lbl_Receitas;
        private System.Windows.Forms.Label Lbl_Despesas;
        private System.Windows.Forms.DateTimePicker Dat_Inicial;
        private System.Windows.Forms.GroupBox Grp_FiltroRelatorio;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_DtInicial;
        private System.Windows.Forms.Label Lbl_DtFinal;
        private System.Windows.Forms.DateTimePicker Dat_Final;
        private System.Windows.Forms.Label Lbl_Saldo;
        private System.Windows.Forms.Label Lbl_TotalReceita;
    }
}
