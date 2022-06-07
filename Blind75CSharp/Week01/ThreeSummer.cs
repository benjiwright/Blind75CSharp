namespace Blind75CSharp.Week01;

public class ThreeSummer
{
   public IList<IList<int>> ThreeSum(int[] nums)
   {
      var results = new List<IList<int>>();
      Array.Sort(nums);

      for (var i = 0; i < nums.Length - 2; i++)
      {
         if (i == 0 || nums[i] != nums[i - 1])
         {
            TwoSum(nums, i, results);
         }
      }

      return results;
   }

   private void TwoSum(int[] nums, int i, List<IList<int>> results)
   {
      var left = i + 1;
      var right = nums.Length - 1;
      var target = 0 - nums[i];

      while (left < right)
      {
         var sum = nums[left] + nums[right];

         if (sum == target)
         {
            results.Add(new List<int> {nums[i], nums[left], nums[right]});
            left++;
            right--;
            while (left < right && nums[left] == nums[left - 1])
               left++;
         }
         else if (target < sum)
         {
            right--;
         }
         else
         {
            left++;
         }
      }
   }
}

// Runtime: 219 ms, faster than 71.03% of C# online submissions for 3Sum.
// Memory Usage: 47.9 MB, less than 74.47% of C# online submissions for 3Sum.