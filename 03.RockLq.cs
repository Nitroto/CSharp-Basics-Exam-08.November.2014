using System;

namespace RockLq
{
    class RockLq
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int midPoint = (int)n/2+1;
            int spaces = n;
            int midSpaces = n+2;
            for (int i = 0; i < midPoint; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', spaces));
                    Console.Write(new string('*', n));
                    Console.Write(new string('.', spaces));
                    Console.WriteLine();
                    spaces-=2;
                }
                else
                {
                    Console.Write(new string('.', spaces));
                    Console.Write('*');
                    Console.Write(new string('.', midSpaces));
                    Console.Write('*');
                    Console.Write(new string('.', spaces));
                    Console.WriteLine();
                    spaces -= 2;
                    midSpaces += 4;

                }
            }
            spaces = n - 2;
            midSpaces = -1;
            for (int i = 1; i < midPoint; i++)
            {
                if (i == 1)
                {
                    Console.Write('*');
                    Console.Write(new string('.', spaces));
                    Console.Write('*');
                    Console.Write(new string('.', n));
                    Console.Write('*');
                    Console.Write(new string('.', spaces));
                    Console.Write('*');
                    Console.WriteLine();
                    spaces -= 2;
                    midSpaces += 2;
                }
                else
                {
                    Console.Write('*');
                    Console.Write(new string('.', spaces));
                    Console.Write('*');
                    Console.Write(new string('.', midSpaces));
                    Console.Write('*');
                    Console.Write(new string('.', n));
                    Console.Write('*');
                    Console.Write(new string('.', midSpaces));
                    Console.Write('*');
                    Console.Write(new string('.', spaces));
                    Console.Write('*');
                    Console.WriteLine();
                    spaces -= 2;
                    midSpaces += 2;
                }
            }
            int counter = 0;
            for (int i = 0; i < n; i++)
            {

                if (i == n-1)
                {
                    Console.Write(new string('*', 3*n));
                    Console.WriteLine();
                }
                else
                {

                    Console.Write(new string('.', n - counter-1));
                    Console.Write('*');
                    Console.Write(new string('.', n+counter*2));
                    Console.Write('*');
                    Console.Write(new string('.', n - counter-1));
                    Console.WriteLine();
                    counter++;
                }
            }
        }
    }
}
