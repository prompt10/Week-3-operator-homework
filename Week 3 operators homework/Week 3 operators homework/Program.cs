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
            Console.Write("Who do you work for? FULL CAP ALL SHORTEN PLEASE: ");
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

            //Console.WriteLine("your first digit is {0}", _6thDigit);
            //Console.WriteLine("your second digit is {0}", _5thDigit);
            //Console.WriteLine("your third digit is {0}", _4thDigit);
            //Console.WriteLine("your forth digit is {0}", _3rdDigit);
            //Console.WriteLine("your fifth digit is {0}", _2ndDigit);
            //Console.WriteLine("your sixth digit is {0}", _1stDigit);

            if (affiliate == "CIA" && (_1stDigit%3==0) && (_2ndDigit != 1) && (_2ndDigit != 3) && (_2ndDigit != 5) && (_4thDigit >=6) && (_4thDigit != 8) )
            {
                Console.Write("True, Access Granted");
            }
            else if (affiliate == "FBI" && _6thDigit>3 && _6thDigit<8 && (_3rdDigit%2==0) && _3rdDigit!=6 && _5thDigit%2!=0 )
            {
                Console.Write("True, Access Granted");
            }
            else if (affiliate == "NSA" && 30%_1stDigit==0 && _3rdDigit%3==0 && _3rdDigit%2!=0 && ( _1stDigit==7 || _2ndDigit == 7 || _3rdDigit == 7 || _4thDigit == 7 || _5thDigit == 7 || _6thDigit ==7 ) )
            {
                Console.Write("True, Access Granted");
            }
            else if (_6thDigit>9)
            {
                Console.Write("False, Access Denied");
            }
            else
            {
                Console.Write("False, Access Denied");
            }
        }
    }
}
