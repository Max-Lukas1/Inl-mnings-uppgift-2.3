using System;
namespace inlämningsuppgift_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du köra?");
            string dagar = Console.ReadLine();
            Console.WriteLine("Hur många kilometer ska du köra?");
            string Kilometer = Console.ReadLine();
            int Kilometers = int.Parse(Kilometer);
            int dagars = int.Parse(dagar);
            int svar = dagars * 500 + 300 + Kilometers;
            Console.WriteLine(svar + " kr");
        }
    }
}

