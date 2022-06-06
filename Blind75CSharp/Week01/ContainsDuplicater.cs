namespace Blind75CSharp.Week01;

public class ContainsDuplicater
{
   public bool ContainsDuplicate(int[] nums)
   {
      var found = new HashSet<int>();

      foreach (var num in nums)
      {
         if (found.Contains(num)) return true;

         found.Add(num);
      }

      return false;
   }
}

// Runtime: 282 ms, faster than 36.68% of C# online submissions for Contains Duplicate.
// Memory Usage: 46.8 MB, less than 65.39% of C# online submissions for Contains Duplicate.