namespace Blind75CSharp.Week01;

public class ProductOfArrayExceptSelf
{
   public int[] ProductExceptSelf(int[] nums)
   {
      var results = new int[nums.Length];

      // prefixes
      var prefix = 1;
      for (var i = 0; i < nums.Length; i++)
      {
         results[i] = prefix;
         prefix *= nums[i];
      }
      
      // postfixes
      var postfix = 1;
      for (var i = nums.Length-1 ; i >= 0; i--)
      {
         results[i] *= postfix;
         postfix *= nums[i];
      }
      

      return results;
   }
}

// Runtime: 240 ms, faster than 36.84% of C# online submissions for Product of Array Except Self.
// Memory Usage: 48.7 MB, less than 91.19% of C# online submissions for Product of Array Except Self.