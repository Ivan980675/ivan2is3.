using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class32
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string inputString = Console.ReadLine();
            string convertedString = ConvertString(inputString);
            Console.WriteLine("Результат: " + convertedString);
            Console.WriteLine("Введите число (до 1000):");
            int number = int.Parse(Console.ReadLine());
            PrintNumbers(number);
            int[] array = new int[5];
            Console.WriteLine("Введите пять элементов массива:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Массив в обратном порядке:");
            PrintArrayReverse(array);
        }
        static string ConvertString(string inputString)
        {
            string result = "";
            bool capitalize = true;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (capitalize)
                {
                    result += char.ToUpper(inputString[i]);
                }
                else
                {
                    result += inputString[i];
                }
                capitalize = !capitalize;
            }
            return result;
        }
        static void PrintNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrintArrayReverse(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }

}