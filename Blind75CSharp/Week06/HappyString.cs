using System.Text;

namespace Blind75CSharp.Week06;

public class HappyString
{
   public string LongestDiverseString(int a, int b, int c)
   {
      var result = new StringBuilder();

      var maxHeap = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
      if (a > 0) maxHeap.Enqueue('a', a);
      if (b > 0) maxHeap.Enqueue('b', b);
      if (c > 0) maxHeap.Enqueue('c', c);


      while (maxHeap.Count > 0)
      {
         // find largest and use it
         maxHeap.TryDequeue(out var nextChar, out var nextPriority);

         if (result.Length > 1 && nextChar == result[^1] && nextChar == result[^2])
         {
            if (maxHeap.Count == 0)
               return result.ToString();

            maxHeap.TryDequeue(out var otherChar, out var otherPriority);
            result.Append(otherChar);
            otherPriority--;
            if (otherPriority > 0)
               maxHeap.Enqueue(otherChar, otherPriority);
         }
         else
         {
            result.Append(nextChar);
            nextPriority--;
         }

         if (nextPriority > 0)
         {
            maxHeap.Enqueue(nextChar, nextPriority);
         }
      }

      return result.ToString();
   }
}
// Runtime: 131 ms, faster than 15.13% of C# online submissions for Longest Happy String.
// Memory Usage: 35.1 MB, less than 97.37% of C# online submissions for Longest Happy String.