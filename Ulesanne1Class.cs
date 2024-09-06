using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Iseseisevtoo
{
    public class Ulesanne1Class
    {
        public static (int sonaCount, int tuhikCount) ArvestamineSonaTuhik(string tekst)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //В заданной строке текста определите количество слов. Каждое слово отделено друг от друга пробелом. Посчитать кол-во слов и пробелов в тексте. 
            int sonaCount = 0;
            int tuhikCount = 0;
            bool sõnaAlgus = true;

            //funktsioon, mis loeb sisendstringi ja arvutab tühikuid ja sõnu
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == ' ')
                {
                    tuhikCount++;
                    sõnaAlgus = true;
                }
                else
                {
                    if (sõnaAlgus)
                    {
                        sonaCount++;
                    }
                    sõnaAlgus = false;
                }
            }

            return (sonaCount, tuhikCount);

        }       
    }
}
