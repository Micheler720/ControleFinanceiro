﻿using System;
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
            Lbl_DataInclusao.Text = "Data Inclusao";
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
            Txt_Documento.Text = "";
            Msk_Valor.Text = "";
            Msk_CodigoEstabelecimento.Enabled = false;
            Msk_CodigoEstabelecimento.Text = "";
            Txt_NomeEstabelecimento.Enabled = false;
            Txt_NomeEstabelecimento.Text = "";
            Btn_BuscaEstabelecimento.Enabled = false;
            Txt_Observacao.Enabled = false;
            Msk_Valor.Enabled = false;
            Dat_DataLancamento.Enabled = false;
            Txt_Documento.Enabled = false;
            Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_Valor, Grp_DadosMovimentacoes.BackColor);
            Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento, Grp_DadosMovimentacoes.BackColor);
            Grp_DadosMovimentacoes.AlterarBordaComponente(Txt_Documento, Grp_DadosMovimentacoes.BackColor);
            Grp_DadosMovimentacoes.AlterarBordaComponente(Dat_DataLancamento, Grp_DadosMovimentacoes.BackColor);

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
            if (temp != "")
            {
                MessageBox.Show(temp, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void ajudaToolStripButton1_Click(object sender, EventArgs e)
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
            Btn_BuscaEstabelecimento.Enabled = true;
            Btn_Gravar.Enabled = true;
            Txt_Observacao.Enabled = true;
            Msk_Valor.Enabled = true;
            Msk_CodigoEstabelecimento.Enabled = true;
            Dat_DataLancamento.Enabled = true;
            Txt_Documento.Enabled = true;
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                var saida = CapturarValor();
                var controleSaida = new FinPagarControle();
                controleSaida.ValidaSaida(saida);
                var M = new Frm_Aviso("Dados Gravados com sucesso!", "sucesso");
                M.ShowDialog();
                LimparFormulario();
            }
        }
        private Fin_Pagar CapturarValor()
        {
            var valor = double.Parse(Msk_Valor.Text);
            var Saida = new Fin_Pagar();
           // Saida.Cod_Estabelecimento = int.Parse(Msk_CodigoEstabelecimento.Text);
            Saida.Observacao = Txt_Observacao.Text;
            Saida.Documento = Txt_Documento.Text;
            Saida.Data_Lancamento = Dat_DataLancamento.Value;
            Saida.Data_Inclusao = DateTime.Now;
            Saida.Valor = valor;
            return Saida;

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
            if (Msk_CodigoEstabelecimento.Text != "")
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento, Color.Green);
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
        }
    }
}
