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
            int password;
            string Input1;
            Console.Write("Please input your password: ");
            Input1 = Console.ReadLine();
            Console.Write("Who do you work for?: ");
            affiliate = Console.ReadLine();

            password = int.Parse(Input1);
            //double _6thDigit = password / (Math.Pow(10, 5));
            //double _5thDigit = ((password - (_6thDigit * Math.Pow(10,5))) / Math.Pow(10,4));
            //double _4thDigit = ((password - ((_6thDigit * Math.Pow(10, 5)) + (_5thDigit * Math.Pow(10, 4))  )) / Math.Pow(10, 3));
            //double _3rdDigit = ((password - ((_6thDigit * Math.Pow(10, 5)) + (_5thDigit * Math.Pow(10, 4)) + (_4thDigit * Math.Pow(10, 3)))) / Math.Pow(10, 2));
            //double _2ndDigit = ((password - ((_6thDigit * Math.Pow(10, 5)) + (_5thDigit * Math.Pow(10, 4)) + (_4thDigit * Math.Pow(10, 3)) + (_3rdDigit * Math.Pow(10, 2)))) / Math.Pow(10, 1));
            //double _1stDigit = ((password - ((_6thDigit * Math.Pow(10, 5)) + (_5thDigit * Math.Pow(10, 4)) + (_4thDigit * Math.Pow(10, 3)) + (_3rdDigit * Math.Pow(10, 1)) + (_2ndDigit * Math.Pow(10, 2)))) );

            int _6thDigit = password / (100000);
            int _5thDigit = ((password - (_6thDigit * 100000)) / 10000);
            int _4thDigit = ((password - ((_6thDigit * 100000) + (_5thDigit * 10000))) / 1000);
            int _3rdDigit = ((password - ((_6thDigit * 100000) + (_5thDigit * 10000) + (_4thDigit * 1000))) / 100);
            int _2ndDigit = ((password - ((_6thDigit * 100000) + (_5thDigit * 10000) + (_4thDigit * 1000) + (_3rdDigit * 100))) / 10);
            int _1stDigit = ((password - ((_6thDigit * 100000) + (_5thDigit * 10000) + (_4thDigit * 1000) + (_3rdDigit * 100) + (_2ndDigit * 10))));

            Console.WriteLine("your first digit is {0}", _6thDigit);
            Console.WriteLine("your second digit is {0}", _5thDigit);
            Console.WriteLine("your third digit is {0}", _4thDigit);
            Console.WriteLine("your forth digit is {0}", _3rdDigit);
            Console.WriteLine("your fifth digit is {0}", _2ndDigit);
            Console.WriteLine("your sixth digit is {0}", _1stDigit);
        }
    }
}
