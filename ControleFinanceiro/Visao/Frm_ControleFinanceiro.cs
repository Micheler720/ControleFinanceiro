using ControleFinanceiro.Modelo;
using ControleFinanceiro.Visao.Cadastros;
using ControleFinanceiro.Visao.Movimentacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.Visao
{
    public partial class Frm_ControleFinanceiro : Form
    {
        public Frm_ControleFinanceiro(Frm_Login L, UsuarioModelo usuario)
        {
            InitializeComponent();
            Lbl_Usuario.Text = usuario.Usuario;
            var MyAvatar = (Image)global::ControleFinanceiro.Properties.Resources.ResourceManager.GetObject("avatar");
            Pic_Avatar.Image = MyAvatar;
            Pic_Avatar.SizeMode = PictureBoxSizeMode.Zoom;
           // L.Close();
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
            var U = new Frm_EstabelecimentoCadastro_UC();
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
            if (Tbc_Aplicacoes.SelectedIndex >= 0)
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
            if (Tbc_Aplicacoes.SelectedIndex >= 0)
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
            for (int i = tabSelecionada - 1; i >= 0; i--)
            {
                ApagarAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }
        private void vToolTip002_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedIndex >= 0)
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
            if (Tbc_Aplicacoes.SelectedIndex >= 0)
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
            if (Tbc_Aplicacoes.SelectedIndex >= 0)
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
    }
}
