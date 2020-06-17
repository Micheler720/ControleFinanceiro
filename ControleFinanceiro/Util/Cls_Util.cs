using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
