using System;

namespace Repetiton
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num;
            string input2;
            int counter =0;



            Console.WriteLine("how many repeats");
            input2 = Console.ReadLine();

            num = int.Parse(input2);
            
            

            while ( counter < num ) {
            Console.WriteLine("Name");
            input = Console.ReadLine();
            }

            System.Console.WriteLine("goodbye");

        }
    }
}
