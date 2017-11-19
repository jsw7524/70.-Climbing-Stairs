using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70.Climbing_Stairs
{

    public class Solution
    {
        private static int[] dp = new int[1000001];
        public int ClimbStairs(int n)
        {
            dp[0] = -1;
            dp[1] = 1;
            dp[2] = 2;

            for (int i=3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
