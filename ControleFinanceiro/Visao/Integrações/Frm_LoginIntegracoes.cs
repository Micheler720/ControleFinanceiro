using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Controle;

namespace ControleFinanceiro.Visao.Integrações
{
    public partial class Frm_LoginIntegracoes : UserControl
    {
        public Frm_LoginIntegracoes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Integrar_Click(object sender, EventArgs e)
        {
            var dados = new Integracao();
            dados.Senha = Txt_Password.Text;
            dados.Usuario = Txt_Usuario.Text;
            var controleIntegracao = new IntegracaoControle();
            var retorno = controleIntegracao.Integrar(dados);
            if (retorno)
            {
                Txt_Integracao.Text = $"Integrado{controleIntegracao.Mensagem}";
            }
            else
            {
                Txt_Integracao.Text = "Você falhou";
            }
        }
    }
}
