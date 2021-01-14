using ControleFinanceiro.Controle;
using ControleFinanceiro.Modelo.Entidades;
using ControleFinanceiro.Util;
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
    public partial class Frm_BuscaEstabelecimento : Form
    {
        List<Estabelecimento> ListaEstabelecimentos;
        public int IdSelect;
        public string NomeEstabelecimento;
        public Frm_BuscaEstabelecimento(List<Estabelecimento> ListEstabelecimentos)
        {
            InitializeComponent();
            Btn_Buscar.Text = "Buscar";
            Btn_Sair.Text = "Sair";
            Btn_Abrir.Text = "Abrir";
            Lbl_Busca.Text = "Nome Estabelecimento";
            Lbl_Legenda.Text = "Utilize o caractere '%' para otimizar a busca.";
            ListaEstabelecimentos = ListEstabelecimentos;
            PreencherLista();
        }
        private void PreencherLista()
        {
            Lst_Estabelecimento.Items.Clear();
            for(int i = 0 ; i < ListaEstabelecimentos.Count; i++)
            {
                var itemList = new ItemList();
                itemList.Id = ListaEstabelecimentos[i].Id.ToString();
                itemList.Nome = ListaEstabelecimentos[i].Nome;
                Lst_Estabelecimento.Items.Add(itemList);

            }
        }
        class ItemList {
            public string  Id { get; set; }
            public string  Nome { get; set; }
            public override string ToString()
            {
                return Nome;
            }

        }
        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Abrir_Click(object sender, EventArgs e)
        {
            AbrirEstabelecimento();
        }
        private void AbrirEstabelecimento()
        {
            if (Lst_Estabelecimento.SelectedIndex >= 0)
            {
                DialogResult = DialogResult.OK;
                var itemSelecionado = (ItemList)Lst_Estabelecimento.Items[Lst_Estabelecimento.SelectedIndex];
                IdSelect = int.Parse(itemSelecionado.Id);
                NomeEstabelecimento = itemSelecionado.Nome;
                Close();
            }
            else
            {
                MessageBox.Show("Selecione um estabelecimento para exibir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Lst_Estabelecimento_DoubleClick(object sender, EventArgs e)
        {
            AbrirEstabelecimento();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            var nomeEstabelecimento = Txt_Estabelecimento.Text;
            if(nomeEstabelecimento != "") 
            {
                var controleEstabelecimento = new EstabelecimentoControle();
                ListaEstabelecimentos = controleEstabelecimento.BuscarEstabelecimentoNome(nomeEstabelecimento);
                PreencherLista();
            }
            else
            {
                MessageBox.Show("Digite o nome de um estabelecimento para pesquisa.", "Busca - Estabelecimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Txt_Estabelecimento_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                Btn_Buscar.Focus();
            }
        }
    }
}
