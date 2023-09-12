using System;

namespace Mod_2_3
{
    class Program
    {
        static string Day_Of_Week(int b)
        {
            if (b == 1)
            {
                return "Понедельник";
            }
            else if (b == 2)
            {
                return "Втор��ик";
            }
            else if (b == 3)
            {
                return "Среда";
            }
            else if (b == 4)
            {
                return "Четверг";
            }
            else if (b == 5)
            {
                return "Пятница";
            }
            else if (b == 6)
            {
                return "Суббота";
            }
            else if (b == 7)
            {
                return "Воскресенье";
            }
            else
            {
                return "Введите число от 1 до 7";
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер дня недели: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = Day_Of_Week(a);
            Console.WriteLine(b);
        }
    }
}
