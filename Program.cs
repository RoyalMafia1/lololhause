﻿
namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Millist kujundit soovid?\n Kirjuta maja...");
            string valik = Console.ReadLine().ToLower();

            switch (valik)
            {
                case "maja":
                    MajaInfo();
                    break;
                default:
                    Console.WriteLine("Sellist kujundit ei ole valikus.");
                    break;
            }
        }

        static void MajaInfo()
        {
            Console.WriteLine("Sisesta ruudu külje pikkus:");
            int kylg = Convert.ToInt32(Console.ReadLine());

            int tahemarke = kylg + 2;

            for (int i = 0; i < tahemarke; i++)
            {
                for (int j = 0; j < tahemarke - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < kylg; i++)
            {
                for (int j = 0; j < kylg; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}

