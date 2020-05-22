using ControleFinanceiro.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.IO;

namespace ControleFinanceiro.Util
{
    public static class ClsUtil
    {

        public class Estado
        {
            public string DescricaoEstado { get; private set; }
            public string SiglaEstado { get; private set; }

            public Estado(string descricaoEstado, string siglaEstado)
            {
                DescricaoEstado = descricaoEstado;
                SiglaEstado = siglaEstado;
            }
        }

        public static List<Estado> EstadosBrasileiros()
        {
            var estados = new List<Estado>(){
                new Estado ("Acre","AC"),
                new Estado ("Alagoas","AL"),
                new Estado ("Amapá","AP"),
                new Estado ("Amazonas","AM"),
                new Estado ("Bahia","BA"),
                new Estado ("Ceará","CE"),
                new Estado ("DistritoFederal","DF"),
                new Estado ("EspíritoSanto","ES"),
                new Estado ("Goiás","GO"),
                new Estado ("Maranhão","MA"),
                new Estado ("MatoGrosso","MT"),
                new Estado ("MatoGrossodoSul","MS"),
                new Estado ("MinasGerais","MG"),
                new Estado ("Pará","PA"),
                new Estado ("Paraíba","PB"),
                new Estado ("Paraná","PR"),
                new Estado ("Pernambuco","PE"),
                new Estado ("Piauí","PI"),
                new Estado ("RiodeJaneiro","RJ"),
                new Estado ("RioGrandedoNorte","RN"),
                new Estado ("RioGrandedoSul","RS"),
                new Estado ("Rondônia","RO"),
                new Estado ("Roraima","RR"),
                new Estado ("SantaCatarina","SC"),
                new Estado ("SãoPaulo","SP"),
                new Estado ("Sergipe","SE"),
                new Estado ("Tocantins","TO")
            };
            return estados;
        }

        public static void ValidaClasse<T>(this T objeto)
        {
            var context = new ValidationContext(objeto, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(objeto, context, results, true);

            if (isValid == false)
            {
                var sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
        }

        public static string GeraJSONCEP(string CEP)
        {
            try
            {
                System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + CEP + "/json/");
                HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();


                int cont;
                byte[] buffer = new byte[1000];
                StringBuilder sb = new StringBuilder();
                string temp;
                Stream stream = resposta.GetResponseStream();
                do
                {
                    cont = stream.Read(buffer, 0, buffer.Length);
                    temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                    sb.Append(temp);

                } while (cont > 0);
                return sb.ToString();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
