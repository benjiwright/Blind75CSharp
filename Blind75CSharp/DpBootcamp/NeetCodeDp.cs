namespace Blind75CSharp.DpBootcamp;

public class NeetCodeDp
{
   #region 1D DP

   #region Easy

   // https://leetcode.com/problems/climbing-stairs/
   // Runtime: 36 ms, faster than 48.63% of C# online submissions for Climbing Stairs.
   // Memory Usage: 25.2 MB, less than 64.82% of C# online submissions for Climbing Stairs.
   public int ClimbStairs(int n)
   {
      if (n == 0) return 0;
      else if (n == 1) return 1;

      var memo = new int[n + 1];
      Array.Fill(memo, 0); // habit
      memo[1] = 1;
      memo[2] = 2;

      for (var i = 3; i <= n; i++)
      {
         memo[i] = memo[i - 1] + memo[i - 2];
      }

      return memo[n];
   }

   // https://leetcode.com/problems/min-cost-climbing-stairs/
   // Runtime: 158 ms, faster than 19.20% of C# online submissions for Min Cost Climbing Stairs.
   // Memory Usage: 38.1 MB, less than 29.95% of C# online submissions for Min Cost Climbing Stairs.
   public int MinCostClimbingStairs(int[] cost)
   {
      var n = cost.Length;
      var memo = new int[n + 1];
      Array.Fill(memo, 0);

      for (var i = 2; i < n + 1; i++)
      {
         var singleJump = memo[i - 1] + cost[i - 1];
         var doubleJump = memo[i - 2] + cost[i - 2];
         memo[i] = Math.Min(singleJump, doubleJump);
      }

      return memo[n];
   }

   // 198. House Robber
   // https://leetcode.com/problems/house-robber/
   public int Robber1(int[] nums)
   {
      if (nums.Length == 0) return 0;

      var memo = new int[nums.Length + 1];
      memo[0] = 0;
      memo[1] = nums[0];

      for (var i = 1; i < nums.Length; i++)
      {
         var robHere = nums[i];
         var robAllThingsPrevious = memo[i - 1] + robHere;
         memo[i + 1] = Math.Max(memo[i], robAllThingsPrevious);
      }

      return memo[nums.Length];
   }
   // Runtime: 146 ms, faster than 23.08% of C# online submissions for House Robber.
   // Memory Usage: 36.9 MB, less than 32.95% of C# online submissions for House Robber.
   

   #endregion

   #endregion
}