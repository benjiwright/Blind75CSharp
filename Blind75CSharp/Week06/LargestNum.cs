using System.Text;

namespace Blind75CSharp.Week06;

public class LargestNum : IComparer<string>
{
   public string LargestNumber(int[] nums)
   {
      if (nums is null || nums.Length == 0) return string.Empty;

      var sb = new StringBuilder();

      var sorted = nums.OrderByDescending(x => x.ToString(), this);
      foreach (var num in sorted)
      {
         sb.Append(num.ToString());
      }

      return sb[0] == '0' ? "0" : sb.ToString();
   }

   public int Compare(string? x, string? y)
   {
      if (x is null) return -1;
      if (y is null) return 1;

      return string.CompareOrdinal(x + y, y + x);
   }
}
// Runtime: 185 ms, faster than 15.46% of C# online submissions for Largest Number. Too many casts?
// Memory Usage: 40.2 MB, less than 79.55% of C# online submissions for Largest Number.