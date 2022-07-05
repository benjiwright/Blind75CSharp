namespace Blind75CSharp.Week05;

public class Solution
{
   public int ClimbStairsDp(int n)
   {
      var one = 1;
      var two = 1;

      for (var i = 0; i < n - 1; i++)
      {
         var temp = one;
         one = one + two;
         two = temp;
      }

      return one;
   }
   // Runtime: 39 ms, faster than 31.73% of C# online submissions for Climbing Stairs.
   // Memory Usage: 25.1 MB, less than 67.06% of C# online submissions for Climbing Stairs.

   public int ClimbStairsRecursive(int n)
   {
      return RecurseStairs(0, n, new int[n + 1]);
   }
   // Runtime: 41 ms, faster than 25.57% of C# online submissions for Climbing Stairs.
   // Memory Usage: 25.3 MB, less than 40.31% of C# online submissions for Climbing Stairs.

   private int RecurseStairs(int i, int n, int[] memo)
   {
      if (i > n) return 0;
      if (i == n) return 1;
      if (memo[i] > 0) return memo[i];

      return memo[i] = RecurseStairs(i + 1, n, memo) + RecurseStairs(i + 2, n, memo);
   }

   public int CoinChange(int[] coins, int amount)
   {
      return DfsMemoCoinChange(amount, coins, new Dictionary<int, int>());
   }
   // Runtime: 227 ms, faster than 22.12% of C# online submissions for Coin Change.
   // Memory Usage: 47 MB, less than 5.07% of C# online submissions for Coin Change.

   private int DfsMemoCoinChange(int target, int[] coins, Dictionary<int, int> memo)
   {
      // base case(s)
      if (memo.ContainsKey(target)) return memo[target];
      if (target == 0) return 0;

      var minCoin = int.MaxValue;
      foreach (var coin in coins)
      {
         if (coin > target) continue;

         var min = DfsMemoCoinChange(target - coin, coins, memo);
         if (min < 0) continue;
         minCoin = Math.Min(minCoin, min);
      }

      memo[target] = minCoin == int.MaxValue ? -1 : minCoin + 1;
      return memo[target];
   }
}