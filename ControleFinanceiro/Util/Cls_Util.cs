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
        /*internal static void RemoverBordaComponente(this GroupBox elementoPai)
        {
            var g = elementoPai.CreateGraphics();
            g.Dispose();
            //g.Clear(elementoPai.BackColor);
        }*/
    }
}
