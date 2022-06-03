using System;

namespace syntax_sugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 8;
            string response;
            if (a > 10)
            {
                Console.WriteLine($" {a} is greater than 10");

            }
            else
            {
                Console.WriteLine($" {a} is less than 10");
            }


            //var a = 10;
           
            //var response = (a > 9) ? $" {a} is greater than 9" : $"{a} is less than 9";
            //Console.WriteLine(response);

            

        }
    }
}
