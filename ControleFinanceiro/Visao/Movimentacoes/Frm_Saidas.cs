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
using ControleFinanceiro.Visao.Avisos;
using ControleFinanceiro.Modelo.Modelo;
using ControleFinanceiro.Visao.Filtros;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Controle;
using ControleFinanceiro.Controle;

namespace ControleFinanceiro.Visao.Movimentacoes
{
    public partial class Frm_Saidas : UserControl
    {
        private Fin_Pagar Lancamento { get; set; }
        private string Operacao { get; set; }

        public Frm_Saidas()
        {
            InitializeComponent();
            Lbl_Codigo.Text = "Codigo";
            Lbl_Estabelecimento.Text = "Estabelecimento *";
            Lbl_Valor.Text = "Valor *";
            Lbl_Observacao.Text = "Observação";
            Lbl_Data.Text = "Data *";
            Lbl_Documento.Text = "Numero Doc. *";
            Lbl_Titulo.Text = "Lançamentos de Saídas";
            Lbl_Legenda.Text = "Campos com * são obrigátorios";
            Grp_DadosMovimentacoes.Text = "Dados Entrada";
            Btn_BuscaEstabelecimento.Text = "...";
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Novo.Text = "Novo";
            Btn_Gravar.Text = "Gravar";
            Dat_Inclusao.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Lbl_DataInclusao.Text = "Data Inclusao";
            Lbl_DataPagamento.Text = "Data Pagamento";
            Btn_Cancelar.Text = "Cancelar";
            Btn_Similar.Text = "Similar";
            Btn_BuscaEstabelecimento.Text = "...";
            Grp_Similar.Visible = false;
            Rdb_Unico.Text = "Uníco";
            Rdb_Varios.Text = "Várias Parcelas";
            Msk_Parcelas.Enabled = false;
            Lbl_Parcelas.Text = "Nº Parcelas";
            Grp_Similar.Text = "Similar Lançamento";
            Lbl_Parcela.Text = "Parcela";
            Txt_Parcela.Enabled = false;
            Btn_Gerar.Text = "Gerar";
            Btn_CancelarSimilar.Text = "Cancelar";
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            Btn_Editar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Gravar.Enabled = false;
            Btn_Novo.Enabled = true;
            Btn_Cancelar.Enabled = false;
            Txt_Codigo.Enabled = false;
            Txt_NomeEstabelecimento.Text = "";
            Txt_Codigo.Text = "";
            Txt_Documento.Text = "";
            Msk_Valor.Text = "";
            Txt_Observacao.Text = "";
            Msk_CodigoEstabelecimento.Enabled = false;
            Msk_CodigoEstabelecimento.Text = "";
            Txt_NomeEstabelecimento.Enabled = false;
            Txt_NomeEstabelecimento.Text = "";
            Btn_BuscaEstabelecimento.Enabled = false;
            Txt_Observacao.Enabled = false;
            Msk_Valor.Enabled = false;
            Dat_DataLancamento.Enabled = false;
            Dat_Pagamento.Enabled = false;
            Txt_Documento.Enabled = false;
            Btn_Similar.Enabled = false;
            Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_Valor, Grp_DadosMovimentacoes.BackColor);
            Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento, Grp_DadosMovimentacoes.BackColor);
            Grp_DadosMovimentacoes.AlterarBordaComponente(Txt_Documento, Grp_DadosMovimentacoes.BackColor);
            Grp_DadosMovimentacoes.AlterarBordaComponente(Dat_DataLancamento, Grp_DadosMovimentacoes.BackColor);

        }
        private void HabilitarDesabilitarComponentes (bool valor)
        {

            Msk_CodigoEstabelecimento.Enabled = valor;
            Txt_NomeEstabelecimento.Enabled = false;
            Btn_BuscaEstabelecimento.Enabled = valor;
            Txt_Observacao.Enabled = valor;
            Msk_Valor.Enabled = valor;
            Dat_DataLancamento.Enabled = valor;
            Txt_Documento.Enabled = valor;
            Dat_Pagamento.Enabled = valor;
        }
        private bool ValidaFormulario()
        {
            var temp = "";
            if (Msk_CodigoEstabelecimento.Text == "")
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento, Color.Red);
                temp += "Não é possivel inserir Entrada sem informação de Estabelecimento \r\n";
            }
            if (Msk_Valor.Text == "0" || Msk_Valor.Text == "")
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_Valor, Color.Red);
                temp += "Não é possivel inserir Entrada sem informação de valor \r\n";
            }
            if (Txt_Observacao.Text.Length > 100)
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Txt_Observacao, Color.Red);
                temp += "Não é possivel inserir observação com mais de 100 caracteres. Verifique! \r\n";
            }
            if (Txt_Documento.Text.Length == 0)
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Txt_Documento, Color.Red);
                temp += "Verifique o numero do documento. \r\n";
            }
            if(Dat_Pagamento.Value < Dat_DataLancamento.Value)
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Dat_Pagamento, Color.Red);
                temp += "Verifique a data de pagamento. Não é possível que seja menor que a data do lançamento . \r\n";
            }
            if (temp != "")
            {
                MessageBox.Show(temp, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void ajudaToolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela Referente a cadastro de Pagamentos de titulos", "Ajuda - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Operacao = "Novo";
            LimparFormulario();
            Btn_Novo.Enabled = false;
            Btn_Editar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Similar.Enabled = false;
            Btn_Gravar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            HabilitarDesabilitarComponentes(true);
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                var saida = CapturarFormulario();
                var controleSaida = new FinPagarControle();
                if(Operacao == "Novo")
                {
                    controleSaida.GravarSaida(saida);
                }
                else
                {
                    saida.Id = Convert.ToInt32(Txt_Codigo.Text);
                    controleSaida.AlterarSaida(saida);
                }
                var M = new Frm_Aviso(controleSaida.Mensagem, "sucesso");
                M.ShowDialog();
                LimparFormulario();
            }
        }
        private Fin_Pagar CapturarFormulario()
        {
            var idEstabelecimento = Convert.ToInt32(Msk_CodigoEstabelecimento.Text);
            var estabelecimento = EstabelecimentoControle.BuscarEstabelecimentoId(idEstabelecimento);
            var valor = double.Parse(Msk_Valor.Text);
            var Saida = new Fin_Pagar();
            Saida.Observacao = Txt_Observacao.Text;
            Saida.Documento = Txt_Documento.Text;
            Saida.Data_Lancamento = Dat_DataLancamento.Value;
            Saida.Data_Inclusao = DateTime.Now;
            Saida.Valor = valor;
            Saida.Data_Pagamento = Dat_Pagamento.Value;
            Saida.Observacao = Txt_Observacao.Text;
            Saida.Estabelecimento = estabelecimento;
            Saida.UsLancamento = Frm_ControleFinanceiro.GetusuarioLogado();
            return Saida;

        }
        private void PreencherFormulario()
        {
            if(Lancamento != null)
            {
                Txt_Parcela.Text = Lancamento.Parcela.ToString();
                Txt_Codigo.Text = Lancamento.Id.ToString();
                Txt_Documento.Text = Lancamento.Documento;
                Txt_NomeEstabelecimento.Text = Lancamento.Estabelecimento.Nome;
                Txt_Observacao.Text = Lancamento.Observacao;
                Msk_CodigoEstabelecimento.Text = Lancamento.Estabelecimento.Id.ToString();
                Msk_Valor.Text = Lancamento.Valor.ToString("F");
                Dat_DataLancamento.Value = Lancamento.Data_Lancamento;
                Dat_Inclusao.Value = Lancamento.Data_Inclusao;
                Dat_Pagamento.Value = Lancamento.Data_Pagamento;
            }
        }

        private void Msk_Valor_KeyUp(object sender, KeyEventArgs e)
        {
            if (Msk_Valor.Text != "")
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_Valor, Color.Green);
            }
            else
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_Valor, Color.Red);
            }
        }

        private void Msk_CodigoEstabelecimento_KeyUp(object sender, KeyEventArgs e)
        {
            if (Msk_CodigoEstabelecimento.Text != "" && e.KeyValue == 13)
            {
                var idEstabelecimento = Convert.ToInt32(Msk_CodigoEstabelecimento.Text);
                var estabelecimento = EstabelecimentoControle.BuscarEstabelecimentoId(idEstabelecimento);
                if (estabelecimento != null)
                {
                    Txt_NomeEstabelecimento.Text = estabelecimento.Nome;
                    Msk_CodigoEstabelecimento.Text = estabelecimento.Id.ToString();
                    Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento, Color.Green);
                }
                else
                {
                    Txt_NomeEstabelecimento.Text = "";
                    Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento, Color.Red);
                    MessageBox.Show("Não existe estabelecimento para o codigo informado.Verifique!","Aviso - Estabelecimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento, Color.Red);
            }
        }

        private void Txt_Documento_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Documento.Text.Length == 0)
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Txt_Documento, Color.Red);
            }
            else
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Txt_Documento, Color.Green);
            }
        }

        private void Btn_BuscaEstabelecimento_Click(object sender, EventArgs e)
        {
            var contEstabelecimento = new EstabelecimentoControle();
            var estabelecimentos = contEstabelecimento.BuscarEstabelecimento();
            var F = new Frm_BuscaEstabelecimento(estabelecimentos);
            F.ShowDialog();
            if(F.DialogResult == DialogResult.OK)
            {
                Txt_NomeEstabelecimento.Text = F.NomeEstabelecimento;
                Msk_CodigoEstabelecimento.Text = F.IdSelect.ToString();
            }
        }

        private void abrirToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var F = new Frm_BuscaLancamento(2);
            F.ShowDialog();
            if(F.DialogResult == DialogResult.OK)
            {
                var controlePagar = new FinPagarControle();
                Lancamento = controlePagar.BuscarFinanceiroId(F.IdLancamento);
                PreencherFormulario();
                Btn_Editar.Enabled = true;
                Btn_Excluir.Enabled = true;
                Btn_Gravar.Enabled = false;
                Btn_Novo.Enabled = true;
                Btn_Cancelar.Enabled = false;
                Btn_Similar.Enabled = true;
                HabilitarDesabilitarComponentes(false);
            }
            this.Cursor = Cursors.Default;
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Operacao = "Editar";
            Btn_Cancelar.Enabled = true;
            Btn_Editar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Gravar.Enabled = true;
            Btn_Novo.Enabled = false;
            HabilitarDesabilitarComponentes(true);
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            var M =MessageBox.Show("Deseja realmente cancelar o lançamento?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(M == DialogResult.OK)
            {
                LimparFormulario();
                Btn_Cancelar.Enabled = false;
                Btn_Editar.Enabled = false;
                Btn_Excluir.Enabled = false;
                Btn_Gravar.Enabled = false;
                Btn_Novo.Enabled = true;
            }
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            var M = MessageBox.Show("Deseja realmente excluir o lançamento?","Aviso",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(M == DialogResult.OK)
            {
                var saida = CapturarFormulario();
                var controleSaida = new FinPagarControle();
                saida.Id = Convert.ToInt32(Txt_Codigo.Text);
                controleSaida.ExcluirSaida(saida);
                if (controleSaida.Sucesso)
                {
                    LimparFormulario();
                    Btn_Cancelar.Enabled = false;
                    Btn_Editar.Enabled = false;
                    Btn_Excluir.Enabled = false;
                    Btn_Gravar.Enabled = false;
                    Btn_Novo.Enabled = true;
                }
                MessageBox.Show(controleSaida.Mensagem, "Movimentação Saídas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Similar_Click(object sender, EventArgs e)
        {
            Grp_Similar.Visible = true;
        }

        private void Btn_CancelarSimilar_Click(object sender, EventArgs e)
        {
            Grp_Similar.Visible = false;
        }

        private void Btn_Gerar_Click(object sender, EventArgs e)
        {
            Operacao = "Novo";
            var lancamento = CapturarFormulario();
            var lancamentoSemelhante = new Valores_Fixos
            {
                Valor = lancamento.Valor,
                Movimentacao = "S",
                Estabelecimento = lancamento.Estabelecimento,
                Observacao = lancamento.Observacao,
                DiaPagamento = lancamento.Data_Pagamento.Day,
                Nome = "Similar lancamento"
            };
            if (Rdb_Unico.Checked)
            {
                var lancamentos = new List<Valores_Fixos>();
                lancamentos.Add(lancamentoSemelhante);
                SimilarUnico(lancamentos);
            }
            else
            {
                SimilarVarios(lancamentoSemelhante);
            }
        }
        private void SimilarVarios(Valores_Fixos lancamento)
        {
            var Lancamentos = new List<Valores_Fixos>();
            var QuantParcelas = Convert.ToInt32(Msk_Parcelas.Text);
            lancamento.Parcela = QuantParcelas;
            Lancamentos.Add(lancamento);
            var F = new Frm_ImportaMovimentacaoFixa(Lancamentos, 1);
            F.TipoOperacao = 2;
            F.ShowDialog();
            Grp_Similar.Visible = false;
        }
        private void SimilarUnico(List<Valores_Fixos> lancamentos)
        {
            var M = MessageBox.Show("Será incluído um lancamento de entrada. Deseja alterar alguma informação?", "Similar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (M == DialogResult.Yes)
            {
                var F = new Frm_ImportaMovimentacaoFixa(lancamentos);
                F.ShowDialog();
            }
            else
            {
                var Saida = CapturarFormulario();
                var controleEntrada = new FinPagarControle();
                if (Operacao == "Novo")
                {
                    controleEntrada.GravarSaida(Saida);
                }
                MessageBox.Show(controleEntrada.Mensagem, "Aviso Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Grp_Similar.Visible = false;
        }

        private void Rdb_Varios_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Varios.Checked)
            {
                Msk_Parcelas.Enabled = true;
            }
        }

        private void Rdb_Unico_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Unico.Checked)
            {
                Msk_Parcelas.Enabled = false;
            }
        }
    }
}
