using System;
using System.Globalization;
using System.Threading;

class Gambling
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double cash = double.Parse(Console.ReadLine());
        string[] housesHand = Console.ReadLine().Split(' ');
        int strength=0;
        foreach (string card in housesHand)
        {
            switch (card)
            {
                case "J": strength += 11;break;
                case "Q": strength += 12;break;
                case "K": strength += 13;break;
                case "A": strength += 14;break;
                default: strength += int.Parse(card);break;
            }
        }
        int possibleHands = 0;
        int winningHands = 0;
        for (int firstCard = 2; firstCard <= 14; firstCard++)
        {
            for (int secondCard = 2; secondCard <= 14; secondCard++)
            {
                for (int thirdCard = 2; thirdCard <= 14; thirdCard++)
                {
                    for (int fourtCard = 2; fourtCard <= 14; fourtCard++)
                    {
                        possibleHands++;
                        int myStrength = firstCard + secondCard + thirdCard + fourtCard;
                        if (myStrength > strength)
                        {
                            winningHands++;
                        }
                    }
                }
            }
        }
        double chanceForWin = (double)winningHands /possibleHands;
        double expectedWinnings = chanceForWin * (2.0* cash);
        if (chanceForWin < 0.5)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }
        Console.WriteLine("{0:F2}", expectedWinnings);
    }
}
