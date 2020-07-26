using ControleFinanceiro.Controle;
using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.Controle;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Modelo;
using ControleFinanceiro.Visao.Cadastros;
using ControleFinanceiro.Visao.Integrações;
using ControleFinanceiro.Visao.Movimentacoes;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ControleFinanceiro.Visao
{
    public partial class Frm_ControleFinanceiro : Form
    {
        private static Usuario usuarioLogado1;

        public static Usuario GetusuarioLogado()
        {
            return usuarioLogado1;
        }

        private static void SetusuarioLogado(Usuario value)
        {
            usuarioLogado1 = value;
        }

        public Frm_ControleFinanceiro(Frm_Login L, Usuario usuario)
        {
            InitializeComponent();
            Lik_Usuario.Text = usuario.Nome;
            if(usuario.Foto is null)
            {
                var MyAvatar = (Image)global::ControleFinanceiro.Properties.Resources.ResourceManager.GetObject("avatar");
                Pic_Avatar.Image = MyAvatar;
            }
            else
            {
                Pic_Avatar.Image = Image.FromFile(usuario.Foto);
            }
            Pic_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            Tab_Inicio.Text = "Inicio";
            Tab_Inicio.ImageIndex = 5;
            configurarGrafico();
            SetusuarioLogado(usuario);
            // L.Close();
        }
        private void configurarGrafico()
        {
            Cha_GastoDiario.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            var hoje = DateTime.Now;
            TimeSpan dias = new TimeSpan(30, 0, 0, 0, 0);
            var UltimoDia = hoje.Subtract(dias);
            var controlePagar = new FinPagarControle();
            var controleReceber = new FinReceberControle();
            var lancametosPagar = controlePagar.BuscarLancamentosAgrupadaPorData(UltimoDia, hoje);
            preencherGrafico(lancametosPagar, "Desepesas", Color.Red);
            var lancametosReceber = controleReceber.BuscarLancamentosAgrupadaPorData(UltimoDia, hoje);
            preencherGrafico(lancametosReceber, "Receitas", Color.Green);
            Cha_GastoDiario.Titles.Add(CreateTitle());
        }
        private Title CreateTitle()
        {
            Title title = new Title();
            title.Text = "Gráfico de Movimentações ultimos 30 dias";
            title.ShadowColor = Color.FromArgb(32, 100, 0, 0);
            // title.ShadowColor = Color.FromArgb(32, 0, 0, 0);
            title.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold);
            title.ShadowOffset = 3;
            title.ForeColor = Color.FromArgb(26, 59, 105);
            return title;
        }
        private void preencherGrafico(List<RelAgrupadoPorData> lancamentos, string nome, Color cor)
        {
            TimeSpan dias = new TimeSpan(30, 0, 0, 0, 0);
            var UltimoDia = DateTime.Now.Subtract(dias);
            var series1 = new Series
            {
                Name =nome,
                Color = cor,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Spline,
                MarkerSize = 5,
                IsValueShownAsLabel = true,
                BorderWidth = 3
            };
            Cha_GastoDiario.Series.Add(series1);
            for (int i = 1; i<=30; i++)
            {
                foreach (var item in lancamentos)
                {
                    if (item.Data.ToShortDateString() == UltimoDia.ToShortDateString())
                    {                        
                        series1.Points.AddXY(UltimoDia.ToString("dd/MM"), item.Valor);
                        UltimoDia = UltimoDia.AddDays(1);
                        continue;
                    }
                }
                series1.Points.AddXY(UltimoDia.ToString("dd/MM"), 0);
                UltimoDia = UltimoDia.AddDays(1);
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void Mnu_Aplicacao_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Frm_ControleFinanceiro_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void estabelecimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controleTipoEstabelecimento = new TipoEstabelecimentoControle();
            var tipoEstabelecimento = controleTipoEstabelecimento.BuscarTipoEstabelecimento();
            var U = new Frm_EstabelecimentoCadastro_UC(tipoEstabelecimento);
            var TB = new TabPage();
            TB.Name = "Cadastro de Estabelecimento";
            TB.Text = "Cadastro de Estabelecimento";
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
            SelecionarUltimaTabPage();
        }
        

        private void tipoEstabelecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var U = new Frm_TipoEstabelecimento_UC();
            var TB = new TabPage();
            TB.Name = "Cadastro Tipo Estabelecimento";
            TB.Text = "Cadastro Tipo Estabelecimento";
            TB.ImageIndex = 8;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
            SelecionarUltimaTabPage();


        }

        private void SelecionarUltimaTabPage()
        {
            var qtTBPage = Tbc_Aplicacoes.TabPages.Count;
            Tbc_Aplicacoes.SelectedTab = Tbc_Aplicacoes.TabPages[--qtTBPage];
        }

        private void fecharAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedIndex > 0)
            {
                var pergunta = MessageBox.Show("Deseja realmente fechar aba?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pergunta == DialogResult.Yes)
                {
                    ApagarAba(Tbc_Aplicacoes.SelectedTab);
                }
            }
        }

        private void ApagarAba(TabPage TB)
        {
                Tbc_Aplicacoes.TabPages.Remove(TB);
        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = IncluirItemMenu("Fechar Aba","DeleteTab" );
                var vToolTip002 = IncluirItemMenu("Fechar a esquerda", "DeleteLeft" );
                var vToolTip003 = IncluirItemMenu("Fechar a direita", "DeleteRight" );
                var vToolTip004 = IncluirItemMenu("Fechar todas exceto está","DeleteAll" );
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Items.Add(vToolTip004);
                ContextMenu.Show(this, e.X, e.Y);
                vToolTip001.Click += new EventHandler(vToolTip001_Click);
                vToolTip002.Click += new EventHandler(vToolTip002_Click);
                vToolTip003.Click += new EventHandler(vToolTip003_Click);
                vToolTip004.Click += new EventHandler(vToolTip004_Click);
            }
        }

        private void vToolTip001_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedIndex > 0)
            {
                var pergunta = MessageBox.Show("Deseja realmente fechar aba?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pergunta == DialogResult.Yes)
                {                
                    ApagarAba(Tbc_Aplicacoes.TabPages[Tbc_Aplicacoes.SelectedIndex]);
                }
            }
        }

        private void ApagarAbaDireita()
        {
            var tabPages = Tbc_Aplicacoes.TabPages.Count;
            var tabSelecionada = Tbc_Aplicacoes.SelectedIndex;
            for(int i = tabPages-1; i > tabSelecionada; i--)
            {
                ApagarAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }
        private void ApagarAbaEsquerda()
        {
            var tabSelecionada = Tbc_Aplicacoes.SelectedIndex;
            for (int i = tabSelecionada - 1; i > 0; i--)
            {
                ApagarAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }
        private void vToolTip002_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedIndex > 0)
            {
                var pergunta = MessageBox.Show("Deseja realmente fechar aba?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pergunta == DialogResult.Yes)
                {                   
                    ApagarAbaEsquerda();
                }
            }
        }
        private void vToolTip003_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedIndex > 0)
            {
                var pergunta = MessageBox.Show("Deseja realmente fechar aba?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pergunta == DialogResult.Yes)
                {
                    ApagarAbaDireita();
                }
            }
        }
        private void vToolTip004_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedIndex > 0)
            {
                var pergunta = MessageBox.Show("Deseja realmente fechar aba?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pergunta == DialogResult.Yes)
                {
                    ApagarAbaEsquerda();
                    ApagarAbaDireita();
                }
            }
        }
        private ToolStripMenuItem IncluirItemMenu(string texto, string nomeImagem, params string[] menuDropDown)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = texto;
            Image MyImage = (Image)global::ControleFinanceiro.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = MyImage;
            foreach (string menu in menuDropDown)
            {
                vToolTip.DropDownItems.Add(menu);
            }
            return vToolTip;
        }

        private void despesasFixasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var U = new Frm_ValoresFixosCadastro();
            var TB = new TabPage();
            TB.Text = "Despesas Fixas";
            TB.Name = "Despesas Fixas";
            TB.ImageIndex = 7;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.Controls.Add(TB);
            SelecionarUltimaTabPage();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var U = new Frm_Entradas();
            var TB = new TabPage();
            TB.Text = "Entradas";
            TB.Name = "Entradas";
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.Controls.Add(TB);
            SelecionarUltimaTabPage();
        }

        private void saídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var U = new Frm_Saidas();
            var TB = new TabPage();
            TB.Text = "Saídas";
            TB.Name = "Saídas";
            TB.ImageIndex = 9;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.Controls.Add(TB);
            SelecionarUltimaTabPage();
        }

        private void saldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var U = new Frm_Saldo();
            var TB = new TabPage();
            TB.Text = "Saldo";
            TB.Name = "Saldo";
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.Controls.Add(TB);
            SelecionarUltimaTabPage();
        }

        private void Cha_GastoDiario_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var U = new Frm_LoginIntegracoes();
            var TB = new TabPage();
            TB.Text = "Integrações";
            TB.Name = "Integrações";
            //TB.ImageIndex = 9;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.Controls.Add(TB);
            SelecionarUltimaTabPage();
        }

        private void Tab_Inicio_Click(object sender, EventArgs e)
        {
            
        }

        private void Lik_Usuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var usuarioLogado = GetusuarioLogado();
            var F = new Frm_DadosUsuario(2, usuarioLogado.Id);
            if(F.ShowDialog() == DialogResult.OK)
            {
                var controle = new UsuarioControle();
                SetusuarioLogado(controle.buscarUsuarioId(GetusuarioLogado().Id));
                Pic_Avatar.Image = Image.FromFile(GetusuarioLogado().Foto);
                Lik_Usuario.Text = GetusuarioLogado().Nome;
            }
        }
    }
}
