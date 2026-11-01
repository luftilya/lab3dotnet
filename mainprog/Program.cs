using System;
namespace mainprog;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        string? choosed_task;
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Лабораторная работа №3. Выполнена Ильей Зеленевым и Станиславом Сахаровым, бТИИ-251.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Меню заданий.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~2) Среди заданных чисел найти количество двухзначных чисел.");
            Console.WriteLine("~3) Даны целые числа К и N(N> 0). Вывести N раз число К.");
            Console.WriteLine("~4) Найти количество чисел в этой последовательности.");
            Console.WriteLine("~5) Найти сумму бесконечного ряда.");
            Console.WriteLine("~6) Табулирование функции.");
            Console.WriteLine("~7) Найти среднее арифметическое четных цифр числа.");
            Console.WriteLine("~8) Найти сумму факториалов.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Для выбора заданий нужно выбрать его номер, ввести и нажать ENTER на клавиатуре.");
            
            choosed_task = Console.ReadLine();
            
            switch (choosed_task)
            {
                case "2":
                    {
                        while (true)
                        {
                            var count = 0;

                            Console.Clear();
                            Console.WriteLine("Среди заданных чисел найти кол-во двузначных.");
                            Console.WriteLine("Введите строку с числами через пробел, оканчивающуюся ПРОБЕЛОМ. Для выхода нажмите Enter.");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.Write("~ Введите последовательность: ");
                            
                            string? numbers = Console.ReadLine();
                            
                            if (string.IsNullOrWhiteSpace(numbers))
                                break;

                            var double_digit = "";

                            for (int i = 0; i < numbers.Length; i++)
                                if (numbers[i] >= '0' && numbers[i] <= '9' || numbers[i] == '-')
                                    double_digit += numbers[i];
                                else
                                    if (!string.IsNullOrWhiteSpace(double_digit) && (double_digit.Length == 2 || (double_digit[0] == '-' && double_digit.Length == 3)))
                                    {
                                        ++count;
                                        double_digit = "";
                                    }

                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine($"~ Кол-во двузначных ч: {count}");
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

                            string? input = Console.ReadLine();

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

                            string? input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                            int i = 0, c = 0;
                            string n = "";

                            while (input is not null && i < input.Length)
                            {
                                if ((input[i] >= '1' && input[i] <= '9') || input[i] == '-')
                                    n += input[i];
                                else if (n != "")
                                {
                                    c++;
                                    n = "";
                                }

                                i++;
                            }

                            Console.WriteLine($"~ Кол-во чисел: {c}");
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
                default:
                    Console.WriteLine($"Вы ввели {choosed_task}, а такого задания нет!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}