using System.Reflection.Metadata;
using System.Security.Claims;
using Ежедневник;

namespace ежедневник
{
    internal class Program
    {
        static void Main()
        {
            while (true)
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
                    if (da == 3)
                    {
                        vabor3();
                    }
                    if (da == 4)
                    {
                        vabor4();
                    }
                    if (da == 5)
                    {
                        vabor5();
                    }
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
            if (posit == 1)
            {
                Console.Clear();
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Полить цветы";
                opis1.opis = "Именно: незабудки, орхидею и розы";
                nomer1.nomer = "В первый день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 2)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Выгулить собаку";
                opis1.opis = "Не идти в парк днём, а пойти в лес";
                nomer1.nomer = "В первый день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 3)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Сделать домашнее задание";
                opis1.opis = "По дисциплинам: C#, Pyuton и Pascal";
                nomer1.nomer = "В первый день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        static void vabor2()
        {
            strelka();
            if (posit == 1)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Сделать домашнее задание";
                opis1.opis = "По дисциплинам: C#, Pyuton";
                nomer1.nomer = "2 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 2)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Сделать домашнее задание";
                opis1.opis = "По дисциплинам: Pascal";
                nomer1.nomer = "2 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 3)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Ничего не запланировано на это время";
                opis1.opis = "Свобода";
                nomer1.nomer = "2 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        static void vabor3()
        {
            strelka();
            if (posit == 1)
            {
                Console.Clear();
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Сходить в библиотеку";
                opis1.opis = "Взять книги Война и мир, Лолита и Русалочка";
                nomer1.nomer = "3 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 2)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Выгулить собаку";
                opis1.opis = "Не идти в парк днём,";
                nomer1.nomer = "3 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 3)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Сделать домашнее задание";
                opis1.opis = "По дисциплинам: Философия и литература";
                nomer1.nomer = "3 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        static void vabor4()
        {
            strelka();
            if (posit == 1)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Выполнить заказ";
                opis1.opis = "Нарисовать портртет девушки и парня, дедлайн через неделю";
                nomer1.nomer = "4 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 2)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "На это время ничего не запланировано";
                opis1.opis = "Свобода";
                nomer1.nomer = "4 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 3)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Заказ";
                opis1.opis = "Забрать посылку из почты";
                nomer1.nomer = "4 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        static void vabor5()
        {
            strelka();
            if (posit == 1)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Ничего не запланировано на это время";
                opis1.opis = "Свобода";
                nomer1.nomer = "5 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 2)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Сходить в магазин";
                opis1.opis = "Купить: Яйца, бекон, макороны,  сыр и помидоры";
                nomer1.nomer = "5 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            if (posit == 3)
            {
                dela sob1 = new dela();
                dela opis1 = new dela();
                dela nomer1 = new dela();
                sob1.sob = "Ничего не запланировано на это время";
                opis1.opis = "Свобода";
                nomer1.nomer = "5 день Октября";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sob1.sob);
                Console.WriteLine(opis1.opis);
                Console.WriteLine(nomer1.nomer);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }


    }
}