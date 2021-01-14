using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.Visao.Filtros
{
    public partial class Frm_Busca : Form
    {
        List<List<String>> List;
        public string IdSelect { get; set; }
        public Frm_Busca(List<List<String>> list, string titulo)
        {
            InitializeComponent();
            List = list;
            PreencherTipoEstabelecimento();
            Lbl_Titulo.Text = titulo;
            Btn_Sair.Text = "Sair";
            Btn_Salvar.Text = "Abrir";
        }
        private void PreencherTipoEstabelecimento()
        {
                Lst_Dados.Items.Clear();
                for (int i = 0; i <= List.Count - 1; i++)
                {
                    var X = new ItemList();
                    X.id = List[i][0];
                    X.nome = List[i][1];
                    Lst_Dados.Items.Add(X);
                }

        }
        class ItemList
        {
            public string id { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            AbrirDado();
        }        
        private void Lst_Dados_DoubleClick(object sender, EventArgs e)
        {
            AbrirDado();
        }
        private void AbrirDado()
        {
            if (Lst_Dados.SelectedIndex >= 0)
            {
                DialogResult = DialogResult.OK;
                var itemSelecionado = (ItemList)Lst_Dados.Items[Lst_Dados.SelectedIndex];
                IdSelect = itemSelecionado.id;
                this.Close();
            }
            else
            {
                MessageBox.Show("Escolha uma opção para Abrir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
