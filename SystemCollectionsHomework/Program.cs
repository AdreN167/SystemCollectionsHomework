using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Sockets;

namespace SystemCollectionsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------1---------------
            int count = 20;
            int sum = 0;

            var random = new Random();
            var numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int temporaryNumber = random.Next(1, 100);
                if (i % 2 == 0)
                {
                    sum += temporaryNumber;
                }

                numbers.Add(temporaryNumber);

                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            int firstMax = 0;
            int secondMax = 0;
            int secondMaxIndex = 0;
            int firstMaxIndex = 0;

            if (numbers[0] > numbers[1])
            {
                firstMax = numbers[0];
                secondMax = numbers[1];
                firstMaxIndex = 0;
                secondMaxIndex = 1;
            }
            else
            {
                firstMax = numbers[1];
                secondMax = numbers[0];
                firstMaxIndex = 1;
                secondMaxIndex = 0;
            }

            for (int i = 2; i < numbers.Count; i++)
            {
                if (numbers[i] > firstMax)
                {
                    secondMax = firstMax;
                    secondMaxIndex = firstMaxIndex;
                    firstMax = numbers[i];
                    firstMaxIndex = i;
                }
                else if (numbers[i] > secondMax)
                {
                    secondMax = numbers[i];
                    secondMaxIndex = i;
                }
            }

            Console.WriteLine($"{secondMaxIndex} - {secondMax}");
            Console.WriteLine(sum);

            //---------------2---------------
            var list = new MyList();
            list.Add(1);
            list.Add(3);
            list.Add(0);
            list.Add(-12);
            list.Add(100);

            list.Sort();

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
