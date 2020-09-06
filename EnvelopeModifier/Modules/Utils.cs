using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvelopeModifier.Modules
{
    public static class Utils
    {
        static string ToHex(this int value, string Hex)
        {
            return String.Format(Hex, value);
        }

    }
}
