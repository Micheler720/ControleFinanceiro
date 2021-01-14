namespace ControleFinanceiro.Visao.Integrações
{
    partial class Frm_LoginIntegracoes
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
            this.Grp_DadosLogin = new System.Windows.Forms.GroupBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Btn_Integrar = new System.Windows.Forms.Button();
            this.Txt_Integracao = new System.Windows.Forms.TextBox();
            this.Grp_DadosLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_DadosLogin
            // 
            this.Grp_DadosLogin.Controls.Add(this.Btn_Integrar);
            this.Grp_DadosLogin.Controls.Add(this.Lbl_Usuario);
            this.Grp_DadosLogin.Controls.Add(this.Lbl_Password);
            this.Grp_DadosLogin.Controls.Add(this.Txt_Password);
            this.Grp_DadosLogin.Controls.Add(this.Txt_Usuario);
            this.Grp_DadosLogin.Location = new System.Drawing.Point(21, 27);
            this.Grp_DadosLogin.Name = "Grp_DadosLogin";
            this.Grp_DadosLogin.Size = new System.Drawing.Size(362, 210);
            this.Grp_DadosLogin.TabIndex = 0;
            this.Grp_DadosLogin.TabStop = false;
            this.Grp_DadosLogin.Text = "groupBox1";
            this.Grp_DadosLogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(17, 55);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(318, 20);
            this.Txt_Usuario.TabIndex = 0;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(17, 112);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(318, 20);
            this.Txt_Password.TabIndex = 1;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(14, 96);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Password.TabIndex = 2;
            this.Lbl_Password.Text = "label1";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Location = new System.Drawing.Point(14, 39);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Usuario.TabIndex = 3;
            this.Lbl_Usuario.Text = "label2";
            // 
            // Btn_Integrar
            // 
            this.Btn_Integrar.Location = new System.Drawing.Point(260, 163);
            this.Btn_Integrar.Name = "Btn_Integrar";
            this.Btn_Integrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Integrar.TabIndex = 4;
            this.Btn_Integrar.Text = "button1";
            this.Btn_Integrar.UseVisualStyleBackColor = true;
            this.Btn_Integrar.Click += new System.EventHandler(this.Btn_Integrar_Click);
            // 
            // Txt_Integracao
            // 
            this.Txt_Integracao.Location = new System.Drawing.Point(21, 267);
            this.Txt_Integracao.Name = "Txt_Integracao";
            this.Txt_Integracao.Size = new System.Drawing.Size(100, 20);
            this.Txt_Integracao.TabIndex = 1;
            // 
            // Frm_LoginIntegracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_Integracao);
            this.Controls.Add(this.Grp_DadosLogin);
            this.Name = "Frm_LoginIntegracoes";
            this.Size = new System.Drawing.Size(430, 349);
            this.Grp_DadosLogin.ResumeLayout(false);
            this.Grp_DadosLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_DadosLogin;
        private System.Windows.Forms.Button Btn_Integrar;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Integracao;
    }
}
