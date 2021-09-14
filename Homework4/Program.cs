/*Создать массив на N элементов, где N указывается с консольной строки.
 * Заполнить его случайными числами от 1 до 26 включительно.
 * Создать 2 массива, где в 1 массиве будут значение только четных значений, а во втором нечетных.
 * Заменить числа в 1 и 2 массиве  на буквы английского алфавита.
 * Значения ячеек этих массивов равны порядковому номеру каждой буквы в алфавите.
 * Если же буква является одной из списка (a, e, i, d, h, j) то она должна быть в верхнем регистре.
 * Вывести на экран результат того, в каком из массивов будет больше букв в верхнем регистре.
 * Вывести оба массива на экран. Каждый из массивов должен быть выведен 1 строкой, где его значения будут разделены пробелом.
*/
namespace Homework4
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(" \n 1) Введите количество элементов массива N = ");

            int n = Convert.ToInt32(Console.ReadLine());
            int min = 1;
            int max = 26;
            char[] mass = new char[27];
            char[] letters = new char[27] { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string str = new string(letters);
            string replaceStr = str.Replace("a", "A")
                    .Replace("e", "E")
                    .Replace("i", "I")
                    .Replace("d", "D")
                    .Replace("h", "H")
                    .Replace("j", "J");
            int[] array = new int[n];
            int[] oddArray = new int[array.Length];
            int[] evenArray = new int[array.Length];

            // Заполнить массив случайными числами от 1 до 26 включительно.
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(min, max);
            }

            Console.WriteLine(" \n 2) Массив, заполненный рандомными числами: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t" + array[i]);
            }

            ArraysEvenOdd(array, evenArray, oddArray, n, letters, mass);
            ReplaceNumbers(evenArray, oddArray, n, mass, letters, str, replaceStr);
            Console.ReadKey();
        }

        // Создать 2 массива, где в 1 массиве будут значение только четных значений, а во втором нечетных.
        public static void ArraysEvenOdd(int[] array, int[] evenArray, int[] oddArray, int n, char[] letters, char[] mass)
        {
            int i, j = 0, k = 0;
            for (i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenArray[j] = array[i];
                    j++;
                }
                else
                {
                    oddArray[k] = array[i];
                    k++;
                }
            }

            Console.WriteLine(" \n 3) Массив, который содержит четные значения: ");
            for (i = 0; i < j; i++)
            {
                Console.Write("\t" + evenArray[i]);
            }

            Console.WriteLine(" \n 4) Массив, который содержит нечетные значения: ");
            for (i = 0; i < k; i++)
            {
                Console.Write("\t" + oddArray[i]);
            }
        }

        /*Заменить числа в 1 и 2 массиве на буквы английского алфавита.
        * Значения ячеек этих массивов равны порядковому номеру каждой буквы в алфавите.
        * Если же буква является одной из списка(a, e, i, d, h, j) то она должна быть в верхнем регистре.
        * Вывести на экран результат того, в каком из массивов будет больше букв в верхнем регистре.
        * Вывести оба массива на экран.Каждый из массивов должен быть выведен 1 строкой, где его значения будут разделены пробелом.*/
        public static void ReplaceNumbers(int[] evenArray, int[] oddArray, int n, char[] mass, char[] letters, string str, string replaceStr)
        {
            int i, j = 0;
            for (i = 0; i < n; i++)
            {
                if (evenArray[i] % 2 == 0)
                {
                    mass[j] = letters[i];
                    j++;
                }
                else if (oddArray[i] % 2 != 0)
                {
                    mass[j] = letters[i];
                    j++;
                }
            }

            int d = 0;
            Console.WriteLine(" \n 5) Замена чисел на буквы английского алфавита в массиве с четными элементами, " +
                "при этом буквы (a, e, i, d, h, j) должны быть в верхнем регистре: ");
            for (i = 0; i < j; i++)
            {
                d = i;
                Console.Write("\t" + replaceStr[evenArray[d]]);
            }

            int p = 0;
            Console.WriteLine(" \n 6) Замена чисел на буквы английского алфавита в массиве с нечетными элементами, " +
                "при этом буквы (a, e, i, d, h, j) должны быть в верхнем регистре: ");
            for (i = 0; i < j; i++)
            {
                p = i;
                Console.Write("\t" + replaceStr[oddArray[p]]);
            }

            /*Вывести на экран результат того, в каком из массивов будет больше букв в верхнем регистре.
            * Вывести оба массива на экран.Каждый из массивов должен быть выведен 1 строкой, где его значения будут разделены пробелом.*/
            int countEven = 0;
            for (i = 0; i < j; i++)
            {
                d = i;
                if (char.IsUpper(replaceStr[evenArray[d]]))
                {
                    countEven++;
                }
            }

            Console.WriteLine(" \n 7) Количество букв в верхнем регистре массива с четными значениями : " + countEven);

            int countOdd = 0;
            for (i = 0; i < j; i++)
            {
                p = i;
                if (char.IsUpper(replaceStr[oddArray[p]]))
                {
                    countOdd++;
                }
            }

            Console.WriteLine(" \n 8) Количество букв в верхнем регистре массива с нечетными значениями : " + countOdd);
        }
    }
}