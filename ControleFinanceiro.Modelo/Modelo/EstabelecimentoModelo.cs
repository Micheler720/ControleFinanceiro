using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Modelo
{
    public class EstabelecimentoModelo
    {
        public class Unit
        {
            //[Required(ErrorMessage = "Obrigatorio a propriedade Nome.")]
            //[StringLength(100, ErrorMessage = "Maximo 100 caracteres para o nome")]
            public string Nome { get; private set; }

            //[Required(ErrorMessage = "Obrigatorio a propriedade Nome.")]
            //[Range(0, int.MaxValue, ErrorMessage = "Apenas números inteiros para códigos")]
            public int Codigo { get; private set; }

            //[Required(ErrorMessage = "Obrigatoria informação de cidade.")]
            //[StringLength(50, ErrorMessage = "Tamanho maximo 50 caracteres")]
            public string Cidade { get; set; }

            //[Required(ErrorMessage = "Obrigatorio a propriedade Endereço.")]
            //[StringLength(50, ErrorMessage = "Maximo 50 caracteres para o nome")]
            public string Endereco { get; set; }

            //[Required(ErrorMessage = "Obrigatorio a propriedade Bairro.")]
            //[StringLength(50, ErrorMessage = "Maximo 50 caracteres para o nome")]
            public string Bairro { get; set; }

            //[Required(ErrorMessage = "Obrigatorio a propriedade Numero.")]
            //[Range(0, int.MaxValue, ErrorMessage = "Obrigatorio a inserção de um valor")]
            public int Numero { get; set; }

            //[Required(ErrorMessage = "Obrigatorio a propriedade Complemento.")]
            //[StringLength(50, ErrorMessage = "Maximo 50 caracteres para o nome")]
            public string Complemento { get; set; }
            public int TipoEstabelecimento { get; set; }

            //[Required(ErrorMessage = "Obrigatorio a propriedade CEP.")]
            //[RegularExpression("[0-9]{5}-[0-9]{3}", ErrorMessage = "Verifique o CEP")]
            public string CEP { get; set; }

            //[Required(ErrorMessage = "Obrigatorio a propriedade Estado.")]
            //[StringLength(2,MinimumLength =2, ErrorMessage = "Maximo 2 caracteres para o nome")]
            public string Estado { get; set; }
            public Unit(string nome, int tipoEstabelecimento)
            {
                Nome = nome;
                TipoEstabelecimento = tipoEstabelecimento;
            }
        }
        public class List
        {
            public List<Unit> ListEstabelecimento { get; set; }
        }


        
    }
}
