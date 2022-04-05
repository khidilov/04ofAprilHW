using System;

namespace UpDownCastingHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            USD usdV = new USD(100);
            AZN aznV = new AZN(171);
            Console.WriteLine(aznV > usdV);

            AZN azn = new AZN(150);
            USD usd = azn;
            Console.WriteLine("usd = " + usd.Amount);
            EURO euro = azn;
            Console.WriteLine("euro = " + euro.Amount);


        }
    }
}