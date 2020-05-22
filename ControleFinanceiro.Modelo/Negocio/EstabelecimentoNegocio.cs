using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.Excexoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Negocio
{
    internal class EstabelecimentoNegocio
    {
        internal bool ValidaCadastroEstabelecimento(EstabelecimentoModelo.Unit estabelecimento)
        {
            if(estabelecimento.Nome == "")
            {
                throw new EstabelecimentoException("Não é possivel inserir estabelecimento sem informação.");
            }

            return true;
        }
    }
}
