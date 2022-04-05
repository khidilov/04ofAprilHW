using System;
using System.Collections.Generic;
using System.Text;

namespace UpDownCastingHomework
{
    public class EURO : Currency
    {
        public EURO(double Amount)
        {
            this.Amount = Amount;
        }

        //Comparing euro-usd
        public static implicit operator EURO(USD usd)
        {
            return new EURO(usd.Amount * 0.91);
        }

        //Converting euro-azn

        public static implicit operator EURO(AZN azn)
        {
            return new EURO(azn.Amount * 0.54);
        }

        //Comparing euro-azn
        public static bool operator >(EURO euro, AZN azn)
        {
            return euro.Amount > azn.Amount * 0.54;
        }
        public static bool operator <(EURO euro, AZN azn)
        {
            return euro.Amount < azn.Amount * 0.54;
        }

        //Comparing euro-usd
        public static bool operator >(EURO euro, USD usd)
        {
            return euro.Amount > usd.Amount * 0.91;
        }
        public static bool operator <(EURO euro, USD usd)
        {
            return euro.Amount > usd.Amount * 0.91;
        }
    }
}