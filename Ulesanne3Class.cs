using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtoo
{
    public class Ulesanne3Class
    {
        public static void MillineArv(string arv)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Дано M'значное число. Создать массив из его цифр, вывести на экран этот массив.           
            // Определить, является ли исходное число счастливым, то есть симметричным(123321), все цифры одинаковые(555555555) или расположены в порядке возраствния(56789)/убывания(987654321)?
 
            // Loo täisarvmassiiv ja teisenda iga tähemärk stringis 'arv' täisarvuks ja salvesta see massiivis 'numbrid'
            int[] numbrid = new int[arv.Length];
            for (int i = 0; i < arv.Length; i++)
            {
                numbrid[i] = int.Parse(arv[i].ToString());
            }

            Console.WriteLine("Arvede masiiv: " + string.Join(", ", numbrid));

            // Kontrollige, kas originaalstring 'arv' on sama, mis selle tagurdatud versioon
            bool summeetriline = arv == new string(arv.Reverse().ToArray());

            // Initsialiseerige lipp, et määrata, kas kõik numbrid on ühesugused
            bool uhesugused = true;
            for (int i = 1; i < numbrid.Length; i++)
            {
                if (numbrid[i] != numbrid[0])
                {
                    uhesugused = false;
                    break;
                }
            }

            // funktsioon, et määrata, kas numbrid on tõusvas järjekorras
            bool ulestousmine = true;
            for (int i = 0; i < numbrid.Length - 1; i++)
            {
                if (numbrid[i] > numbrid[i + 1])
                {
                    ulestousmine = false;
                    break;
                }
            }

            // funktsioon, et määrata, kas numbrid on laskuvas järjekorras
            bool laskumine = true;
            for (int i = 0; i < numbrid.Length - 1; i++)
            {
                if (numbrid[i] < numbrid[i + 1])
                {
                    laskumine = false;
                    break;
                }
            }

            if (summeetriline)
            {
                Console.WriteLine("Numbrid on sümmeetriline (õnnelik)");
            }
            else if (uhesugused)
            {
                Console.WriteLine("Kõik numbrid on ühesugused");
            }
            else if (ulestousmine)
            {
                Console.WriteLine("Numbrid asetsevad kasvamise järjekorras");
            }
            else if (laskumine)
            {
                Console.WriteLine("Numbrid asuvad kahanemise järjekorras");
            }
            else
            {
                Console.WriteLine("Arv ei ole sümmeetriline, ühesuguste numbritega ega korrastatud.");
            }


        }
    }
}
