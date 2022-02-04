using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Arrays_Sort_04._02._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ArrayLenght;                     
            var rnd = new Random();
            ConsoleKeyInfo UserAnswer;

            Console.WriteLine("Введите количество чисел в массиве.");
            ArrayLenght = int.Parse(Console.ReadLine());
            int[] ArrayForSort = new int[ArrayLenght];

            Console.WriteLine("Заполнить случайно? Y - да / N - нет.");
            UserAnswer = Console.ReadKey();

            if (UserAnswer.Key == ConsoleKey.N)
            {           
            for (int i = 0; i < ArrayLenght;)               // Заставляем пользователя ввести корректные значения.
                {
                Console.WriteLine("\nВведите число:");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    ArrayForSort[i] = result;
                    i++;
                }
                else
                {
                    Console.WriteLine("Некорректное число. Повторите попытку.");
                }
            }
            }
            else if (UserAnswer.Key == ConsoleKey.Y)        // Генерируем случайно. 
            {
                for (int i = 0; i < ArrayLenght; i++)
                {
                    ArrayForSort[i] = rnd.Next(0,1000);
                }
            }
            else
            {
                Console.WriteLine("Ответ не распознан. Массив будет содержать случайные значения. ");
                for (int i = 0; i < ArrayLenght; i++)
                {                    
                    ArrayForSort[i] = rnd.Next(0, 1000);
                }
            }
            
            Console.WriteLine("\n\nВаш массив");
            foreach (int item in ArrayForSort)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n\nСортируем числа в массиве...");                 
            foreach (int item in Sort(ArrayForSort))
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }



        public static int[] Sort (int[] arrayin)
        {         
            for (var j = 0; j < arrayin.Length; j++)
            {
                for (int i = j; i < arrayin.Length; i++)
                {
                    int temp = arrayin[j];
                    if (temp < arrayin[i])              // Находим наибольшее значение
                    {
                        temp = arrayin[i];
                        arrayin[i] = arrayin[j];
                        arrayin[j] = temp;              // Переставляем его на место элемента j

                    }
                }      
            }

            return arrayin;
            
        }
    }
}
