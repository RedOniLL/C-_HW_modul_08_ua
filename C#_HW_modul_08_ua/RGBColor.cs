using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_08_ua
{
    struct RGBColor
    {
        public byte Red { get; private set; }
        public byte Green { get; private set; }
        public byte Blue { get; private set; }

        public RGBColor(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

       
    }
}
