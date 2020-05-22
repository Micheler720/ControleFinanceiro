using ControleFinanceiro.Modelo;
using ControleFinanceiro.Modelo.Excexoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Negocio
{
    internal class TipoEstabelecimentoNegocio
    {
        public bool validaTipoEstabelecimentoNegocio(TipoEstabelecimentoModelo estabelecimento)
        {
            if(estabelecimento.Descricao == "")
            {
               throw new TipoEstabelecimentoException("Não é possível incluir um tipo de estabelecimento sem descrição.");
                
            }
            return true;
        }
    }
}
