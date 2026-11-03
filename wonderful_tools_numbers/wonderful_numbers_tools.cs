using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wonderful_numbers_tools
{
    public static class NumbersTools
    {
        public static int HowMuchDoubleDigitsNumbers(string numbers_string)
        {
            int count = 0;

            string[] numbers = numbers_string.Split(' ');

            foreach (string number in numbers)
                if (int.TryParse(number, out int value))
                    if ((value >= 10 && value <= 99) ||
                        (value <= -10 && value >= -99))
                        ++count;

            return count;
        }

        public static int HowMuchNumbers(string numbers_string)
        {
            int i = 0, c = 0;
            string n = "";

            while (i < numbers_string.Length)
            {
                if ((numbers_string[i] >= '1' && numbers_string[i] <= '9') || numbers_string[i] == '-')
                    n += numbers_string[i];
                else if (n != "")
                {
                    c++;
                    n = "";
                }

                i++;
            }

            return c;
        }

        public static double FindRowSum(double eps)
        {
            double sum = 0, mem = 1,

                f = 1;
            int n = 2;

            while (mem >= eps)
                sum += mem = 1.0 / Math.Sqrt(f *= n++);

            return sum;
        }

        public static double TabulateFunc(double step, ListBox listBox)
        {
            double sum = 0;

            for (double i = 0; i <= 6; i += step)
            {
                if (Math.Abs(i - 2) < 1e-9)
                    continue;

                double expr = 2 * Math.Pow(i - 2, 2) * (8 - i) - 1;

                if (expr < 0)
                    continue;

                double mem = Math.Sqrt(expr);

                sum += Math.Sqrt(expr);

                listBox.Items.Add("x(" + (listBox.Items.Count + 1) + ") = " + mem.ToString());
            }

            return sum;
        }

        public static double AverangeEvenNumbers(string number)
        {
            var digits = new List<int>();

            foreach (var digit in number)
                if (char.IsDigit(digit)
                    && (digit - '0') % 2 == 0)
                    digits.Add(digit - '0');

            return digits.Count > 0 ? digits.Average() : 0;
        }

        public static long SumFacts(int n)
        {
            long sum = 0, mem = 1;

            for (int i = 1; i <= n; i++)
                sum += mem *= i;

            return sum;
        }
    }
}
