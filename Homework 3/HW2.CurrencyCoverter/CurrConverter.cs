using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverter
{
    class CurrConverter
    {
        double currencyUSD, currencyEUR;
        public CurrConverter(double usd, double eur) 
        {
            currencyUSD = usd;
            currencyEUR = eur;          
        }

        public void ToConverte()
        {
            Console.WriteLine($"Currency rate to UAH: {currencyUSD} USD / {currencyEUR} EUR");
            while (true)
            {
                int userChoice = TakeUserChoice();
                double sum = TakeUserSum();

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine($"{sum} USD to {Math.Round(sum * currencyUSD, 2)} UAH");
                        break;
                    case 2:
                        Console.WriteLine($"{sum} EUR to {Math.Round(sum * currencyEUR, 2)} UAH");
                        break;
                    case 3:
                        Console.WriteLine($"{sum} UAH to {Math.Round(sum / currencyUSD, 2)} USD");
                        break;
                    case 4:
                        Console.WriteLine($"{sum} UAH to {Math.Round(sum / currencyEUR, 2)} EUR");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Enter \"l\" to exit or another");
                char inputKey = Console.ReadKey().KeyChar;
                if (inputKey == 'l' || inputKey == 'L' || inputKey == 'д' || inputKey == 'Д')
                    break;
            }
        }

        private int TakeUserChoice()
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("Please, choose action");
            Console.WriteLine("1. USD to UAH");
            Console.WriteLine("2. EUR to UAH");
            Console.WriteLine("3. UAH to USD");
            Console.WriteLine("4. UAH to EUR");

            int userChoice;
            while (true)
            {
                try
                {
                    userChoice = int.Parse(Console.ReadLine());
                    if (userChoice < 1 || userChoice > 4)
                        throw new Exception();
                    break;
                }
                catch
                {
                    Console.WriteLine("ERROR input /// Please, enter again");
                }

            }
            return userChoice;
        }

        private double TakeUserSum()
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("Enter your sum of money");

            double sum;
            while (true)
            {
                try
                {
                    sum = int.Parse(Console.ReadLine());
                    if (sum < 0 )
                        throw new Exception();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR input /// Please, enter again");
                }

            }
            Console.WriteLine("===========================================================");
            return sum;
        }
    }
}
