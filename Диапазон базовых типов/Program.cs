using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диапазон_базовых_типов
{
    class Program
    {
        static void Main(string[] args)
        {
        
         MessageBox.Show(string.Format("тип sbyte   : ({0}) до ({1})\n" +
          "тип byte    : ({2}) до ({3})\n" +
          "тип short   : ({4:0,0}) до ({5:0,0})\n" +
          "тип ushort  : ({6: мин значение 0,0}) до ({7: макс значение 0,0})\n" +
          "тип int     : ({8: 0,0}) до ({9: мак значение, 0,0})\n" +
          "тип uint    : ({10}) до ({11})\n" +
          "тип long    : ({12}) до ({13})\n" +
          "тип ulong   : ({14}) до ({15})\n" +
          "тип float   : ({16}) до ({17})\n" +
          "тип double  : ({18}) до ({19})\n" +
          "тип decimal : ({20}) до ({21})\n",

         sbyte.MinValue, SByte.MaxValue, byte.MinValue, Byte.MaxValue, short.MinValue, Int16.MaxValue, ushort.MinValue, UInt16.MaxValue,
         int.MinValue, Int32.MaxValue, uint.MinValue, UInt32.MaxValue, long.MinValue, Int64.MaxValue, ulong.MinValue, UInt64.MaxValue,
         float.MinValue, Single.MaxValue, double.MinValue, Double.MaxValue, decimal.MinValue, Decimal.MaxValue), "Диапазон базовых типов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        

        }
    }
}
