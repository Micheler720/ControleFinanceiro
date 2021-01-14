using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using ControleFinanceiro.Util;
using ControleFinanceiro.Modelo.Controle;
using ControleFinanceiro.Modelo.Entidades;

namespace ControleFinanceiro.Visao.Movimentacoes
{
    public partial class Frm_Saldo : UserControl
    {
        private DateTime DataInicial { get; set; }
        private DateTime DataFinal { get; set; }
        public Frm_Saldo()
        {
            InitializeComponent();
            Lbl_Receitas.Text = "Receitas";
            Lbl_Despesas.Text = "Despesas";
            Lbl_DtFinal.Text = "Data Final";
            Lbl_DtInicial.Text = "Data Inicial";
            Btn_Buscar.Text = "Buscar";            
            Grp_FiltroRelatorio.Text = "Filtro";
            criarDatView();
            Grp_MovimentacoesFinanceiras.Text = "Movimentações Financeiras";
            Grp_Totalizador.Text = "Totalizador";
            Btn_ImportarFixos.Text = "Importar";
            Grp_MovimentacoesFinanceiras.Visible = false;
        }
        private void criarDatView()
        {
            DatView_Receber.Columns.Add("Id", "Numero Interno");
            DatView_Receber.Columns.Add("Documento", "Doc");
            DatView_Receber.Columns.Add("Parcela", "Parc");
            DatView_Receber.Columns.Add("Data_Lancamento", "Data Pagamento");
            DatView_Receber.Columns.Add("Estabelecimento", "Estabelecimento");
            DatView_Receber.Columns.Add("Valor", "Valor");
            DatView_Pagar.Columns.Add("Id", "Numero Interno");
            DatView_Pagar.Columns.Add("Documento", "Doc");
            DatView_Pagar.Columns.Add("Parcela", "Parc");
            DatView_Pagar.Columns.Add("Data_Lancamento", "Data Pagamento");
            DatView_Pagar.Columns.Add("Estabelecimento", "Estabelecimento");
            DatView_Pagar.Columns.Add("Valor", "Valor");
            DatView_Pagar.Columns["Parcela"].Width = 40;
            DatView_Pagar.Columns["Id"].Width = 70;
            DatView_Pagar.Columns["Valor"].Width = 80;
            DatView_Pagar.Columns["Documento"].Width = 70;
            DatView_Pagar.Columns["Estabelecimento"].Width = 150;
            DatView_Receber.Columns["Parcela"].Width = 40;
            DatView_Receber.Columns["Id"].Width = 70;
            DatView_Receber.Columns["Documento"].Width = 70;
            DatView_Receber.Columns["Valor"].Width = 80;
            DatView_Receber.Columns["Estabelecimento"].Width = 150;
        }

        private bool ValidaFormulario()
        {
            var temp = "";
            DataInicial = Dat_Inicial.Value.Date;
            DataFinal = Dat_Final.Value.Date;
            if (DataInicial > DataFinal)
            {
                Grp_FiltroRelatorio.AlterarBordaComponente(Dat_Inicial, Color.Red);
                temp += "Verifique as Datas. Impossivel que data inicial seja maior que data final.\r \n";
            }
            else
            {
                Grp_FiltroRelatorio.AlterarBordaComponente(Dat_Inicial, Color.Green);
            }
            if(temp != "")
            {
                MessageBox.Show(temp, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                this.Cursor = Cursors.WaitCursor;
                Grp_MovimentacoesFinanceiras.Visible = true;
                var controleEntrada = new FinReceberControle();
                var lancamentosEntradas = controleEntrada.BuscaPorDataLancamento(DataInicial, DataFinal);
                var totalEntrada = PreencherDataGrid(lancamentosEntradas);
                var controlePagar = new FinPagarControle();
                var lancamentosPagar = controlePagar.BuscaPorDataLancamento(DataInicial, DataFinal);
                var totalSaidas = PreencherDataGrid(lancamentosPagar);
                Lbl_Saldo.Text = $"O Saldo da conta é: {(totalEntrada - totalSaidas).ToString("C")}";
                this.Cursor = Cursors.Default;
            }
        }

        private double PreencherDataGrid(List<Fin_Receber> lancamentos)
        {
            double total = 0;
            DatView_Receber.Rows.Clear();
            foreach (var lancamento in lancamentos)
            {
                DatView_Receber.Rows.Add(lancamento.Id, lancamento.Documento, lancamento.Parcela, lancamento.Data_Pagamento.ToShortDateString(), lancamento.Estabelecimento.Nome, lancamento.Valor.ToString("C"));
                total += lancamento.Valor;
            }
            Lbl_TotalReceita.Text = $"Total de Receita: {total.ToString("C")}";
            return total;
        }
        private double PreencherDataGrid(List<Fin_Pagar> lancamentos)
        {
            double total = 0;
            DatView_Pagar.Rows.Clear();
            foreach (var lancamento in lancamentos)
            {
                DatView_Pagar.Rows.Add(lancamento.Id,lancamento.Documento, lancamento.Parcela,lancamento.Data_Pagamento.ToShortDateString(), lancamento.Estabelecimento.Nome, lancamento.Valor.ToString("C"));
                total += lancamento.Valor;
            }
            Lbl_TotalDespesas.Text =  $"Total de Despesas: {total.ToString("C")}";
            return total;
        }

        private void Btn_ImportarFixos_Click(object sender, EventArgs e)
        {
            var controle = new ValoresFixosControle();
            var valores = controle.BuscarValoresFixosAtivos();
            var F = new Frm_ImportaMovimentacaoFixa(valores);
            F.ShowDialog();
        }

        private void Frm_Saldo_Load(object sender, EventArgs e)
        {

        }
    }
}
