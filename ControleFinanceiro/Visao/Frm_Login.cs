using ControleFinanceiro.Controle;
using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.Controle;
using ControleFinanceiro.Modelo.Entidades;
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
            PreencherUsuario();
            Lik_CadastrarUsuario.Text = "Cadastrar Usuario";
            Lik_EsqueceuSenha.Text = "Esqueci minha Senha";
            Txt_Usuario.Enabled = false;
        }
        private void PreencherUsuario()
        {
            var controle = new UsuarioControle();
            var usuarios = controle.BuscarUsuario();
            Cbo_Usuario.Items.Clear();
            foreach (var usuario in usuarios)
            {
                var u = new UsuarioModelo(usuario.Email, usuario.Senha);
                u.Nome = usuario.Nome;
                u.Id = usuario.Id;
                Cbo_Usuario.Items.Add(u);
            } 
            

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
                var usuario = Cbo_Usuario.Items[Cbo_Usuario.SelectedIndex] as UsuarioModelo;
                var ControleUsuario = new AutenticarControle();
                var senha = Txt_Senha.Text;
                if (ControleUsuario.ControleSenhaValida(usuario.Email, senha))
                {
                    var M = new Frm_Aviso($"Olá, {usuario.Nome}!", "sucesso");
                    M.ShowDialog();
                    var controle = new UsuarioControle();
                    var UsuarioEntidade = controle.buscarUsuarioId(usuario.Id);
                    var F = new Frm_ControleFinanceiro(this, UsuarioEntidade );
                    F.ShowDialog();
                }
                else
                {
                    MessageBox.Show(ControleUsuario.Mensagem, "Validação Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_Senha.Focus();
                }
                

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

        private void Lik_CadastrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var F = new Frm_DadosUsuario(1);
            F.ShowDialog();
            PreencherUsuario();
        }

        private void Cbo_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            var usuario = Cbo_Usuario.Items[Cbo_Usuario.SelectedIndex] as UsuarioModelo;
            Txt_Usuario.Text = usuario.Nome;
        }
    }
}
