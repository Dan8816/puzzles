using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static (int max, int min, int sum) RandomArray()
        {
            int[] randArray = new int[10];
            int max = 5;
            int min = 25;
            int sum = 0;            
            for (int i = 0; i < randArray.Length; i++)
            {
                Random rand = new Random();
                randArray[i] = (rand.Next(5,25));
                if (randArray[i] >= max)
                {
                    max = randArray[i];
                }
                if (randArray[i] <= min)
                {
                    min = randArray[i];
                }
                sum += randArray[i];
            }
            foreach (var item in randArray)
            {
                System.Console.WriteLine(item);
            }
            return (max, min, sum);
        }
        public static string TossCoin()
        {
            string result = "";
            System.Console.WriteLine("tossing a coin");
            Random rand = new Random();
            int toss = (rand.Next(0,1));
            if (toss == 0)
            {
                result = "Heads";
            }
            if (toss == 1)
            {
                result = "Tails";
            }
            return (result);
        }        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var All = RandomArray();
            //System.Console.WriteLine(All);
            var Flip = TossCoin();
            System.Console.WriteLine(Flip);
        }
    }
}
