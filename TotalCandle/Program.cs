using System;

namespace TotalCandles
{
    class Program
    {

        static  int TotalBurnedCandles(int candles, int leftoversPerCandle)
        {
            if (leftoversPerCandle <=1)
                return -1;

            int totalBurnedCandles = 0;
            int leftovers = 0;

            do
            {
                // Burn
                totalBurnedCandles += candles;
                // leftovers created
                leftovers = candles + leftovers % leftoversPerCandle;
                // new candles created
                candles = leftovers / leftoversPerCandle;
                //Console.WriteLine($"leftovers {leftovers}, candles {candles}, totalBurnedCandles  {totalBurnedCandles}");
            }
            while (leftovers + candles >= leftoversPerCandle);

            return totalBurnedCandles;
        }

        static void Main(string[] args)
        {

            int candles = 5;
            int leftoversPerCandle = 2;
            int result = TotalBurnedCandles(candles, leftoversPerCandle);
            Console.WriteLine($"Total Burned Candles  {result}");
            Console.ReadKey();

        }
    }
}
