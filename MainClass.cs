using System;
using System.Text;
namespace Iseseisevtoo
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.OutputEncoding = Encoding.UTF8;

            //Ülesanne 1
            //В заданной строке текста определите количество слов. Каждое слово отделено друг от друга пробелом. Посчитать кол-во слов и пробелов в тексте. 

            Console.WriteLine("Sisesta suvalised sõnad läbi tühiku:");
            string tekst = Console.ReadLine();

            var result = Ulesanne1Class.ArvestamineSonaTuhik(tekst);

            Console.WriteLine($"Sõnade arv: {result.sonaCount}");
            Console.WriteLine($"Tühide arv: {result.tuhikCount}");

            //Ülesanne 2
            //Задан одномерный массив целых чисел, заполненый случайным образом. Образуйте из него два отсортированных по возрастанию массива, содержащих четные и нечетные числа. Подсказка: четное число делится на 2 без остатка.

            int size = 20; 
            int[] masiiv = new int[size];

            for (int i = 0; i < size; i++)
            {
                masiiv[i] = random.Next(1, 101); 
            }

            Ulesanne2Class.SortMasiiv(masiiv);

            //Ülesanne 3
            // Дано M'значное число. Создать массив из его цифр, вывести на экран этот массив.
            // Определить, является ли исходное число счастливым, то есть симметричным(123321), все цифры одинаковые(555555555) или расположены в порядке возраствния(56789)/убывания(987654321)?

            Console.WriteLine("Sisesta teie arv: ");
            string arv = Console.ReadLine();

            Ulesanne3Class.MillineArv(arv);

        }
    }
}