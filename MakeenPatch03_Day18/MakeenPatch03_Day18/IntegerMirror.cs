using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day18
{
    internal static class IntegerMirror
    {
        public static int Miror(this int Number)
        {
            //12345 ==> 54321
            //two ways 
            // first way convert x to string and reverse the loop 
            // using the Mathimatic way 
            int  result = 0 ,  reminder;
            while(Number != 0)
            {
                reminder = Number % 10; 
                result = result * 10 + reminder;
                Number  = Number / 10;
            }
            return result;
        }

    }
}
