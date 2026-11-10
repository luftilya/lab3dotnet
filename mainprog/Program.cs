using System;
using wonderful_numbers_tools;
namespace mainprog;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Лабораторная работа №3. Выполнена Ильей Зеленевым и Станиславом Сахаровым, бТИИ-251, вариант 1.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~2) Среди заданных чисел найти количество двухзначных чисел.");
            Console.WriteLine("~3) Даны целые числа К и N(N> 0). Вывести N раз число К.");
            Console.WriteLine("~4) Найти количество чисел в этой последовательности.");
            Console.WriteLine("~5) Найти сумму бесконечного ряда.");
            Console.WriteLine("~6) Табулирование функции.");
            Console.WriteLine("~7) Найти среднее арифметическое четных цифр числа.");
            Console.WriteLine("~8) Найти сумму факториалов.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Для выбора заданий нужно выбрать его номер, ввести и нажать ENTER на клавиатуре: ");

            string? input = Console.ReadLine();
            
            switch (input)
            {
                case "2":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Среди заданных чисел найти кол-во двузначных.");
                            Console.WriteLine("Введите строку с числами через пробел. Для выхода нажмите Enter.");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.Write("~ Введите последовательность: ");

                            input = Console.ReadLine();
                            
                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine($"~ Кол-во двузначных ч: {NumbersTools.HowMuchDoubleDigitsNumbers(input, ' ')}.");
                            Console.ReadKey();
                        }
                        break;
                    }
                case "3":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Даны целые K и N (N>0). Вывести N раз число K.");
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            Console.Write("! Введите целое число K: ");

                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            if (!int.TryParse(input, out int K))
                            {
                                Console.Write($"Ошибка! Вы ввели {input}, а нужно ввести число! Попробуйте ещё раз ввести число K. Для продолжения нажмите Enter.");
                                Console.ReadLine();
                                continue;
                            }

                            Console.Write("! Введите целое число N: ");

                            input = Console.ReadLine();

                            if (!int.TryParse(input, out int N))
                            {
                                Console.Write($"Ошибка! Вы ввели {input}, а нужно ввести число! Попробуйте ещё раз ввести число N. Для продолжения нажмите Enter.");
                                Console.ReadKey();
                                break;
                            }

                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

                            for (int i = 0; i < N; i++)
                                Console.WriteLine($"!{K}. Напечатано {i + 1} раз.\n^");
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            Console.ReadKey();
                        }
                        break;
                    }
                case "4":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Дана последовательность целых чисел, оканчивающаяся нулём.");
                            Console.WriteLine("Необходимо найти количество чисел в этой последовательности.");
                            Console.WriteLine("Ноль числом последовательности не считается.");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.Write("~ Дайте последовательность целых чисел: ");

                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine($"~ Кол-во чисел: {NumbersTools.HowMuchNumbers(input)}");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.ReadKey();
                        }
                        break;
                    }
                case "5":
                        Application.Run(new FormOf5());
                        break;
                case "6":
                        Application.Run(new FormOf6());
                        break;
                case "7":
                        Application.Run(new FormOf7());
                        break;
                case "8":
                        Application.Run(new FormOf8());
                        break;
            }
        }
    }
}