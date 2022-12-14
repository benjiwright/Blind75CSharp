namespace Blind75CSharp.Xero;

public class XeroSolver
{
   // Runtime 348 ms Beats 93.89%
   // Memory 58.1 MB Beats 15.2%
   // https://leetcode.com/problems/k-closest-points-to-origin/submissions/859405986/
   public int[][] KClosest(int[][] points, int k)
   {
      var pq = new PriorityQueue<int[], double>();
      foreach (var a in points)
      {
         // i hate jagged arrays
         var distance = FindDistanceToOrigin(a[0], a[1]);

         pq.Enqueue(a, distance);
      }

      var result = new List<int[]>();

      while (k > 0)
      {
         result.Add(pq.Dequeue());
         k--;
      }

      return result.ToArray();
   }

   private static double FindDistanceToOrigin(int x, int y)
   {
      return Math.Sqrt(x * x + y * y);
   }
}