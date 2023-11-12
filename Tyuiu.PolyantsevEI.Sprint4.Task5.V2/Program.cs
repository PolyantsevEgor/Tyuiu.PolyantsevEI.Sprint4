using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PolyantsevEI.Sprint4.Task5.V2.Lib;

namespace Tyuiu.PolyantsevEI.Sprint4.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService dataService = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Полянцев Е. И. | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Полянцев Егор Ильич | ИСТНб-23-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -7 до 5.                          *");
            Console.WriteLine("* Найти количество отрицательных элементов.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] numsArray = new int[rows, columns];

            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numsArray[i, j] = rnd.Next(-7, 5);
                }
            }

            Console.Write("Массив:{ ");
            for (int i = 0; i < numsArray.GetUpperBound(0) + 1; i++)
            {
                if (i != 0) { Console.Write("\t "); }
                Console.Write("{");
                for (int j = 0; j < numsArray.Length / (numsArray.GetUpperBound(0) + 1); j++)
                {
                    Console.Write(numsArray[i, j]);
                    if (j != numsArray.GetLength(0) - 1) { Console.Write(", "); }
                }
                Console.Write("}");
                if (i != numsArray.GetLength(0) - 1) { Console.WriteLine(","); }
            }
            Console.WriteLine("}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = dataService.Calculate(numsArray);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
