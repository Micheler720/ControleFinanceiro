namespace ControleFinanceiro.Visao
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Pic_Login = new System.Windows.Forms.PictureBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_Usuario.Location = new System.Drawing.Point(12, 144);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(50, 16);
            this.Lbl_Usuario.TabIndex = 0;
            this.Lbl_Usuario.Text = "label1";
            // 
            // Pic_Login
            // 
            this.Pic_Login.Location = new System.Drawing.Point(12, 12);
            this.Pic_Login.Name = "Pic_Login";
            this.Pic_Login.Size = new System.Drawing.Size(187, 117);
            this.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Login.TabIndex = 1;
            this.Pic_Login.TabStop = false;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.Color.White;
            this.Txt_Usuario.Location = new System.Drawing.Point(12, 164);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(187, 20);
            this.Txt_Usuario.TabIndex = 2;
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_Senha.Location = new System.Drawing.Point(11, 195);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(50, 16);
            this.Lbl_Senha.TabIndex = 3;
            this.Lbl_Senha.Text = "label1";
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(12, 217);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(187, 20);
            this.Txt_Senha.TabIndex = 4;
            this.Txt_Senha.TextChanged += new System.EventHandler(this.Txt_Senha_TextChanged);
            this.Txt_Senha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyUp);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(12, 253);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(86, 23);
            this.Btn_Ok.TabIndex = 5;
            this.Btn_Ok.Text = "button1";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Fechar.Location = new System.Drawing.Point(113, 253);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(86, 23);
            this.Btn_Fechar.TabIndex = 6;
            this.Btn_Fechar.Text = "button1";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(211, 288);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Pic_Login);
            this.Controls.Add(this.Lbl_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.PictureBox Pic_Login;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}