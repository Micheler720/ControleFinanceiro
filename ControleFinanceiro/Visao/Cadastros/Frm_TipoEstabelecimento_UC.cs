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
using ControleFinanceiro.Controle;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Visao.Filtros;

namespace ControleFinanceiro.Visao.Cadastros
{
    public partial class Frm_TipoEstabelecimento_UC : UserControl
    {
        private string Operacao;
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

            Operacao = "Novo";
            Btn_Gravar.Enabled = true;
            Btn_Novo.Enabled = false;
            Txt_Descricao.Enabled = true;
            Txt_Descricao.Focus();
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                try
                {
                    var tipoEstabelecimento = CapturarFormulario();
                    var tipoEstabelecimentoControle = new TipoEstabelecimentoControle();

                    if (Operacao == "Novo")
                    {
                        tipoEstabelecimentoControle.GravarTipoEstabelecimento(tipoEstabelecimento);
                    }
                    else
                    {
                        tipoEstabelecimento.Id = int.Parse(Txt_Codigo.Text);
                        tipoEstabelecimentoControle.AlterarTipoEstabelecimento(tipoEstabelecimento);
                    }                         
                    var M = new Frm_Aviso(tipoEstabelecimentoControle.Mensagem, "sucesso");
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
        private Tipo_Estabelecimento CapturarFormulario()
        {
            var tipoEstabelecimento = new Tipo_Estabelecimento();
            tipoEstabelecimento.Descricao = Txt_Descricao.Text;
            tipoEstabelecimento.Status = 1;
            return tipoEstabelecimento;
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
            Operacao = "Editar";
            Txt_Descricao.Enabled = true;
            Btn_Gravar.Enabled = true;
            Btn_Novo.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Editar.Enabled = false;
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            var M = MessageBox.Show("Deseja realmente excluir o Tipo Estabelecimento", "Exclusão",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(M == DialogResult.OK)
            {
                var controle = new TipoEstabelecimentoControle();
                var estabelecimento = new Tipo_Estabelecimento();
                estabelecimento.Descricao = Txt_Descricao.Text;
                estabelecimento.Id = int.Parse(Txt_Codigo.Text);
                controle.ExcluirTipoEstabelecimento(estabelecimento);
                LimparFormulario();
            }
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
            Txt_Codigo.Text = "";
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

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            var tipoEstabelecimentoControle = new TipoEstabelecimentoControle();
            var tiposEstabelecimentos = tipoEstabelecimentoControle.BuscarTipoEstabelecimento();
            var F = new Frm_Busca(tiposEstabelecimentos, "Tipo Estabelecimentos");
            F.ShowDialog();
            if(F.DialogResult == DialogResult.OK)
            {
                var tipoEstabelecimento = new Tipo_Estabelecimento();
                var controleTipoEstabelecimento = new TipoEstabelecimentoControle();
                var id = int.Parse(F.IdSelect);
                tipoEstabelecimento = controleTipoEstabelecimento.BuscarTipoEstabelecimentoId(id);
                PreencherFormulario(tipoEstabelecimento);
                Btn_Editar.Enabled = true;
                Btn_Excluir.Enabled = true;
            }
        }
        private void PreencherFormulario(Tipo_Estabelecimento estabelecimento)
        {
            Txt_Codigo.Text = estabelecimento.Id.ToString();
            Txt_Descricao.Text = estabelecimento.Descricao;
        }

    }
}
