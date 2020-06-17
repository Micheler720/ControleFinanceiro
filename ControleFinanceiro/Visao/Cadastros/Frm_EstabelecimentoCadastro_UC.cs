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
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Excexoes;
using ControleFinanceiro.Controle;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using ControleFinanceiro.Modelo.Modelo;
using System.Text.RegularExpressions;
using ControleFinanceiro.Visao.Filtros;

namespace ControleFinanceiro.Visao.Cadastros
{
    public partial class Frm_EstabelecimentoCadastro_UC : UserControl
    {
        string Operacao;
        List<List<string>> _ListaBuscaTipoEstabelecimento = new List<List<string>>();
        public Frm_EstabelecimentoCadastro_UC(List<List<String>> ListaBusca)
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
            Btn_Cancelar.Text = "Cancelar";
            Btn_Novo.Text = "Novo";
            Btn_Gravar.Text = "Gravar";
            Btn_Cancelar.Enabled = false;
            Tls_Principal.Items[0].ToolTipText = "Limpar Formulário";
            _ListaBuscaTipoEstabelecimento = ListaBusca;
            HabilitarDesabitarCampos(false);
            LimparFormulario();
            PreencherEstado();
            PreencherLista();
            Btn_Excluir.Enabled = false;
            Btn_Editar.Enabled = false;
            Btn_Gravar.Enabled = false;

        }
        private void PreencherEstado()
        {
            var estados = ClsUtil.EstadosBrasileiros();
            Cbo_Estado.Items.Clear();
            foreach (var estado in estados)
            {
                Cbo_Estado.Items.Add(estado.SiglaEstado);
            }
        }
        private void PreencherLista()
        {
            Cbo_TipoEstabelecimento.Items.Clear();
            for (int i = 0; i <= _ListaBuscaTipoEstabelecimento.Count - 1; i++)
            {
                ItemBox X = new ItemBox();
                X.id = _ListaBuscaTipoEstabelecimento[i][0];
                X.nome = _ListaBuscaTipoEstabelecimento[i][1];
                Cbo_TipoEstabelecimento.Items.Add(X);
            }
        }
        private void SelecionarTipoEstabelecimento(int id)
        {
            for (int i = 0; i < _ListaBuscaTipoEstabelecimento.Count; i++)
            {
                ItemBox X = new ItemBox();
                X.id = _ListaBuscaTipoEstabelecimento[i][0];
                if(int.Parse(X.id) == id)
                {
                    Cbo_TipoEstabelecimento.SelectedIndex = i;
                }
                
            }
        }
       
        class ItemBox
        {
            public string id { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
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
            Operacao = "Novo";
            HabilitarDesabitarCampos(true);
            Btn_Novo.Enabled = false;
            Btn_Gravar.Enabled = true;
        }
       

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Operacao = "Editar";
            Btn_Editar.Enabled = false;
            Btn_Gravar.Enabled = true;
            Btn_Excluir.Enabled = false;
            Btn_Novo.Enabled = false;
            HabilitarDesabitarCampos(true);
        }

