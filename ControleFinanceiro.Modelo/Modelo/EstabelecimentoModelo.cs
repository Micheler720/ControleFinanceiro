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
        }
        public class List
        {
            public List<Unit> ListEstabelecimento { get; set; }
        }


        
    }
}
