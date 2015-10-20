using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator1
{
    public class Parse
    {
        string input;
        public Parse(string input)
        {
            this.input = input;
        }
        char[] operands = { '+', '-', '*', '/', '%', '=' };
        public char operand { get; set; }
        public static Dictionary<string, int> Constants = new Dictionary<string, int>();
        public int[] results { get; set; }

        public string[] extractnumbers(string input)
        {
            var stringArray = new string[2];
            //this is the way to set up a string array of you know what is going inside it.
            //var stringArray = new string[] { "2", "7" };

            //telling c# that each piece is a char and looping thru it with foreach
            foreach (char o in operands)
            {
                //is o in the input??
                if (input.Contains(o))
                {
                    //array is made with the split function
                    stringArray = input.Split(o);
                    foreach (string s in stringArray)
                    {
                        //when you split on the end or beginng of the string you end up with an empty string as one of the items in your array.
                        if (s == "")
                        {
                            throw new ArgumentException("dont put your operand first or last");
                        }
           
                    }
                    //having to loop back throw them again to see if either item in the string array contains another operand.
                    foreach (string r in stringArray)
                    {
         
                        foreach (char j in operands)
                        {
                            if (r.Contains(j))
                            {
                                throw new ArgumentException("Please stop trying to do two differnt operands at once. tardo");
                            }

                        }
                    }
                    this.operand = o;
                }
            }
            return stringArray;
        }
        public int[] stringArraytoIntArray(string[] stringr)

        {
            return new int[2];
        }

    }
}