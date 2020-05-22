using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.Visao.Avisos
{
    public partial class Frm_Aviso : Form
    {
        /// <summary>
        /// Inserir mensagem e Imagem para formação do Aviso
        /// </summary>
        /// <param name="mensagem">Mensagem para ser exibido na tela</param>
        /// <param name="imagem"> Sucesso - Imagem de sucesso </param>
        public Frm_Aviso(string mensagem, string imagem)
        {
            InitializeComponent();
            Lbl_Aviso.Text = mensagem;
            Image MyImage = (Image)global::ControleFinanceiro.Properties.Resources.ResourceManager.GetObject(imagem);
            Icon MyIcon = (Icon)global::ControleFinanceiro.Properties.Resources.ResourceManager.GetObject($"{imagem}I");
            Pic_Aviso.Image = MyImage;
            this.Icon = MyIcon;
            this.Text = "Aviso";
            Btn_Ok.Text = "Ok";
        }

        private void Frm_Aviso_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
