using System.Reflection.Metadata;
using System.Security.Claims;
namespace ежедневник
{
    internal class Program
    {
        static void Main()
        {
            int da = 1;
            DateTime dates = new(2022, 10, da);
            Console.WriteLine(dates + " нажмите Enter, что бы выбрать дату, " +
                    "\n а потом нажмите на стрелку вверх или вниз что бы посмотрель заметку, \n" +
                    "а чтобы увидеть более подробную информацию, снова нажмите Enter");
            ConsoleKey date;
            do
            {
                date = Console.ReadKey(true).Key;
                Console.Clear();
                if (date == ConsoleKey.LeftArrow)
                {
                    da--;
                    if (da < 1)
                    {
                        da = 5;
                    }
                }
                else if (date == ConsoleKey.RightArrow)
                {
                    da++;
                    if (da > 5)
                    {
                        da = 1;
                    }
                }
                DateTime dats1 = new(2022, 10, da);
                Console.WriteLine(dats1 + " нажмите Enter, что бы выбрать дату, " +
                    "\n а потом нажмите на стрелку вверх или вниз что бы посмотрель заметку, \n" +
                    "а чтобы увидеть более подробную информацию, снова нажмите Enter");
            }
            while (date != ConsoleKey.Enter);
            {
                if (da == 1)
                {
                    vabor();
                }
                if (da == 2)
                {
                    vabor2();

                }
            }

        }
        static int posit = 2;
        static void strelka()
        {

            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    if (posit < 3)
                    {
                        posit++;
                    }
                }
                else
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    if (posit > 1)
                    {
                        posit--;
                    }
                }
                Console.Clear();

                Console.WriteLine("На какое время");
                Console.WriteLine("  Утро");
                Console.WriteLine("  День");
                Console.WriteLine("  Вечер");
                Console.SetCursorPosition(0, posit);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
            }
        }
        static void vabor()
        {
            strelka();
            string[] num = new string[] { "Полить цветы", "Сходить в библиотеку", "Сделать домашку" };
            if (posit == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(num[0]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(num[1]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(num[2]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Main();

        }
        static void vabor2()
        {
            strelka();
            string[] num = new string[] { "Выгулить собаку", "Посмотреть фильм -Веном- ", "" };
            if (posit == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(num[0]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(num[1]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Main();

        }
    }
}