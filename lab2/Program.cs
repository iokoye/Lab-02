using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueloop = true;

            while (continueloop = true)
            {
                Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

                Console.WriteLine("Enter Length:");
                var inputNumberlength = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                var inputNumberwidth = double.Parse(Console.ReadLine());

                Console.WriteLine("Perimeter:");
                var perimeter = (inputNumberlength * 2) + (inputNumberwidth * 2);
                Console.WriteLine(perimeter);

                Console.WriteLine("Area:");
                var area = (inputNumberlength) * (inputNumberwidth);
                Console.WriteLine(area);

                Console.WriteLine("Continue? (y/n):");
                string continuecommision = Console.ReadLine();
                if (continuecommision == "n")
                {
                    continueloop = false;
                    break;
                }
            }
        }
    }
}
