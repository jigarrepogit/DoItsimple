using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanWordsTest
{
    public static class CharToNumber
    {
        public static int ConvertCharToNumber(this char text)
        {
            return (text - 'a') + 1;
        }
    }
}
