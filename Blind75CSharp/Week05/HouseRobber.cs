namespace Blind75CSharp.Week05;

public class HouseRobber
{
   private Dictionary<int, int> memo;

   public int Rob(int[] nums)
   {
      return RobBottomUp(nums);
   }

   // Runtime: 92 ms, faster than 84.99% of C# online submissions for House Robber.
   // Memory Usage: 36.9 MB, less than 32.52% of C# online submissions for House Robber.
   private int RobBottomUp(int[] nums)
   {
      if (nums.Length == 0) return 0;

      var prev1 = 0;
      var prev2 = 0;

      foreach (var num in nums)
      {
         var tmp = prev1;
         prev1 = Math.Max(prev2 + num, prev1);
         prev2 = tmp;
      }

      return prev1;
   }

   // Runtime: 128 ms, faster than 40.28% of C# online submissions for House Robber.
   // Memory Usage: 36.8 MB, less than 43.21% of C# online submissions for House Robber.
   private int RobRecurse(int[] nums, int i)
   {
      if (i < 0) return 0;

      if (memo.ContainsKey(i)) return memo[i];

      var result = Math.Max(RobRecurse(nums, i - 2) + nums[i], RobRecurse(nums, i - 1));
      memo[i] = result;
      return result;
   }

   // Runtime: 148 ms, faster than 18.89% of C# online submissions for House Robber.
   // Memory Usage: 36.9 MB, less than 25.14% of C# online submissions for House Robber.
   private int RobMemoTabulation(int[] nums)
   {
      if (nums.Length == 0) return 0;

      int[] memo = new int[nums.Length + 1];
      memo[0] = 0;
      memo[1] = nums[0];

      for (var i = 1; i < nums.Length; i++)
      {
         int val = nums[i];
         memo[i + 1] = Math.Max(memo[i], memo[i - 1] + val);
      }

      return memo[nums.Length];
   }
}