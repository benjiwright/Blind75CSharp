namespace Blind75CSharp.Week06;

public class Solution06
{
   public List<int> QuickSortLists(List<int> nums)
   {
      if (nums.Count < 2) // single or empty
      {
         return nums;
      }

      var pivot = nums[0];

      var less = new List<int>();
      var more = new List<int>();

      for (var i = 1; i < nums.Count; i++)
      {
         var num = nums[i];
         if (num <= pivot)
         {
            less.Add(num);
         }
         else
         {
            more.Add(num);
         }
      }

      return QuickSortLists(less)
         .Concat(new List<int> {pivot})
         .Concat(QuickSortLists(more))
         .ToList();
   }


   public bool WordBreak(string s, IList<string> wordDict)
   {
      return WordBreakMemo(s, wordDict, new Dictionary<string, bool>());
   }

   // According to LeetCode, this is too slow and we have to use DP
   private bool WordBreakMemo(string s, IList<string> wordDict, Dictionary<string, bool> memo)
   {
      if (s.Length == 0) return true;
      if (memo.ContainsKey(s)) return memo[s];

      foreach (var word in wordDict)
      {
         if (!s.StartsWith(word)) continue;
         var remaining = s.Substring(word.Length, s.Length - word.Length);
         if (!WordBreak(remaining, wordDict)) continue;
         memo.Add(s, true);
         return true;
      }

      return false;
   }
}