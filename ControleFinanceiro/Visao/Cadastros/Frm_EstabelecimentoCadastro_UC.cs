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
using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.Excexoes;
using ControleFinanceiro.Controle;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using ControleFinanceiro.Modelo.Modelo;
using System.Text.RegularExpressions;

namespace ControleFinanceiro.Visao.Cadastros
{
    public partial class Frm_EstabelecimentoCadastro_UC : UserControl
    {

        public Frm_EstabelecimentoCadastro_UC()
        {
            InitializeComponent();
            Lbl_Bairro.Text = "Bairro *";
            Lbl_CEP.Text = "CEP *";
            Lbl_Complemento.Text = "Complemento";
            Lbl_Endereco.Text = "Endereço *";
            Lbl_Estado.Text = "Estado *";
            Lbl_NomeEstabelecimento.Text = "Estabelecimento *";
            Lbl_Numero.Text = "Nº *";
            Lbl_TipoEstabelecimento.Text = "Tipo Estabelecimento";
            Lbl_Codigo.Text = "Código";
            Lbl_Cidade.Text = "Cidade *";
            Lbl_Legenda.Text = "Campos com * são obrigátorios";
            Grp_DadosEstabelecimento.Text = "Estabelecimento";
            Grp_EnderecoEstabelecimento.Text = "Endereço *";
            Btn_Editar.Text = "Editar";
            Btn_Excluir.Text = "Excluir";
            Btn_Novo.Text = "Novo";
            Btn_Gravar.Text = "Gravar";
            Tls_Principal.Items[0].ToolTipText = "Limpar Formulário";
            var estados = ClsUtil.EstadosBrasileiros();
            Cbo_Estado.Items.Clear();
            foreach(var estado in estados)
            {
                Cbo_Estado.Items.Add(estado.SiglaEstado);
            }
            HabilitarDesabitarCampos(false); 
            LimparCampos();
            Btn_Excluir.Enabled = false;
            Btn_Editar.Enabled = false;
            Btn_Gravar.Enabled = false;

        }


        private void Cbo_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {

            Grp_EnderecoEstabelecimento.AlterarBordaComponente(Cbo_Estado, Color.Green);
        }

        private void Frm_EstabelecimentoCadastro_UC_Load(object sender, EventArgs e)
        {

        }

        private void Grp_DadosEstabelecimento_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            HabilitarDesabitarCampos(true);
            Btn_Novo.Enabled = false;
            Btn_Gravar.Enabled = true;
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {

        }

