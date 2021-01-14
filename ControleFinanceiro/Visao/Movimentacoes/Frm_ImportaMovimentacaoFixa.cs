using ControleFinanceiro.Controle;
using ControleFinanceiro.Modelo.Controle;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Util;
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

namespace ControleFinanceiro.Visao.Movimentacoes
{
    public partial class Frm_ImportaMovimentacaoFixa : Form
    {
        private List<Valores_Fixos> Valores;
        private string Menssagem;
        DateTimePicker Dtp = new DateTimePicker();
        Rectangle _Retangle;
        /// <summary>
        /// 0 - Equivale Ambos
        /// 1 - Somente Entrada
        /// 3 - Somente Saídas
        /// </summary>
        public int TipoOperacao = 0;
        public Frm_ImportaMovimentacaoFixa(List<Valores_Fixos> valores, int tipoOperacao = 0)
        {
            InitializeComponent();
            DatView_Lancamentos.Columns.Clear();
            DatView_Lancamentos.Columns.Add("Parcela", "Parcelas");
            DatView_Lancamentos.Columns.Add("Tipo_Movimentacao", "Tipo Lançamento");
            DatView_Lancamentos.Columns.Add("Descricao_Despesa", "Descrição Despesa");
            DatView_Lancamentos.Columns.Add("Documento", "Documento");
            DatView_Lancamentos.Columns.Add("Data_Documento", "Data Documento");
            DatView_Lancamentos.Columns.Add("Data_Pagamento", "Data Pagamento");
            DatView_Lancamentos.Columns.Add("Cod_Estabelecimento", "Cod Estabelecimento");
            DatView_Lancamentos.Columns.Add("Nome_Estabelecimento", "Nome Estabelecimento");
            DatView_Lancamentos.Columns.Add("Valor", "Valor");
            DatView_Lancamentos.Columns.Add("Observacao", "Observação");
            DatView_Lancamentos.Columns[0].ReadOnly = true;
            DatView_Lancamentos.Columns[1].ReadOnly = true;
            DatView_Lancamentos.Columns[6].ReadOnly = true;
            DatView_Lancamentos.Columns[4].ReadOnly = true;
            DatView_Lancamentos.Columns[5].ReadOnly = true;
            DatView_Lancamentos.Controls.Add(Dtp);
            Dtp.Visible = false;
            Dtp.Format = DateTimePickerFormat.Custom;
            Dtp.TextChanged += new EventHandler(Dtp_TextChange);
            Lbl_Mes.Text = "Data Inicial";
            Btn_Importar.Text = "Importar";
            Dat_Mes.CustomFormat =  "MMM yyyy";
            Valores = valores;
            Grp_DadosImportacao.Text = "Dados Importação";
            TipoOperacao = tipoOperacao;
            if(TipoOperacao != 0)
            {
                Lbl_Mes.Visible = false;
                Dat_Mes.Visible = false;
            }
            PreencherDataGridView();
        }
        private List<Fin_Receber> RecuperarDataGridReceber()
        {
            var lancamentos = new List<Fin_Receber>();
            var rows = DatView_Lancamentos.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                if(rows[i].Cells[1].Value.ToString() == "Receita")
                {
                    var codEstabelecimento = Convert.ToInt32(rows[i].Cells[6].Value);
                    var estabelecimento = EstabelecimentoControle.BuscarEstabelecimentoId(codEstabelecimento);
                    var lancamento = new Fin_Receber 
                    {
                        Documento = rows[i].Cells[3].Value.ToString(),
                        Data_Lancamento = Cls_Util.ConvertData(rows[i].Cells[4].Value.ToString()),
                        Data_Pagamento = Cls_Util.ConvertData(rows[i].Cells[5].Value.ToString()),
                        Estabelecimento = estabelecimento,
                        Valor = Convert.ToDouble(rows[i].Cells[8].Value.ToString().Replace("R$", "")),
                        Observacao = rows[i].Cells[9].Value.ToString(),
                        Data_Inclusao = DateTime.Now,
                        Importado = TipoOperacao == 0 ? 1: 0,
                        Parcela = Convert.ToInt32(rows[i].Cells[0].Value),
                        UsLancamento = Frm_ControleFinanceiro.GetusuarioLogado()
                    };
                    lancamentos.Add(lancamento);
                }
            }
            return lancamentos;
        }
        private List<Fin_Pagar> RecuperarDataGridPagar()
        {
            var lancamentos = new List<Fin_Pagar>();
            var rows = DatView_Lancamentos.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Cells[1].Value.ToString() == "Despesa")
                {
                    var codEstabelecimento = Convert.ToInt32(rows[i].Cells[6].Value);
                    var estabelecimento = EstabelecimentoControle.BuscarEstabelecimentoId(codEstabelecimento);
                    var lancamento = new Fin_Pagar
                    {
                        Documento = rows[i].Cells[3].Value.ToString(),
                        Data_Lancamento = Cls_Util.ConvertData(rows[i].Cells[4].Value.ToString()),
                        Data_Pagamento = Cls_Util.ConvertData(rows[i].Cells[5].Value.ToString()),
                        Estabelecimento = estabelecimento,
                        Valor = Convert.ToDouble(rows[i].Cells[8].Value.ToString().Replace("R$", "")),
                        Observacao = rows[i].Cells[9].Value.ToString(),
                        Data_Inclusao = DateTime.Now,
                        Importado = TipoOperacao == 2 ? 1 : 0,
                        Parcela = Convert.ToInt32(rows[i].Cells[0].Value),
                        UsLancamento = Frm_ControleFinanceiro.GetusuarioLogado()
                    };
                    lancamentos.Add(lancamento);
                }
            }
            return lancamentos;
        }

        private void PreencherDataGridView()
        {
            var pDoc = 1;
            DatView_Lancamentos.Rows.Clear();
            foreach (var valor in Valores)
            {
                var tipoMovimentacao = valor.Movimentacao == "S" ? "Despesa" : "Receita";
                var ultimoDiaMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                var diaPagamento = valor.DiaPagamento > ultimoDiaMes ? ultimoDiaMes : valor.DiaPagamento;
                var dataPagamento = new DateTime(DateTime.Now.Year, DateTime.Now.Month, diaPagamento);
                var data = valor.Parcela > 1 ? dataPagamento.AddMonths(valor.Parcela): dataPagamento;
                if(valor.Parcela > 1)
                {
                    for(int i = 1; i <= valor.Parcela; i++)
                    {
                        data = dataPagamento.AddMonths(i);
                        DatView_Lancamentos.Rows.Add(++pDoc, tipoMovimentacao, valor.Nome, "", DateTime.Now.ToShortDateString(), data.ToShortDateString(), valor.Estabelecimento.Id, valor.Estabelecimento.Nome, valor.Valor.ToString("C"), valor.Observacao);
                        
                    }
                    continue;
                }
                DatView_Lancamentos.Rows.Add(valor.Parcela,tipoMovimentacao, valor.Nome, "", DateTime.Now.ToShortDateString(), data.ToShortDateString() , valor.Estabelecimento.Id, valor.Estabelecimento.Nome, valor.Valor.ToString("C"), valor.Observacao);
            }
            AlterarDataGrid();
        }
        private void AlterarDataGrid()
        {
            for (int i = 0; i < DatView_Lancamentos.Rows.Count; i++)
            {
                var valor = DatView_Lancamentos.Rows[i];
                valor.Cells[0].Style.BackColor = Color.LightGray;
                valor.Cells[1].Style.BackColor = Color.LightGray;
                valor.Cells[2].Style.BackColor = Color.LightGray;
                valor.Cells[8].Style.BackColor = Color.LightGray;
                valor.Cells[6].Style.BackColor = Color.LightGray;
                valor.Cells[7].Style.BackColor = Color.LightGray;

            }
        }
        private bool ValidarDataGridView()
        {
            var mensagem = "";
            for (int i = 0; i < DatView_Lancamentos.Rows.Count; i++)
            {
                var valor = DatView_Lancamentos.Rows[i];
                if (String.IsNullOrEmpty(valor.Cells[3].Value.ToString()) || String.IsNullOrEmpty(valor.Cells[4].Value.ToString()) || String.IsNullOrEmpty(valor.Cells[5].Value.ToString()))
                {
                    valor.Cells[3].Style.BackColor = Color.Red;
                    valor.Cells[4].Style.BackColor = Color.Red;
                    valor.Cells[5].Style.BackColor = Color.Red;
                    mensagem += $"Verifique o numero de documento ou data do lançamento: {valor.Cells[1].Value}, para prosseguir com importação. \n";
                }
            }
            if (mensagem != "")
            {
                MessageBox.Show(mensagem, "Validção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Btn_Importar_Click(object sender, EventArgs e)
        {
            if (ValidarDataGridView())
            {
                
                var M = MessageBox.Show("Deseja realmente importar as desepesas fixas para o mês selecionado? Caso exista algum registro o mesmo será atualizado.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (M == DialogResult.OK)
                {
                    Menssagem = "";
                    switch (TipoOperacao)
                    {
                        case 0:
                            ImportarReceber();
                            ImportarPagar();
                            break;
                        case 1:
                            GerarParcelas();
                            break;
                        case 2:
                            ImportarPagar();
                            break;
                    }
                    MessageBox.Show(Menssagem, "Importação - Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void GerarParcelas()
        {
            var LancamentosReceber = RecuperarDataGridReceber();
            var dataFinal = Cls_Util.UltimoDiadoMes(Dat_Mes.Value);
            var dataInicial = Cls_Util.PrimeiroDiadoMes(Dat_Mes.Value);
            var controleReceber = new FinReceberControle();
            controleReceber.GerarParcelas(LancamentosReceber, dataInicial, dataFinal);
            Menssagem += controleReceber.Mensagem;
        }
        private void ImportarReceber()
        {
            var LancamentosReceber = RecuperarDataGridReceber();
            var dataFinal = Cls_Util.UltimoDiadoMes(Dat_Mes.Value);
            var dataInicial = Cls_Util.PrimeiroDiadoMes(Dat_Mes.Value);
            var controleReceber = new FinReceberControle();
            controleReceber.ImportarEntrada(LancamentosReceber, dataInicial, dataFinal);
            Menssagem += controleReceber.Mensagem;
        }
        private void ImportarPagar()
        {
            var LancamentosPagar = RecuperarDataGridPagar();
            var dataFinal = Cls_Util.UltimoDiadoMes(Dat_Mes.Value);
            var dataInicial = Cls_Util.PrimeiroDiadoMes(Dat_Mes.Value);
            var controlePagar = new FinPagarControle();
            controlePagar.ImportarSaida(LancamentosPagar, dataInicial, dataFinal);
            Menssagem += controlePagar.Mensagem;
        }

        private void DatView_Lancamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = DatView_Lancamentos.Rows; 
            switch (DatView_Lancamentos.Columns[e.ColumnIndex].Name)
            {
                case "Data_Documento":
                    _Retangle = DatView_Lancamentos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    Dtp.Size = new Size(_Retangle.Width, _Retangle.Height);
                    Dtp.Location = new Point(_Retangle.X, _Retangle.Y);
                    Dtp.Value = DateTime.Now;
                    Dtp.Visible = true;
                    break;
                case "Data_Pagamento":
                    _Retangle = DatView_Lancamentos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    Dtp.Size = new Size(_Retangle.Width, _Retangle.Height);
                    Dtp.Location = new Point(_Retangle.X, _Retangle.Y);
                    var data = DatView_Lancamentos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Split('/');
                    Dtp.Value = new DateTime(Convert.ToInt32(data[2]), Convert.ToInt32(data[1]), Convert.ToInt32(data[0]));
                    Dtp.Visible = true;
                    break;
            }
        }
        private void Dtp_TextChange(object sender,EventArgs e)
        {
            DatView_Lancamentos.CurrentCell.Value = Dtp.Text.ToString();
        }

        private void DatView_Lancamentos_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Dtp.Visible = false;
        }

        private void DatView_Lancamentos_Scroll(object sender, ScrollEventArgs e)
        {
            Dtp.Visible = false;
        }
    }
}
