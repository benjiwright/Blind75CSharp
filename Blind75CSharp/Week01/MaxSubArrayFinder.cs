namespace Blind75CSharp.Week01;

public class MaxSubArrayFinder
{
   // 53 https://leetcode.com/problems/maximum-subarray/
   public int MaxSubArray(int[] nums)
   {
      int maxSum = nums[0], currMax = nums[0];

      for (var idx = 1; idx < nums.Length; idx++)
      {
         // does adding this index improve our current max?
         currMax = Math.Max(nums[idx], currMax + nums[idx]);

         // do we update the overall max?
         if (currMax > maxSum) maxSum = currMax;
      }

      return maxSum;
   }
   // Runtime: 396 ms, faster than 12.27% of C# online submissions for Maximum Subarray.
   // Memory Usage: 49 MB, less than 43.02% of C# online submissions for Maximum Subarray.

   // 152 https://leetcode.com/problems/maximum-product-subarray/
   public int MaxProduct(int[] nums)
   {
      var result = nums.Max();
      var max = 1;
      var min = 1; // gotcha 1 - gotta track the min product

      foreach (var num in nums)
      {
         var tmp = max * num; // gotcha 2 - need to use old max before computing min 
         max = new[] {tmp, min * num, num}.Max();
         min = new[] {tmp, min * num, num}.Min();
         result = Math.Max(result, max);
      }

      return result;
   }
   // Runtime: 158 ms, faster than 19.58% of C# online submissions for Maximum Product Subarray.
   // Memory Usage: 39.3 MB, less than 23.29% of C# online submissions for Maximum Product Subarray.
}