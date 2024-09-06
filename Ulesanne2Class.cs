using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Iseseisevtoo
{
    public class Ulesanne2Class
    {
        public static void SortMasiiv(int[] masiiv)
        {

            Console.OutputEncoding = Encoding.UTF8;

            //Ü 2. Задан одномерный массив целых чисел, заполненый случайным образом. Образуйте из него два отсортированных по возрастанию массива, содержащих четные и нечетные числа. Подсказка: четное число делится на 2 без остатка. 

            // luua massiivid, mis sisaldavad ainult paaris või paarituid numbreid
            int[] paarisMasiiv = masiiv.Where(x => x % 2 == 0).ToArray();
            int[] paarituMasiiv = masiiv.Where(x => x % 2 != 0).ToArray();

            // Masiivi sorteerimine
            Array.Sort(paarisMasiiv);
            Array.Sort(paarituMasiiv);

            Console.WriteLine("Paaris numbrid: " + string.Join(", ", paarisMasiiv));
            Console.WriteLine("Paaritu numbrid: " + string.Join(", ", paarituMasiiv));
        }
    }
}
