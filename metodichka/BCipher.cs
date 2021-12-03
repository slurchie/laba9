using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    class BCipher:ICipher
    {
        private string MovingLetter(string input)
        {
            char[] charinputt = input.ToCharArray();
            string output = "";
            for (int i=0;i<charinputt.Length;i++)
            {
                if ((int)charinputt[i]>=1040&&(int)charinputt[i]<=1071)//заглавные буквы
                {
                    int Letter = (int)charinputt[i]- (int)'А';//номер в алфавите
                    int lastLetter = (int)'Я' - Letter;//номер в кодировке 
                    charinputt[i] =(char)lastLetter;

                }
                else if ((int)charinputt[i] <= 1103 && (int)charinputt[i] >= 1072)//мал буквы
                {
                    int letter = (int)charinputt[i] - (int)'а'; //смотрим номер в мал алфавите
                    int lastletter = (int)'я' - letter;//номер зашифрованного символа в кодировке
                    charinputt[i] = (char)lastletter;
                }
                output += charinputt[i];
            }
            return output;
        }
        public string Encode(string input)
        {         
            return MovingLetter(input);          
        }
        public string Decode(string output)
        {
           return MovingLetter(output);
        }
    }
}
