﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите количество гвоздей");
            int Nails = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите количество ударов на гвоздь");
            int Strike = int.Parse(Console.ReadLine());
            int HammeredNails = 0;
            do
            {
                Console.WriteLine("Берем гвоздь");
                for (int i = 0; i < Strike; i++)
                {
                    Console.WriteLine("Бьем по гвоздю 1 раз");
                }
                HammeredNails++;
                Console.WriteLine("Гвоздь забит");
            }
            while (HammeredNails < Nails);
            Console.WriteLine("Все гвозди забиты");
        }
    }
}
