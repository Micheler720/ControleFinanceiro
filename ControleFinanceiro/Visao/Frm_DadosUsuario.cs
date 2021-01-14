using ControleFinanceiro.Modelo.Controle;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Modelo.Util;
using ControleFinanceiro.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleFinanceiro.Util.Cls_Util;

namespace ControleFinanceiro.Visao
{
    public partial class Frm_DadosUsuario : Form
    {
        private bool AlterouImagem = false;
        private string OrigemImagem;
        private string DestinoImagem;
        private string SenhaOriginal;
        public int Operacao;
        public int IdUsuario;
        private Hash hash = new Hash(SHA512.Create());
        /// <summary>
        /// Tipo operação: 
        /// </summary>
        /// <param name="operacao">
        ///     1 - Incluir
        ///     2 - Alterar
        /// </param>
        public Frm_DadosUsuario(int operacao, int idUsuarioLogado = 0)
        {
            InitializeComponent();
            Btn_Sair.Text = "Sair";
            Lbl_Email.Text = "E-mail";
            Lbl_Nome.Text = "Nome";
            Grp_Sexo.Text = "Sexo";
            Lik_Abrir.Text = "Abrir";
            Grp_DadosUsuario.Text = "Dados Usuário";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";
            Rdb_Masculino.Text = "Masculino";
            Lbl_ConfirmaSenha.Text = "Confirma Senha";
            Lbl_Senha.Text = "Senha";
            Lbl_Nome.Text = "Usuario";
            Lbl_InfoSenha.Text = "Senha deverá conter números, letras maiúsculas, minúsculas e um caractere especial que não seja letra nem número";
            Lbl_InfoSenha.ForeColor = Color.Blue;
            Lbl_Resultado.Text = "";
            Lbl_VerificaEmail.Text = "";
            Txt_Id.Text = "1";
            Operacao = operacao;
            Btn_Gravar.Text = "Gravar";
            Lik_VerOcultarSenha.Text = "Exibir Senha";
            IdUsuario = idUsuarioLogado;
            if(operacao == 1)
            {
                var MyAvatar = (Image)global::ControleFinanceiro.Properties.Resources.ResourceManager.GetObject("avatar");
                Pic_Usuario.Image = MyAvatar;
                Pic_Usuario.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                PreencherFormulario(IdUsuario);
                SenhaOriginal = Txt_Senha.Text;
            }


        }
        private bool ValidarFormulario()
        {
            string retorno = "";
            if(Rdb_Feminino.Checked && Rdb_Indefinido.Checked && Rdb_Masculino.Checked)
            {
                retorno += "Verifique as marcações de Sexo. \n";
            }
            if(Txt_ConfirmaSenha.Text != Txt_Senha.Text)
            {
                retorno += "Senhas não coicidem, verifique \n";
            }
            if(Txt_Senha.Text == "" )
            {
                retorno += "Campo de senha vazio, verifique. \n";
            }
            if(Lbl_Resultado.Text == "Inaceitavel" || Lbl_Resultado.Text == "Fraca")
            {
                retorno += "Senha Inaceitavel verifique. \n";
            }
            if (Txt_NomeUsuario.Text == "")
            {
                retorno += "Campo nome de usuário vazio, verifique.\n";
            }
            if(Txt_Email.Text == "" || !Cls_Util.VerificarEmail(Txt_Email.Text))
            {
                retorno += "Verifique o campo de e-mail. \n";
            }
            if(retorno != "")
            {
                MessageBox.Show(retorno, "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Abrir_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var DB = new OpenFileDialog();
            DB.Filter = "PNG|*.PNG|JPG|*.JPG|JPEG|*.JPEG";
            DB.InitialDirectory = "C:\\Users\\Admin\\source\\repos\\CursoWindowsForm\\CursoWindowsForm\\Imagens";
            DB.Title = "Escolha uma imagem:";
            var R = DB.ShowDialog();
            if(R == DialogResult.OK)
            {
                OrigemImagem = DB.FileName.ToString();
                var extencao = Path.GetExtension(DB.FileName);
                var nomeArquivo = Path.GetRandomFileName() + extencao;
                DestinoImagem = $"C:\\Users\\miche\\source\\repos\\ControleFinanceiro\\ControleFinanceiro.Modelo\\Imagens\\{nomeArquivo}";
                while (File.Exists(DestinoImagem))
                {
                    nomeArquivo = Path.GetRandomFileName() + extencao;
                    DestinoImagem = $"C:\\Users\\miche\\source\\repos\\ControleFinanceiro\\ControleFinanceiro.Modelo\\Imagens\\{nomeArquivo}";
                }
                Pic_Usuario.Image = Image.FromFile(OrigemImagem);
                AlterouImagem = true;
                Pic_Usuario.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                var controle = new UsuarioControle();
                var usuario = CapturarFormulario();
                controle.alterarUsuario(usuario);
                MessageBox.Show(controle.Mensagem, "Usuario - Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }
        private Usuario CapturarFormulario()
        {
            var usuario = new Usuario();
            usuario.Email = Txt_Email.Text;
            usuario.Foto = OrigemImagem;
            if (AlterouImagem)
            {
                File.Copy(OrigemImagem, DestinoImagem, true);
                usuario.Foto = DestinoImagem;
            }
            if(SenhaOriginal != Txt_Senha.Text)
            {
                var senha = hash.CriptografarSenha(Txt_Senha.Text);
                usuario.Senha = senha;
            }
            else
            {
                usuario.Senha = Txt_Senha.Text;
            }            
            usuario.Nome = Txt_NomeUsuario.Text;
            usuario.Id = Convert.ToInt32(Txt_Id.Text);
            if (Rdb_Feminino.Checked)
            {
                usuario.Sexo = 1;
            }else if (Rdb_Indefinido.Checked)
            {
                usuario.Sexo = 3;
            }
            else
            {
                usuario.Sexo = 2;
            }
            return usuario;
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                var controle = new UsuarioControle();
                var usuario = CapturarFormulario();
                bool r;
                if(Operacao == 1)
                {
                    r = controle.gravarUsuario(usuario);
                }
                else
                {
                    usuario.Id = Convert.ToInt32(Txt_Id.Text);
                    r = controle.alterarUsuario(usuario);
                }
                MessageBox.Show(controle.Mensagem, "Usuario - Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (r)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }
        private void PreencherFormulario(int id)
        {
            var controle = new UsuarioControle();
            var usuario = controle.buscarUsuarioId(id);
            Txt_ConfirmaSenha.Text = usuario.Senha;
            Txt_Email.Text = usuario.Email;
            Txt_Id.Text = usuario.Id.ToString();
            Txt_NomeUsuario.Text = usuario.Nome;
            Txt_Senha.Text = usuario.Senha; 
            if(usuario.Foto is null)
            {
                var MyAvatar = (Image)global::ControleFinanceiro.Properties.Resources.ResourceManager.GetObject("avatar");
                Pic_Usuario.Image = MyAvatar;
            }
            else
            {
                OrigemImagem = usuario.Foto;
                Pic_Usuario.Image = Image.FromFile(OrigemImagem);
            }
            Pic_Usuario.SizeMode = PictureBoxSizeMode.StretchImage;
            if(usuario.Sexo == 1)
            {
                Rdb_Feminino.Checked = true;
            }else if(usuario.Sexo == 2)
            {
                Rdb_Masculino.Checked = true;
            }
            else
            {
                Rdb_Indefinido.Checked = true;
            }
        }

        private void Pic_VisualizarSenha_Click(object sender, EventArgs e)
        {
           
        }

        private void Lik_VerOcultarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var exibicao = Lik_VerOcultarSenha.Text;
            if(exibicao == "Exibir Senha")
            {
                Lik_VerOcultarSenha.Text = "Ocultar Senha";
                Txt_Senha.PasswordChar = '\0';
            }
            else
            {
                Lik_VerOcultarSenha.Text = "Exibir Senha";
                Txt_Senha.PasswordChar = '*';
            }
        }

        private void Txt_Senha_KeyUp(object sender, KeyEventArgs e)
        {
            var senha = Txt_Senha.Text;
            var checarSenha = new ChecaForcaSenha();
            var forca = checarSenha.GetForcaDaSenha(senha).ToString();
            Lbl_Resultado.Text = $"Senha: {forca}";
            if (forca == "Inaceitavel" || forca == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            if (forca == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            if (forca == "Forte" || forca == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void Txt_Email_Leave(object sender, EventArgs e)
        {
            if(!Cls_Util.VerificarEmail(Txt_Email.Text))
            {
                Lbl_VerificaEmail.Text = "Email invalido, Verifique.";
                Lbl_VerificaEmail.ForeColor = Color.Red;
            }
            else
            {
                Lbl_VerificaEmail.Text = "Email valido.";
                Lbl_VerificaEmail.ForeColor = Color.Green;
            }
        }
    }
}
