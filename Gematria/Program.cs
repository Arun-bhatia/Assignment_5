using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gematria
{
    class Program
    {
        string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        static void Main(string[] args)
        {
            //writing the gemetria algorithm
            Program p = new Program();
            Console.WriteLine(p.Gemetria("universe"));

        }
        public  int Gemetria(string word)
        {
            int gematriaValue = 0;
            for(int i=0;i<word.Length;i++)
            {
                gematriaValue += letterValue(word[i].ToString());
            }
            return gematriaValue;
        }

        private  int letterValue(string v)
        {
            int x = 0;
            while (letters[x] != v)
            {
                if (letters[x++] == v)
                    return x;
            }
            return x;
        }
    }
    
}
