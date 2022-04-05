using System;
using System.Collections.Generic;
using System.Text;

namespace UpDownCastingHomework
{
    public class USD : Currency
    {
        public USD(double Amount)
        {
            this.Amount = Amount;
        }

        //Converting usd-azn
        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.Amount * 1.7);
        }

        //Converting usd-euro
        public static implicit operator USD(EURO euro)
        {
            return new USD(euro.Amount * 1.10);
        }

        //Comparing usd-azn
        public static bool operator >(USD usd, AZN azn)
        {
            return usd.Amount > azn.Amount * 1.7;
        }
        public static bool operator <(USD usd, AZN azn)
        {
            return usd.Amount < azn.Amount * 1.7;
        }

        //Comparing usd-euro
        public static bool operator >(USD usd, EURO euro)
        {
            return usd.Amount > euro.Amount * 1.10;
        }
        public static bool operator <(USD usd, EURO euro)
        {
            return usd.Amount < euro.Amount * 1.10;
        }
    }
}