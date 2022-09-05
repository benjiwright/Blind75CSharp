namespace Blind75CSharp.Week06;

public class SlidingWindowMax
{
   public int[] MaxSlidingWindow(int[] nums, int k)
   {
      // monotonically decreasing queue (always in decreasing order)
      // need a double sided queue.
      // Front: pop the largest number
      // Back: ensure the queue is in decreasing order


      var output = new List<int>();
      LinkedList<int> queue = new();
      int left = 0, right = 0;

      while (right < nums.Length)
      {
         // pop smaller values from queue
         while (queue.Count > 0 && nums[queue.Last.Value] < nums[right])
         {
            queue.RemoveLast();
         }

         queue.AddLast(right);

         // remove left val from the window
         if (left > queue.First.Value)
         {
            queue.RemoveFirst();
         }

         if (right + 1 >= k)
         {
            output.Add(nums[queue.First.Value]);
            left++;
         }

         right++;
      }

      return output.ToArray();
   }
}
// Runtime: 659 ms, faster than 59.10% of C# online submissions for Sliding Window Maximum.
// Memory Usage: 56.6 MB, less than 25.44% of C# online submissions for Sliding Window Maximum.