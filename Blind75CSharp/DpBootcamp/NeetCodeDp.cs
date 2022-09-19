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


   // 213. House Robber II
   // https://leetcode.com/problems/house-robber-ii/
   public int Rob(int[] nums)
   {
      if (nums.Length == 1) return nums[0];

      // think the "nums" is circular street
      int RobHelper(int[] nums)
      {
         var rob1 = 0;
         var rob2 = 0;

         for (var i = 0; i < nums.Length; i++)
         {
            var newRob = Math.Max(rob1 + nums[i], rob2);
            rob1 = rob2;
            rob2 = newRob;
         }

         return rob2;
      }

      var skipFirstHouse = nums.Skip(1).ToArray();
      var skipLastHouse = new int[nums.Length - 1];
      Array.Copy(nums, skipLastHouse, nums.Length - 1);
      return Math.Max(RobHelper(skipFirstHouse), RobHelper(skipLastHouse));
   }
   // Runtime: 141 ms, faster than 28.09% of C# online submissions for House Robber II.
   // Memory Usage: 36.7 MB, less than 62.61% of C# online submissions for House Robber II.

   #endregion

   #endregion
}