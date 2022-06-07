namespace Blind75CSharp.Week01;

public class TwoSummer
{
   // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
   public int[] TwoSum(int[] nums, int target)
   {
      var compliments = new Dictionary<int, int>();

      for (var i = 0; i < nums.Length; i++)
      {
         if (compliments.ContainsKey(nums[i]))
            return new[] {i, compliments[nums[i]]};

         compliments.TryAdd(target - nums[i], i);
      }

      // assume that each input would have exactly one solution
      return Array.Empty<int>();
   }

   // BONUS: what if the input array is sorted
   // https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
   public int[] TwoSumSorted(int[] numbers, int target)
   {
      var left = 0;
      var right = numbers.Length - 1;

      while (left < right)
      {
         var sum = numbers[left] + numbers[right];
         if (target == sum) return new int[] {left + 1, right + 1};

         if (target < sum)
            right--;
         else
            left++;
      }

      return Array.Empty<int>();
   }
}

// Runtime: 230 ms, faster than 39.82% of C# online submissions for Two Sum.
// Memory Usage: 43.5 MB, less than 39.93% of C# online submissions for Two Sum.