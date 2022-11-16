using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    internal class ConversorDeMoeda
    {

        public static double valordol;

        public static double Valortotal(double quant)
        {
            return valordol * quant;
        }
 
    }
}
