using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCost
{
    internal class Program
    {

        public int MiniStepCost(int[] cost)
        {

            int step = cost.Length;
            if (step == 0)
            {
                return 0;
            }
            else if (step == 1)
            {
                return cost[0];
            }


            int[] MiniStep = new int[step];
            // The cost to reach the first step
            MiniStep[0] = cost[0];
            // The cost to reach the second step
            MiniStep[1] = cost[1];


            int i;
            //logic for find the MiniStep with example 2 
            //Iterate through the rest of the steps starting 
            for (i = 2; i < step; i++)
            {
                MiniStep[i] = cost[i] + Mini(MiniStep[i - 1], MiniStep[i-2]);

            }
            // The minimum cost to reach the top of the staircase is
            // the minimum of the last two steps
         
            return Mini(MiniStep[i - 1], MiniStep[i - 2]);


        }
        // Mini method to find the minimum of two numbers
        private int Mini(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }


        }
        static void Main(string[] args)
        {
            Program result = new Program();

            int[] cost1 = { 10, 15, 20 };
            Console.WriteLine(result.MiniStepCost(cost1)); 

            // Example 2
            int[] cost2 = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            Console.WriteLine(result.MiniStepCost(cost2));
            Console.ReadKey();
        }
    }
}
