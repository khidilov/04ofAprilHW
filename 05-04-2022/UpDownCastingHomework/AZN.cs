using System;
using System.Collections.Generic;
using System.Text;

namespace UpDownCastingHomework
{
    public class AZN : Currency
    {
        public AZN(double Amount)
        {
            this.Amount = Amount;
        }

        //Converting azn-usd
        public static implicit operator USD(AZN azn)
        {
            return new USD(azn.Amount * 0.59);
        }

        //Converting azn-euro
        public static implicit operator AZN(EURO euro)
        {
            return new AZN(euro.Amount * 1.87);
        }

        //Comparing azn-usd
        public static bool operator >(AZN azn, USD usd)
        {
            return azn.Amount > usd.Amount * 1.70;
        }
        public static bool operator <(AZN azn, USD usd)
        {
            return azn.Amount < usd.Amount * 1.70;
        }

        //Comparing azn-euro 
        public static bool operator >(AZN azn, EURO euro)
        {
            return azn.Amount > euro.Amount * 1.87;
        }
        public static bool operator <(AZN azn, EURO euro)
        {
            return azn.Amount < euro.Amount * 1.87;
        }
    }
}