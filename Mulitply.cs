using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simpleCalculator1;

namespace simpleCalculator1
{
    public class Multiply
    {
        public int Mult(int x, int y) // Argument names are placeholders
        {
            return x * y;
        }

        public int MultStrings(string a, string b)
        {
            int output;
            int j;
            int k;
            if (!Int32.TryParse(a, out j))
            {
                ArgumentException argEx = new ArgumentException();
                throw argEx;
            }

            if (!Int32.TryParse(b, out k)) // Throw Exception when TryParse is NOT true.
            {
                ArgumentException argEx = new ArgumentException();
                throw argEx;
            }
            /*output = j * k;
            return output;*/

            return Mult(j, k); // This is the method from Above.
        }
    }
    }
