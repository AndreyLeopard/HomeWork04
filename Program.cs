using System;
using System.Globalization;
using MyLib;


namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void FillArray(int[] array, int minValue = -9, int maxValue = 9)
            {
                maxValue++;
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(minValue, maxValue);
                }
            }

            void Print(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }


            void Task25()
            {
                /* Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
                                3, 5 -> 243 (3⁵)
                                2, 4 -> 16 */


                int a = MyLibClass.Input("Введите число возводимое в степень: ");
                int b = MyLibClass.Input("Введите степень числа: ");

                int result = 1;


                for (int i = 1; i <= b; i++)
                {
                    result *= a;
                }
                Console.WriteLine($"Решение: {a}*{b} = {result}");
            }


            void Task27()
            {
                /* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
                                452 -> 11
                                82 -> 10
                                9012 -> 12 */
                int number = MyLibClass.Input("Введите число сложения суммы цифр: ");
                int sum = 0;


                Console.Write($"Сумма цифр числа {number} равна ");
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                Console.WriteLine(sum);
            }


            void Task29()
            {
                /* Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
                                -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
                                6, 1, -33 -> [1, 6, -33] */
                int size = MyLibClass.Input("Введите целое число размера массива для сортировки по модулю: ");
                int[] numbers = new int[size];
                FillArray(numbers);
                Print(numbers);


                int lastIndex = numbers.Length - 1;
                for (int i = 0; i < lastIndex - 1; i++)
                {
                    for (int k = 0; k < lastIndex - i; k++)
                    {
                        if (Math.Abs(numbers[k]) > Math.Abs(numbers[k + 1]))
                        {
                            int temp = numbers[k];
                            numbers[k] = numbers[k + 1];
                            numbers[k + 1] = temp;
                        }
                    }
                }
                Console.WriteLine();
                Print(numbers);
            }

            Console.Clear();
            Task29();


        }
    }
}
