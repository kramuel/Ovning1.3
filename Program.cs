using System;

namespace Ovning1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            double d;
            double a;
            double o;

            Console.WriteLine("Ange cirkelns diameter:  ");
            userInput = Console.ReadLine();
            d = Convert.ToDouble(userInput);

            double r = d / 2;

            o = d * 3.14;
            a = (r * r) * 3.14;

            Console.WriteLine(".... Omkretsen är :  " + o.ToString("F2"));
            Console.WriteLine(".... Arean är :  " + a.ToString("F2"));

            Console.ReadKey();
        }
    }
}
