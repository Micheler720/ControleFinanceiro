using ControleFinanceiro.Modelo.Controle;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.Visao.Filtros
{
    public partial class Frm_BuscaLancamento : Form
    {
        
        private int TipoLancamentos { get; set; }
        public int IdLancamento { get; set; }
        private DateTime DataInicial { get; set; }
        private DateTime DataFinal { get; set; }
        /// <summary>
        /// Passar como parâmetro Tipo de lançamento a ser exibido
        /// </summary>
        /// <param name="tipoLancamentos">1 = Entrada/Receber , 2 = Saida/Pagar</param>
        public Frm_BuscaLancamento(int tipoLancamentos)
        {
            InitializeComponent();
            Btn_Buscar.Text = "Buscar";
            Grp_TipoData.Text = "Tipo Data:";
            Rdb_Inclusao.Text = "Inclusão";
            Rdb_Lancamento.Text = "Lançamento";
            Rdb_Lancamento.Checked = true;
            Btn_Abrir.Text = "Abrir";
            Btn_Sair.Text = "Sair";
            Lbl_DataFinal.Text = "Data Final";
            Lbl_DataInicial.Text = "Data Inicial";
            fin_ReceberDataGridView.Columns.Add("Id", "Numero Interno");
            fin_ReceberDataGridView.Columns.Add("Doc_num", "Documento");
            fin_ReceberDataGridView.Columns.Add("Parcela", "Parcela");
            fin_ReceberDataGridView.Columns.Add("Data_Inclusao", "Data Inclusao");
            fin_ReceberDataGridView.Columns.Add("Data_lancamento", "Data Lancamento");
            fin_ReceberDataGridView.Columns.Add("Data_Pagamento", "Data Pagamento");
            fin_ReceberDataGridView.Columns.Add("Estabelecimento", "Estabelecimento");
            fin_ReceberDataGridView.Columns.Add("Valor", "Valor");
            fin_ReceberDataGridView.MultiSelect = false;
            TipoLancamentos = tipoLancamentos;
            buscarLancamentos();
        }
        private  void PreencherDataGrid(List<Fin_Receber> ListaLancamentos)
        {
            fin_ReceberDataGridView.Rows.Clear();
            foreach (var lancamento in ListaLancamentos)
            {
                fin_ReceberDataGridView.Rows.Add(lancamento.Id, lancamento.Documento, lancamento.Parcela,lancamento.Data_Inclusao.ToShortDateString(), lancamento.Data_Lancamento.ToShortDateString(),lancamento.Data_Pagamento.ToShortDateString(), lancamento.Estabelecimento.Nome,lancamento.Valor.ToString("C"));
            }
        }
        private void PreencherDataGrid(List<Fin_Pagar> ListaLancamentos)
        {
            fin_ReceberDataGridView.Rows.Clear();
            foreach (var lancamento in ListaLancamentos)
            {
                fin_ReceberDataGridView.Rows.Add(lancamento.Id, lancamento.Documento, lancamento.Parcela, lancamento.Data_Inclusao.ToShortDateString(), lancamento.Data_Lancamento.ToShortDateString(), lancamento.Data_Pagamento.ToShortDateString(), lancamento.Estabelecimento.Nome, lancamento.Valor.ToString("C"));
            }
        }
        private void buscarLancamentos()
        {
            if(TipoLancamentos == 1)
            {
                var controleReceber = new FinReceberControle();
                var ListaLancamentos = controleReceber.BuscarFinanceiros();
                PreencherDataGrid(ListaLancamentos);
            }
            else
            {
                var controlePagar = new FinPagarControle();
                var ListaLancamentos = controlePagar.BuscarFinanceiros();
                PreencherDataGrid(ListaLancamentos);
            }
        }
        private void fin_ReceberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fin_ReceberBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Btn_Abrir_Click(object sender, EventArgs e)
        {
            AbrirLancamento();

        }
        private void AbrirLancamento()
        {
            if (fin_ReceberDataGridView.SelectedRows.Count > 0)
            {
                DialogResult = DialogResult.OK;
                var lancamento = fin_ReceberDataGridView.SelectedRows[0].Cells[0].Value;
                IdLancamento = Convert.ToInt32(lancamento);
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                MessageBox.Show("Selecione pelo menos um item para prosseguir.", "Aviso - Busca Lançamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fin_ReceberDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AbrirLancamento();
        }
        private bool validaFormulario()
        {
            var mensagem = "";
            DataInicial = Dat_Inicial.Value;
            DataFinal = Dat_Final.Value;
            if(DataInicial > DataFinal)
            {
                mensagem = "Data inicial invalida. Verifique!";
                Grp_TipoData.AlterarBordaComponente(Dat_Inicial, Color.Red);
            }
            if(mensagem != "")
            {
                MessageBox.Show(mensagem, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (validaFormulario())
            {
                if (Rdb_Inclusao.Checked)
                {
                    BuscarDataInclusao();
                }
                if (Rdb_Lancamento.Checked)
                {
                    BuscarDataLancamento();
                }
            }
        }

        private void BuscarDataInclusao()
        {
            if (TipoLancamentos == 1)
            {
                var controle = new FinReceberControle();
                var lancamentos = controle.BuscaPorDataInclusao(DataInicial, DataFinal);
                PreencherDataGrid(lancamentos);
            }
            else
            {
                var controle = new FinPagarControle();
                var lancamentos = controle.BuscaPorDataInclusao(DataInicial, DataFinal);
                PreencherDataGrid(lancamentos);
            }
        }
        private void BuscarDataLancamento()
        {
            if (TipoLancamentos == 1)
            {
                var controle = new FinReceberControle();
                var lancamentos = controle.BuscaPorDataLancamento(DataInicial, DataFinal);
                PreencherDataGrid(lancamentos);
            }
            else
            {
                var controle = new FinPagarControle();
                var lancamentos = controle.BuscaPorDataLancamento(DataInicial, DataFinal);
                PreencherDataGrid(lancamentos);
            }
        }
    }
}
