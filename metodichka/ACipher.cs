using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    class ACipher:ICipher
    {
        public string Encode(string input )
        {
            char[] charinput = input.ToCharArray();
            string output = "";
            for (int i=0;i<input.Length;i++)
            {
                charinput[i]++;
                output += charinput[i];

            }
            return output;
        }
        public string Decode(string output)
        {
            char[] charinput = output.ToCharArray();
            string outputt = "";
            for (int i = 0; i < output.Length; i++)
            {
                charinput[i]--;
                outputt += charinput[i];
            }
            return outputt;
        }

    }
}
