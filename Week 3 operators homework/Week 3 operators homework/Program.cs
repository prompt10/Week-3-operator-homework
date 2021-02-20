using System;

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

        }
    }
}
