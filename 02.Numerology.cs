using System;
using System.Linq;

namespace Numerology
{
    class Numerology
    {
        static void Main()
        {
            string[] inputData = Console.ReadLine().Split(new char[] {'.',' ' });
            int day = int.Parse(inputData[0]);
            int month = int.Parse(inputData[1]);
            int year = int.Parse(inputData[2]);
            char[] name = inputData[3].ToCharArray();
            long sumOfData= day * month * year; ;
            int sumOfName = 0;
            if (month % 2 == 1)
            {
                sumOfData = sumOfData * sumOfData;
            }
            foreach (char element in name)
            {
                if (element >= '0' && element <= '9')
                {
                    sumOfName += element - '0';
                }
                else
                {
                    if (element >= 'A' && element <= 'Z')
                    {
                        sumOfName += (element-'A'+1)*2;
                    }
                    else
                    {
                        sumOfName += element - 'a'+1;
                    }
                }
            }
            long totalSum = sumOfName + sumOfData;
            if (totalSum > 13)
            {
                do
                {
                    int total = totalSum.ToString().Sum(c => c - '0');
                    totalSum = total;
                } while (totalSum > 13);
            }
            Console.WriteLine(totalSum);
        }
    }
}
