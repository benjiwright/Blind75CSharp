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

   #endregion

   #endregion
}