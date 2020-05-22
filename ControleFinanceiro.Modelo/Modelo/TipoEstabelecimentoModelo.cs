using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Modelo
{
    public class TipoEstabelecimentoModelo
    {
        //[Required(ErrorMessage ="Impossivel inserir Tipo estabelecimento sem codigo")]
        //[Range(0,int.MaxValue, ErrorMessage ="Código permitido apenas números inteiros")]
        public int Codigo { get; private set; }
        //[Required(ErrorMessage = "Impossivel inserir Tipo estabelecimento sem nome")]
        //[StringLength(50,ErrorMessage ="Descrição permitido maximo de 50 caracteres.")]
        public string Descricao { get; set; }



    }
}
