using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFinanceiro.Util;
using ControleFinanceiro.Modelo.Modelo;
using ControleFinanceiro.Modelo.Controle;
using ControleFinanceiro.Visao.Avisos;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Visao.Filtros;

namespace ControleFinanceiro.Visao.Cadastros
{
    public partial class Frm_ValoresFixosCadastro : UserControl
    {
        public Frm_ValoresFixosCadastro()
        {
            InitializeComponent();
            Lbl_Codigo.Text = "Codigo";
            Lbl_NomeDespesa.Text = "Descrição";
            Lbl_Valor.Text = "Valor";
            Lbl_Observacao.Text = "Observação";
            Lbl_TipoMovimentacao.Text = "Tipo Movimentação";
            Lbl_Estabelecimento.Text = "Estabelecimento";
            Txt_Codigo.Enabled = false;
            Ckb_AtivoInativo.Text = "Ativo";
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Novo.Text = "Novo";
            Btn_Gravar.Text = "Gravar";
            Btn_BuscaEstabelecimento.Text = "...";
            Grp_DadosDespesaFixa.Text = "Cadastro Despesas Fixas";
            Cbo_TipoMovimentacao.Items.Add("Entrada");
            Cbo_TipoMovimentacao.Items.Add("Saída");
            Cbo_TipoMovimentacao.SelectedItem = Cbo_TipoMovimentacao.Items[0];
            LimparFormulario();
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            var M = MessageBox.Show("Deseja realmente excluir o cadastro?", "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(M == DialogResult.OK)
            {
                MessageBox.Show("Dados Excluídos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Txt_NomeDespesa.Enabled = true;
            Btn_Editar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Gravar.Enabled = true;
            Btn_Novo.Enabled = false;
            Msk_Valor.Enabled = true;
            Cbo_TipoMovimentacao.Enabled = true;
            Btn_BuscaEstabelecimento.Enabled = true;
            Txt_CodigoEstabelecimento.Enabled = true;
            Ckb_AtivoInativo.Enabled = true;
            Txt_Observacao.Enabled = true;

        }
        private bool ValidaFormulario()
        {
            var temp = "";
            if(Txt_NomeDespesa.Text.Length < 3)
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Txt_NomeDespesa, Color.Red);
                temp += "Verifique a Descrição da Despesa.\r\n";
            }
            if (Txt_NomeDespesa.Text.Length > 50 )
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Txt_NomeDespesa, Color.Red);
                temp += "Verifique a Descrição da Despesa. Tamanho maior que o permitido.\r\n";
            }
            if(Txt_CodigoEstabelecimento.Text == "" || Txt_CodigoEstabelecimento.Text == "0")
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Txt_CodigoEstabelecimento, Color.Red);
                temp += "Verifique o codigo do estabelecimento.\r\n";
            }
            if(Msk_Valor.Text == "")
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Msk_Valor, Color.Red);
                temp += "Verifique o valor da Despesa. Não é possivel inserir despesa zerada.\r\n";
            }else if(double.Parse(Msk_Valor.Text) <= 0)
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Msk_Valor, Color.Red);
                temp += "Verifique o valor da Despesa. Não é possivel inserir despesa zerada.\r\n";
            }
            if(Txt_Observacao.Text.Length> 100)
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Txt_Observacao, Color.Red);
                temp += "Verifique o campo observação. Não é possivel inserir mais de 100 caracteres.\r\n";
            }
            if(temp != "")
            {
                MessageBox.Show(temp, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            return true;
        }

        private void LimparFormulario()
        {
            Txt_Codigo.Text = "";
            Txt_NomeDespesa.Text = "";
            Msk_Valor.Text = "";
            Btn_Editar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Gravar.Enabled = false;
            Btn_Novo.Enabled = true;
            Txt_NomeDespesa.Enabled = false;
            Msk_Valor.Enabled = false;
            Cbo_TipoMovimentacao.Enabled = false;
            Btn_BuscaEstabelecimento.Enabled = false;
            Txt_NomeEstabelecimento.Enabled = false;
            Txt_CodigoEstabelecimento.Enabled = false;
            Ckb_AtivoInativo.Checked = true;
            Ckb_AtivoInativo.Enabled = false;
            Txt_Observacao.Enabled = false;
            Grp_DadosDespesaFixa.AlterarBordaComponente(Txt_NomeDespesa, Grp_DadosDespesaFixa.BackColor);
            Grp_DadosDespesaFixa.AlterarBordaComponente(Msk_Valor, Grp_DadosDespesaFixa.BackColor);
            Grp_DadosDespesaFixa.AlterarBordaComponente(Txt_CodigoEstabelecimento, Grp_DadosDespesaFixa.BackColor);
        }

        private void Grp_DadosDespesaFixa_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                var ValorFixo = new Valores_Fixos();
                ValorFixo.Nome = Txt_NomeDespesa.Text;
                ValorFixo.Valor = double.Parse(Msk_Valor.Text);
                ValorFixo.Ativo = Ckb_AtivoInativo.Checked;
                ValorFixo.CodigoEstabelecimento = int.Parse(Txt_CodigoEstabelecimento.Text);
                ValorFixo.Movimentacao = Cbo_TipoMovimentacao.Text == "Entrada" ? "E" : "S";
                ValorFixo.Observacao = Txt_Observacao.Text;
                var ControleDespesaFixa = new ValoresFixosControle();
                ControleDespesaFixa.validaDespesasFixas(ValorFixo);
                var M = new Frm_Aviso("Dados salvos com sucesso!!", "sucesso");
                M.Show();
                LimparFormulario();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void Txt_NomeDespesa_KeyUp(object sender, KeyEventArgs e)
        {
            if(Txt_NomeDespesa.Text.Length>= 3)
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Txt_NomeDespesa, Color.Green);
            }
            else
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Txt_NomeDespesa, Color.Red);
            }
        }

        private void Msk_Valor_KeyUp(object sender, KeyEventArgs e)
        {
            if (Msk_Valor.Text != "" )
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Msk_Valor, Color.Green);
            }
            else
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Msk_Valor, Color.Red);
            }
        }

        private void ajudaToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela Referente a cadastro de Valores Fixos de Controle Financeiro. Os valores que estiverem ativos serão contabilizados na movimentação financeira do mês corrente.Exemplos: Salário, Aluguel, Supermercado, Luz ...", "Ajuda - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Msk_Valor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_BuscaEstabelecimento_Click(object sender, EventArgs e)
        {
            var F = new Frm_BuscaEstabelecimento();
            F.ShowDialog();
        }
    }
}
