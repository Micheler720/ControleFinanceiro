﻿namespace ControleFinanceiro.Visao
{
    partial class Frm_ControleFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ControleFinanceiro));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Mnu_Aplicacao = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoEstabelecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estabelecimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasFixasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nubankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharAbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Iml_ListaTabPage = new System.Windows.Forms.ImageList(this.components);
            this.Grp_Avatar = new System.Windows.Forms.GroupBox();
            this.Lik_Usuario = new System.Windows.Forms.LinkLabel();
            this.Pic_Avatar = new System.Windows.Forms.PictureBox();
            this.Tab_Inicio = new System.Windows.Forms.TabPage();
            this.Cha_GastoDiario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mnu_Aplicacao.SuspendLayout();
            this.Grp_Avatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Avatar)).BeginInit();
            this.Tab_Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cha_GastoDiario)).BeginInit();
            this.Tbc_Aplicacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mnu_Aplicacao
            // 
            this.Mnu_Aplicacao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Mnu_Aplicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mnu_Aplicacao.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mnu_Aplicacao.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mnu_Aplicacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.integraçõesToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.fecharAbaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.Mnu_Aplicacao.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Aplicacao.Name = "Mnu_Aplicacao";
            this.Mnu_Aplicacao.Size = new System.Drawing.Size(126, 703);
            this.Mnu_Aplicacao.TabIndex = 1;
            this.Mnu_Aplicacao.Text = "Menu";
            this.Mnu_Aplicacao.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Mnu_Aplicacao_ItemClicked);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoEstabelecimentoToolStripMenuItem,
            this.estabelecimentosToolStripMenuItem,
            this.despesasFixasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.Cadastros;
            this.cadastrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 10);
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(113, 30);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tipoEstabelecimentoToolStripMenuItem
            // 
            this.tipoEstabelecimentoToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.TipoEstabelecimento;
            this.tipoEstabelecimentoToolStripMenuItem.Name = "tipoEstabelecimentoToolStripMenuItem";
            this.tipoEstabelecimentoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tipoEstabelecimentoToolStripMenuItem.Text = "Tipo Estabelecimento";
            this.tipoEstabelecimentoToolStripMenuItem.Click += new System.EventHandler(this.tipoEstabelecimentoToolStripMenuItem_Click);
            // 
            // estabelecimentosToolStripMenuItem
            // 
            this.estabelecimentosToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.Estabelecimentos;
            this.estabelecimentosToolStripMenuItem.Name = "estabelecimentosToolStripMenuItem";
            this.estabelecimentosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.estabelecimentosToolStripMenuItem.Text = "Estabelecimentos";
            this.estabelecimentosToolStripMenuItem.Click += new System.EventHandler(this.estabelecimentosToolStripMenuItem_Click);
            // 
            // despesasFixasToolStripMenuItem
            // 
            this.despesasFixasToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.GastosFixos;
            this.despesasFixasToolStripMenuItem.Name = "despesasFixasToolStripMenuItem";
            this.despesasFixasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.despesasFixasToolStripMenuItem.Text = "Valores Fixos";
            this.despesasFixasToolStripMenuItem.Click += new System.EventHandler(this.despesasFixasToolStripMenuItem_Click);
            // 
            // integraçõesToolStripMenuItem
            // 
            this.integraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nubankToolStripMenuItem});
            this.integraçõesToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.integracao;
            this.integraçõesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.integraçõesToolStripMenuItem.Name = "integraçõesToolStripMenuItem";
            this.integraçõesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 10);
            this.integraçõesToolStripMenuItem.Size = new System.Drawing.Size(113, 30);
            this.integraçõesToolStripMenuItem.Text = "Integrações";
            this.integraçõesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nubankToolStripMenuItem
            // 
            this.nubankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.nubankToolStripMenuItem.Name = "nubankToolStripMenuItem";
            this.nubankToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.nubankToolStripMenuItem.Text = "Nubank";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.saídasToolStripMenuItem,
            this.saldoToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.Movimentacoes;
            this.movimentaçõesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 10);
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(113, 30);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            this.movimentaçõesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.Entradas;
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // saídasToolStripMenuItem
            // 
            this.saídasToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.Saidas;
            this.saídasToolStripMenuItem.Name = "saídasToolStripMenuItem";
            this.saídasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.saídasToolStripMenuItem.Text = "Saídas";
            this.saídasToolStripMenuItem.Click += new System.EventHandler(this.saídasToolStripMenuItem_Click);
            // 
            // saldoToolStripMenuItem
            // 
            this.saldoToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.Saldo;
            this.saldoToolStripMenuItem.Name = "saldoToolStripMenuItem";
            this.saldoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.saldoToolStripMenuItem.Text = "Saldo";
            this.saldoToolStripMenuItem.Click += new System.EventHandler(this.saldoToolStripMenuItem_Click);
            // 
            // fecharAbaToolStripMenuItem
            // 
            this.fecharAbaToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.Erro;
            this.fecharAbaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharAbaToolStripMenuItem.Name = "fecharAbaToolStripMenuItem";
            this.fecharAbaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 10);
            this.fecharAbaToolStripMenuItem.Size = new System.Drawing.Size(113, 30);
            this.fecharAbaToolStripMenuItem.Text = "Fechar Aba";
            this.fecharAbaToolStripMenuItem.Click += new System.EventHandler(this.fecharAbaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::ControleFinanceiro.Properties.Resources.Sair;
            this.sairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 10);
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(113, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Iml_ListaTabPage
            // 
            this.Iml_ListaTabPage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Iml_ListaTabPage.ImageStream")));
            this.Iml_ListaTabPage.TransparentColor = System.Drawing.Color.Transparent;
            this.Iml_ListaTabPage.Images.SetKeyName(0, "Cadastros.png");
            this.Iml_ListaTabPage.Images.SetKeyName(1, "Entradas.png");
            this.Iml_ListaTabPage.Images.SetKeyName(2, "Estabelecimentos.png");
            this.Iml_ListaTabPage.Images.SetKeyName(3, "Movimentacoes.png");
            this.Iml_ListaTabPage.Images.SetKeyName(4, "Saldo.png");
            this.Iml_ListaTabPage.Images.SetKeyName(5, "ControleFinanceiro.ico");
            this.Iml_ListaTabPage.Images.SetKeyName(6, "Erro.png");
            this.Iml_ListaTabPage.Images.SetKeyName(7, "GastosFixos.png");
            this.Iml_ListaTabPage.Images.SetKeyName(8, "TipoEstabelecimento.png");
            this.Iml_ListaTabPage.Images.SetKeyName(9, "Saidas.png");
            this.Iml_ListaTabPage.Images.SetKeyName(10, "integracao.png");
            // 
            // Grp_Avatar
            // 
            this.Grp_Avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Grp_Avatar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grp_Avatar.Controls.Add(this.Lik_Usuario);
            this.Grp_Avatar.Controls.Add(this.Pic_Avatar);
            this.Grp_Avatar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Avatar.Location = new System.Drawing.Point(0, 524);
            this.Grp_Avatar.Name = "Grp_Avatar";
            this.Grp_Avatar.Size = new System.Drawing.Size(126, 179);
            this.Grp_Avatar.TabIndex = 1;
            this.Grp_Avatar.TabStop = false;
            this.Grp_Avatar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Lik_Usuario
            // 
            this.Lik_Usuario.AutoSize = true;
            this.Lik_Usuario.Location = new System.Drawing.Point(5, 154);
            this.Lik_Usuario.Name = "Lik_Usuario";
            this.Lik_Usuario.Size = new System.Drawing.Size(61, 16);
            this.Lik_Usuario.TabIndex = 3;
            this.Lik_Usuario.TabStop = true;
            this.Lik_Usuario.Text = "linkLabel1";
            this.Lik_Usuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lik_Usuario_LinkClicked);
            // 
            // Pic_Avatar
            // 
            this.Pic_Avatar.Location = new System.Drawing.Point(8, 22);
            this.Pic_Avatar.Name = "Pic_Avatar";
            this.Pic_Avatar.Size = new System.Drawing.Size(112, 129);
            this.Pic_Avatar.TabIndex = 1;
            this.Pic_Avatar.TabStop = false;
            // 
            // Tab_Inicio
            // 
            this.Tab_Inicio.Controls.Add(this.groupBox1);
            this.Tab_Inicio.Controls.Add(this.chart1);
            this.Tab_Inicio.Controls.Add(this.Cha_GastoDiario);
            this.Tab_Inicio.ImageIndex = 5;
            this.Tab_Inicio.Location = new System.Drawing.Point(4, 23);
            this.Tab_Inicio.Name = "Tab_Inicio";
            this.Tab_Inicio.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Inicio.Size = new System.Drawing.Size(1001, 676);
            this.Tab_Inicio.TabIndex = 0;
            this.Tab_Inicio.Text = "tabPage1";
            this.Tab_Inicio.UseVisualStyleBackColor = true;
            this.Tab_Inicio.Click += new System.EventHandler(this.Tab_Inicio_Click);
            // 
            // Cha_GastoDiario
            // 
            this.Cha_GastoDiario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.Cha_GastoDiario.ChartAreas.Add(chartArea2);
            legend2.ItemColumnSpacing = 1;
            legend2.Name = "Legend1";
            this.Cha_GastoDiario.Legends.Add(legend2);
            this.Cha_GastoDiario.Location = new System.Drawing.Point(15, 16);
            this.Cha_GastoDiario.Name = "Cha_GastoDiario";
            this.Cha_GastoDiario.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.Cha_GastoDiario.Size = new System.Drawing.Size(978, 338);
            this.Cha_GastoDiario.TabIndex = 0;
            this.Cha_GastoDiario.Text = "chart1";
            this.Cha_GastoDiario.Click += new System.EventHandler(this.Cha_GastoDiario_Click);
            // 
            // Tbc_Aplicacoes
            // 
            this.Tbc_Aplicacoes.Controls.Add(this.Tab_Inicio);
            this.Tbc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Aplicacoes.ImageList = this.Iml_ListaTabPage;
            this.Tbc_Aplicacoes.Location = new System.Drawing.Point(126, 0);
            this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            this.Tbc_Aplicacoes.SelectedIndex = 0;
            this.Tbc_Aplicacoes.Size = new System.Drawing.Size(1009, 703);
            this.Tbc_Aplicacoes.TabIndex = 2;
            this.Tbc_Aplicacoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbc_Aplicacoes_MouseDown);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-1, 430);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(460, 190);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(474, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Frm_ControleFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1135, 703);
            this.Controls.Add(this.Tbc_Aplicacoes);
            this.Controls.Add(this.Grp_Avatar);
            this.Controls.Add(this.Mnu_Aplicacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ControleFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ControleFinanceiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ControleFinanceiro_Load);
            this.Mnu_Aplicacao.ResumeLayout(false);
            this.Mnu_Aplicacao.PerformLayout();
            this.Grp_Avatar.ResumeLayout(false);
            this.Grp_Avatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Avatar)).EndInit();
            this.Tab_Inicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cha_GastoDiario)).EndInit();
            this.Tbc_Aplicacoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Aplicacao;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estabelecimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoEstabelecimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasFixasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox Grp_Avatar;
        private System.Windows.Forms.PictureBox Pic_Avatar;
        private System.Windows.Forms.ImageList Iml_ListaTabPage;
        private System.Windows.Forms.ToolStripMenuItem fecharAbaToolStripMenuItem;
        private System.Windows.Forms.TabPage Tab_Inicio;
        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.DataVisualization.Charting.Chart Cha_GastoDiario;
        private System.Windows.Forms.ToolStripMenuItem integraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nubankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.LinkLabel Lik_Usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}