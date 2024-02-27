using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompPractic24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Задача 1. Определить, имеется ли в массиве случайных чисел элемент, значение которого равно значению первого элемента одномерного массива. Если такой элемент имеется, вывести на экран его порядковый номер. Массив состоит из шести элементов.
            /*
            int[] omas = new int[6];
            Random rnd = new Random();

            for (int i = 0; i < omas.Length; i++)
            {

                omas[i] = rnd.Next(10);

            }

            for (int i = 1; i < omas.Length; i++) 
            {

                if (omas[0] == omas[i]) { Console.WriteLine($"Его порядковый номер - {i}"); }

            }
            */



            //Задача 2. Дан одномерный массив. Вывести:
            /*
            int[] omas = new int[10] { 5, -3, 4, 129, -9, 143, 9, 6, -7, 54 };

            //а) все неотрицательные элементы;
            for (int i = 0; i < omas.Length; i++)
            {
                if (omas[i] > 0)
                    Console.WriteLine(omas[i]);
            }

            //б) все элементы, не превышающие число 100;
            for (int i = 0; i < omas.Length; i++)
            {
                if (omas[i] < 100)
                    Console.WriteLine(omas[i]);
            }

            //в) все четные элементы.
            for (int i = 0; i < omas.Length; i++)
            {
                if (omas[i] % 2 == 0)
                    Console.WriteLine(omas[i]);
            }
            */

            //Задача 3. Заполнить одномерный массив без использования клавиатуры следующими значениями: 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2. Подсчитать количество отрицательных элементов.
            /*
            int[] omas = new int[] { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            int count = 0;
            for (int i = 0; i < omas.Length; i++)
            {
                if (omas[i] < 0) {
                
                    count++;
                }
            }
            
            Console.WriteLine($"Кол-во отрицательных чисел - {count}");
            */



            //Задача 4. Составьте программу вычисления среднего арифметического элементов с нечетными номерами.
            /*
            int[] omas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            int count = 0;

            for (int i = 0; i < omas.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += omas[i];
                    count++;
                }
            }

            Console.WriteLine($"Среднее арифметическое элементов с нечетными номерами: {(double)sum / count}");
            */


            //Задача 5. Составьте программу увеличения всех элементов массива в 5 раз.
            int[] omas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = omas[i]*5;
                Console.WriteLine(omas[i]);
            }

                

            Console.ReadKey();
        }
    }
}
