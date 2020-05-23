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
using ControleFinanceiro.Visao.Avisos;

namespace ControleFinanceiro.Visao.Movimentacoes
{
    public partial class Frm_Entradas : UserControl
    {
        public Frm_Entradas()
        {
            InitializeComponent();
            Lbl_Codigo.Text = "Codigo";
            Lbl_Estabelecimento.Text = "Estabelecimento";
            Lbl_Valor.Text = "Valor";
            Lbl_Observacao.Text = "Observação";
            Grp_DadosMovimentacoes.Text = "Dados Entrada";
            Btn_BuscaEstabelecimento.Text = "...";
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Novo.Text = "Novo";
            Btn_Gravar.Text = "Gravar";
            Btn_BuscaEstabelecimento.Text = "...";
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            Btn_Editar.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Gravar.Enabled = false;
            Btn_Novo.Enabled = true;
            Txt_Codigo.Enabled = false;
            Txt_NomeEstabelecimento.Text = "";
            Txt_Codigo.Text = "";
            Msk_CodigoEstabelecimento.Enabled = false;
            Msk_CodigoEstabelecimento.Text = "";
            Txt_NomeEstabelecimento.Enabled = false;
            Txt_NomeEstabelecimento.Text = "";
            Btn_BuscaEstabelecimento.Enabled = false;
            Txt_Observacao.Enabled = false;
            Msk_Valor.Enabled = false;
            
        }
        private bool ValidaFormulario()
        {
            var temp = "";
            if(Msk_CodigoEstabelecimento.Text == "" || Msk_CodigoEstabelecimento.Text == "0")
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento,Color.Red);
                temp += "Não é possivel inserir Entrada sem informação de Estabelecimento \r\n";
            }
            if(Msk_Valor.Text == "0" || Msk_Valor.Text == "")
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_Valor, Color.Red);
                temp += "Não é possivel inserir Entrada sem informação de valor \r\n";
            }
            if(Txt_Observacao.Text.Length > 100)
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Txt_Observacao, Color.Red);
                temp += "Não é possivel inserir observação com mais de 100 caracteres. Verifique! \r\n";
            }

            if(temp != "")
            {
                MessageBox.Show(temp, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void ajudaToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela Referente a cadastro de Entradas de valores", "Ajuda - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            Btn_Novo.Enabled = false;
            Btn_Gravar.Enabled = true;
            Txt_Observacao.Enabled = true;
            Msk_Valor.Enabled = true;
            Msk_CodigoEstabelecimento.Enabled = true;
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                var codigo = int.Parse(Txt_Codigo.Text);
                var valor = double.Parse(Msk_Valor.Text);
                var Entrada = new EntradasModelo(codigo,valor);
                Entrada.CodEstabelecimento = int.Parse(Msk_CodigoEstabelecimento.Text);
                Entrada.Observacao = Txt_Observacao.Text;
                var M = new Frm_Aviso("Dados Gravados com sucesso!", "sucesso");
                M.ShowDialog();
                LimparFormulario();
            }
        }

        private void Msk_Valor_KeyUp(object sender, KeyEventArgs e)
        {
            if(Msk_Valor.Text != "" || double.Parse(Msk_Valor.Text) > 0)
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento,Color.Green);
            }
            else
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento, Color.Red);
            }
        }
    }
}
