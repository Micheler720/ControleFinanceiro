namespace ControleFinanceiro.Visao.Avisos
{
    partial class Frm_Aviso
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
            this.Lbl_Aviso = new System.Windows.Forms.Label();
            this.Pic_Aviso = new System.Windows.Forms.PictureBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Aviso)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Aviso
            // 
            this.Lbl_Aviso.AutoSize = true;
            this.Lbl_Aviso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Aviso.Location = new System.Drawing.Point(12, 20);
            this.Lbl_Aviso.Name = "Lbl_Aviso";
            this.Lbl_Aviso.Size = new System.Drawing.Size(47, 16);
            this.Lbl_Aviso.TabIndex = 0;
            this.Lbl_Aviso.Text = "label1";
            // 
            // Pic_Aviso
            // 
            this.Pic_Aviso.Location = new System.Drawing.Point(12, 55);
            this.Pic_Aviso.Name = "Pic_Aviso";
            this.Pic_Aviso.Size = new System.Drawing.Size(103, 86);
            this.Pic_Aviso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Aviso.TabIndex = 1;
            this.Pic_Aviso.TabStop = false;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(175, 118);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(102, 23);
            this.Btn_Ok.TabIndex = 2;
            this.Btn_Ok.Text = "button1";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Frm_Aviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 151);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Pic_Aviso);
            this.Controls.Add(this.Lbl_Aviso);
            this.Name = "Frm_Aviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Aviso";
            this.Load += new System.EventHandler(this.Frm_Aviso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Aviso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Aviso;
        private System.Windows.Forms.PictureBox Pic_Aviso;
        private System.Windows.Forms.Button Btn_Ok;
    }
}