using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.Excexoes;
using ControleFinanceiro.Util;
using ControleFinanceiro.Visao.Avisos;

namespace ControleFinanceiro.Visao.Cadastros
{
    public partial class Frm_TipoEstabelecimento_UC : UserControl
    {
        public Frm_TipoEstabelecimento_UC()
        {
            InitializeComponent();
            Lbl_Codigo.Text = "Código";
            Lbl_Descricao.Text = "Descrição";
            Txt_Codigo.Enabled = false;
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Novo.Text = "Novo";
            Btn_Editar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Gravar.Enabled = false;
            Txt_Descricao.Enabled = false;
            Btn_Gravar.Text = "Gravar";
            Grp_TipoEstabelecimento.Text = "Tipo Estabelecimento";
        }

        private void Frm_TipoEstabelecimento_UC_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Btn_Gravar.Enabled = true;
            Btn_Novo.Enabled = false;
            Txt_Descricao.Enabled = true;
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                try
                {
                    var tipoEstabelecimento = new TipoEstabelecimentoModelo();
                    tipoEstabelecimento.Descricao = Txt_Descricao.Text;
                    var M = new Frm_Aviso("Dados Gravados com Sucesso!", "sucesso");
                    M.ShowDialog();
                    LimparFormulario();
                    Btn_Gravar.Enabled = false;
                    Btn_Novo.Enabled = true;
                }
                catch (TipoEstabelecimentoException ex)
                {
                    MessageBox.Show(ex.Message, "Tipo Estabelecimento - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Descricao_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Codigo_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Descricao_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Descricao.Text.Length > 0)
            {
                Grp_TipoEstabelecimento.AlterarBordaComponente(Txt_Descricao, Color.Green);
            }
            else
            {
                Grp_TipoEstabelecimento.AlterarBordaComponente(Txt_Descricao, Color.Red);
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {

        }

        private void Tab_TipoEstabelecimento_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool ValidaFormulario()
        {
            var temp = "";
            if(Txt_Descricao.Text == "")
            {
                temp += "Verifique a Descrição do Tipo Estabelecimento \r\n";
                Grp_TipoEstabelecimento.AlterarBordaComponente(Txt_Descricao, Color.Red);

            }
            else
            {

                Grp_TipoEstabelecimento.AlterarBordaComponente(Txt_Descricao, Color.Green);
            }
            if(Txt_Descricao.Text.Length > 50)
            {
                temp += "Tamonho máximo de descrição 50 caracteres.";
                Grp_TipoEstabelecimento.AlterarBordaComponente(Txt_Descricao, Color.Red);
            }
            else
            {

                Grp_TipoEstabelecimento.AlterarBordaComponente(Txt_Descricao, Color.Green);
            }
            if(temp != "")
            {
                MessageBox.Show(temp, "Cadastro Tipo Estabelecimento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente limpar o formulario", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.OK)
            {
                LimparFormulario();
            }
        }
        private void LimparFormulario()
        {
            Txt_Descricao.Text = "";
            Txt_Descricao.Enabled = false;
            Btn_Editar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Novo.Enabled = true;
            Btn_Gravar.Enabled = false;
            Grp_TipoEstabelecimento.AlterarBordaComponente(Txt_Descricao, Grp_TipoEstabelecimento.BackColor);
        }

        private void ajudaToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela Referente a cadastro de tipo de estabelecimento. Exemplos: Lazer, Despesa, Investimento ...", "Ajuda - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
