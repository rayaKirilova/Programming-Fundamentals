﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int lenght = input.Length;
                int mainDigit = int.Parse(input) % 10;
                int offset = 0;
                char s = '\0';

                if (mainDigit == 0)
                {
                    s = ' ';
                }
                else
                {
                    offset = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                        offset++;

                    int index = offset + lenght - 1;
                    s = (char)(97 + index);
                }
                message += s;
            }
            Console.WriteLine(message);
        }
    }
}
