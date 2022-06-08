namespace Blind75CSharp.Week01;

public class MaxSubArrayFinder
{
   public int MaxSubArray(int[] nums)
   {
      int maxSum = nums[0], currMax = nums[0];

      for (var i = 1; i < nums.Length; i++)
      {
         currMax = Math.Max(currMax, currMax + nums[i]);
         if (currMax > maxSum) maxSum = currMax;
      }

      return maxSum;
   }
}