using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_3_operators_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string affiliate;
            double password;
            string Input1;
            Console.Write("Please input your password: ");
            Input1 = Console.ReadLine();
            Console.Write("Who do you work for?: ");
            affiliate = Console.ReadLine();

            password = int.Parse(Input1);
            double _6thDigit = password / (Math.Pow(10, 6));
            double _5thDigit = ((password - (_6thDigit * Math.Pow(10,6))) / Math.Pow(10,5));
            double _4thDigit = ((password - ((_6thDigit * Math.Pow(10, 6)) + (_5thDigit * Math.Pow(10, 5))  )) / Math.Pow(10, 4));
            double _3rdDigit = ((password - ((_6thDigit * Math.Pow(10, 6)) + (_5thDigit * Math.Pow(10, 5)) + (_4thDigit * Math.Pow(10, 4)))) / Math.Pow(10, 3));
            double _2ndDigit = ((password - ((_6thDigit * Math.Pow(10, 6)) + (_5thDigit * Math.Pow(10, 5)) + (_4thDigit * Math.Pow(10, 4)) + (_3rdDigit * Math.Pow(10, 3)))) / Math.Pow(10, 2));
            double _1stDigit = ((password - ((_6thDigit * Math.Pow(10, 6)) + (_5thDigit * Math.Pow(10, 5)) + (_4thDigit * Math.Pow(10, 4)) + (_3rdDigit * Math.Pow(10, 3)) + (_2ndDigit * Math.Pow(10, 2)))) / Math.Pow(10, 2));


        }
    }
}
