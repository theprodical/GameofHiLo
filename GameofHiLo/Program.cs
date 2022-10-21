﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameofHiLo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hi-Lo");
            Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
            HiLoGame.Hint();

            while (HiLoGame.GetPot() > 0)
            {
                Console.WriteLine("Press h for higher, l for lower, ? to buy a hint,");
                Console.WriteLine($" or any other key to quit with {HiLoGame.GetPot()}. ");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'h') HiLoGame.Guess(true);
                else if (key == 'l') HiLoGame.Guess(false);
                else if (key == '?') HiLoGame.Hint();
                else return;
            }
            Console.WriteLine("The pot is empty!!! Bye.");
        }
    }
}
