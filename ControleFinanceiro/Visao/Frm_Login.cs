using ControleFinanceiro.Controle;
using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.Excexoes;
using ControleFinanceiro.Visao.Avisos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.Visao
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            Lbl_Senha.Text = "Senha";
            Lbl_Usuario.Text = "Usuário";
            Btn_Ok.Text = "OK";
            Btn_Fechar.Text = "Fechar";
            Image MyImage = (Image)global::ControleFinanceiro.Properties.Resources.ResourceManager.GetObject("ControleFinanceiro1");
            Pic_Login.Image = MyImage;
            Txt_Usuario.Text ="Michele";
            Txt_Senha.Text = "teste";
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                var nomeUsuario = Txt_Usuario.Text;
                var senhaUsuario = Txt_Senha.Text;
                var Usuario = new UsuarioModelo(nomeUsuario, senhaUsuario);
                var ControleUsuario = new AutenticarControle();
                ControleUsuario.ControleSenhaValida(Usuario);
                var M = new Frm_Aviso($"Olá {nomeUsuario}!", "sucesso");
                M.ShowDialog();
                var F = new Frm_ControleFinanceiro(this,Usuario);
                F.Show();

            }catch(AutenticarException ex)
            {
                MessageBox.Show(ex.Message, "Login - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Txt_Senha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_Senha_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue.ToString() == "13")
            {
                Btn_Ok.Focus();
            }
        }
    }
}
