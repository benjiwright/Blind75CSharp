﻿using System.Text;

namespace Blind75CSharp.Week05;

public class Solution05
{
   public int CalPoints(string[] ops)
   {
      var stack = new Stack<int>();
      foreach (var op in ops)
      {
         switch (op.ToUpper())
         {
            case "+": // sum of previous 2
               var prev2 = stack.Pop();
               var prev1 = stack.Peek();
               stack.Push(prev2);
               stack.Push(prev1+prev2);
               break;
            case "D": // double previous
               stack.Push(stack.Peek()*2);
               break;
            case "C": // invalidate previous
               stack.Pop();
               break;
            default: // is int, add as score
               stack.Push(int.Parse(op));
               break;
         }
      }

      return stack.Sum();
   }
   // Runtime: 128 ms, faster than 55.03% of C# online submissions for Baseball Game.
   // Memory Usage: 39.2 MB, less than 6.71% of C# online submissions for Baseball Game.

   public string ReorganizeString(string s)
   {
      {
         if (string.IsNullOrEmpty(s))
            return string.Empty;

         var frequencyMap = s.GroupBy(c => c)
            .ToDictionary(grp => grp.Key, grp => grp.Count());

         var maxHeap = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
         maxHeap.EnqueueRange(frequencyMap.Select(kv => (kv.Key, kv.Value)));

         (char prevChar, int prevCharPriority) previous = ('\0', -1);
         var result = new StringBuilder();
         while (maxHeap.Count > 0)
         {
            if (!maxHeap.TryDequeue(out var currentChar, out var currentCharPriority)) continue;

            result.Append(currentChar);
            if (previous.prevChar != '\0' && previous.prevCharPriority > 0)
               maxHeap.Enqueue(previous.prevChar, previous.prevCharPriority);
            previous = (currentChar, currentCharPriority - 1);
         }

         return result.ToString().Length == s.Length ? result.ToString() : string.Empty;
      }
   }
   // Runtime: 127 ms, faster than 44.26% of C# online submissions for Reorganize String.
   // Memory Usage: 36.1 MB, less than 49.18% of C# online submissions for Reorganize String.

   public int LengthOfLIS(int[] nums)
   {
      var memo = new int[nums.Length];
      Array.Fill(memo, 1);

      for (var i = 0; i < nums.Length; i++)
      {
         var startNum = nums[i];
         for (var j = 0; j < i; j++)
         {
            if (startNum > nums[j])
               memo[i] = Math.Max(memo[i], memo[j] + 1);
         }
      }

      return memo.Max();
   }
   // Runtime: 175 ms, faster than 59.79% of C# online submissions for Longest Increasing Subsequence.
   // Memory Usage: 38 MB, less than 55.58% of C# online submissions for Longest Increasing Subsequence.

   public int ClimbStairsDpMinimumMemory(int n)
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

   public int ClimbStairsTabulation(int numOfStairs)
   {
      if (numOfStairs == 1)
      {
         return 1;
      }

      var dp = new int[numOfStairs + 1];
      dp[1] = 1;
      dp[2] = 2;
      for (var i = 3; i <= numOfStairs; i++)
      {
         dp[i] = dp[i - 1] + dp[i - 2];
      }

      return dp[numOfStairs];
   }

   public int ClimbStairsRecursive(int n)
   {
      return RecurseStairs(0, n, new int[n]);
   }
   // Runtime: 41 ms, faster than 25.57% of C# online submissions for Climbing Stairs.
   // Memory Usage: 25.3 MB, less than 40.31% of C# online submissions for Climbing Stairs.

   private int RecurseStairs(int currentStair, int numOfStairs, int[] memo)
   {
      if (currentStair > numOfStairs) return 0;
      if (currentStair == numOfStairs) return 1;
      if (memo[currentStair] > 0) return memo[currentStair];

      var result = RecurseStairs(currentStair + 1, numOfStairs, memo)
                   + RecurseStairs(currentStair + 2, numOfStairs, memo);
      memo[currentStair] = result;
      return result;
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