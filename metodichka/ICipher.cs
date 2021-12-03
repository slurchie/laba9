using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    interface ICipher
    {
        string Encode(string input);
        string Decode(string output);
    }
}
