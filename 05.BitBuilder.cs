using System;
using System.Globalization;
using System.Threading;

class BitBuilder
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long num = long.Parse(Console.ReadLine());
        string firstCommand = Console.ReadLine();
        while (firstCommand != "quit")
        {
            int bitNumber;
            int.TryParse(firstCommand, out bitNumber);
            string secondCommand = Console.ReadLine();
            if (secondCommand == "flip")
            {
                num ^= 1u << bitNumber;
            }
            else if (secondCommand == "insert")
            {
                long copySecondPart = num >> bitNumber;
                num |= 1u << bitNumber;
                num &= maskGenerator(bitNumber);
                num |= copySecondPart << (bitNumber + 1);
            }
            else if (secondCommand == "remove")
            {
                long copyFirstPart = num & maskGenerator(bitNumber-1);
                num >>= bitNumber+1;
                num <<= bitNumber;
                num |= copyFirstPart;

            }
            firstCommand = Console.ReadLine();
        }
        Console.WriteLine(num);
    }
    private static long maskGenerator(int bitNumber)
    {
        long mask=1;
        for (int i = 0; i < bitNumber; i++)
        {
            mask = mask<<1 | 1;
        }
        return mask;
    }
}

