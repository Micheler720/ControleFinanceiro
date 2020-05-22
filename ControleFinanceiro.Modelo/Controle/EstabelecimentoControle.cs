using ControleFinanceiro.Modelo;
using ControleFinanceiro.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Controle
{
    public class EstabelecimentoControle
    {
        public void controleCadastroEstabelecimento(EstabelecimentoModelo.Unit estabelecimento)
        {
            var EstabelecimentoNegocio = new EstabelecimentoNegocio();
            if (EstabelecimentoNegocio.ValidaCadastroEstabelecimento(estabelecimento))
            {
               // MessageBox.Show("Dados Gravados com sucesso!", "Messagem"); Gravar informação
            } 
        }
    }
}
