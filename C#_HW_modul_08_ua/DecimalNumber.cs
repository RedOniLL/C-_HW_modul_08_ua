using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_08_ua
{
    struct DecimalNumber
    {
        private int decimalValue;

        public DecimalNumber(int value)
        {
            decimalValue = value;
        }

        public string ToBinary() => Convert.ToString(decimalValue, 2);

        public string ToOctal() => Convert.ToString(decimalValue, 8);

        public string ToHexadecimal() => Convert.ToString(decimalValue, 16);

    }
}
