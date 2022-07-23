using System.Text;
using Blind75CSharp.Week02;

namespace Blind75CSharp.Week05;

public class Solution05
{
   public long SubArrayRanges(int[] nums)
   {
     return SubArrayRangesNaive(nums);
   }

   private long SubArrayRangesNaive(int[] nums)
   {
      // Sadly, this takes too long and we are required to use a
      // monotonic stack. This becomes a rather difficult math problem.
      // Are places looking for software engineers or mathematicians?
      // Yes, I'm a little salty 
      var result = 0L;

      for (var i = 0; i < nums.Length; i++)
      {
         var j = i + 1;
         for (; j < nums.Length; j++)
         {
            var subArray = nums.Skip(i).Take(j - i + 1).ToArray();
            var max = subArray.Max();
            var min = subArray.Min();
            result += max - min;
         }
      }

      return result;
   }

   public int[] FindBuildings(int[] heights)
   {
      var maxHeight = int.MinValue;
      var results = new List<int>();

      for (var i = heights.Length - 1; i >= 0; i--)
      {
         var currentHeight = heights[i];
         if (currentHeight <= maxHeight) continue;
         results.Add(i);
         maxHeight = Math.Max(currentHeight, maxHeight);
      }

      // a little faster:  324 ms (85.43%) 
      results.Reverse();
      return results.ToArray();

      var answer = new int[results.Count];
      for (var i = 0; i < results.Count; i++)
      {
         answer[i] = results[results.Count - 1 - i];
      }

      return answer;
   }
   // Runtime: 341 ms, faster than 82.41% of C# online submissions for Buildings With an Ocean View.
   // Memory Usage: 54.7 MB, less than 83.42% of C# online submissions for Buildings With an Ocean View.

   public ListNode SortList(ListNode head)
   {
      // base case(s)
      if (head is null || head.next is null) return head;

      var mid = GetMiddleOfList(head);
      var left = SortList(head);
      var right = SortList(mid);

      return MergeLinkList(left, right);
   }

   private ListNode MergeLinkList(ListNode list1, ListNode list2)
   {
      var dummy = new ListNode();
      var tail = dummy;

      while (true)
      {
         if (list1 == null)
         {
            tail.next = list2;
            break;
         }

         if (list2 == null)
         {
            tail.next = list1;
            break;
         }

         if (list1.val <= list2.val)
         {
            tail.next = list1;
            list1 = list1.next;
         }
         else
         {
            tail.next = list2;
            list2 = list2.next;
         }

         tail = tail.next;
      }

      return dummy.next;
   }
   // Runtime: 310 ms, faster than 10.34% of C# online submissions for Sort List. Holy SLOW for (n log n)
   // Memory Usage: 49.6 MB, less than 35.42% of C# online submissions for Sort List. 

   private ListNode GetMiddleOfList(ListNode head)
   {
      var fast = head.next;
      var slow = head;

      while (fast is not null && fast.next is not null)
      {
         slow = slow.next;
         fast = fast.next.next;
      }

      var tmp = slow.next;
      slow.next = null;
      return tmp;
   }

   public void Merge(int[] nums1, int m, int[] nums2, int n)
   {
      var curr = m + n - 1;

      while (m > 0 && n > 0)
      {
         if (nums1[m - 1] > nums2[n - 1])
         {
            nums1[curr] = nums1[m - 1];
            m--;
         }
         else
         {
            nums1[curr] = nums2[n - 1];
            n--;
         }

         curr--;
      }

      while (n > 0)
      {
         nums1[curr] = nums2[n - 1];
         n--;
         curr--;
      }
   }
   // Runtime: 244 ms, faster than 16.82% of C# online submissions for Merge Sorted Array.
   // Memory Usage: 41.4 MB, less than 60.00% of C# online submissions for Merge Sorted Array.

   public ListNode MergeKLists(ListNode[] lists)
   {
      // this uses space of (n) when this could be done with space of (1) using merge sort of link list
      var minHeap = new PriorityQueue<ListNode, int>();
      foreach (var listNode in lists)
      {
         var current = listNode;
         while (current != null)
         {
            minHeap.Enqueue(new ListNode(current.val), current.val);
            current = current.next;
         }
      }

      if (minHeap.Count == 0) return null;

      var result = minHeap.Dequeue();
      var pointer = result;
      while (minHeap.Count > 0)
      {
         pointer.next = minHeap.Dequeue();
         pointer = pointer.next;
      }

      return result;
   }
   // Runtime: 158 ms, faster than 60.46% of C# online submissions for Merge k Sorted Lists.
   // Memory Usage: 40 MB, less than 70.07% of C# online submissions for Merge k Sorted Lists.

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
               stack.Push(prev1 + prev2);
               break;
            case "D": // double previous
               stack.Push(stack.Peek() * 2);
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

   public int CoinChangeRecursive(int[] coins, int amount)
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

   public int CoinChangeDp(int[] coins, int amount)
   {
      var dp = new int[amount + 1];
      var initialValue = amount + 1;
      Array.Fill(dp, initialValue);
      dp[0] = 0;

      for (var i = 1; i <= amount; i++)
      {
         foreach (var coin in coins)
         {
            if (i - coin < 0) continue;

            dp[i] = Math.Min(dp[i], 1 + dp[i - coin]);
         }
      }

      return dp[amount] == initialValue ? -1 : dp[amount];
   }
   // Runtime: 109 ms, faster than 90.05% of C# online submissions for Coin Change.
   // Memory Usage: 39.6 MB, less than 64.07% of C# online submissions for Coin Change.
}