        private void Grp_EnderecoEstabelecimento_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                
                var Estabelecimento = CapturarFormulario();
                var EstabelecimentoControle = new EstabelecimentoControle();                    
                if(Operacao == "Novo")
                {
                   EstabelecimentoControle.GravarCadastroEstabelecimento(Estabelecimento);                   
                }
                else
                {
                    Estabelecimento.Id = int.Parse(Txt_Codigo.Text);
                    EstabelecimentoControle.AlterarCadastroEstabelecimento(Estabelecimento);
                }
                MessageBox.Show(EstabelecimentoControle.Mensagem, "Cadastro Estabelecimento - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparFormulario();
                HabilitarDesabitarCampos(false);
                Btn_Gravar.Enabled = false;
                Btn_Novo.Enabled = true;
                Btn_Editar.Enabled = false;
                Btn_Cancelar.Enabled = false;
                Btn_Excluir.Enabled = false;
                RemoverBordaComponentes();
            }

        }
        private Estabelecimento CapturarFormulario()
        {
            var nomeEstabelecimento = Txt_NomeEstabelecimento.Text;
            var tipoEstabelecimento = new Tipo_Estabelecimento { 
                Id = int.Parse(_ListaBuscaTipoEstabelecimento[Cbo_TipoEstabelecimento.SelectedIndex][0]),
                Descricao = _ListaBuscaTipoEstabelecimento[Cbo_TipoEstabelecimento.SelectedIndex][1]
            };

            var Estabelecimento = new Estabelecimento()
            {
                Endereco = Txt_Endereco.Text,
                Nome = nomeEstabelecimento,
                Bairro = Txt_Bairro.Text,
                Cidade = Txt_Cidade.Text,
                Complemento = Txt_Complemento.Text,
                CEP = Msk_CEP.Text,
                Tipo_Estabelecimento = tipoEstabelecimento
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
            return Estabelecimento;
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
        private void LimparFormulario()
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
            LimparFormulario();
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

        private void ajudaToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela Referente a cadastro de Estabelecimentos. Exemplos: Supermercado, Academia, Lanchonete ...", "Ajuda - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {           
            var contEstabelecimento = new EstabelecimentoControle();
            var estabelecimentos = contEstabelecimento.BuscarEstabelecimento();
            var F = new Frm_BuscaEstabelecimento(estabelecimentos);
            F.ShowDialog();
            if (F.DialogResult == DialogResult.OK)
            {
                LimparFormulario();
                var estabelecimeto = EstabelecimentoControle.BuscarEstabelecimentoId(F.IdSelect);
                PreencherFormulario(estabelecimeto);
                RemoverBordaComponentes();
                HabilitarDesabitarCampos(false);
                Btn_Editar.Enabled = true;
                Btn_Excluir.Enabled = true;
                Btn_Gravar.Enabled = false;
                Btn_Novo.Enabled = false;
                Btn_Cancelar.Enabled = false;

            }
            
        }

        private void PreencherFormulario (Estabelecimento estabelecimento)
        {
            Txt_Bairro.Text = estabelecimento.Bairro;
            Txt_Cidade.Text = estabelecimento.Cidade;
            Txt_Codigo.Text = estabelecimento.Id.ToString();
            Txt_Endereco.Text = estabelecimento.Endereco;
            Txt_NomeEstabelecimento.Text = estabelecimento.Nome;
            Msk_CEP.Text = estabelecimento.CEP;
            Msk_Numero.Text = estabelecimento.Numero.ToString();
            var IdEstado = Cbo_Estado.Items.IndexOf(estabelecimento.Estado);
            Cbo_Estado.SelectedIndex = IdEstado;
            SelecionarTipoEstabelecimento(estabelecimento.Tipo_Estabelecimento.Id);
            RemoverBordaComponentes();
        }
        

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            var M = MessageBox.Show("Deseja realmente excluir o estabelecimento?", "Cadastro Estabelecimento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(M == DialogResult.OK && Txt_Codigo.Text != "")
            {
                var contrEstabelecimento = new EstabelecimentoControle();
                var estabelecimento = CapturarFormulario();
                estabelecimento.Id = int.Parse(Txt_Codigo.Text);
                contrEstabelecimento.ExcluirCadastroEstabelecimento(estabelecimento);
                if (contrEstabelecimento.Sucesso)
                {
                    Btn_Gravar.Enabled = false;
                    Btn_Novo.Enabled = true;
                    Btn_Editar.Enabled = false;
                    Btn_Cancelar.Enabled = false;
                    Btn_Excluir.Enabled = false;
                    LimparFormulario();
                }
                MessageBox.Show(contrEstabelecimento.Mensagem, "Cadastro Estabelecimento - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {           
            var M = MessageBox.Show("Deseja realmente cancelar alterações?", "Cancelar Alterações - Cadastro Estabelecimento", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (M == DialogResult.OK)
            {
                LimparFormulario();
                HabilitarDesabitarCampos(false);
                Btn_Gravar.Enabled = false;
                Btn_Novo.Enabled = true;
                Btn_Editar.Enabled = false;
                Btn_Cancelar.Enabled = false;
                Btn_Excluir.Enabled = false;
            }
        }
    }
}
