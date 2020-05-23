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

namespace ControleFinanceiro.Visao.Cadastros
{
    public partial class Frm_DespesaFixasCadastro : UserControl
    {
        public Frm_DespesaFixasCadastro()
        {
            InitializeComponent();
            Lbl_Codigo.Text = "Codigo";
            Lbl_NomeDespesa.Text = "Descrição";
            Lbl_Valor.Text = "Valor";
            Txt_Codigo.Enabled = false;
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Novo.Text = "Novo";
            Btn_Gravar.Text = "Gravar";
            Grp_DadosDespesaFixa.Text = "Cadastro Despesas Fixas";
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
            if(Msk_Valor.Text == "")
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Msk_Valor, Color.Red);
                temp += "Verifique o valor da Despesa. Não é possivel inserir despesa zerada.\r\n";
            }else if(double.Parse(Msk_Valor.Text) <= 0)
            {
                Grp_DadosDespesaFixa.AlterarBordaComponente(Msk_Valor, Color.Red);
                temp += "Verifique o valor da Despesa. Não é possivel inserir despesa zerada.\r\n";
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
            Grp_DadosDespesaFixa.AlterarBordaComponente(Txt_NomeDespesa, Grp_DadosDespesaFixa.BackColor);
            Grp_DadosDespesaFixa.AlterarBordaComponente(Msk_Valor, Grp_DadosDespesaFixa.BackColor);
        }

        private void Grp_DadosDespesaFixa_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                var DespesaFixa = new DespesasFixasModelo(0);
                DespesaFixa.Nome = Txt_NomeDespesa.Text;
                DespesaFixa.Valor = double.Parse(Msk_Valor.Text);
                var ControleDespesaFixa = new DespesasFixasControle();
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
    }
}
