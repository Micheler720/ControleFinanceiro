using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.Util
{
    internal static class Cls_Util
    {
        

        /// <summary>
        /// Alterar borda de componente Devido a erros
        /// </summary>
        /// <param name="elementoPai">Elemento pai do componente </param>
        /// <param name="componente">Componente para alterar a borda</param>
        /// <param name="cor">Cor de alteração</param>
        internal static void AlterarBordaComponente(this GroupBox elementoPai , TextBox componente, Color cor)
        {
            //componente.BorderStyle = BorderStyle.None;
            
            float Espessura = (float)4.0;
            Graphics g = elementoPai.CreateGraphics();
            g.BeginContainer();
            g.DrawRectangle(new Pen(cor,Espessura) , componente.Location.X, componente.Location.Y, componente.Width, componente.Height);
            
        }
        internal static void AlterarBordaComponente(this GroupBox elementoPai, ComboBox componente, Color cor)
        {
            float Espessura = (float)4.0;
            Graphics g = elementoPai.CreateGraphics();
            g.DrawRectangle(new Pen(cor, Espessura), componente.Location.X, componente.Location.Y, componente.Width, componente.Height);

        }
        internal static void AlterarBordaComponente(this GroupBox elementoPai, CheckBox componente, Color cor)
        {
            float Espessura = (float)4.0;
            Graphics g = elementoPai.CreateGraphics();
            g.DrawRectangle(new Pen(cor, Espessura), componente.Location.X, componente.Location.Y, componente.Width, componente.Height);

        }
        internal static void AlterarBordaComponente(this GroupBox elementoPai, MaskedTextBox componente, Color cor)
        {
            float Espessura = (float)4.0;
            Graphics g = elementoPai.CreateGraphics();
            g.DrawRectangle(new Pen(cor, Espessura), componente.Location.X, componente.Location.Y, componente.Width, componente.Height);
             
        }
        internal static void AlterarBordaComponente(this GroupBox elementoPai, DateTimePicker componente, Color cor)
        {
            float Espessura = (float)4.0;
            Graphics g = elementoPai.CreateGraphics();
            g.DrawRectangle(new Pen(cor, Espessura), componente.Location.X, componente.Location.Y, componente.Width, componente.Height);

        }
        internal static DateTime ConvertData(string data)
        {
            var Data = data.Split('/');
            var dataLancamento = new DateTime(Convert.ToInt32(Data[2]), Convert.ToInt32(Data[1]), Convert.ToInt32(Data[0]));
            return dataLancamento;
        }
        public static DateTime PrimeiroDiadoMes(DateTime Data)
        {
            DateTime PrimeiroDiadoMes =new  DateTime(Data.Year,Data.Month,1);

            return PrimeiroDiadoMes;
        }
        public static DateTime UltimoDiadoMes(DateTime Data)

        {

            DateTime PrimeiroDiadoMes = DateTime.Parse("01" +Data.ToString("/ MM / yyyy"));

            DateTime PrimeiroDiadoProximoMes = PrimeiroDiadoMes.AddMonths(1);

            DateTime UltimoDiadoMes = PrimeiroDiadoProximoMes.AddDays(-1);

            return UltimoDiadoMes;

        }
        public static bool VerificarEmail(string _email)
        {
            string email = _email;

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            return rg.IsMatch(email);
        }
        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return senha.Length < 8 ? 0 : 56;
            }

            private int GetPontoPorMinusculas(string senha)
            {

                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return rawplacar == 0 ? 0 : 10;
            }

            private int GetPontoPorMaiusculas(string senha)
            {

                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return rawplacar == 0 ? 0 : 10;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return rawplacar == 0 ? 0 : 12;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return rawplacar == 0 ? 0 : 10;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }


            public ForcaDaSenha GetForcaDaSenha(string senha)
            {
                int placar = geraPontosSenha(senha);

                if (placar < 50)
                    return ForcaDaSenha.Inaceitavel;
                else if (placar < 60)
                    return ForcaDaSenha.Fraca;
                else if (placar < 80)
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)
                    return ForcaDaSenha.Forte;
                else
                    return ForcaDaSenha.Segura;
            }
        }

    }
}