        private void Grp_EnderecoEstabelecimento_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                try
                {
                    var nomeEstabelecimento = Txt_NomeEstabelecimento.Text;
                    int tipoEstabelecimento = Cbo_TipoEstabelecimento.SelectedIndex;
                    var Estabelecimento = new EstabelecimentoModelo.Unit(nomeEstabelecimento, tipoEstabelecimento)
                    {
                        Endereco = Txt_Endereco.Text,
                        Bairro = Txt_Bairro.Text,
                        Cidade = Txt_Cidade.Text,
                        Complemento = Txt_Complemento.Text,
                        CEP = Msk_CEP.Text
                    };
                    if (Cbo_Estado.SelectedIndex >= 0)
                    {
                        Estabelecimento.Estado = Cbo_Estado.SelectedItem.ToString();
                    }
                    else
                    {
                        Estabelecimento.Estado = "";
                    }
                    if (Information.IsNumeric(Msk_Numero.Text))
                    {
                        Estabelecimento.Numero = Convert.ToInt32(Msk_Numero.Text);
                    }
                    else
                    {
                        Estabelecimento.Numero = 0;
                    }
                    Estabelecimento.ValidaClasse();
                    var EstabelecimentoControle = new EstabelecimentoControle();
                    EstabelecimentoControle.controleCadastroEstabelecimento(Estabelecimento);
                    MessageBox.Show("Dados Gravados com sucesso!", "Cadastro Estabelecimento - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    HabilitarDesabitarCampos(false);
                    Btn_Gravar.Enabled = false;
                    Btn_Novo.Enabled = true;
                    RemoverBordaComponentes();
                }
                catch (EstabelecimentoException ex)
                {
                    MessageBox.Show(ex.Message, "Cad. Estabelcimento - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ValidationException ex)
                {
                    MessageBox.Show(ex.Message, "Cad. Estabelcimento - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Msk_CEP_KeyUp(object sender, KeyEventArgs e)
        {
            var cep = Msk_CEP.Text;
            if(cep.Length == 9)
            {
                try
                {
                    cep = cep.Replace("-", "");
                    
                    var vJson = ClsUtil.GeraJSONCEP(cep);
                    var Cep = CepModelo.DesSerializedClassUnit(vJson);
                    Txt_Bairro.Text = Cep.bairro;
                    Txt_Cidade.Text = Cep.localidade;
                    Txt_Complemento.Text = Cep.complemento;
                    Txt_Endereco.Text = Cep.logradouro;
                    Cbo_Estado.SelectedItem = Cep.uf;
                    Grp_EnderecoEstabelecimento.AlterarBordaComponente(Msk_CEP, Color.Green);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro de Conexão", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                }
            }
            else
            {
                Txt_Bairro.Text = "";
                Txt_Cidade.Text ="";
                Txt_Complemento.Text ="";
                Txt_Endereco.Text = "";
                Cbo_Estado.SelectedItem = "";
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Msk_CEP, Color.Red);
            }
        }
        private void HabilitarDesabitarCampos(bool valor)
        {
            Txt_Codigo.Enabled = false;
            Txt_Bairro.Enabled = valor;
            Txt_Complemento.Enabled = valor;
            Txt_Endereco.Enabled = valor;
            Txt_NomeEstabelecimento.Enabled = valor;
            Txt_Cidade.Enabled = valor;
            Cbo_Estado.Enabled = valor;
            Cbo_TipoEstabelecimento.Enabled = valor;
            Msk_CEP.Enabled = valor;
            Msk_Numero.Enabled = valor;
            Cbo_Estado.SelectedIndex = -1;
        }
        private void LimparCampos()
        {
            Txt_Codigo.Text = "";
            Txt_Bairro.Text = "";
            Txt_Complemento.Text = "";
            Txt_Endereco.Text = "";
            Txt_NomeEstabelecimento.Text = "";
            Txt_Cidade.Text = "";
            Cbo_Estado.Text = "";
            Cbo_TipoEstabelecimento.Text = "";
            Msk_CEP.Text = "";
            Msk_Numero.Text = "";
            Cbo_Estado.SelectedIndex = -1;
            RemoverBordaComponentes();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarDesabitarCampos(false);
            Btn_Gravar.Enabled = false;
            Btn_Novo.Enabled = true;
        }
        private bool ValidaFormulario()
        {
            string temp ="";
            if(Txt_NomeEstabelecimento.Text == "")
            {
                Grp_DadosEstabelecimento.AlterarBordaComponente(Txt_NomeEstabelecimento, Color.Red);
                temp += "Não é permitido nome vazio!\r\n";
            }
            if(Txt_NomeEstabelecimento.Text.Length > 100)
            {
                Grp_DadosEstabelecimento.AlterarBordaComponente(Txt_NomeEstabelecimento, Color.Red);
                temp += "Não é nome com mais de 100 caracteres.Verifique!\r\n";
            }
            if(Txt_Cidade.Text == "")
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Cidade, Color.Red);
                temp += "Não é permitido cidade vazio!\r\n";
            }
            if (Txt_Cidade.Text.Length > 50)
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Cidade, Color.Red);
                temp += "Não é permitido cidade com mais de 50 caracteres. Verifique!\r\n";
            }
            if(Txt_Endereco.Text == "")
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Endereco, Color.Red);
                temp += "Verifique o campo endereço\r\n";
            }
            if (Txt_Endereco.Text.Length > 50)
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Endereco, Color.Red);
                temp += "Não é permitido endereço com mais de 50 caracteres. Verifique!\r\n";
            }
            if(Txt_Bairro.Text == "")
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Bairro, Color.Red);
                temp += "Sem informação de bairro. Verifique!\r\n";
            }
            if(Txt_Bairro.Text.Length > 50)
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Bairro, Color.Red);
                temp += "Bairro com mais de 50 caracteres. Verifique!\r\n";
            }
            if(Msk_Numero.Text == "")
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Msk_Numero, Color.Red);
                temp += "Sem informação de numero. Verifique!\r\n";
            }
            var MskCep = "[0-9]{5}-[0-9]{3}";
            var resultado =  Regex.Match(Msk_CEP.Text, MskCep);
            if (!resultado.Success)
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Msk_CEP, Color.Red);
                temp += "Verifique o campo CEP \r\n";
            }
            if(Cbo_Estado.SelectedIndex < 0)
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Cbo_Estado, Color.Red);
                temp += "Verifique a informação de Estado\r\n";
            }
            if (temp != "")
            {
                MessageBox.Show(temp, "Validação de formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Txt_NomeEstabelecimento_KeyUp(object sender, KeyEventArgs e)
        {
            if(Txt_NomeEstabelecimento.Text.Length > 3)
            {
                Grp_DadosEstabelecimento.AlterarBordaComponente(Txt_NomeEstabelecimento,Color.Green);
            }
            else
            {
                Grp_DadosEstabelecimento.AlterarBordaComponente(Txt_NomeEstabelecimento, Color.Red);
            }
        }

        private void Txt_Endereco_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Endereco.Text.Length > 0)
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Endereco, Color.Green);
            }
            else
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Endereco, Color.Red);
            }
        }

        private void Txt_Cidade_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Cidade.Text.Length > 0)
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Cidade, Color.Green);
            }
            else
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Cidade, Color.Red);
            }
        }

        private void Txt_Bairro_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Bairro.Text.Length > 3)
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Bairro, Color.Green);
            }
            else
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Bairro, Color.Red);
            }

        }

        private void Msk_Numero_TextChanged(object sender, EventArgs e)
        {
            if (Msk_Numero.Text.Length > 0)
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Msk_Numero, Color.Green);
            }
            else
            {
                Grp_EnderecoEstabelecimento.AlterarBordaComponente(Msk_Numero, Color.Red);
                
            }
        }
        private void RemoverBordaComponentes()
        {
            Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Bairro, Grp_DadosEstabelecimento.BackColor);
            Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Endereco, Grp_DadosEstabelecimento.BackColor);
            Grp_EnderecoEstabelecimento.AlterarBordaComponente(Txt_Cidade, Grp_DadosEstabelecimento.BackColor);
            Grp_EnderecoEstabelecimento.AlterarBordaComponente(Msk_Numero, Grp_DadosEstabelecimento.BackColor);
            Grp_EnderecoEstabelecimento.AlterarBordaComponente(Msk_CEP, Grp_DadosEstabelecimento.BackColor);
            Grp_EnderecoEstabelecimento.AlterarBordaComponente(Cbo_Estado, Grp_DadosEstabelecimento.BackColor);
            Grp_DadosEstabelecimento.AlterarBordaComponente(Txt_NomeEstabelecimento, Grp_DadosEstabelecimento.BackColor);
        }
    }
}
