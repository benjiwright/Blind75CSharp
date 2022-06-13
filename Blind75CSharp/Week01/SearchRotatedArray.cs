namespace Blind75CSharp.Week01;

public class SearchRotatedArray
{
   // Find Max
   public int Search(int[] nums, int target)
   {
      if (nums.Length == 0) return -1;

      int left = 0, right = nums.Length - 1;

      while (left <= right)
      {
         var mid = (left + right) / 2;
         if (target == nums[mid]) return mid; // success case
         var isInLeftSorted = nums[left] <= nums[mid]; // which side of the inflection point are we?

         if (isInLeftSorted)
         {
            if (target > nums[mid])
            {
               left = mid + 1; // search right
            }
            else if (target < nums[left])
            {
               left = mid + 1; // search right
            }
            else
            {
               right = mid - 1; // search left
            }
         }
         else // we're in right sorted 
         {
            if (target < nums[mid])
            {
               right = mid - 1; // search left
            }
            else if (target > nums[right])
            {
               right = mid - 1; // search left
            }
            else
            {
               left = mid + 1; // search right
            }
         }
      }

      // not found
      return -1;
   }
   // Runtime: 88 ms, faster than 87.03% of C# online submissions for Search in Rotated Sorted Array.
   // Memory Usage: 38 MB, less than 38.43% of C# online submissions for Search in Rotated Sorted Array.

   public int FindMin(int[] nums)
   {
      if (nums is null) return -1;

      var left = 0;
      var right = nums.Length - 1;

      // collection is already sorted
      if (nums[left] < nums[right]) return nums[0];
      
      while (left <= right)
      {
         var mid = left + (right - left) / 2;
         
         // are we sorted?
         if (mid == right)
         {
            return (nums[mid]);
         }

         // is this the inflection point on either side?
         if (nums[mid] > nums[mid + 1])
         {
            return nums[mid + 1];
         }
         else if(nums[mid-1] > nums[mid])
         {
            return nums[mid];
         }

         // which side do we continue the search?
         if (nums[left] < nums[mid])
         {
            left = mid + 1;
         }
         else
         {
            right = mid - 1;
         }
      }

      return -1;
   }
   // Runtime: 121 ms, faster than 38.25% of C# online submissions for Find Minimum in Rotated Sorted Array.
   // Memory Usage: 38.1 MB, less than 37.44% of C# online submissions for Find Minimum in Rotated Sorted Array.
}
