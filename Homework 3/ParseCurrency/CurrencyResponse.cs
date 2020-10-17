using System;
using System.Collections.Generic;
using System.Text;

namespace ParseCurrency
{
    class CurrencyResponse
    {
        string currency;
        double rate;
        public string CC 
        {
            get { return currency; }
            set { currency = value; }
        }
        public double Rate 
        {
            get { return rate; }
            set { rate = value; }
        }
    }
}
