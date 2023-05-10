using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int arrayLenght = 30;
            int[] numbers = new int[arrayLenght];
            Random randomForArray = new Random();
            int lastIndex = numbers.Length - 1;

            Console.WriteLine("Для начала и проверки выводим наш массив: ");
            
            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = randomForArray.Next(arrayLenght);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\nТеперь перебираем его для поиска максимума: ");
            Console.ForegroundColor = ConsoleColor.Red;
            
            if (numbers[0] > numbers[1]) 
            {
                Console.Write(numbers[0] + " ");
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            if (numbers[lastIndex] > numbers[lastIndex - 1])
            {
                Console.WriteLine(numbers[lastIndex]);
            }

            Console.ReadKey();
        }
    }
}
