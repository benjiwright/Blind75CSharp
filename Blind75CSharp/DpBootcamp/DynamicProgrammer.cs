namespace Blind75CSharp.DpBootcamp;

public class DynamicProgrammer
{
   public int GridTraveler(int m, int n)
   {
      return GridTravelerMemo(m, n, new Dictionary<string, int>());
   }

   private int GridTravelerMemo(int m, int n, Dictionary<string, int> memo)
   {
      var key = $"{m},{n}";
      if (memo.ContainsKey(key)) return memo[key];

      if (m == 1 && n == 1) return 1;
      if (m == 0 || n == 0) return 0;

      var result = GridTravelerMemo(m - 1, n, memo) + GridTravelerMemo(m, n - 1, memo);
      memo[key] = result;
      return result;
   }

   public bool CanSum(int target, int[] nums)
   {
      return CanSumMemo(target, nums, new Dictionary<int, bool>());
   }

   private bool CanSumMemo(int target, int[] nums, Dictionary<int, bool> memo)
   {
      if (memo.ContainsKey(target)) return memo[target];
      if (target < 0) return false;
      if (target == 0) return true;

      foreach (var num in nums)
      {
         var remaining = target - num;
         if (CanSumMemo(remaining, nums, memo))
         {
            memo[target] = true;
            return true;
         }
      }

      memo[target] = false;
      return false;
   }

   public List<int> HowSum(int target, int[] nums)
   {
      return HowSumMemo(target, nums, new Dictionary<int, List<int>>());
   }

   private List<int> HowSumMemo(int target, int[] nums, Dictionary<int, List<int>> memo)
   {
      if (memo.ContainsKey(target)) return memo[target];
      if (target == 0) return new List<int>();
      if (target < 0) return null;

      foreach (var num in nums)
      {
         var remaining = target - num;
         var result = HowSumMemo(remaining, nums, memo);
         if (result is not null)
         {
            result.Add(num);
            memo[remaining] = result;
            return result;
         }
      }

      memo[target] = null;
      return null;
   }
}