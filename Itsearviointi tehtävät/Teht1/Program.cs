﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä sana tai lause");
            string virke = Console.ReadLine();

            for (int i = 0; i < 5; i++ )
            {
                Console.WriteLine($"{i}. {virke}");
            }
            Console.ReadLine();
        }
    }
}
