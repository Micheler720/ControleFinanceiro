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
using ControleFinanceiro.Modelo.Helpers;
using ControleFinanceiro.Modelo.DAO;
using Org.BouncyCastle.Crypto.Tls;
using ControleFinanceiro.Controle;

namespace ControleFinanceiro.Visao.Cadastros
{
    public partial class Frm_ValoresFixosCadastro : UserControl
    {
        private string Operacao;
        public Frm_ValoresFixosCadastro()
        {
            InitializeComponent();
            Lbl_Codigo.Text = "Codigo";
            Lbl_NomeDespesa.Text = "Descrição";
            Lbl_Valor.Text = "Valor";
            Lbl_Observacao.Text = "Observação";
            Lbl_TipoMovimentacao.Text = "Tipo Movimentação";
            Lbl_Estabelecimento.Text = "Estabelecimento";
            Lbl_DataPagamento.Text = "Dia Pag.";
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
            Btn_Novo.Enabled = true;
            Btn_Gravar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Editar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Cbo_DiaPagamento.Enabled = false;
            Btn_Cancelar.Text = "Cancelar";
            Msk_Valor.Mask = "000.00";
            for(int i =1; i<=31; i++)
            {
                Cbo_DiaPagamento.Items.Add(i);
            }
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            var M = MessageBox.Show("Deseja realmente excluir o cadastro?", "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(M == DialogResult.OK)
            {
                var controleValoresFixos = new ValoresFixosControle();
                var valorFixo = CapturarFormulario();
                valorFixo.Id = int.Parse(Txt_Codigo.Text);
                controleValoresFixos.ExcluirDespesaFixas(valorFixo);
                MessageBox.Show(controleValoresFixos.Mensagem, "Exclusão - Valor Fixo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btn_Cancelar.Enabled = false;
                Btn_Editar.Enabled = false;
                Btn_Excluir.Enabled = false;
                Btn_Gravar.Enabled = false;
                Btn_Novo.Enabled = true;
                LimparFormulario();
                HabilitarDesabilitarCampos(false);
            }
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Operacao = "Novo";
            Btn_Editar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Gravar.Enabled = true;
            Btn_Novo.Enabled = false;
            Btn_Cancelar.Enabled = true;
            HabilitarDesabilitarCampos(true);

        }
        private void HabilitarDesabilitarCampos(bool valor)
        {
            Txt_NomeDespesa.Enabled = valor;
            Msk_Valor.Enabled = valor;
            Cbo_TipoMovimentacao.Enabled = valor;
            Btn_BuscaEstabelecimento.Enabled = valor;
            Txt_CodigoEstabelecimento.Enabled = valor;
            Ckb_AtivoInativo.Enabled = valor;
            Txt_Observacao.Enabled = valor;
            Cbo_DiaPagamento.Enabled = valor;
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
            if (Txt_Observacao.Text.Length> 100)
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
            Txt_CodigoEstabelecimento.Text = "";
            Txt_NomeEstabelecimento.Text = "";
            Txt_Observacao.Text = "";
            Txt_NomeDespesa.Enabled = false;
            Msk_Valor.Enabled = false;
            Cbo_TipoMovimentacao.Enabled = false;
            Btn_BuscaEstabelecimento.Enabled = false;
            Txt_NomeEstabelecimento.Enabled = false;
            Txt_CodigoEstabelecimento.Enabled = false;
            Ckb_AtivoInativo.Checked = true;
            Ckb_AtivoInativo.Enabled = false;
            Txt_Observacao.Enabled = false;
            Cbo_DiaPagamento.Enabled = false;
            Cbo_DiaPagamento.SelectedItem = 0;
            Cbo_DiaPagamento.Text = "";
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
                var ValorFixo = CapturarFormulario();
                var ControleDespesaFixa = new ValoresFixosControle();
                if (Operacao == "Novo")
                {
                    ControleDespesaFixa.GravarDespesasFixas(ValorFixo);
                }
                else
                {
                    ValorFixo.Id = int.Parse(Txt_Codigo.Text);
                    ControleDespesaFixa.AlterarDespesasFixas(ValorFixo);
                }
                var M = new Frm_Aviso(ControleDespesaFixa.Mensagem, "sucesso");
                M.Show();
                LimparFormulario();
                Btn_Cancelar.Enabled = false;
                Btn_Editar.Enabled = false;
                Btn_Excluir.Enabled = false;
                Btn_Gravar.Enabled = false;
                Btn_Novo.Enabled = true;
            }
        }
        private Valores_Fixos CapturarFormulario()
        {
            var idEstabelecimento = int.Parse(Txt_CodigoEstabelecimento.Text);
            var estabelecimento = EstabelecimentoControle.BuscarEstabelecimentoId(idEstabelecimento);
            var ValorFixo = new Valores_Fixos();
            ValorFixo.Nome = Txt_NomeDespesa.Text;
            ValorFixo.Valor = double.Parse(Msk_Valor.Text);
            ValorFixo.Ativo = Ckb_AtivoInativo.Checked;
            ValorFixo.DiaPagamento = Convert.ToInt32(Cbo_DiaPagamento.Text);
            ValorFixo.Movimentacao = Cbo_TipoMovimentacao.Text == "Entrada" ? "E" : "S";
            ValorFixo.Observacao = Txt_Observacao.Text;
            ValorFixo.Estabelecimento = estabelecimento;
            ValorFixo.UsValoresFixos = Frm_ControleFinanceiro.GetusuarioLogado();
            return ValorFixo;
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
            var contEstabelecimento = new EstabelecimentoControle();
            var estabelecimentos = contEstabelecimento.BuscarEstabelecimento();
            var F = new Frm_BuscaEstabelecimento(estabelecimentos);
            var M = F.ShowDialog();
            if(M == DialogResult.OK)
            {
                Txt_CodigoEstabelecimento.Text = F.IdSelect.ToString();
                Txt_NomeEstabelecimento.Text = F.NomeEstabelecimento;
            }
        }

        private void Txt_CodigoEstabelecimento_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                var id = int.Parse(Txt_CodigoEstabelecimento.Text);
                var estabelecimento = EstabelecimentoControle.BuscarEstabelecimentoId(id);
                if(estabelecimento != null)
                {
                    Txt_NomeEstabelecimento.Text = estabelecimento.Nome;
                    Txt_CodigoEstabelecimento.Text = estabelecimento.Id.ToString();
                }
                else
                {
                    MessageBox.Show("Não foi encontrado Estabelecimento para código informado. Verifique!", "Cadastro - Valores Fixos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            var M = MessageBox.Show("Deseja realmente cancelar a inclusão do lançamento?", "Cadastro - Valores Fixos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(M == DialogResult.OK)
            {
                LimparFormulario();
                HabilitarDesabilitarCampos(false);
                Btn_Cancelar.Enabled = false;
                Btn_Editar.Enabled = false;
                Btn_Excluir.Enabled = false;
                Btn_Gravar.Enabled = false;
                Btn_Novo.Enabled = true;
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Operacao = "Editar";
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Gravar.Enabled = true;
            Btn_Novo.Enabled = false;
            HabilitarDesabilitarCampos(true);
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            var controleValoresFixos = new ValoresFixosControle();
            var valoresFixos = controleValoresFixos.BuscarDespesasFixas();
            var F = new Frm_Busca(valoresFixos, "Valores Fixos");
            var M = F.ShowDialog();
            if(M == DialogResult.OK)
            {
                var idValorFixo = int.Parse(F.IdSelect);
                var valorFixo = controleValoresFixos.BuscarDespesasFixasId(idValorFixo);
                PreencherFormulario(valorFixo);
                Btn_Cancelar.Enabled = false;
                Btn_Editar.Enabled = true;
                Btn_Excluir.Enabled = true;
                Btn_Gravar.Enabled = false;
                Btn_Novo.Enabled = true;
            }

        }
        private void PreencherFormulario (Valores_Fixos valor)
        {
            Txt_Codigo.Text = valor.Id.ToString();
            Txt_CodigoEstabelecimento.Text = valor.Estabelecimento.Id.ToString();
            Txt_NomeDespesa.Text = valor.Nome;
            Txt_NomeEstabelecimento.Text = valor.Estabelecimento.Nome;
            Txt_Observacao.Text = valor.Observacao;
            Msk_Valor.Text = valor.Valor.ToString();
            Cbo_TipoMovimentacao.SelectedIndex = valor.Movimentacao == "E" ? 0 : 1;
            Cbo_DiaPagamento.SelectedItem = valor.DiaPagamento;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
