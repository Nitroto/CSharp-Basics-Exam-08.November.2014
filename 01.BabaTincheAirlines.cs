using System;

namespace BabaTincheAirlines
{
    class BabaTincheAirlines
    {
        static void Main()
        {
            int firstPrice = 7000;
            int businessPrice = 3500;
            int economyPrice = 1000;
            int maxIncome = (int)Math.Ceiling(firstPrice * 12 * 1.005 + businessPrice * 28 * 1.005 + economyPrice * 50 * 1.005);
            string[] firstClass = Console.ReadLine().Split(' ');
            string[] businessClass = Console.ReadLine().Split(' ');
            string[] economyClass = Console.ReadLine().Split(' ');
            int mealFirst = Int32.Parse(firstClass[2]);
            int mealBusiness = Int32.Parse(businessClass[2]);
            int mealEconomy = Int32.Parse(economyClass[2]);
            int freqFirst = Int32.Parse(firstClass[1]);
            int freqBusiness = Int32.Parse(businessClass[1]);
            int freqEconomy = Int32.Parse(economyClass[1]);
            int normalFirst = Int32.Parse(firstClass[0]) - freqFirst;
            int normalBusiness = Int32.Parse(businessClass[0])- freqBusiness;
            int normalEconomy = Int32.Parse(economyClass[0]) - freqEconomy;
            int firstIncome = (int)(normalFirst * firstPrice) + (int)(freqFirst * (0.3 * firstPrice)) + (int)(mealFirst * (firstPrice * 0.005));
            int businessIncome = (int)(normalBusiness * businessPrice) + (int)(freqBusiness * (0.3 * businessPrice)) + (int)(mealBusiness * (businessPrice * 0.005));
            int economyIncome = (int)(normalEconomy * economyPrice) + (int)(freqEconomy * (0.3 * economyPrice)) + (int)(mealEconomy * (economyPrice * 0.005));
            int income = firstIncome + businessIncome+economyIncome;
            int diff = maxIncome - income;
            Console.WriteLine(income);
            Console.WriteLine(diff);
        }
    }
}
