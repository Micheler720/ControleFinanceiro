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
using ControleFinanceiro.Modelo.Modelo;
using ControleFinanceiro.Visao.Avisos;
using ControleFinanceiro.Visao.Filtros;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Controle;
using ControleFinanceiro.Controle;

namespace ControleFinanceiro.Visao.Movimentacoes
{
    public partial class Frm_Entradas : UserControl
    {
        private Fin_Receber Lancamento { get; set; }
        private string Operacao { get; set; }
        public Frm_Entradas()
        {
            InitializeComponent();
            Lbl_Codigo.Text = "Codigo";
            Lbl_Estabelecimento.Text = "Estabelecimento *";
            Lbl_Valor.Text = "Valor *";
            Lbl_Observacao.Text = "Observação";
            Lbl_Data.Text = "Data *";
            Lbl_Documento.Text = "Numero Doc. *";
            Lbl_Titulo.Text = "Lançamentos de Entradas";
            Lbl_Legenda.Text = "Campos com * são obrigátorios";
            Grp_DadosMovimentacoes.Text = "Dados Entrada";
            Btn_BuscaEstabelecimento.Text = "...";
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Novo.Text = "Novo";
            Btn_Gravar.Text = "Gravar";
            Btn_BuscaEstabelecimento.Text = "...";
            Lbl_DataInclusao.Text = "Data Inclusão";
            Dat_Inclusão.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_Cancelar.Text = "Cancelar";
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
            Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_Valor,Grp_DadosMovimentacoes.BackColor);
            Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_CodigoEstabelecimento,Grp_DadosMovimentacoes.BackColor);
            Grp_DadosMovimentacoes.AlterarBordaComponente(Txt_Documento,Grp_DadosMovimentacoes.BackColor);
            Grp_DadosMovimentacoes.AlterarBordaComponente(Dat_DataLancamento,Grp_DadosMovimentacoes.BackColor);

        }
        private void HabilitarDesabilitarComponentes(bool valor)
        {

            Msk_CodigoEstabelecimento.Enabled = valor;
            Txt_NomeEstabelecimento.Enabled = valor;
            Btn_BuscaEstabelecimento.Enabled = valor;
            Txt_Observacao.Enabled = valor;
            Msk_Valor.Enabled = valor;
            Dat_DataLancamento.Enabled = valor;
            Txt_Documento.Enabled = valor;
        }
        private bool ValidaFormulario()
        {
            var temp = "";
            if(Msk_CodigoEstabelecimento.Text == "" )
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
            if (Txt_Documento.Text.Length == 0 )
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
            Operacao = "Novo";
            LimparFormulario();
            Btn_Novo.Enabled = false;
            Btn_Gravar.Enabled = true;
            Btn_BuscaEstabelecimento.Enabled = true;
            Btn_Cancelar.Enabled = true;
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
                var Entrada = CapturarFormulario();
                var controleEntrada = new FinReceberControle();
                if (Operacao == "Novo")
                {
                    controleEntrada.GravarEntrada(Entrada);
                }
                else
                {
                    Entrada.Id = Convert.ToInt32(Txt_Codigo.Text);
                    controleEntrada.AlterarEntrada(Entrada);
                }                                
                var M = new Frm_Aviso(controleEntrada.Mensagem, "sucesso");
                M.ShowDialog();
                LimparFormulario();
                HabilitarDesabilitarComponentes(false);
            }
        }
        private Fin_Receber CapturarFormulario()
        {
            var valor = double.Parse(Msk_Valor.Text);
            var Entrada = new Fin_Receber();
            var idEstabelecimento = Convert.ToInt32(Msk_CodigoEstabelecimento.Text);
            var estabelecimento = EstabelecimentoControle.BuscarEstabelecimentoId(idEstabelecimento);
            Entrada.Valor = valor;
            Entrada.Data_Lancamento = Dat_DataLancamento.Value;
            Entrada.Data_Inclusao = DateTime.Now;
            Entrada.Observacao = Txt_Observacao.Text;
            Entrada.Documento = Txt_Documento.Text;
            Entrada.Estabelecimento = estabelecimento;
            return Entrada;
        }

        private void Msk_Valor_KeyUp(object sender, KeyEventArgs e)
        {
            if(Msk_Valor.Text != "" )
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_Valor,Color.Green);
            }
            else
            {
                Grp_DadosMovimentacoes.AlterarBordaComponente(Msk_Valor, Color.Red);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
            if(Txt_Documento.Text.Length == 0)
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
            var controleEstabelecimento = new EstabelecimentoControle();
            var estabelecimentos = controleEstabelecimento.BuscarEstabelecimento();
            var F = new Frm_BuscaEstabelecimento(estabelecimentos);
            F.ShowDialog();
            Txt_NomeEstabelecimento.Text =  F.NomeEstabelecimento;
            Msk_CodigoEstabelecimento.Text = F.IdSelect.ToString();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            var F = new Frm_BuscaLancamento(1);
            F.ShowDialog();
            if (F.DialogResult == DialogResult.OK) {
                var IdLancamento = F.IdLancamento;
                var controleFinanceiro = new FinReceberControle();
                Lancamento = controleFinanceiro.BuscarFinanceiroId(IdLancamento);
                PreencherFormulario();
                Btn_Novo.Enabled = true;
                Btn_Gravar.Enabled = false;
                Btn_Excluir.Enabled = true;
                Btn_Editar.Enabled = true;
                Btn_Cancelar.Enabled = false;
                HabilitarDesabilitarComponentes(false);
            }
        }
        private void PreencherFormulario()
        {
            if(Lancamento != null)
            {
                Txt_Codigo.Text = Lancamento.Id.ToString();
                Txt_Documento.Text = Lancamento.Documento;
                Txt_NomeEstabelecimento.Text = Lancamento.Estabelecimento.Nome;
                Txt_Observacao.Text = Lancamento.Observacao;
                Dat_DataLancamento.Value = Lancamento.Data_Lancamento;
                Dat_Inclusão.Value = Lancamento.Data_Inclusao;
                Msk_Valor.Text = Lancamento.Valor.ToString();
                Msk_CodigoEstabelecimento.Text = Lancamento.Estabelecimento.Id.ToString();
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
            HabilitarDesabilitarComponentes(true);
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            var M = MessageBox.Show("Deseja realmente excluir o lançamento?", "Questao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(M == DialogResult.OK)
            {
                var Entrada = CapturarFormulario();
                Entrada.Id = Convert.ToInt32(Txt_Codigo.Text);
                var controleFinanceiro = new FinReceberControle();
                controleFinanceiro.ExcluirEntrada(Entrada);
                MessageBox.Show(controleFinanceiro.Mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparFormulario();
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            var M = MessageBox.Show("Deseja realmente cancelar o lancamento?", "Questão",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(M == DialogResult.OK)
            {
                LimparFormulario();
                HabilitarDesabilitarComponentes(false);
            }
        }
    }
}
