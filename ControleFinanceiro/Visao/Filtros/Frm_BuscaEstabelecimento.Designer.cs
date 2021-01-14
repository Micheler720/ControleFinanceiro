namespace ControleFinanceiro.Visao.Filtros
{
    partial class Frm_BuscaEstabelecimento
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
            this.Txt_Estabelecimento = new System.Windows.Forms.TextBox();
            this.Lbl_Busca = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Abrir = new System.Windows.Forms.Button();
            this.Lst_Estabelecimento = new System.Windows.Forms.ListBox();
            this.Lbl_Legenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Estabelecimento
            // 
            this.Txt_Estabelecimento.Location = new System.Drawing.Point(12, 24);
            this.Txt_Estabelecimento.Name = "Txt_Estabelecimento";
            this.Txt_Estabelecimento.Size = new System.Drawing.Size(281, 20);
            this.Txt_Estabelecimento.TabIndex = 0;
            this.Txt_Estabelecimento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Estabelecimento_KeyUp);
            // 
            // Lbl_Busca
            // 
            this.Lbl_Busca.AutoSize = true;
            this.Lbl_Busca.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Busca.Name = "Lbl_Busca";
            this.Lbl_Busca.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Busca.TabIndex = 1;
            this.Lbl_Busca.Text = "label1";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(376, 24);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "button1";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(376, 264);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sair.TabIndex = 4;
            this.Btn_Sair.Text = "button1";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Abrir
            // 
            this.Btn_Abrir.Location = new System.Drawing.Point(295, 264);
            this.Btn_Abrir.Name = "Btn_Abrir";
            this.Btn_Abrir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Abrir.TabIndex = 5;
            this.Btn_Abrir.Text = "button1";
            this.Btn_Abrir.UseVisualStyleBackColor = true;
            this.Btn_Abrir.Click += new System.EventHandler(this.Btn_Abrir_Click);
            // 
            // Lst_Estabelecimento
            // 
            this.Lst_Estabelecimento.FormattingEnabled = true;
            this.Lst_Estabelecimento.Location = new System.Drawing.Point(12, 65);
            this.Lst_Estabelecimento.Name = "Lst_Estabelecimento";
            this.Lst_Estabelecimento.Size = new System.Drawing.Size(439, 160);
            this.Lst_Estabelecimento.TabIndex = 6;
            this.Lst_Estabelecimento.DoubleClick += new System.EventHandler(this.Lst_Estabelecimento_DoubleClick);
            // 
            // Lbl_Legenda
            // 
            this.Lbl_Legenda.AutoSize = true;
            this.Lbl_Legenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Legenda.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_Legenda.Location = new System.Drawing.Point(12, 242);
            this.Lbl_Legenda.Name = "Lbl_Legenda";
            this.Lbl_Legenda.Size = new System.Drawing.Size(47, 15);
            this.Lbl_Legenda.TabIndex = 7;
            this.Lbl_Legenda.Text = "label1";
            // 
            // Frm_BuscaEstabelecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 299);
            this.Controls.Add(this.Lbl_Legenda);
            this.Controls.Add(this.Lst_Estabelecimento);
            this.Controls.Add(this.Btn_Abrir);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Busca);
            this.Controls.Add(this.Txt_Estabelecimento);
            this.Name = "Frm_BuscaEstabelecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaEstabelecimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Estabelecimento;
        private System.Windows.Forms.Label Lbl_Busca;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Abrir;
        private System.Windows.Forms.ListBox Lst_Estabelecimento;
        private System.Windows.Forms.Label Lbl_Legenda;
    }
}